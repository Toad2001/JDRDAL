CREATE PROCEDURE [dbo].[AjouterStyle]
	@Nom nvarchar(50),
	@Prix int
AS
	insert into Style values (@Nom, @Prix)
RETURN 0
