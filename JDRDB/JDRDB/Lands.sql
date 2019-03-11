CREATE TABLE [dbo].[Lieu]
(
	[Id] INT NOT NULL identity PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
    [ID_Provinces] INT NOT NULL, 
    CONSTRAINT [FK_Lands_Provinces] FOREIGN KEY[ID_Provinces]ces) REFERENCES Provinces(Id)
)
