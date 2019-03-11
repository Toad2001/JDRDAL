CREATE PROCEDURE [dbo].[ModifierClasse]
	@Nom nvarchar(50),
	@Id int
AS
	update Classe
	set Nom = @Nom
	where Id = @Id
RETURN 0
