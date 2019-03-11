CREATE TABLE [dbo].[Race-Stat]
(
	[Id] INT NOT NULL identity PRIMARY KEY, 
    [Id_Race] INT NOT NULL, 
    [Id_Stat] INT NOT NULL, 
    [Valeur] INT NOT NULL, 
    CONSTRAINT [FK_Race-Stat_Race] FOREIGN KEY (Id_Race) REFERENCES Race(Id), 
    CONSTRAINT [FK_Race-Stat_Stat] FOREIGN KEY (Id_Stat) REFERENCES Stat(Id)
)
