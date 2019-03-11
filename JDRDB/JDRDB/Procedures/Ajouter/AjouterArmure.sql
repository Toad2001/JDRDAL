CREATE PROCEDURE [dbo].[AjouterArmure]
	@Nom nvarchar(50)
AS
	Insert into Armure (Nom) values (@Nom)
RETURN 0
