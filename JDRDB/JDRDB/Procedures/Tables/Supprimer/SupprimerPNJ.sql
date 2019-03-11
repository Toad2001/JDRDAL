CREATE PROCEDURE [dbo].[SupprimerPNJ]
	@Id int
AS
	delete from PNJ where Id = @Id
RETURN 0
