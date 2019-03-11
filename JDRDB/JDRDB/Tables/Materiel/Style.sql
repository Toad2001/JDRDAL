CREATE TABLE [dbo].[Style]
(
	[Id] INT NOT NULL identity PRIMARY KEY, 
    [Nom] NVARCHAR(50) NOT NULL, 
    [Prix] INT NULL DEFAULT 1
)
