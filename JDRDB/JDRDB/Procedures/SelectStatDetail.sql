CREATE PROCEDURE [dbo].[SelectStatDetail]
	@Id int
	
AS
	SELECT PS.Id, S.Nom, PS.Valeur FROM [PJ-Stat] PS JOIN Stat S ON PS.Id_Stat = S.Id WHERE PS.Id = @Id
RETURN 0
