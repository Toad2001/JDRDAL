CREATE TABLE [dbo].[Style-Armure]
(
    [Id_Style] INT NOT NULL, 
    [Id_Armure] INT NOT NULL, 
    CONSTRAINT [FK_Style-Armure_Style] FOREIGN KEY ([Id_Style]) REFERENCES Style(Id), 
    CONSTRAINT [FK_Style-Armure_Armure] FOREIGN KEY ([Id_Armure]) REFERENCES Armure(Id)
)
