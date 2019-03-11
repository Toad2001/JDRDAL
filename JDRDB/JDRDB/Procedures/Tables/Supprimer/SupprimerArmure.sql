CREATE PROCEDURE [dbo].[SupprimerArmure]
	@Id int
AS
	delete from Armure where Id = @Id
RETURN 0
