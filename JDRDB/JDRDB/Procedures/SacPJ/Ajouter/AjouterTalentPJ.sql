CREATE PROCEDURE [dbo].[AjouterTalentPJ]
	@Id_PJ int,
	@Id_Talent int
AS
	insert into [PJ-Talent] values (@Id_PJ, @Id_Talent);
RETURN 0
