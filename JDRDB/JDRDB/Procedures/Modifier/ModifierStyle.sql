CREATE PROCEDURE [dbo].[ModifierStyle]
	@Nom nvarchar(50),
	@Prix int,
	@Id int
AS
	update Style
	set Nom = @Nom, Prix = @Prix
	where Id = @Id
RETURN 0
