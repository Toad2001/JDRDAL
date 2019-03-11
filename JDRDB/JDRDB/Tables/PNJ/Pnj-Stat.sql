﻿CREATE TABLE [dbo].[PNJ-Stat]
(
	[Id] INT NOT NULL identity PRIMARY KEY, 
    [Id_PNJ] INT NOT NULL, 
    [Id_Stat] INT NOT NULL, 
    [Valeur] INT NOT NULL, 
    CONSTRAINT [FK_PNJ-Stat_PJ] FOREIGN KEY (Id_PNJ) REFERENCES PNJ(Id), 
    CONSTRAINT [FK_PNJ-Stat_Stat] FOREIGN KEY (Id_Stat) REFERENCES Stat(Id)
)
