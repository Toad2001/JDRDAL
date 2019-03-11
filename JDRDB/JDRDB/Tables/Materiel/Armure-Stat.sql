CREATE TABLE [dbo].[Armure-Stat]
(
	[Id] INT NOT NULL identity PRIMARY KEY, 
    [Id_Armure] INT NOT NULL, 
    [Id_Stat] INT NOT NULL, 
    [Valeur] INT NOT NULL, 
    CONSTRAINT [FK_Armure-Stat_Armure] FOREIGN KEY (Id_Armure) REFERENCES Armure(Id),
	CONSTRAINT [FK_Armure-Stat_Stat] FOREIGN KEY (Id_Stat) REFERENCES Stat(Id)
)
