CREATE PROCEDURE [dbo].[SupprimerStyle]
	@Id int
AS
	delete from Style where Id = @Id
RETURN 0
