CREATE PROCEDURE [dbo].[AjouterClasse]
	@Nom nvarchar(50)
AS
	insert into Classe values (@Nom)
RETURN 0
