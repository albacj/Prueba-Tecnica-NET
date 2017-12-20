CREATE TABLE [dbo].[Gateway]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SerialNumber] NVARCHAR(50) NOT NULL, 
    [Brand] NVARCHAR(50) NULL, 
    [Model] NVARCHAR(50) NULL, 
    [Ip] NVARCHAR(50) NOT NULL, 
    [Port] INT NULL
)
