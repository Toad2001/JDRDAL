CREATE TABLE [dbo].[Lieu-Monstre]
(
    [Id_Monster] INT NOT NULL, 
    [Id_Land] INT NOT NULL ,

	CONSTRAINT [FK_Lieu_Lieu_Monstre] FOREIGN KEY ([Id_Land]) REFERENCES Lieu([Id]),
	CONSTRAINT [FK_Monstre_Lieu_Monstre] FOREIGN KEY ([Id_Monster]) REFERENCES Monstre(Id_Monstre)

)
