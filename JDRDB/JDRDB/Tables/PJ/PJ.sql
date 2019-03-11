CREATE TABLE [dbo].[PJ]
(
	[Id] INT NOT NULL identity PRIMARY KEY, 
    [Nom] VARCHAR(50) NULL, 
    [Sexe] BIT NOT NULL, 
    [Blesse] BIT NOT NULL DEFAULT 0, 
    [Esquive] BIT NOT NULL DEFAULT 0, 
    [CoupPuissant] BIT NOT NULL DEFAULT 0, 
    [Id_Race] INT NULL, 
    [Id_Classe] INT NULL, 
    [Id_Signe] INT NULL, 
    CONSTRAINT [FK_PJ_Race] FOREIGN KEY (Id_Race) REFERENCES Race(Id), 
    CONSTRAINT [FK_PJ_Classe] FOREIGN KEY (Id_Classe) REFERENCES Classe(Id), 
    CONSTRAINT [FK_PJ_Signe] FOREIGN KEY (Id_Signe) REFERENCES Signe(Id), 

)
