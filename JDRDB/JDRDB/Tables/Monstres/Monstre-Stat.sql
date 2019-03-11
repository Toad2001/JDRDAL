CREATE TABLE [dbo].[Monstre-Stat]
(
	[Id] INT NOT NULL identity PRIMARY KEY, 
    [Id_Monstre] INT NOT NULL, 
    [Id_Stat] INT NOT NULL, 
    [Valeur] INT NOT NULL, 
    CONSTRAINT [FK_Monstre-Stat_Monstre] FOREIGN KEY (Id_Monstre) REFERENCES Monstre(Id), 
    CONSTRAINT [FK_Monstre-Stat_Stat] FOREIGN KEY (Id_Stat) REFERENCES Stat(Id)
)
