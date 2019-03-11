CREATE PROCEDURE [dbo].[AjouterUtilisateur]
	@Nom nvarchar(50),
	@Prenom nvarchar(50),
	@Login nvarchar(50),
	@Password nvarchar(50),	 
	@Email nvarchar(50)	
AS
	INSERT INTO [Utilisateur] ([Nom]
           ,[Prenom]
           ,[Login]
           ,[Password]           
           ,[Email])	
		   output inserted.id
		   VALUES (@Nom,@Prenom,@Login,@Password,@Email)
	
RETURN 0
