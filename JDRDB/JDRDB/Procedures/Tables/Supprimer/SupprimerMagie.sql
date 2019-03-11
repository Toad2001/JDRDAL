CREATE PROCEDURE [dbo].[SupprimerMagie]
	@Id int
AS
	delete from Magie where Id = @Id
RETURN 0
