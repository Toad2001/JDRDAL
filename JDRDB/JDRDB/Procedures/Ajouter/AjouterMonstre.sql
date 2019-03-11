CREATE PROCEDURE [dbo].[AjouterMonstre]
	@Nom nvarchar(50),
	@Id_Ame int, 
	@Id_Rang int, 
	@Id_Resistence int, 
	@Id_Capacite int
AS
	insert into Monstre values (@Nom, @Id_Ame, @Id_Rang, @Id_Resistence, @Id_Capacite)
RETURN 0
