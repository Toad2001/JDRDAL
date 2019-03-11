CREATE TABLE [dbo].[PJ-Equipement]
(
    [Id_PJ] INT NOT NULL, 
    [Id_Equipement] INT NOT NULL, 
    CONSTRAINT [FK_PJ-Equipement_PJ] FOREIGN KEY (Id_PJ) REFERENCES PJ(Id), 
    CONSTRAINT [FK_PJ-Equipement_Equipement] FOREIGN KEY (Id_Equipement) REFERENCES Equipement(Id)
)
