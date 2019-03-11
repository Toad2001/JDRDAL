CREATE TABLE [dbo].[Enchantement]
(
	[Id] INT NOT NULL identity PRIMARY KEY, 
    [Nom] NVARCHAR(50) NOT NULL, 
    [Effet] TEXT NOT NULL 
)
