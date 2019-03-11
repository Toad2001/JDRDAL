CREATE PROCEDURE [dbo].[AjouterEnchantement]
	@Nom Nvarchar(50),
	@Effet text,
	@Id_Prix int,
	@Id_Degats int
AS
	insert into Enchantement values (@Nom, @Effet)
	DECLARE @Id_Enchantement int
	SET @Id_Enchantement = @@IDENTITY
	Insert into [Enchantement-Stat](Id_Enchantement, Id_Stat, Valeur) values (@Id_Enchantement, 43, @Id_Prix)
	Insert into [Enchantement-Stat](Id_Enchantement, Id_Stat, Valeur) values (@Id_Enchantement, 42, @Id_Degats)


RETURN 0
