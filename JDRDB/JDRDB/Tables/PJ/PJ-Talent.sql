CREATE TABLE [dbo].[PJ-Talent]
(
    [Id_PJ] INT NOT NULL, 
    [Id_Talent] INT NOT NULL, 
    CONSTRAINT [FK_PJ-Talent_PJ] FOREIGN KEY (Id_PJ) REFERENCES PJ(Id), 
    CONSTRAINT [FK_PJ-Talent_Talent] FOREIGN KEY ([Id_Talent]) REFERENCES Talent(Id)
)
