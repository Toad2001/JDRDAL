CREATE PROCEDURE [dbo].[SupprimerPJ]
	@Id int
AS
	delete from [PJ-Stat] where Id_PJ = @Id
	delete from PJ where Id = @Id
RETURN 0
