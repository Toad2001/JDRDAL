CREATE TABLE [dbo].[CapaciteRace]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Nom] NVARCHAR(50) NOT NULL, 
    [Description] TEXT NOT NULL, 
    [Id_Race] INT NOT NULL, 
    CONSTRAINT [FK_CapaciteRace_Race] FOREIGN KEY (Id_Race) REFERENCES Race(Id)
)
