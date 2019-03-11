CREATE TABLE [dbo].[Objet]
(
	[Id] INT NOT NULL identity PRIMARY KEY, 
    [Nom] NVARCHAR(50) NOT NULL, 
    [Encombrement] INT NOT NULL DEFAULT 0, 
    [Prix] INT NOT NULL DEFAULT 0, 
    [Effet] TEXT NULL 
)
