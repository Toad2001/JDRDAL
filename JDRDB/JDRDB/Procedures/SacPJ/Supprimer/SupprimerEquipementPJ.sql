CREATE PROCEDURE [dbo].[SupprimerEquipementPJ]
	@Id_PJ int,
	@Id_Equipement int
AS
	delete from [PJ-Equipement] where Id_PJ = @Id_PJ and Id_Equipement = @Id_Equipement
RETURN 0
