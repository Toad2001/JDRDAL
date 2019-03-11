CREATE PROCEDURE [dbo].[AjouterArme]
	@Nom nvarchar(50), 
	@Malus int, 
	@DeuxMains bit, 
	@Id_TypeArme int
AS
	Insert into Arme (Nom, Malus, DeuxMains, Id_TypeArme) values (@Nom, @Malus, @DeuxMains, @Id_TypeArme)
RETURN 0
