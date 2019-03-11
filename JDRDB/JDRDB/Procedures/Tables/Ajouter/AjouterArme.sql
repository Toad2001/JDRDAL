CREATE PROCEDURE [dbo].[AjouterArme]
	@Nom nvarchar(50), 
	@Malus int, 
	@DeuxMains bit, 
	@Id_TypeArme int,
	@Encombrement int, 
	@Degat int,
	@Prix int

AS
	Insert into Arme (Nom, Malus, DeuxMains, Id_TypeArme) values (@Nom, @Malus, @DeuxMains, @Id_TypeArme)	
	DECLARE @Id_Arme int
	SET @Id_Arme = @@IDENTITY
	Insert into [Arme-Stat](Id_Arme, Id_Stat, Valeur) values (@Id_Arme, 37, @Encombrement)
	Insert into [Arme-Stat](Id_Arme, Id_Stat, Valeur) values (@Id_Arme, 42, @Degat)
	Insert into [Arme-Stat](Id_Arme, Id_Stat, Valeur) values (@Id_Arme, 43, @Prix)
RETURN 0