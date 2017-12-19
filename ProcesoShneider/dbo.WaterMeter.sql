CREATE TABLE [dbo].[WaterMeter]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SerialNumber] NVARCHAR(50) NOT NULL, 
    [Brand] NVARCHAR(50) NULL, 
    [Model] NVARCHAR(50) NULL
)
