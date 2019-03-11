CREATE PROCEDURE [dbo].[AjouterMonstre]
	@Nom nvarchar(50),
	@Id_Ame int, 
	@Id_Rang int, 
	@Id_Resistence int, 
	@Id_Capacite int,
	@Id_Sante int,
	@Id_Attaque int,
	@Id_Defense int,
	@Id_Reflexe int,
	@Id_Degats int
AS
	insert into Monstre values (@Nom, @Id_Ame, @Id_Rang, @Id_Resistence, @Id_Capacite)
	DECLARE @Id_Monstre int
	SET @Id_Monstre = @@IDENTITY
	Insert into [Monstre-Stat](Id_Monstre, Id_Stat, Valeur) values (@Id_Monstre, 1, @Id_Sante)
	Insert into [Monstre-Stat](Id_Monstre, Id_Stat, Valeur) values (@Id_Monstre, 39, @Id_Attaque)
	Insert into [Monstre-Stat](Id_Monstre, Id_Stat, Valeur) values (@Id_Monstre, 40, @Id_Defense)
	Insert into [Monstre-Stat](Id_Monstre, Id_Stat, Valeur) values (@Id_Monstre, 41, @Id_Reflexe)
	Insert into [Monstre-Stat](Id_Monstre, Id_Stat, Valeur) values (@Id_Monstre, 42, @Id_Degats)


RETURN 0
