CREATE TABLE [dbo].[Grade]
(
	[StudentId] INT NOT NULL,
    [SubjectId] INT NOT NULL,
	[Value] INT NOT NULL,
	
    CONSTRAINT PK_Grade PRIMARY KEY (StudentId, SubjectId),
    CONSTRAINT FK_GradeStudent FOREIGN KEY (StudentId) REFERENCES Student(Id),
    CONSTRAINT FK_GradeSubject FOREIGN KEY (SubjectId) REFERENCES Subject(Id),
	CONSTRAINT CK_ValueRange CHECK (Value >= 0 AND Value <= 20)
)
