CREATE PROCEDURE [dbo].[SupprimerEnchantement]
	@Id int
AS
	delete from Enchantement where Id = @Id
RETURN 0
