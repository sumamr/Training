CREATE TABLE [dbo].[products]
(
	[code] INT NOT NULL PRIMARY KEY, 
    [name] VARCHAR(50) NOT NULL, 
    [description] VARCHAR(100) NULL, 
    [manufacturer] VARCHAR(50) NOT NULL, 
    [price] FLOAT NOT NULL,

)