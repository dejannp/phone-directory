﻿CREATE TABLE [dbo].[registration]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [firstname] VARCHAR(50) NULL, 
    [lastname] VARCHAR(50) NULL, 
    [email] VARCHAR(MAX) NULL, 
    [username] VARCHAR(50) NULL, 
    [password] VARCHAR(50) NULL, 
    [contact] VARCHAR(50) NULL
)
