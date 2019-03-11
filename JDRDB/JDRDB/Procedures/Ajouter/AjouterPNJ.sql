CREATE PROCEDURE [dbo].[AjouterPNJ]
	@Sexe bit, 
	@Id_Race int = null, 
	@Id_Ame int = 5, 
	@Id_Rang int, 
	@Id_ClassePNJ int
AS
	insert into PNJ values (@Sexe, @Id_Race, @Id_Ame, @Id_Rang, @Id_ClassePNJ)
RETURN 0
