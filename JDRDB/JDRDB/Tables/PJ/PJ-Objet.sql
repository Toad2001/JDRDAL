﻿CREATE TABLE [dbo].[PJ-Objet]
(
    [Id_PJ] INT NOT NULL, 
    [Id_Objet] INT NOT NULL, 
    CONSTRAINT [FK_PJ-Objet_PJ] FOREIGN KEY (Id_PJ) REFERENCES PJ(Id), 
    CONSTRAINT [FK_PJ-Objet_Objet] FOREIGN KEY (Id_Objet) REFERENCES Objet(Id)
)
