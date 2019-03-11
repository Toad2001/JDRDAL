CREATE PROCEDURE [dbo].[ModifierEnchantement]
	@Nom nvarchar(50),
	@Effet text,
	@Id int
AS
	update Enchantement
	set Nom = @Nom, Effet = @Effet
	where Id = @Id
RETURN 0
