CREATE PROCEDURE [dbo].[AjouterPJ]
	@Nom varchar(50), 
	@Sexe bit,  
	@Id_Race int = null, 
	@Id_Classe int = null, 
	@Id_Signe int = null,
	@ValeurD4 int

AS
	insert into PJ output inserted.id values (@Nom, @Sexe, 0, 0, 0, @Id_Race, @Id_Classe, @Id_Signe) 
	DECLARE @Id_PJ int
	SET @Id_PJ = @@IDENTITY
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 15, 1)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 1, 50)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 2, 5)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 3, 10)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 4, 5)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 5, 1)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 6, 5)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 7, 0)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 8, 0)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 9, 0)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 10, 0)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 11, 0)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 12, 0)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 13, 0)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 16, @ValeurD4)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 17, @ValeurD4)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 18, 25)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 19, 25)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 20, 25)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 21, 25)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 22, 25)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 23, 25)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 24, 25)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 25, 25)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 26, 25)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 27, 25)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 28, 25)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 29, 25)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 30, 25)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 31, 25)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 32, 25)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 33, 25)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 34, 25)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 35, 25)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 36, 0)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 37, 100)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 38, 0)
RETURN 0
