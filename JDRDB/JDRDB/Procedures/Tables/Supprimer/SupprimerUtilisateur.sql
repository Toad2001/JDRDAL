CREATE PROCEDURE [dbo].[SupprimerUtilisateur]
	@Id int
AS
	DELETE [Utilisateur] WHERE Id = @Id
RETURN 0
