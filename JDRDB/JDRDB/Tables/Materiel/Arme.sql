CREATE TABLE [dbo].[Arme]
(
	[Id] INT NOT NULL identity PRIMARY KEY, 
    [Nom] NVARCHAR(50) NOT NULL, 
    [Malus] INT NULL, 
    [DeuxMains] BIT NOT NULL, 
    [Id_TypeArme] INT NULL, 
	CONSTRAINT [FK_Arme_TypeArme] FOREIGN KEY (Id_TypeArme) REFERENCES TypeArme(Id)

)
