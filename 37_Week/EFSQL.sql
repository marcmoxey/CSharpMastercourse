


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