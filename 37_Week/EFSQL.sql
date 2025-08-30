


SELECT [c].[Id], [c].[FirstName], [c].[LastName], 
	[e].[Id], [e].[ContactId], [e].[EmailAddress], 
	[p].[Id], [p].[ContactId], [p].[PhoneNumber]
FROM [Contacts] AS [c]
LEFT JOIN [EmailAddresses] AS [e] ON [c].[Id] = [e].[ContactId]
LEFT JOIN [PhoneNumbers] AS [p] ON [c].[Id] = [p].[ContactId]
ORDER BY [c].[Id], [e].[Id]

SELECT [c].[Id], [c].[FirstName], [c].[LastName]
FROM [Contacts] AS [c]


-- never use
exec sp_executesql N'SELECT TOP(1) [c].[Id], [c].[FirstName], [c].[LastName]
FROM [Contacts] AS [c]
WHERE [c].[Id] = @__id_0',N'@__id_0 int',@__id_0=1

exec sp_executesql N'SET IMPLICIT_TRANSACTIONS OFF;
SET NOCOUNT ON;
INSERT INTO [Contacts] ([FirstName], [LastName])
OUTPUT INSERTED.[Id]
VALUES (@p0, @p1);
',N'@p0 nvarchar(4000),@p1 nvarchar(4000)',@p0=N'Charity',@p1=N'Corey'


exec sp_executesql N'SET NOCOUNT ON;
MERGE [EmailAddresses] USING (
VALUES (@p2, @p3, 0),
(@p4, @p5, 1)) AS i ([ContactId], [EmailAddress], _Position) ON 1=0
WHEN NOT MATCHED THEN
INSERT ([ContactId], [EmailAddress])
VALUES (i.[ContactId], i.[EmailAddress])
OUTPUT INSERTED.[Id], i._Position;
MERGE [PhoneNumbers] USING (
VALUES (@p6, @p7, 0),
(@p8, @p9, 1)) AS i ([ContactId], [PhoneNumber], _Position) ON 1=0
WHEN NOT MATCHED THEN
INSERT ([ContactId], [PhoneNumber])
VALUES (i.[ContactId], i.[PhoneNumber])
OUTPUT INSERTED.[Id], i._Position;
',N'@p2 int,@p3 nvarchar(4000),
@p4 int,@p5 nvarchar(4000),
@p6 int,@p7 nvarchar(4000),
@p8 int,@p9 nvarchar(4000)',
@p2=5,@p3=N'nope@aol.com',
@p4=5,@p5=N'me@timothycorey.com',
@p6=5,@p7=N'555-1212',@p8=5,@p9=N'555-9876'