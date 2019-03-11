CREATE PROCEDURE [dbo].[SelectStat]
	@IdPJ int
	
AS
	SELECT PS.Id, S.Nom, PS.Valeur FROM [PJ-Stat] PS JOIN Stat S ON PS.Id_Stat = S.Id WHERE PS.Id_PJ = @IdPJ
RETURN 0
