CREATE PROCEDURE [dbo].[AjouterArmureStat]
	@Id_Armure int,
	@Encombrement int,
	@Protection int,
	@Prix int
AS
	Insert into [Armure-Stat](Id_Armure, Id_Stat, Valeur) values (@Id_Armure, 37, @Encombrement)
	Insert into [Armure-Stat](Id_Armure, Id_Stat, Valeur) values (@Id_Armure, 40, @Protection)
	Insert into [Armure-Stat](Id_Armure, Id_Stat, Valeur) values (@Id_Armure, 43, @Prix)

RETURN 0
