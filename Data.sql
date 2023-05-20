CREATE DATABASE DB_L_Project;

USE DB_L_Project;

-- Creating Tables
CREATE TABLE USER_R (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(255),
	Pass NVARCHAR(255),
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

CREATE TABLE Announcement (
    announce_ID INT PRIMARY KEY,
	announce_Title NVARCHAR(255),
	announce_Desc NVARCHAR(MAX),
	announce_Time DATETIME,
    ClassCode INT FOREIGN KEY REFERENCES CLASS(ClassCode)
);

CREATE TABLE Assignment (
    ass_ID INT PRIMARY KEY,
	ass_Title NVARCHAR(255),
	ass_Desc NVARCHAR(MAX),
	ass_Time DATETIME,
	ass_Marks INT,
    ClassCode INT FOREIGN KEY REFERENCES CLASS(ClassCode)
);

CREATE TABLE Material (
    MT_ID INT PRIMARY KEY,
	MT_Title NVARCHAR(255),
	MT_Desc NVARCHAR(MAX),
	MT_Time DATETIME,
    ClassCode INT FOREIGN KEY REFERENCES CLASS(ClassCode)
);

-- Inserting Data


-- Insert into USER_R table
INSERT INTO USER_R (Name, Pass, Email, UserType)
VALUES
(N'John Doe', N'password1', N'john.doe@example.com', N'Student'),
(N'Jane Smith', N'password2', N'jane.smith@example.com', N'Teacher'),
(N'Michael Johnson', N'password3', N'michael.johnson@example.com', N'Student'),
(N'Sarah Lee', N'password4', N'sarah.lee@example.com', N'Student'),
(N'David Wang', N'password5', N'david.wang@example.com', N'Teacher');

-- Insert into CLASS table
INSERT INTO CLASS (ClassCode, ClassName, ManagedBy)
VALUES
(101, N'English Literature', 2),
(102, N'Mathematics', 2),
(103, N'Physics', 2),
(104, N'History', 2),
(105, N'Chemistry', 2);

-- Insert into TEACHER_CLASS table
INSERT INTO TEACHER_CLASS (UserID, ClassCode)
VALUES
(2, 101),
(2, 102),
(2, 103),
(2, 104),
(2, 105);

-- Insert into REPORT table
INSERT INTO REPORT (ReportID, Time, ClassCode)
VALUES
(1, GETDATE(), 101),
(2, GETDATE(), 102),
(3, GETDATE(), 103),
(4, GETDATE(), 104),
(5, GETDATE(), 105);

-- Insert into COMMENT table
INSERT INTO COMMENT (ClassCode, Time, Content, UserID)
VALUES
(101, GETDATE(), N'Great class!', 1),
(101, GETDATE(), N'Excellent teaching!', 3),
(102, GETDATE(), N'Interesting topic!', 4),
(103, GETDATE(), N'I need help with the assignment.', 1),
(105, GETDATE(), N'Thanks for the explanation.', 5);

-- Insert into STUDENT_CLASS table
INSERT INTO STUDENT_CLASS (UserID, ClassCode)
VALUES
(1, 101),
(3, 101),
(4, 101),
(1, 102),
(5, 102);

-- Insert into Announcement table
INSERT INTO Announcement (announce_ID, announce_Title, announce_Desc, announce_Time, ClassCode)
VALUES
(1, N'Welcome message', N'Welcome to the class!', GETDATE(), 101),
(2, N'Important announcement', N'Please submit your assignments by Friday.', GETDATE(), 102),
(3, N'Class cancellation', N'Todays class is canceled.', GETDATE(), 103),
(4, N'Exam schedule', N'The final exam will be held on June 15th.', GETDATE(), 104),
(5, N'Guest speaker', N'We have a guest speaker coming next week.', GETDATE(), 105);

-- Insert into Assignment table
INSERT INTO Assignment (ass_ID, ass_Title, ass_Desc, ass_Time, ass_Marks, ClassCode)
VALUES
(1, N'Essay Writing', N'Write an essay on the topic of globalization.', GETDATE(), 100, 101),
(2, N'Algebraic Equations', N'Solve the given algebraic equations.', GETDATE(), 80, 102),
(3, N'Projectile Motion', N'Calculate the trajectory of a projectile.', GETDATE(), 90, 103),
(4, N'Historical Research', N'Research and present a historical event.', GETDATE(), 95, 104),
(5, N'Chemical Reactions', N'Balance the given chemical equations.', GETDATE(), 85, 105);

-- Insert into Material table
INSERT INTO Material (MT_ID, MT_Title, MT_Desc, MT_Time, ClassCode)
VALUES
(1, N'Introduction to Literature', N'A presentation introducing the basics of literature.', GETDATE(), 101),
(2, N'Geometry Formulas', N'A document containing important geometry formulas.', GETDATE(), 102),
(3, N'Laws of Thermodynamics', N'A lecture recording explaining the laws of thermodynamics.', GETDATE(), 103),
(4, N'World War II Timeline', N'A timeline infographic illustrating key events of World War II.', GETDATE(), 104),
(5, N'Chemical Bonding', N'A PDF document explaining different types of chemical bonds.', GETDATE(), 105);