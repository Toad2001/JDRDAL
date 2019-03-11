CREATE TABLE [dbo].[Monstre]
(
	[Id] INT NOT NULL identity , 
	[Nom] NVARCHAR(50) NOT NULL, 
	[Id_Ame] INT NULL , 
    [Id_Rang] INT NOT NULL, 
    [Id_Resistence] INT NULL, 
    [Id_Capacite] INT NULL, 
    PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Monstre_Ame] FOREIGN KEY (Id_Ame) REFERENCES Ame (Id), 
    CONSTRAINT [FK_Monstre_Rang] FOREIGN KEY (Id_Rang) REFERENCES Rang(Id), 
    CONSTRAINT [FK_Monstre_Resistence] FOREIGN KEY (Id_Resistence) REFERENCES Resistence(Id), 
    CONSTRAINT [FK_Monstre_Capacite] FOREIGN KEY (Id_Capacite) REFERENCES Capacite(Id), 
)
