CREATE TABLE [dbo].[Classroom]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[Name] VARCHAR(50) NOT NULL,
	[ProfessorId] INT,
	[LevelId] INT,

	CONSTRAINT PK_Classroom PRIMARY KEY (Id),
	CONSTRAINT FK_ClassroomLevel FOREIGN KEY (LevelId) REFERENCES Level(Id),
	CONSTRAINT FK_ClassroomProfessor FOREIGN KEY (ProfessorId) REFERENCES Professor(Id),
)
