CREATE TABLE [dbo].[Arme-Stat]
(
	[Id] INT NOT NULL identity PRIMARY KEY, 
    [Id_Arme] INT NOT NULL, 
    [Id_Stat] INT NOT NULL, 
    [Valeur] INT NOT NULL, 
    CONSTRAINT [FK_Arme-Stat_Arme] FOREIGN KEY (Id_Arme) REFERENCES Arme(Id),
	CONSTRAINT [FK_Arme-Stat_Stat] FOREIGN KEY (Id_Stat) REFERENCES Stat(Id)

)
