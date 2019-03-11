CREATE TABLE [dbo].[Pj-Armure]
(
    [Id_PJ] INT NOT NULL, 
    [Id_Armure] INT NOT NULL, 
    CONSTRAINT [FK_PJ-Armure_PJ] FOREIGN KEY (Id_PJ) REFERENCES PJ(Id), 
    CONSTRAINT [FK_PJ-Armure_Armure] FOREIGN KEY (Id_Armure) REFERENCES Armure(Id)
	)
