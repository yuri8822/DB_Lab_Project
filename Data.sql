CREATE DATABASE DB_L_Project;

USE DB_L_Project;

-- Creating Tables
CREATE TABLE USER_R (
    UserID INT PRIMARY KEY,
    Name NVARCHAR(255),
    Email NVARCHAR(255),
    UserType NVARCHAR(10) CHECK (UserType IN ('Student', 'Teacher'))
);

CREATE TABLE CLASS (
    ClassCode INT PRIMARY KEY,
    ClassName NVARCHAR(255),
    ManagedBy INT FOREIGN KEY REFERENCES USER_R(UserID)
);

CREATE TABLE TEACHER_CLASS (
    UserID INT FOREIGN KEY REFERENCES USER_R(UserID),
    ClassCode INT FOREIGN KEY REFERENCES CLASS(ClassCode),
    PRIMARY KEY(UserID, ClassCode)
);

CREATE TABLE POST (
    PostID INT PRIMARY KEY,
    Name NVARCHAR(255),
    Time DATETIME,
    ClassCode INT FOREIGN KEY REFERENCES CLASS(ClassCode),
    PostType NVARCHAR(20) CHECK (PostType IN ('Material', 'Assignment', 'Announcement')),
    Deadline DATETIME NULL,
    Status NVARCHAR(20) CHECK (Status IN ('Not Started', 'In Progress', 'Submitted')) NULL,
    Grade FLOAT NULL
);

CREATE TABLE REPORT (
    ReportID INT PRIMARY KEY,
    Time DATETIME,
    ClassCode INT FOREIGN KEY REFERENCES CLASS(ClassCode)
);

CREATE TABLE COMMENT (
    ClassCode INT FOREIGN KEY REFERENCES CLASS(ClassCode),
    Time DATETIME,
    Content NVARCHAR(MAX),
    UserID INT FOREIGN KEY REFERENCES USER_R(UserID),
    CONSTRAINT PK_Comment PRIMARY KEY (ClassCode, Time, UserID)
);

CREATE TABLE STUDENT_CLASS (
    UserID INT FOREIGN KEY REFERENCES USER_R(UserID),
    ClassCode INT FOREIGN KEY REFERENCES CLASS(ClassCode),
    PRIMARY KEY(UserID, ClassCode)
);

-- Inserting Data
INSERT INTO USER_R(UserID, Name, Email, UserType) VALUES
(1, 'John Doe', 'john.doe@example.com', 'Student'),
(2, 'Jane Smith', 'jane.smith@example.com', 'Student'),
(3, 'Alice Johnson', 'alice.johnson@example.com', 'Teacher'),
(4, 'Bob Williams', 'bob.williams@example.com', 'Teacher'),
(5, 'Charlie Brown', 'charlie.brown@example.com', 'Student');

INSERT INTO CLASS (ClassCode, ClassName, ManagedBy) VALUES
(101, 'Mathematics', 3),
(102, 'Physics', 3),
(103, 'Chemistry', 4),
(104, 'Biology', 4),
(105, 'English', 3);

INSERT INTO TEACHER_CLASS (UserID, ClassCode) VALUES
(3, 101),
(3, 102),
(4, 103),
(4, 104),
(3, 105);

INSERT INTO POST (PostID, Name, Time, ClassCode, PostType, Deadline, Status, Grade) VALUES
(1, 'Math Assignment 1', GETDATE(), 101, 'Assignment', DATEADD(DAY, 7, GETDATE()), 'Not Started', NULL),
(2, 'Physics Material', GETDATE(), 102, 'Material', NULL, NULL, NULL),
(3, 'Chemistry Announcement', GETDATE(), 103, 'Announcement', NULL, NULL, NULL),
(4, 'Biology Assignment 2', GETDATE(), 104, 'Assignment', DATEADD(DAY, 14, GETDATE()), 'Not Started', NULL),
(5, 'English Material', GETDATE(), 105, 'Material', NULL, NULL, NULL);

INSERT INTO REPORT (ReportID, Time, ClassCode) VALUES
(1, GETDATE(), 101),
(2, GETDATE(), 102),
(3, GETDATE(), 103),
(4, GETDATE(), 104),
(5, GETDATE(), 105);

INSERT INTO COMMENT (ClassCode, Time, Content, UserID) VALUES
(101, GETDATE(), 'I am having trouble with this topic.', 1),
(102, GETDATE(), 'This material is helpful.', 2),
(103, GETDATE(), 'Any extra resources for this topic?', 1),
(104, GETDATE(), 'I have a question about this assignment.', 5),
(105, GETDATE(), 'I am excited to learn this topic!', 2);

INSERT INTO STUDENT_CLASS (UserID, ClassCode) VALUES
(1, 101),
(2, 102),
(1, 103),
(5, 104),
(2, 105);