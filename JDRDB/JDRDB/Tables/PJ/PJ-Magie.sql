﻿CREATE TABLE [dbo].[PJ-Magie]
(
    [Id_PJ] INT NOT NULL, 
    [Id_Magie] INT NOT NULL, 
    CONSTRAINT [FK_PJ-Magie_PJ] FOREIGN KEY (Id_PJ) REFERENCES PJ(Id), 
    CONSTRAINT [FK_PJ-Magie_Magie] FOREIGN KEY ([Id_Magie]) REFERENCES Magie(Id))
