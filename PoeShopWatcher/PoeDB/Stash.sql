CREATE TABLE [dbo].[Stash]
(
	[Id] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [AccountName] VARCHAR(50) NULL, 
    [LastCharacterName] VARCHAR(50) NULL, 
    [Public] VARCHAR(1) NOT NULL DEFAULT 'N', 
    [StashName] VARCHAR(50) NULL, 
    [StashType] VARCHAR(50) NULL
)
