CREATE PROCEDURE [dbo].[SupprimerObjetPJ]
	@Id_PJ int,
	@Id_Objet int
AS
	delete from [PJ-Objet] where Id_PJ = @Id_PJ and Id_Objet = @Id_Objet
RETURN 0
