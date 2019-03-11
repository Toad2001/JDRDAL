CREATE PROCEDURE [dbo].[ModifierPJ]
	@Nom varchar(50), 
	@Sexe bit, 
	@Blesse bit = 0, 
	@Esquive bit = 0, 
	@CoupPuissant bit = 0, 
	@Id_Race int = null, 
	@Id_Classe int = null, 
	@Id_Signe int = null,
	@Sante int,
	@Vigeur int,
	@Magie int,
	@RegenSante int,
	@RegenVigeur int,
	@RegenMagie int,
	@Force int, 
	@Intelligence int,
	@Volonte int,
	@Agilite int,
	@Rapidite int,
	@Endurence int,
	@Personnalite int,
	@Niveau int,
	@ValeurD4 int,
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
	@Septime int,
	@Encombrement int,
	@Vivres int,
	@Id int
AS
	update PJ
	set Nom = @Nom, Sexe = @Sexe, Blesse = @Blesse, Esquive = @Esquive, CoupPuissant = @CoupPuissant, Id_Race = @Id_Race, Id_Classe = @Id_Classe, Id_Signe = Id_Signe
	where Id = @Id

	update [PJ-Stat]
	set Valeur = @Sante
	where Id_PJ = @Id and Id_Stat = 1

	update [PJ-Stat]
	set Valeur = @Vigeur
	where Id_PJ = @Id and Id_Stat = 2

	update [PJ-Stat]
	set Valeur = @Magie
	where Id_PJ = @Id and Id_Stat = 3

	update [PJ-Stat]
	set Valeur = @RegenSante 
	where Id_PJ = @Id and Id_Stat = 4

	update [PJ-Stat]
	set Valeur = @RegenVigeur 
	where Id_PJ = @Id and Id_Stat = 5

	update [PJ-Stat]
	set Valeur = @RegenMagie 
	where Id_PJ = @Id and Id_Stat = 6

	update [PJ-Stat]
	set Valeur = @Force
	where Id_PJ = @Id and Id_Stat = 7

	update [PJ-Stat]
	set Valeur = @Intelligence  
	where Id_PJ = @Id and Id_Stat = 8

	update [PJ-Stat]
	set Valeur = @Volonte 
	where Id_PJ = @Id and Id_Stat = 9

	update [PJ-Stat]
	set Valeur = @Agilite 
	where Id_PJ = @Id and Id_Stat = 10

	update [PJ-Stat]
	set Valeur = @Rapidite 
	where Id_PJ = @Id and Id_Stat = 11

	update [PJ-Stat]
	set Valeur = @Endurence 
	where Id_PJ = @Id and Id_Stat = 12

	update [PJ-Stat]
	set Valeur = @Personnalite 
	where Id_PJ = @Id and Id_Stat = 13

	update [PJ-Stat]
	set Valeur = @Niveau 
	where Id_PJ = @Id and Id_Stat = 15

	update [PJ-Stat]
	set Valeur = @ValeurD4  
	where Id_PJ = @Id and Id_Stat = 16

	update [PJ-Stat]
	set Valeur = @ValeurD4 
	where Id_PJ = @Id and Id_Stat = 17

	update [PJ-Stat]
	set Valeur = @Forgeage 
	where Id_PJ = @Id and Id_Stat = 18

	update [PJ-Stat]
	set Valeur = @ArmureLourde 
	where Id_PJ = @Id and Id_Stat = 19

	update [PJ-Stat]
	set Valeur = @Blocage 
	where Id_PJ = @Id and Id_Stat = 20

	update [PJ-Stat]
	set Valeur = @DeuxMains 
	where Id_PJ = @Id and Id_Stat = 21

	update [PJ-Stat]
	set Valeur = @UneMain  
	where Id_PJ = @Id and Id_Stat = 22

	update [PJ-Stat]
	set Valeur = @Distance  
	where Id_PJ = @Id and Id_Stat = 23

	update [PJ-Stat]
	set Valeur = @ArmureLégère  
	where Id_PJ = @Id and Id_Stat = 24

	update [PJ-Stat]
	set Valeur = @Furtivité  
	where Id_PJ = @Id and Id_Stat = 25

	update [PJ-Stat]
	set Valeur = @Crochetage  
	where Id_PJ = @Id and Id_Stat = 26

	update [PJ-Stat]
	set Valeur = @Vol  
	where Id_PJ = @Id and Id_Stat = 27

	update [PJ-Stat]
	set Valeur = @Eloquence   
	where Id_PJ = @Id and Id_Stat = 28

	update [PJ-Stat]
	set Valeur = @Alchimie  
	where Id_PJ = @Id and Id_Stat = 29
	
	update [PJ-Stat]
	set Valeur = @Illusion  
	where Id_PJ = @Id and Id_Stat = 30
	
	update [PJ-Stat]
	set Valeur = @Conjuration  
	where Id_PJ = @Id and Id_Stat = 31
	
	update [PJ-Stat]
	set Valeur = @Destruction  
	where Id_PJ = @Id and Id_Stat = 32
	
	update [PJ-Stat]
	set Valeur = @Guérison   
	where Id_PJ = @Id and Id_Stat = 33
	
	update [PJ-Stat]
	set Valeur = @Altération   
	where Id_PJ = @Id and Id_Stat = 34
	
	update [PJ-Stat]
	set Valeur = @Enchantement   
	where Id_PJ = @Id and Id_Stat = 35
	
	update [PJ-Stat]
	set Valeur = @Septime   
	where Id_PJ = @Id and Id_Stat = 36
	
	update [PJ-Stat]
	set Valeur = @Encombrement   
	where Id_PJ = @Id and Id_Stat = 37
	
	update [PJ-Stat]
	set Valeur = @Vivres   
	where Id_PJ = @Id and Id_Stat = 38
RETURN 0
