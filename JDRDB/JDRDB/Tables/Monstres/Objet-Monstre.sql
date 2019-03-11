CREATE TABLE [dbo].[Objet-Monstre]
(
    [Id_Objet] INT NOT NULL, 
    [Id_Monstre] INT NOT NULL, 
    CONSTRAINT [FK_Objet-Monstre_Objet] FOREIGN KEY (Id_Objet) REFERENCES Objet(Id), 
    CONSTRAINT [FK_Objet-Monstre_Monstre] FOREIGN KEY (Id_Monstre) REFERENCES Monstre(Id)
)
