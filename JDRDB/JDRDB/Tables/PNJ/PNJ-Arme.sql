﻿CREATE TABLE [dbo].[PNJ-Arme]
(
    [Id_PNJ] INT NOT NULL, 
    [Id_Arme] INT NOT NULL, 
    CONSTRAINT [FK_PNJ-Arme_PNJ] FOREIGN KEY ([Id_PNJ]) REFERENCES PNJ(Id), 
    CONSTRAINT [FK_PNJ-Arme_Arme] FOREIGN KEY ([Id_Arme]) REFERENCES Arme(Id)
)
