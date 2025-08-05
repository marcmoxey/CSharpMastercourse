CREATE TABLE [dbo].[PersonEmployer]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PersonId] INT NOT NULL, 
    [EmployerId] INT NOT NULL
)
