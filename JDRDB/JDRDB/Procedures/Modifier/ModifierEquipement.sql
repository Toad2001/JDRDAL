CREATE PROCEDURE [dbo].[ModifierEquipement]
	@Id_Arme int = null, 
	@Id_Armure int = null, 
	@Id_Matiere int, 
	@Id_Style int, 
	@Id_Enchantement int = null,
	@Id int
AS
	Update Equipement
	set Id_Arme = @Id_Arme, Id_Armure = @Id_Armure, Id_Matiere = @Id_Matiere, Id_Style = @Id_Style, Id_Enchantement = @Id_Enchantement
	where Id = @Id
RETURN 0
