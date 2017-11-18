CREATE TABLE [dbo].[Item]
(
	[Id] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [StashId] VARCHAR(50) NOT NULL FOREIGN KEY REFERENCES Stash(Id), 
    [Corrupted] VARCHAR(1) NOT NULL DEFAULT 'N', 
    [DescrText] VARCHAR(50) NULL, 
    [FrameType] FLOAT NULL, 
    [Height] INT NULL, 
    [Icon] VARCHAR(50) NULL, 
    [Identified] VARCHAR(1) NOT NULL DEFAULT 'Y', 
    [Ilvl] FLOAT NULL, 
    [InventoryId] VARCHAR(50) NULL, 
    [League] VARCHAR(50) NULL, 
    [LockedToCharacter] VARCHAR(1) NOT NULL DEFAULT 'N', 
    [Name] VARCHAR(50) NULL, 
    [Note] VARCHAR(50) NULL, 
    [SecDescrText] VARCHAR(50) NULL, 
    [Support] VARCHAR(1) NULL DEFAULT 'N', 
    [TypeLine] VARCHAR(50) NULL, 
    [Verified] VARCHAR(50) NULL, 
    [W] FLOAT NULL, 
    [X] FLOAT NULL, 
    [Y] FLOAT NULL
)
