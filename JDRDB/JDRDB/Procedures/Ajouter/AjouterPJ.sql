CREATE PROCEDURE [dbo].[AjouterPJ]
	@Nom varchar(50), 
	@Sexe bit, 
	@Blesse bit = 0, 
	@Esquive bit = 0, 
	@CoupPuissant bit = 0, 
	@Id_Race int = null, 
	@Id_Classe int = null, 
	@Id_Signe int = null
AS
	insert into PJ values (@Nom, @Sexe, @Blesse, @Esquive, @CoupPuissant, @Id_Race, @Id_Classe, @Id_Signe)
RETURN 0
