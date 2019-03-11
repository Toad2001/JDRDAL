CREATE PROCEDURE [dbo].[ModifierUtilisateur]
	@Nom nvarchar(50),
	@Prenom nvarchar(50),
	@Login nvarchar(50),
	@Password nvarchar(50),	 
	@Email nvarchar(50),	
	@Id int
AS
	UPDATE [Utilisateur] SET Nom = @Nom, Prenom = @Prenom , [Login] = @Login , [Password] = @Password , Email = @Email
 	WHERE Id = @Id 
RETURN 0
