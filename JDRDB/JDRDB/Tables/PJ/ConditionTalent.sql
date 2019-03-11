CREATE TABLE [dbo].[ConditionTalent]
(
	[Id] INT NOT NULL identity PRIMARY KEY, 
    [Condition] TEXT NOT NULL, 
    [Id_Talent] INT NOT NULL, 
    CONSTRAINT [FK_ConditionTalent_Talent] FOREIGN KEY (Id_Talent) REFERENCES Talent(Id)
)
