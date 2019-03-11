CREATE PROCEDURE [dbo].[AjouterObjetPJ]
	@Id_PJ int,
	@Id_Objet int
AS
	insert into [PJ-Objet] values (@Id_PJ, @Id_Objet);
RETURN 0
