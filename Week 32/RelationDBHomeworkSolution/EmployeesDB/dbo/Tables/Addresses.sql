﻿CREATE TABLE [dbo].[Addresses]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [StreetAddress] NVARCHAR(50) NOT NULL, 
    [City] NVARCHAR(50) NOT NULL, 
    [State] NVARCHAR(2) NOT NULL, 
    [ZipCode] NVARCHAR(10) NOT NULL
)
