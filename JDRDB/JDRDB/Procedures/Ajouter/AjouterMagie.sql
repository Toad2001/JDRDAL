CREATE PROCEDURE [dbo].[AjouterMagie]
	@Nom nvarchar(50), 
	@Effet text, 
	@Id_EcoleMagie int, 
	@Id_RangMagie int
AS
	insert into Magie values (@Nom, @Effet, @Id_EcoleMagie, @Id_RangMagie)
RETURN 0
