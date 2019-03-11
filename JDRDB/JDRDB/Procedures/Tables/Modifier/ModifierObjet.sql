CREATE PROCEDURE [dbo].[ModifierObjet]
	@Nom nvarchar(50),
	@Encombrement int, 
	@Prix int, 
	@Effet text = null,
	@Id int
AS
	update Objet
	set Nom = @Nom, Encombrement = @Encombrement, Prix = @Prix, Effet = @Effet
	where Id = @Id
RETURN 0
