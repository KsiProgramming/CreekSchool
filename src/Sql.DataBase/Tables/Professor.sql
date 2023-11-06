CREATE TABLE [dbo].[Professor]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[FirstName] VARCHAR(50) NOT NULL,
	[LastName] VARCHAR(50) NOT NULL,
	[SexId] INT NOT NULL,
	[SubjectId] INT,

	CONSTRAINT PK_Professor PRIMARY KEY (Id),
)
