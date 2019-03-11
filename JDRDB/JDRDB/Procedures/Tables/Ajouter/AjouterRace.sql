CREATE PROCEDURE [dbo].[AjouterRace]
	@Nom nvarchar(50), 
	@Id_Province int = null,
	@Id_Resistence int = null,
	@Id_Capacite1 int,
	@Id_Capacite2 int,
	@Force int, 
	@Intelligence int,
	@Volonte int,
	@Agilite int,
	@Rapidite int,
	@Endurence int,
	@Personnalite int,
	@Forgeage int,
	@ArmureLourde int,
	@Blocage int,
	@DeuxMains int,
	@UneMain int,
	@Distance int,
	@ArmureLégère int,
	@Furtivité int,
	@Crochetage int,
	@Vol int,
	@Eloquence int,
	@Alchimie int,
	@Illusion int,
	@Conjuration int,
	@Destruction int,
	@Guérison int,
	@Altération int,
	@Enchantement int,
	@Perception int

AS

	Insert into Race values (@Nom, @Id_Province, @Id_Resistence, @Id_Capacite1, @Id_Capacite2)
	DECLARE @Id_Race int
	SET @Id_Race = @@IDENTITY
	Insert into [Race-Stat](Id_Race, Id_Stat, Valeur) values (@Id_Race, 7, @Force)
	Insert into [Race-Stat](Id_Race, Id_Stat, Valeur) values (@Id_Race, 8, @Intelligence)
	Insert into [Race-Stat](Id_Race, Id_Stat, Valeur) values (@Id_Race, 9, @Volonte)
	Insert into [Race-Stat](Id_Race, Id_Stat, Valeur) values (@Id_Race, 10, @Agilite)
	Insert into [Race-Stat](Id_Race, Id_Stat, Valeur) values (@Id_Race, 11, @Rapidite)
	Insert into [Race-Stat](Id_Race, Id_Stat, Valeur) values (@Id_Race, 12, @Endurence)
	Insert into [Race-Stat](Id_Race, Id_Stat, Valeur) values (@Id_Race, 13, @Personnalite)
	Insert into [Race-Stat](Id_Race, Id_Stat, Valeur) values (@Id_Race, 18, @Forgeage)
	Insert into [Race-Stat](Id_Race, Id_Stat, Valeur) values (@Id_Race, 19, @ArmureLourde)
	Insert into [Race-Stat](Id_Race, Id_Stat, Valeur) values (@Id_Race, 20, @Blocage)
	Insert into [Race-Stat](Id_Race, Id_Stat, Valeur) values (@Id_Race, 21, @DeuxMains)
	Insert into [Race-Stat](Id_Race, Id_Stat, Valeur) values (@Id_Race, 22, @UneMain)
	Insert into [Race-Stat](Id_Race, Id_Stat, Valeur) values (@Id_Race, 23, @Distance)
	Insert into [Race-Stat](Id_Race, Id_Stat, Valeur) values (@Id_Race, 24, @ArmureLégère)
	Insert into [Race-Stat](Id_Race, Id_Stat, Valeur) values (@Id_Race, 25, @Furtivité)
	Insert into [Race-Stat](Id_Race, Id_Stat, Valeur) values (@Id_Race, 26, @Crochetage)
	Insert into [Race-Stat](Id_Race, Id_Stat, Valeur) values (@Id_Race, 27, @Vol)
	Insert into [Race-Stat](Id_Race, Id_Stat, Valeur) values (@Id_Race, 28, @Eloquence)
	Insert into [Race-Stat](Id_Race, Id_Stat, Valeur) values (@Id_Race, 29, @Alchimie)
	Insert into [Race-Stat](Id_Race, Id_Stat, Valeur) values (@Id_Race, 30, @Illusion)
	Insert into [Race-Stat](Id_Race, Id_Stat, Valeur) values (@Id_Race, 31, @Conjuration)
	Insert into [Race-Stat](Id_Race, Id_Stat, Valeur) values (@Id_Race, 32, @Destruction)
	Insert into [Race-Stat](Id_Race, Id_Stat, Valeur) values (@Id_Race, 33, @Guérison)
	Insert into [Race-Stat](Id_Race, Id_Stat, Valeur) values (@Id_Race, 34, @Altération)
	Insert into [Race-Stat](Id_Race, Id_Stat, Valeur) values (@Id_Race, 35, @Enchantement)
	Insert into [Race-Stat](Id_Race, Id_Stat, Valeur) values (@Id_Race, 14, @Perception)
RETURN 0
