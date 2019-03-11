CREATE PROCEDURE [dbo].[AjouterMagiePJ]
	@Id_PJ int,
	@Id_Magie int
AS
	insert into [PJ-Magie] values (@Id_PJ, @Id_Magie);
RETURN 0
