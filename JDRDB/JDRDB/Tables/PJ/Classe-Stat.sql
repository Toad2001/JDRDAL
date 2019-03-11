CREATE TABLE [dbo].[Classe-Stat]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [Id_Classe] INT NOT NULL, 
    [Id_Stat] INT NOT NULL, 
    [Valeur] INT NOT NULL, 
    CONSTRAINT [FK_Classe-Stat_Classe] FOREIGN KEY (Id_Classe) REFERENCES Classe(Id), 
    CONSTRAINT [FK_Classe-Stat_Stat] FOREIGN KEY (Id_Stat) REFERENCES Stat(Id)
)
