CREATE TABLE [dbo].[Talent]
(
	[Id] INT NOT NULL identity PRIMARY KEY, 
    [Nom] NVARCHAR(50) NOT NULL, 
    [Limite] INT NULL, 
    [Effet] TEXT NOT NULL,
	[Id_Stat] INT NOT NULL, 
    CONSTRAINT [FK_Talent_Stat] FOREIGN KEY (Id_Stat) REFERENCES Stat(Id)

)
