CREATE TABLE [dbo].[PNJ-Armure]
(
    [Id_PNJ] INT NOT NULL, 
    [Id_Armure] INT NOT NULL, 
    CONSTRAINT [FK_PNJ-Armure_PNJ] FOREIGN KEY ([Id_PNJ]) REFERENCES PNJ(Id), 
    CONSTRAINT [FK_PNJ-Armure_Armure] FOREIGN KEY (Id_Armure) REFERENCES Armure(Id)
)
