CREATE TABLE [dbo].[EffetMagie]
(
	[Id] INT NOT NULL identity PRIMARY KEY, 
    [Nom] NVARCHAR(50) NOT NULL, 
    [Effet] NCHAR(10) NOT NULL, 
    [Id_Magie] INT NOT NULL, 
    CONSTRAINT [FK_EffetMagie_Magie] FOREIGN KEY (Id_Magie) REFERENCES Magie(Id)
)
