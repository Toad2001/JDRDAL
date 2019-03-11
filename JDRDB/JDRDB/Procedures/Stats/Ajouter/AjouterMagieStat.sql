CREATE PROCEDURE [dbo].[AjouterMagieStat]
	@Id_Magie int,
	@Id_Prix int,
	@Id_Degats int

AS
	Insert into [Magie-Stat](Id_Magie, Id_Stat, Valeur) values (@Id_Magie, 43, @Id_Prix)
	Insert into [Magie-Stat](Id_Magie, Id_Stat, Valeur) values (@Id_Magie, 42, @Id_Degats)

RETURN 0
