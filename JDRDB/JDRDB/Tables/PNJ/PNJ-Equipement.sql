CREATE TABLE [dbo].[PNJ-Equipement]
(
    [Id_PNJ] INT NOT NULL, 
    [Id_Equipement] INT NOT NULL, 
    CONSTRAINT [FK_PNJ-Equipement_PNJ] FOREIGN KEY ([Id_PNJ]) REFERENCES PNJ(Id), 
    CONSTRAINT [FK_PNJ-Equipement_Equipement] FOREIGN KEY ([Id_Equipement]) REFERENCES Equipement(Id)
)
