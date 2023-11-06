CREATE TABLE [dbo].[Student]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[FirstName] VARCHAR(50) NOT NULL,
	[LastName] VARCHAR(50) NOT NULL,
	[SexId] INT NOT NULL,
	[ProfessorId] INT,
	[ClassroomId] INT,

	CONSTRAINT PK_Student PRIMARY KEY (Id),
	CONSTRAINT FK_StudentProfessor FOREIGN KEY (ProfessorId) REFERENCES Professor(Id),
	CONSTRAINT FK_StudentClassroom FOREIGN KEY (ClassroomId) REFERENCES Classroom(Id),
	CONSTRAINT FK_StudentSex       FOREIGN KEY (SexId) REFERENCES Sex(Id),
)
