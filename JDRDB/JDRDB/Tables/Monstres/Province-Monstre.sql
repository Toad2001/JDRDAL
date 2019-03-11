CREATE TABLE [dbo].[Province-Monstre]
(
    [Id_Monstre] INT NOT NULL, 
    [Id_Province] INT NOT NULL ,

	CONSTRAINT [FK_Province_Province_Monstre] FOREIGN KEY ([Id_Province]) REFERENCES Province([Id]),
	CONSTRAINT [FK_Monstre_Province_Monstre] FOREIGN KEY (Id_Monstre) REFERENCES Monstre([Id])
)
