CREATE PROCEDURE [dbo].[AjouterObjet]
	@Nom nvarchar(50), 
	@Encombrement int, 
	@Prix int, 
	@Effet text = null
AS
	insert into Objet values (@Nom, @Encombrement, @Prix, @Effet)
RETURN 0
