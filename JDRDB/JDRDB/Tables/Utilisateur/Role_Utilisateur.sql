CREATE TABLE [dbo].[Role_Utilisateur]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Id_Utilisateur] INT NOT NULL, 
    [Id_Role] INT NOT NULL, 
    CONSTRAINT [FK_Role_Utilisateur] FOREIGN KEY ([Id_Role]) REFERENCES [Roles]([Id]), 
    CONSTRAINT [FK_Utilisateur_Role] FOREIGN KEY ([Id_Utilisateur]) REFERENCES [Utilisateur]([Id])
)
