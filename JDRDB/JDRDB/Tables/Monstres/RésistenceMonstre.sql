CREATE TABLE [dbo].[RésistenceMonstre]
(
	[Id] INT NOT NULL identity PRIMARY KEY, 
    [Description] TEXT NOT NULL, 
    [Id_Monstre] INT NOT NULL, 
    CONSTRAINT [FK_RésistenceMonstre_Monstre] FOREIGN KEY (Id_Monstre) REFERENCES Monstre(Id)
)
