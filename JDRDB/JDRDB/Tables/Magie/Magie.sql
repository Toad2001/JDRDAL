CREATE TABLE [dbo].[Magie]
(
	[Id] INT NOT NULL identity PRIMARY KEY, 
    [Nom] NVARCHAR(50) NOT NULL, 
	[Effet] TEXT NOT NULL, 
    [Id_EcoleMagie] INT NOT NULL , 
    [Id_RangMagie] INT NOT NULL, 
    CONSTRAINT [FK_Magie_EcoleMagie] FOREIGN KEY (Id_EcoleMagie) REFERENCES EcoleMagie(Id),
    CONSTRAINT [FK_Magie_RangMagie] FOREIGN KEY (Id_RangMagie) REFERENCES RangMagie(Id),
)
