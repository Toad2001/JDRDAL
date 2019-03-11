CREATE TABLE [dbo].[Magie-Stat]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [Id_Magie] INT NOT NULL, 
    [Id_Stat] INT NOT NULL, 
    [Valeur] INT NOT NULL, 
    CONSTRAINT [FK_Magie-Stat_Magie] FOREIGN KEY (Id_Magie) REFERENCES Magie(Id), 
    CONSTRAINT [FK_Magie-Stat_Stat] FOREIGN KEY (Id_Stat) REFERENCES Stat(Id)
)
