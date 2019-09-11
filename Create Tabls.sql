--DBTabls

--סוג אירוע
CREATE TABLE [dbo].[EventType]
(
	[EventTypeCode] INT NOT NULL PRIMARY KEY Identity (1,1), 
    [EventTypeName] NVARCHAR(50) NOT NULL,

)
--משתמש
CREATE TABLE [dbo].[Users]
(
	[UserCode] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [UserName] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [Phone] NCHAR(10) NULL, 
    [Clue] NCHAR(10) NOT NULL, 
    [Mail] NVARCHAR(50) NOT NULL

)

--אירוע
CREATE TABLE [dbo].[Event]
(
	[EventCode] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [EventName] NVARCHAR(50) NOT NULL, 
    [EventTypeCode] NVARCHAR(50) NOT NULL, 
    [EventDate] DATE NOT NULL, 
    [UserCode] INT NOT NULL, 
    [EventStatus] INT NOT NULL
)
CREATE TABLE [dbo].[SubTask]
(
	[SubTaskCode] INT NOT NULL PRIMARY KEY identity(1,1), 
    [SubTaskName] NVARCHAR(50) NOT NULL, 
    [TaskCode] INT NOT NULL, 
    [SubTaskDate] DATE NOT NULL, 
    [BeginingTime] TIME NOT NULL, 
    [duration] FLOAT NOT NULL, 
    [status] INT NOT NULL, 
    [details] NVARCHAR(50) NOT NULL
)
CREATE TABLE [dbo].[Professional]
(
	[ProfessionalCode] INT NOT NULL PRIMARY KEY identity(1,1), 
    [ProfessionalName] NVARCHAR(50) NOT NULL, 
    [ProfessionalTypeCode] INT NOT NULL, 
    [ProfessionalPhone] NVARCHAR(50) NOT NULL, 
    [SeveralTimesInvited] INT NOT NULL, 
    [LivingArea] NCHAR(10) NOT NULL, 
    [TotalRatings] INT NOT NULL
)