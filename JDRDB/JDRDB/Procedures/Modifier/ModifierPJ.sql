CREATE PROCEDURE [dbo].[ModifierPJ]
	@Nom varchar(50), 
	@Sexe bit, 
	@Blesse bit = 0, 
	@Esquive bit = 0, 
	@CoupPuissant bit = 0, 
	@Id_Race int = null, 
	@Id_Classe int = null, 
	@Id_Signe int = null,
	@Id int
AS
	update PJ
	set Nom = @Nom, Sexe = @Sexe, Blesse = @Blesse, Esquive = @Esquive, CoupPuissant = @CoupPuissant, Id_Race = @Id_Race, Id_Classe = @Id_Classe, Id_Signe = Id_Signe
	where Id = @Id
RETURN 0
