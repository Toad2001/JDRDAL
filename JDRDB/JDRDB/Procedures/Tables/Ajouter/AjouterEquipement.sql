CREATE PROCEDURE [dbo].[AjouterEquipement]
	@Id_Arme int = null, 
	@Id_Armure int = null, 
	@Id_Matiere int, 
	@Id_Style int, 
	@Id_Enchantement int = null
AS
	insert into Equipement values (@Id_Arme, @Id_Armure, @Id_Matiere, @Id_Style, @Id_Enchantement)
RETURN 0
