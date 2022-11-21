CREATE TABLE [dbo].[productnew]
(
	[code] INT NOT NULL PRIMARY KEY, 
    [name] VARCHAR(50) NOT NULL, 
    [description] VARCHAR(100) NOT NULL, 
    [manufacturer] VARCHAR(50) NOT NULL, 
    [price] FLOAT NULL
)