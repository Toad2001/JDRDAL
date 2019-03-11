CREATE PROCEDURE [dbo].[ModifierPNJ]
	@Sexe bit, 
	@Id_Race int = null, 
	@Id_Ame int = 5, 
	@Id_Rang int, 
	@Id_ClassePNJ int,
	@Id int
AS
	update PNJ
	set Sexe = @Sexe, Id_Race = @Id_Race, Id_Ame = @Id_Ame, Id_Rang = @Id_Rang, Id_ClassePNJ = @Id_ClassePNJ
	where Id = @Id
RETURN 0
