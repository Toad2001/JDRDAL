CREATE PROCEDURE [dbo].[ModifierMonstre]
	@Nom nvarchar(50),
	@Id_Ame int, 
	@Id_Rang int, 
	@Id_Resistence int, 
	@Id_Capacite int,
	@Id int
AS
	update Monstre
	set Nom = @Nom, Id_Ame = @Id_Ame, Id_Rang = @Id_Rang, Id_Resistence = @Id_Resistence, Id_Capacite = @Id_Capacite
	where Id = @Id
RETURN 0
