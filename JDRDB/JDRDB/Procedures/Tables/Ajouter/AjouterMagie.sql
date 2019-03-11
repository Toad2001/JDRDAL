CREATE PROCEDURE [dbo].[AjouterMagie]
	@Nom nvarchar(50), 
	@Effet text, 
	@Id_EcoleMagie int, 
	@Id_RangMagie int,
	@Degat int,
	@Prix int
AS
	insert into Magie values (@Nom, @Effet, @Id_EcoleMagie, @Id_RangMagie)
	DECLARE @Id_Magie int
	SET @Id_Magie = @@IDENTITY
	Insert into [Magie-Stat] values (@Id_Magie, 42, @Degat)
	Insert into [Magie-Stat] values (@Id_Magie, 43, @Prix)
RETURN 0
