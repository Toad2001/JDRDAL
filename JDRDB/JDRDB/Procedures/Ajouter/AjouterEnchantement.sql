CREATE PROCEDURE [dbo].[AjouterEnchantement]
	@Nom Nvarchar(50),
	@Effet text
AS
	insert into Enchantement values (@Nom, @Effet)

RETURN 0
