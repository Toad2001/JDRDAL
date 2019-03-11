CREATE PROCEDURE [dbo].[ModifierMagie]
	@Nom nvarchar(50), 
	@Effet text, 
	@Id_EcoleMagie int, 
	@Id_RangMagie int,
	@Id int
AS
	update Magie
	set Nom = @Nom, Effet = @Effet, Id_EcoleMagie = @Id_EcoleMagie, Id_RangMagie = @Id_RangMagie
	where Id = @Id
RETURN 0
