CREATE PROCEDURE [dbo].[AjouterEnchantementStat]
	@Id_Enchantement int,
	@Id_Prix int,
	@Id_Degats int

AS
	Insert into [Enchantement-Stat](Id_Enchantement, Id_Stat, Valeur) values (@Id_Enchantement, 43, @Id_Prix)
	Insert into [Enchantement-Stat](Id_Enchantement, Id_Stat, Valeur) values (@Id_Enchantement, 42, @Id_Degats)

RETURN 0
