CREATE TABLE [dbo].[Enchantement-Stat]
(
	[Id] INT NOT NULL identity PRIMARY KEY, 
    [Id_Enchantement] INT NOT NULL, 
    [Id_Stat] INT NOT NULL, 
    [Valeur] INT NOT NULL, 
    CONSTRAINT [FK_Enchantement-Stat_Enchantement] FOREIGN KEY (Id_Enchantement) REFERENCES Enchantement(Id), 
    CONSTRAINT [FK_Enchantement-Stat_Stat] FOREIGN KEY (Id_Stat) REFERENCES Stat(Id)
)
