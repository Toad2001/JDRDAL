CREATE PROCEDURE [dbo].[SupprimerClasse]
	@Id int
AS
	delete from Classe where Id = @Id
RETURN 0
