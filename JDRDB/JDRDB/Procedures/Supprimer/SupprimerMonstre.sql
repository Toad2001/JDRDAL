CREATE PROCEDURE [dbo].[SupprimerMonstre]
	@Id int
AS
	delete from Monstre where Id = @Id
RETURN 0
