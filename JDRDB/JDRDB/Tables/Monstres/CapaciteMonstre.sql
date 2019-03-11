CREATE TABLE [dbo].[CapaciteMonstre]
(
	[Id] INT NOT NULL identity PRIMARY KEY, 
    [Nom] NVARCHAR(50) NOT NULL, 
    [Description] TEXT NOT NULL, 
    [Id_Monstre] INT NOT NULL, 
    CONSTRAINT [FK_CapacitéMonstre_Monstre] FOREIGN KEY (Id_Monstre) REFERENCES Monstre(Id)
)
