CREATE PROCEDURE [dbo].[AjouterMonstreStat]
	@Id_Monstre int,
	@Id_Sante int,
	@Id_Attaque int,
	@Id_Defense int,
	@Id_Reflexe int,
	@Id_Degats int
AS
	Insert into [Monstre-Stat](Id_Monstre, Id_Stat, Valeur) values (@Id_Monstre, 1, @Id_Sante)
	Insert into [Monstre-Stat](Id_Monstre, Id_Stat, Valeur) values (@Id_Monstre, 39, @Id_Attaque)
	Insert into [Monstre-Stat](Id_Monstre, Id_Stat, Valeur) values (@Id_Monstre, 40, @Id_Defense)
	Insert into [Monstre-Stat](Id_Monstre, Id_Stat, Valeur) values (@Id_Monstre, 41, @Id_Reflexe)
	Insert into [Monstre-Stat](Id_Monstre, Id_Stat, Valeur) values (@Id_Monstre, 42, @Id_Degats)

RETURN 0
