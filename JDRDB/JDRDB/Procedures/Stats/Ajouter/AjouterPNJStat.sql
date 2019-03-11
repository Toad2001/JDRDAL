CREATE PROCEDURE [dbo].[AjouterPNJStat]
	@Id_PNJ int,
	--@Sante int,
	--@Vigeur int,
	--@Magie int,
	--@RegenSante int,
	--@RegenVigeur int,
	--@RegenMagie int,
	--@Force int, 
	--@Intelligence int,
	--@Volonte int,
	--@Agilite int,
	--@Rapidite int,
	--@Endurence int,
	--@Personnalite int,
	--@Niveau int,
	@ValeurD4 int --@PointsDestion
	--@PointsFortune int
	--@Forgeage int,
	--@ArmureLourde int,
	--@Blocage int,
	--@DeuxMains int,
	--@UneMain int,
	--@Distance int,
	--@ArmureLégère int,
	--@Furtivité int,
	--@Crochetage int,
	--@Vol int,
	--@Eloquence int,
	--@Alchimie int,
	--@Illusion int,
	--@Conjuration int,
	--@Destruction int,
	--@Guérison int,
	--@Altération int,
	--@Enchantement int,
	--@Septime int,
	--@Encombrement int,
	--@Vivres int
AS
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 1, 50)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 2, 5)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 3, 10)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 4, 5)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 5, 1)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 6, 5)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 7, 25)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 8, 25)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 9, 25)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 10, 5)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 11, 25)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 12, 25)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 13, 25)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 15, 1)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 16, @ValeurD4)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 17, @ValeurD4)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 18, 25)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 19, 25)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 20, 25)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 21, 25)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 22, 25)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 23, 25)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 24, 25)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 25, 25)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 26, 25)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 27, 25)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 28, 25)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 29, 25)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 30, 25)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 31, 25)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 32, 25)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 33, 25)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 34, 25)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 35, 25)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 36, 0)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 37, 100)
	Insert into [PNJ-Stat](Id_PNJ, Id_Stat, Valeur) values (@Id_PNJ, 38, 0)
RETURN 0															 
