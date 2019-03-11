CREATE TABLE [dbo].[Lieu-Monstre]
(
    [Id_Monstre] INT NOT NULL, 
    [Id_Lieu] INT NOT NULL ,

	CONSTRAINT [FK_Lieu_Lieu_Monstre] FOREIGN KEY (Id_Lieu) REFERENCES Lieu([Id]),
	CONSTRAINT [FK_Monstre_Lieu_Monstre] FOREIGN KEY (Id_Monstre) REFERENCES Monstre([Id])

)
