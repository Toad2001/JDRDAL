CREATE PROCEDURE [dbo].[AjouterArmeStat]
	@Id_Arme int,
	@Encombrement int,
	@Degat int,
	@Prix int
AS
	Insert into [Arme-Stat](Id_Arme, Id_Stat, Valeur) values (@Id_Arme, 37, @Encombrement)
	Insert into [Arme-Stat](Id_Arme, Id_Stat, Valeur) values (@Id_Arme, 42, @Degat)
	Insert into [Arme-Stat](Id_Arme, Id_Stat, Valeur) values (@Id_Arme, 43, @Prix)
RETURN 0