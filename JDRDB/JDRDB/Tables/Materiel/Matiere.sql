CREATE TABLE [dbo].[Matiere]
(
	[Id] INT NOT NULL identity PRIMARY KEY, 
    [Nom] NVARCHAR(50) NOT NULL, 
	[Arme] BIT NOT NULL ,
    [ArmureLourd] BIT NOT NULL, 
    [ArmureLegere] BIT NOT NULL
)
