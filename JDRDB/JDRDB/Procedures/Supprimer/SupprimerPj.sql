CREATE PROCEDURE [dbo].[SupprimerPJ]
	@Id int
AS
	delete from PJ where Id = @Id
RETURN 0
