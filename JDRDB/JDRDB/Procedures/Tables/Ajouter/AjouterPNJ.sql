CREATE PROCEDURE [dbo].[AjouterPNJ]
	@Sexe bit, 
	@Id_Race int, 
	@Id_Rang int, 
	@Id_ClassePNJ int,
	@Id_Sante int,
	@Id_Attaque int,
	@Id_Reflexe int
AS
	insert into PNJ values (@Sexe, @Id_Race, 5, @Id_Rang, @Id_ClassePNJ)
	DECLARE @Id_PNJ int
	SET @Id_PNJ = @@IDENTITY
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 1, @Id_Sante)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 39, @Id_Attaque)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 41, @Id_Reflexe)
RETURN 0
