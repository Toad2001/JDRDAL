CREATE TABLE [dbo].[Style-Arme]
(
    [Id_Style] INT NOT NULL, 
    [Id_Arme] INT NOT NULL, 
    CONSTRAINT [FK_Style-Arme_Style] FOREIGN KEY ([Id_Style]) REFERENCES Style(Id), 
    CONSTRAINT [FK_Style-Arme_Arme] FOREIGN KEY ([Id_Arme]) REFERENCES Arme(Id)
)
