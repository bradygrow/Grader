-- NewGrader Schema Creation Script (includes ALTER SESSION Statement)

/*
Tables to create:
* Terms
* Students (statement created - 1st)
* Enrollments (statement created -4th)
* Courses (statement created - 2nd)
* CourseOfferings (statement created - 3rd)
* Attendances (statement created - 5th)
* Grades (statement created - 7th)
* Assignments (statement created - 6th)
* RubricParts (statement created - 8th)
* RubricGrades (statement created - 9th)
*/


-- Alter the session to operate in the NewGrader schema
-- ALTER SESSION SET CURRENT_SCHEMA = 'NewGrader'

CREATE TABLE Terms (
   TermName VARCHAR2(12),
   StartDate DATE,
   EndDate DATE,
   CONSTRAINT Terms_TermName_PK PRIMARY KEY(TermName)
   );

-- Drop terms statement, if necessary
-- DROP table terms;


-- Create Students table statement
CREATE TABLE Students (
    sid CHAR(9),
    username VARCHAR2(25) NOT NULL, 
    firstname VARCHAR2(25),
    lastname VARCHAR2(25),
    middleinitial CHAR(1),
    nickname VARCHAR2(25),
    notes VARCHAR2(200),
    CONSTRAINT students_pk PRIMARY KEY (sid),
    CONSTRAINT students_username_uk UNIQUE (username)
);

-- Drop students statement, if necessary
-- DROP TABLE students;

-- Create Courses table statement
CREATE TABLE Courses (
    coursenum VARCHAR2(8),
    coursename VARCHAR2(40), 
    CONSTRAINT courses_pk PRIMARY KEY (coursenum)
);

-- Drop courses statement, if necessary
-- DROP TABLE courses;

-- Create CourseOfferings table statement
CREATE TABLE CourseOfferings (
    offeringid NUMBER(8),
    coursenum VARCHAR2(8),
    coursename VARCHAR2(40),
    semester VARCHAR2(11),
    sectionno NUMBER(4),
    location VARCHAR2(25),
    notes VARCHAR2(200),
    CONSTRAINT courseofferings_pk PRIMARY KEY (offeringid),
    CONSTRAINT courseofferings_coursenum_fk1 FOREIGN KEY (coursenum) REFERENCES courses (coursenum)
);

-- Drop courseofferings statement, if necessary
-- DROP TABLE courseofferings;

-- Create enrollments table statement
CREATE TABLE Enrollments (
    sid CHAR(9),
    offeringid NUMBER(8), 
    gradeoption VARCHAR2(10),
    grade VARCHAR2(4),
	EnrollmentNotes VARCHAR2(200),
    CONSTRAINT enrollments_pk PRIMARY KEY (sid, offeringid),
    CONSTRAINT enrollments_sid_fk1 FOREIGN KEY (sid) REFERENCES Students (sid),
    CONSTRAINT enrollments_offeringid_fk2 FOREIGN KEY (offeringid) REFERENCES CourseOfferings (offeringid)
);

-- Drop enrollments statement, if necessary
-- DROP TABLE enrollments;

-- Create attendances table statement
CREATE TABLE Attendances (
    sid CHAR(9),
    offeringid NUMBER(8),
    dateof DATE,
    attended CHAR(1),
    CONSTRAINT attendances_pk PRIMARY KEY (sid, offeringid, dateof),
    CONSTRAINT attendances_fk1 FOREIGN KEY (sid, offeringid) REFERENCES Enrollments (sid, offeringid)
);

-- Drop attendances statement, if necessary
-- DROP TABLE attendances;

-- Create taskTypes table statement

CREATE TABLE TaskTypes(
   offeringid NUMBER(8),
   taskType Varchar2(15),
   Weight Number(3),
   CONSTRAINT taskTypes_taskType_PK PRIMARY KEY(OfferingID, taskType)
);
-- Drop taskTypes statement, if necessary
-- DROP TABLE taskTypes;

-- Create tasks table statement
CREATE TABLE Tasks (
    TaskID number(8),
    description VARCHAR2(40),
    offeringid NUMBER(8),
	taskType VARCHAR2(15),
    maxpoints NUMBER(4),
    curve NUMBER(4),
	SortOrderKey number(4),
    CONSTRAINT Tasks_pk PRIMARY KEY (TaskID),
    CONSTRAINT Tasks_TaskType_fk1 FOREIGN KEY (offeringid,TaskType) 
	           REFERENCES TaskTypes (offeringid,TaskType) 
);

-- Drop tasks statement, if necessary
-- DROP TABLE tasks;

-- Create Grades table statement
CREATE TABLE Grades (
    offeringid NUMBER(8),
    taskID number(8),
    sid CHAR(9),
    pointsearned NUMBER(4),
    dropped CHAR(1),
    CONSTRAINT grades_pk PRIMARY KEY (taskID, sid),
    CONSTRAINT grades_fk1 FOREIGN KEY (taskid) REFERENCES tasks (taskid)
);

-- Drop grades statement, if necessary
-- DROP TABLE Grades;

-- Create RubricParts table statement
CREATE TABLE RubricParts (
    taskid NUMBER(8),
    partno NUMBER(4),
    maxpoints NUMBER(4),
    description VARCHAR2(80),
    CONSTRAINT rubricparts_pk PRIMARY KEY (TaskID, partno),
    CONSTRAINT rubricparts_fk1 FOREIGN KEY (TaskID) REFERENCES tasks (TaskID)
);

-- Drop rubricparts statement, if necessary
-- DROP TABLE rubricparts;

-- Create RubricGrades tables statement
CREATE TABLE RubricGrades (
    TaskID NUMBER(8),
	partno NUMBER(4),
    SID CHAR(9),
    pointsearned NUMBER(4),
    comments VARCHAR2(200),
    CONSTRAINT rubricgrades_pk PRIMARY KEY (taskID, partno, SID),
    CONSTRAINT rubricgrades_fk1 FOREIGN KEY (TaskID, SID) REFERENCES Grades (taskID, SID),
    CONSTRAINT rubricgrades_fk2 FOREIGN KEY (TaskID, partno) REFERENCES RubricParts (TaskID, partno)
);

-- Drop rubricgrades statement, if necessary
-- DROP TABLE rubricgrades;

insert into terms values('Fall 2019',TO_DATE('26-AUG-2019','DD-MON-YYYY'), TO_DATE('16-DEC-2019','DD-MON-YYYY'));
insert into terms values('Spring 2020',TO_DATE('21-JAN-2020','DD-MON-YYYY'), TO_DATE('11-MAY-2020','DD-MON-YYYY'));

insert into students values('900111111','jsmith14','James','Smith','K',Null,'Speaks six languages');
insert into students values('900222222','kdavis22','Davis','Kara','M',Null,Null);
insert into students values('900333333','rthompson7','Thompson','Richard','A',Null,'Very quiet');
insert into students values('900444444','smyers','Myers','Samantha','B','Sam','Very Loud');
insert into students values('900555555','bwells11','Bryla','Wells','H',Null,Null);
insert into students values('900666666','sfaranello','Scott','Faranello','K','Scotty',Null);
insert into students values('900777777','tripler','Robert','Ruble','R',Null,'Vision Problem');
insert into students values('900888888','tgarr','Terri','Garr','L',Null,Null);
insert into students values('900999999','klee32','Kristen','Lee','A','K','Speaks six languages');
insert into students values('900121212','oprivitera','Olivia','Privitera','M','Livi','Student Athlete');
insert into students values('900343434','tsimms','Tavaras','Simms','S',Null,Null);

insert into courses values('ITEC 315','GUI Design and Implementation');
insert into courses values('ITEC 340','Database Management Systems');
insert into courses values('ITEC 441','Database II');
insert into courses values('ITEC 497','ERP Systems');

insert into courseofferings values(1234,'ITEC 340','Database Management Systems','Fall 2019','01','Davis 216',Null);
insert into courseofferings values(1527,'ITEC 340','Database Management Systems','Spring 2020','02','Davis 212',Null);
insert into courseofferings values(1302,'ITEC 441','Database II','Fall 2019','01','Davis 151',Null);
insert into courseofferings values(1533,'ITEC 441','Database II','Spring 2020','01','Davis 212',Null);

insert into enrollments values('900111111',1234,'A/F','B',null);
insert into enrollments values('900222222',1234,'A/F','A',null);
insert into enrollments values('900333333',1234,'A/F','C',null);
insert into enrollments values('900666666',1234,'A/F','B',null);
insert into enrollments values('900777777',1234,'A/F','B',null);
insert into enrollments values('900444444',1527,'A/F',null,null);
insert into enrollments values('900555555',1527,'A/F',null,null);
insert into enrollments values('900888888',1302,'A/F','A',null);
insert into enrollments values('900999999',1302,'A/F','A',null);
insert into enrollments values('900111111',1533,'A/F',null,null);
insert into enrollments values('900222222',1533,'A/F',null,null);
insert into enrollments values('900333333',1533,'A/F',null,null);
insert into enrollments values('900666666',1533,'A/F',null,null);
insert into enrollments values('900777777',1533,'A/F',null,null);

insert into attendances values('900111111',1234,'27-AUG-2019','P');
insert into attendances values('900111111',1234,'29-AUG-2019','P');
insert into attendances values('900111111',1234,'03-SEP-2019','P');
insert into attendances values('900111111',1234,'05-SEP-2019','A');
insert into attendances values('900111111',1234,'10-SEP-2019','P');
insert into attendances values('900111111',1234,'12-SEP-2019','P');
insert into attendances values('900111111',1234,'17-SEP-2019','P');
insert into attendances values('900111111',1234,'19-SEP-2019','E');
insert into attendances values('900111111',1234,'24-SEP-2019','P');
insert into attendances values('900111111',1234,'26-SEP-2019','P');
insert into attendances values('900111111',1234,'01-OCT-2019','P');
insert into attendances values('900111111',1234,'03-OCT-2019','P');
insert into attendances values('900111111',1234,'08-OCT-2019','P');
insert into attendances values('900111111',1234,'10-OCT-2019','P');

insert into tasktypes values(1234,'HWK',50);
insert into tasktypes values(1234,'TESTS',50);

insert into tasks values(10000001,'HWK1: SQL teacher 1',1234,'HWK',10,0,1);
insert into tasks values(10000002,'HWK2: SQL teacher 2',1234,'HWK',10,0,2);
insert into tasks values(10000003,'HWK3: Views',1234,'HWK',20,0,3);
insert into tasks values(10000004,'HWK4: DDL',1234,'HWK',30,0,4);

insert into grades values(1234,10000001,'900111111',9,'F');
insert into grades values(1234,10000002,'900111111',8,'F');
insert into grades values(1234,10000003,'900111111',17,'F');
insert into grades values(1234,10000004,'900111111',29,'F');

insert into rubricparts values(10000003,1,10,'Views Created');
insert into rubricparts values(10000003,2,10,'View Queries Correct');
insert into rubricparts values(10000004,1,10,'Tables Created');
insert into rubricparts values(10000004,2,10,'Tables Constrained');
insert into rubricparts values(10000004,3,10,'Data Inserted Successfully');

Insert into rubricgrades values(10000003,1,'900111111',10,'correct');
Insert into rubricgrades values(10000003,2,'900111111',7,'query 2 is not correct');
Insert into rubricgrades values(10000004,1,'900111111',10,'correct');
Insert into rubricgrades values(10000004,2,'900111111',9,'missing one check constraint');
Insert into rubricgrades values(10000004,3,'900111111',10,'correct');

commit;





