CREATE PROCEDURE [dbo].[AjouterEquipementPJ]
	@Id_PJ int,
	@Id_Equipement int
AS
	insert into [PJ-Equipement] values (@Id_PJ, @Id_Equipement);
RETURN 0