CREATE PROCEDURE [dbo].[SupprimerEquipement]
	@Id int
AS
	delete from Equipement where Id = @Id
RETURN 0
