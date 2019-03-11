CREATE TABLE [dbo].[Equipement]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [Id_Arme] INT NULL, 
    [Id_Armure] INT NULL, 
    [Id_Matiere] INT NOT NULL, 
    [Id_Style] INT NOT NULL, 
    [Id_Enchantement] INT NULL,
    CONSTRAINT [FK_Equipement_Arme] FOREIGN KEY (Id_Arme) REFERENCES Arme(Id),
    CONSTRAINT [FK_Equipement_Armure] FOREIGN KEY (Id_Armure) REFERENCES Armure(Id),
    CONSTRAINT [FK_Equipement_Matiere] FOREIGN KEY (Id_Matiere) REFERENCES Matiere(Id),
    CONSTRAINT [FK_Equipement_Style] FOREIGN KEY (Id_Style) REFERENCES Style(Id),
    CONSTRAINT [FK_Equipement_Enchantement] FOREIGN KEY (Id_Enchantement) REFERENCES Enchantement(Id)
)
