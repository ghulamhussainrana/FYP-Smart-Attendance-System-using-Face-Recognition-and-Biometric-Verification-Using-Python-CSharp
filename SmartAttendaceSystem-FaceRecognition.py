import cv2
import numpy as np
import face_recognition
import os
from datetime import datetime
import mysql.connector
import winsound
import csv

frequency = 2500  # Set Frequency To 2500 Hertz
duration = 1000  # Set Duration To 1000 ms == 1 second

#Connection to Mysql
db= mysql.connector.connect(host="localhost",user="root",passwd="",database="attendancedb")
mycursor = db.cursor()

#creating a database AttendanceDB
# mycursor.execute("CREATE DATABASE AttendanceDB")
# print("Database 'AttendanceDB' has been created!!!")

#creating table 'details' in AttendanceDB
# mycursor.execute("CREATE Table stddetails(ID int primary key, stdName varchar(200), stdRollNo int, stdPic BLOB)")
# print("table created")

# getting names of students from database
sql_fetch_blob_query = """SELECT StdName from stddetails"""
mycursor.execute(sql_fetch_blob_query)
Namedb = mycursor.fetchall()
Namedb = [item for t in Namedb for item in t]
print(Namedb)

# getting rollnos of students from database
sql_fetch_blob_query = """SELECT stdRollNo from stddetails"""
mycursor.execute(sql_fetch_blob_query)
RollNodb = mycursor.fetchall()
RollNodb = [item for t in RollNodb for item in t]
print(RollNodb)

# storing images of students in directory
def write_file_to_directory(data, filename):
    # Convert binary data to proper format and write it on Hard Disk
    print("write function")
    with open(filename, 'wb') as file:
        file.write(data)

def readData_from_database(id, photo):
    print("Reading BLOB data from Student table")
    sql_fetch_blob_query = """SELECT * from stddetails where ID = %s"""
    mycursor.execute(sql_fetch_blob_query, (id,))
    record = mycursor.fetchall()
    print(type(record))
    for row in record:
        image = row[8]
        print("Storing employee image on disk \n")
        write_file_to_directory(image, photo)

l = len(RollNodb)
print(l)
i=1
for n in RollNodb:
    if(i < (l+1)):
        readData_from_database(i,f"{n}.jpg")
    i=i+1    

print("done")

# Getting images from directory and doing further process
path = 'ImagesAttendance'
images = []
classNames = []
myList = os.listdir(path)
print(myList)


#For Getting the names of Students
for cl in myList:
    curImg = cv2.imread(f'{path}/{cl}')
    images.append(curImg)
    classNames.append(os.path.splitext(cl)[0])
print(classNames)


def findEncodings(images):
    encodeList = []
    for img in images:
        img = cv2.cvtColor(img, cv2.COLOR_BGR2RGB)
        encode = face_recognition.face_encodings(img)[0]
        encodeList.append(encode)
    return encodeList

encodeListKnown = findEncodings(images)
# p1rint(encodeListKnown)
print('Encoding Complete')

def markAttendance(name,roll):
    ndate = datetime.now()
    print(ndate)
    filename = ndate.strftime('%Y-%m-%d')
    if(os.path.exists(f"{filename}.csv")):
        print("file already exists")
    else:
        with open(f"{filename}.csv",'w') as fp:
            fp.write("Name, RollNo, Date, Time, Status")
            print("Created File : ", filename)

    with open(f"{filename}.csv", 'r+') as f:
        myDataList = f.readlines()
        nameList = []
        for line in myDataList:
            entry = line.split(',')
            nameList.append(entry[0])
        if name not in nameList:
            # now = datetime.now()
            dtString = ndate.strftime('%Y-%m-%d, %H:%M:%S')
            f.writelines(f'\n{name}, {roll}, {dtString}, Present')

def markAbsent(name,r):
    ndate = datetime.now()
    filename = ndate.strftime('%Y-%m-%d')
    if(os.path.exists(f"{filename}.csv")):
        print("file already exists")
    else:
        with open(f"{filename}.csv",'w') as fp:
            fp.write("Name, RollNo, Date, Time, Status")
            print("Created File : ", filename)

    with open(f"{filename}.csv", 'r+') as f:
        myDataList = f.readlines()
        nameList = []
        for line in myDataList:
            entry = line.split(',')
            nameList.append(entry[0])
        if name not in nameList:
            # now = datetime.now()
            dtString = ndate.strftime('%Y-%m-%d, %H:%M:%S')
            f.writelines(f'\n{name}, {r}, {dtString}, Absent')

def upload_to_database():
    ndate = datetime.now()
    filename = ndate.strftime('%Y-%m-%d')
    loc = f"{filename}.csv"
    csv_data = csv.reader(open(loc))
    header = next(csv_data)

    print("importing the file")
    for row in csv_data:
        print(row)
        q = """INSERT INTO stdattendance(Name,RollNo,Date,Time,Status) VALUES (%s,%s,%s,%s,%s)"""
        mycursor.execute(q,row)
    db.commit()
    mycursor.close()
    print("done")


cap = cv2.VideoCapture(0)

while True:
    _, img = cap.read()
    # img = captureScreen()
    imgS = cv2.resize(img, dsize=None, fx=0.25, fy=0.25)
    imgS = cv2.cvtColor(imgS, cv2.COLOR_BGR2RGB)

    facesCurFrame = face_recognition.face_locations(imgS)
    encodesCurFrame = face_recognition.face_encodings(imgS, facesCurFrame)

    for encodeFace, faceLoc in zip(encodesCurFrame, facesCurFrame):
        color = (0, 255, 0)
        matches = face_recognition.compare_faces(encodeListKnown, encodeFace)
        faceDis = face_recognition.face_distance(encodeListKnown, encodeFace)
        # print(faceDis)
        matchIndex = np.argmin(faceDis)
        print("Matched Index : ", matchIndex)
        if faceDis[matchIndex] < 0.50:
            name = Namedb[matchIndex].upper()
            color = (0, 255, 0)
            print("Roll No = " + RollNodb[matchIndex])
            markAttendance(name,RollNodb[matchIndex])
            
        else:
            name = 'Unknown'
            color = (0, 0, 255)
            winsound.Beep(frequency, duration)
            print("\a")

        y1, x2, y2, x1 = faceLoc
        y1, x2, y2, x1 = y1 * 4, x2 * 4, y2 * 4, x1 * 4
        cv2.rectangle(img, (x1, y1), (x2, y2), color, 2)
        cv2.rectangle(img, (x1, y2 - 35), (x2, y2), color, cv2.FILLED)
        cv2.putText(img, name, (x1 + 6, y2 - 6), cv2.FONT_HERSHEY_COMPLEX, 0.7, (255, 255, 255), 2)
    
    cv2.imshow('Webcam', img)
    if cv2.waitKey(1) & 0xFF == ord('q'):
        break

for n in range(0,l):
    markAbsent(Namedb[n].upper(),RollNodb[n])

upload_to_database()


cap.release()
cv2.destroyAllWindows()