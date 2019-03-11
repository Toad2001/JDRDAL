CREATE TABLE [dbo].[Race]
(
	[Id] INT NOT NULL identity PRIMARY KEY, 
    [Nom] NVARCHAR(50) NOT NULL, 
    [Id_Province] INT NULL, 
    [Id_Resistence] INT NULL, 
    [Id_Capacite1] INT NOT NULL, 
    [Id_Capacite2] INT NOT NULL, 
    CONSTRAINT [FK_Race_Province] FOREIGN KEY (Id_Province) REFERENCES Province(Id), 
    CONSTRAINT [FK_Race_Resistence] FOREIGN KEY ([Id_Resistence]) REFERENCES Resistence(Id), 
    CONSTRAINT [FK_Race_Capacite1] FOREIGN KEY (Id_Capacite1) REFERENCES Capacite(Id),
    CONSTRAINT [FK_Race_Capacite2] FOREIGN KEY (Id_Capacite2) REFERENCES Capacite(Id)
)
