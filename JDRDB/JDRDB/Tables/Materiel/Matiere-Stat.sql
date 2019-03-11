CREATE TABLE [dbo].[Matiere-Stat]
(
	[Id] INT NOT NULL identity PRIMARY KEY, 
    [Id_Matiere] INT NOT NULL, 
    [Id_Stat] INT NOT NULL, 
    [Valeur] INT NOT NULL, 
    CONSTRAINT [FK_Matiere-Stat_Matiere] FOREIGN KEY (Id_Matiere) REFERENCES Matiere(Id),
    CONSTRAINT [FK_Matiere-Stat_Stat] FOREIGN KEY (Id_Stat) REFERENCES Stat(Id)
)
