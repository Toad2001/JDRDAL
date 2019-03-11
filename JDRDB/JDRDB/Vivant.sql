CREATE TABLE [dbo].[Vivant]
(
	[Id_Vivant] INT NOT NULL identity PRIMARY KEY, 
    [Nom] VARCHAR(50) NOT NULL, 
    [Sante] INT NOT NULL, 
    [Esquive] INT NOT NULL, 
    [Ame] VARCHAR(50) NULL , 
    [Rang] NCHAR(10) NOT NULL, 
    [Id_Province] INT NOT NULL, 
    CONSTRAINT [FK_Vivant_Province] FOREIGN KEY (Id_Province) REFERENCES Province(Id_Province) 
)
