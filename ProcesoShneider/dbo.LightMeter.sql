CREATE TABLE [dbo].[LightMeter]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Serial_Number] NVARCHAR(50) NOT NULL, 
    [Brand] NVARCHAR(50) NULL, 
    [Model] NVARCHAR(50) NULL
)
