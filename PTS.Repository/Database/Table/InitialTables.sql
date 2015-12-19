Use Master
GO
CREATE DATABASE ProjectTrackingSystemDB
GO
USE ProjectTrackingSystemDB
GO
CREATE TABLE Project
(
    ProjectID INT PRIMARY KEY IDENTITY,
    ProjectName NVARCHAR(100),
    StartDate DATETIME NULL,
    EndDate DATETIME NULL,
    ClientName NVARCHAR(100)
)

CREATE TABLE Employee
(
    EmployeeID INT PRIMARY KEY,
    EmployeeName NVARCHAR(100),
    Designation NVARCHAR(100),
    ManagerID INT,
    ContactNo NVARCHAR(15) NULL,
    EMailID NVARCHAR(30),
    SkillSet NVARCHAR(100) NULL
)

CREATE TABLE UserStory
(
    UserStoryID INT PRIMARY KEY,
    Story NVARCHAR(4000),
    ProjectID INT REFERENCES Project(ProjectID)
)

CREATE TABLE ProjectTask
(
    ProjectTaskID INT PRIMARY KEY IDENTITY,
    AssignedTo INT REFERENCES Employee(EmployeeID) NULL,
    TaskStartDate DATETIME NULL,
    TaskEndDate DATETIME NULL,
    TaskCompletion INT DEFAULT 0,
    UserStoryID INT REFERENCES UserStory(UserStoryID)
)

CREATE TABLE ManagerComment
(
    ManagerCommentID INT PRIMARY KEY IDENTITY,
    Comments NVARCHAR(2000),
    ProjectTaskID INT REFERENCES ProjectTask(ProjectTaskID)
)