CREATE PROCEDURE [dbo].[AjouterClasse]
	@Nom nvarchar(50),
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
	@Enchantement int
AS
	insert into Classe (Nom) values (@Nom)
	DECLARE @Id_Classe int
	SET @Id_Classe = @@IDENTITY
	Insert into [Classe-Stat](Id_Classe, Id_Stat, Valeur) values (@Id_Classe, 7, @Force)
	Insert into [Classe-Stat](Id_Classe, Id_Stat, Valeur) values (@Id_Classe, 8, @Intelligence)
	Insert into [Classe-Stat](Id_Classe, Id_Stat, Valeur) values (@Id_Classe, 9, @Volonte)
	Insert into [Classe-Stat](Id_Classe, Id_Stat, Valeur) values (@Id_Classe, 10, @Agilite)
	Insert into [Classe-Stat](Id_Classe, Id_Stat, Valeur) values (@Id_Classe, 11, @Rapidite)
	Insert into [Classe-Stat](Id_Classe, Id_Stat, Valeur) values (@Id_Classe, 12, @Endurence)
	Insert into [Classe-Stat](Id_Classe, Id_Stat, Valeur) values (@Id_Classe, 13, @Personnalite)
	Insert into [Classe-Stat](Id_Classe, Id_Stat, Valeur) values (@Id_Classe, 18, @Forgeage)
	Insert into [Classe-Stat](Id_Classe, Id_Stat, Valeur) values (@Id_Classe, 19, @ArmureLourde)
	Insert into [Classe-Stat](Id_Classe, Id_Stat, Valeur) values (@Id_Classe, 20, @Blocage)
	Insert into [Classe-Stat](Id_Classe, Id_Stat, Valeur) values (@Id_Classe, 21, @DeuxMains)
	Insert into [Classe-Stat](Id_Classe, Id_Stat, Valeur) values (@Id_Classe, 22, @UneMain)
	Insert into [Classe-Stat](Id_Classe, Id_Stat, Valeur) values (@Id_Classe, 23, @Distance)
	Insert into [Classe-Stat](Id_Classe, Id_Stat, Valeur) values (@Id_Classe, 24, @ArmureLégère)
	Insert into [Classe-Stat](Id_Classe, Id_Stat, Valeur) values (@Id_Classe, 25, @Furtivité)
	Insert into [Classe-Stat](Id_Classe, Id_Stat, Valeur) values (@Id_Classe, 26, @Crochetage)
	Insert into [Classe-Stat](Id_Classe, Id_Stat, Valeur) values (@Id_Classe, 27, @Vol)
	Insert into [Classe-Stat](Id_Classe, Id_Stat, Valeur) values (@Id_Classe, 28, @Eloquence)
	Insert into [Classe-Stat](Id_Classe, Id_Stat, Valeur) values (@Id_Classe, 29, @Alchimie)
	Insert into [Classe-Stat](Id_Classe, Id_Stat, Valeur) values (@Id_Classe, 30, @Illusion)
	Insert into [Classe-Stat](Id_Classe, Id_Stat, Valeur) values (@Id_Classe, 31, @Conjuration)
	Insert into [Classe-Stat](Id_Classe, Id_Stat, Valeur) values (@Id_Classe, 32, @Destruction)
	Insert into [Classe-Stat](Id_Classe, Id_Stat, Valeur) values (@Id_Classe, 33, @Guérison)
	Insert into [Classe-Stat](Id_Classe, Id_Stat, Valeur) values (@Id_Classe, 34, @Altération)
	Insert into [Classe-Stat](Id_Classe, Id_Stat, Valeur) values (@Id_Classe, 35, @Enchantement)
RETURN 0
