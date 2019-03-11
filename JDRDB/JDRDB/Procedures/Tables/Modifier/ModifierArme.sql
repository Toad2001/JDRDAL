CREATE PROCEDURE [dbo].[ModifierArme]
	@Nom nvarchar(50), 
	@Malus int, 
	@DeuxMains bit, 
	@Id_TypeArme int,
	@Id int
AS
	update Arme
	set Nom = @Nom, Malus = @Malus, DeuxMains = @DeuxMains, Id_TypeArme = @Id_TypeArme
	where Id = @Id
RETURN 0
