CREATE PROCEDURE [dbo].[AjouterMatiere]
	@Nom nvarchar(50),
	@Arme bit,
	@ArmureLourde bit,
	@ArmeLegere bit,
	@Id_Prix int,
	@Id_Degats int,
	@Id_Encombrement int

AS
	Insert into Matiere values (@Nom, @Arme, @ArmeLegere, @ArmureLourde)
	DECLARE @Id_Matiere int
	SET @Id_Matiere = @@IDENTITY
	Insert into [Matiere-Stat](Id_Matiere, Id_Stat, Valeur) values (@Id_Matiere, 43, @Id_Prix)
	Insert into [Matiere-Stat](Id_Matiere, Id_Stat, Valeur) values (@Id_Matiere, 42, @Id_Degats)
	Insert into [Matiere-Stat](Id_Matiere, Id_Stat, Valeur) values (@Id_Matiere, 37, @Id_Encombrement)
RETURN 0
