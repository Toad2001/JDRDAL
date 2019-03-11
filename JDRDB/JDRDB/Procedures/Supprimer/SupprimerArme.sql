CREATE PROCEDURE [dbo].[SupprimerArme]
	@Id int
AS
	delete from Arme where Id = @Id
RETURN 0
