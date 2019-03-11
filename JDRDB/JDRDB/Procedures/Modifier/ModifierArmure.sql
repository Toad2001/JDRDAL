CREATE PROCEDURE [dbo].[ModifierArmure]
	@Nom nvarchar(50),
	@Id int
AS
	update Armure
	set Nom = @Nom
	where Id = @Id
RETURN 0
