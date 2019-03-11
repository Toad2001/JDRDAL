CREATE PROCEDURE [dbo].[ModifierPNJStat]
	@Id int,
	@Value int
AS
	update [PJ-Stat]
	set Valeur = @Value
	where Id = @Id

RETURN 0
