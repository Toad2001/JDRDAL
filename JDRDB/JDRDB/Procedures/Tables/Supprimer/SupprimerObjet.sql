CREATE PROCEDURE [dbo].[SupprimerObjet]
	@Id int
AS
	delete from Objet where Id = @Id
RETURN 0
