CREATE TABLE [dbo].[Utilisateur]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Nom] NVARCHAR(50) NOT NULL, 
    [Prenom] NVARCHAR(50) NOT NULL, 
    [Login] NVARCHAR(50) UNIQUE NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) UNIQUE NOT NULL CHECK (Email LIKE '%___@___%'), 
    [Active] BIT NULL DEFAULT 1 
)
