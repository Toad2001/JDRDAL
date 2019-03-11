CREATE PROCEDURE [dbo].[AjouterPJStat]
	@Id_PJ int,
	@Id_Sante int,
	@Id_Attaque int,
	@Id_Reflexe int,
	@Id_Degats int
AS
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 1, @Id_Sante)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 39, @Id_Attaque)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 41, @Id_Reflexe)
	Insert into [PJ-Stat](Id_PJ, Id_Stat, Valeur) values (@Id_PJ, 42, @Id_Degats)

RETURN 0
