CREATE TABLE [dbo].[PJ_User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Id_PJ] INT NOT NULL, 
    [Id_User] INT NOT NULL, 
    CONSTRAINT [FK_PJ_User_ToTable] FOREIGN KEY ([Id_PJ]) REFERENCES [PJ]([Id]), 
    CONSTRAINT [FK_User_PJ_ToTable] FOREIGN KEY ([Id_User]) REFERENCES [Utilisateur]([Id])
)
