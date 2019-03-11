CREATE TABLE [dbo].[Stat]
(
	[Id] INT NOT NULL identity PRIMARY KEY, 
    [Nom] VARCHAR(50) NOT NULL, 
    [Id_ClasseStat] INT NOT NULL, 
    CONSTRAINT [FK_Stat_ClasseStat] FOREIGN KEY ([Id_ClasseStat]) REFERENCES ClasseStat(Id)
)
