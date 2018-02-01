
USE [C:\USERS\BERRE\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\OGEP - OUALA GESTION ECOLE PRIVÉE\OGEP\OGEP_DB.MDF]


GO
IF fulltextserviceproperty(N'IsFulltextInstalled') = 1
    EXECUTE sp_fulltext_database 'enable';


GO
PRINT N'Création de [dbo].[Groups]...';


GO
CREATE TABLE [dbo].[Groups] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [name]     VARCHAR (50) NOT NULL,
    [capacite] INT          NOT NULL,
    [moduleId] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Création de [dbo].[Matieres]...';


GO
CREATE TABLE [dbo].[Matieres] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Description] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Création de [dbo].[Modules]...';


GO
CREATE TABLE [dbo].[Modules] (
    [Id]      INT IDENTITY (1, 1) NOT NULL,
    [Matiere] INT NOT NULL,
    [ProfId]  INT NOT NULL,
    [year]    INT NOT NULL,
    [userId]  INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Création de [dbo].[Niveaux]...';


GO
CREATE TABLE [dbo].[Niveaux] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Description] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Création de [dbo].[ProfPayment]...';


GO
CREATE TABLE [dbo].[ProfPayment] (
    [Id]       INT  IDENTITY (1, 1) NOT NULL,
    [ProfId]   INT  NOT NULL,
    [Montant]  REAL NOT NULL,
    [Date]     DATE NOT NULL,
    [ModuleId] INT  NOT NULL,
    [userId]   INT  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Création de [dbo].[Profs]...';


GO
CREATE TABLE [dbo].[Profs] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (50)  NOT NULL,
    [FamilyName] NVARCHAR (50)  NOT NULL,
    [Adresse]    NVARCHAR (MAX) NULL,
    [Phone]      NUMERIC (18)   NOT NULL,
    [userId]     INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Création de [dbo].[Students]...';


GO
CREATE TABLE [dbo].[Students] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (50)  NOT NULL,
    [FamilyName] NVARCHAR (50)  NOT NULL,
    [Adresse]    NVARCHAR (MAX) NULL,
    [Phone]      NVARCHAR (50)  NOT NULL,
    [AlterPhone] NVARCHAR (50)  NULL,
    [Niveau]     INT            NOT NULL,
    [date]       DATE           NOT NULL,
    [userId]     INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Création de [dbo].[StudModule]...';


GO
CREATE TABLE [dbo].[StudModule] (
    [Id]        INT NOT NULL,
    [StudentId] INT NOT NULL,
    [ModuleId]  INT NOT NULL,
    [userId]    INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Création de [dbo].[StudPayment]...';


GO
CREATE TABLE [dbo].[StudPayment] (
    [Id]       INT  IDENTITY (1, 1) NOT NULL,
    [StudId]   INT  NOT NULL,
    [Montant]  REAL NOT NULL,
    [Date]     DATE NOT NULL,
    [ModuleId] INT  NOT NULL,
    [userId]   INT  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Création de [dbo].[Users]...';


GO
CREATE TABLE [dbo].[Users] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [username] NVARCHAR (50) NOT NULL,
    [password] NVARCHAR (50) NOT NULL,
    [type]     INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Création de [dbo].[UserTypes]...';


GO
CREATE TABLE [dbo].[UserTypes] (
    [Id]    INT           NOT NULL,
    [descr] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Création de [dbo].[FK_Groups_Modules]...';


GO
ALTER TABLE [dbo].[Groups]
    ADD CONSTRAINT [FK_Groups_Modules] FOREIGN KEY ([moduleId]) REFERENCES [dbo].[Modules] ([Id]);


GO
PRINT N'Création de [dbo].[FK_Modules_Matieres]...';


GO
ALTER TABLE [dbo].[Modules]
    ADD CONSTRAINT [FK_Modules_Matieres] FOREIGN KEY ([Matiere]) REFERENCES [dbo].[Matieres] ([Id]);


GO
PRINT N'Création de [dbo].[FK_Modules_Niveaux]...';


GO
ALTER TABLE [dbo].[Modules]
    ADD CONSTRAINT [FK_Modules_Niveaux] FOREIGN KEY ([year]) REFERENCES [dbo].[Niveaux] ([Id]);


GO
PRINT N'Création de [dbo].[FK_Modules_Profs]...';


GO
ALTER TABLE [dbo].[Modules]
    ADD CONSTRAINT [FK_Modules_Profs] FOREIGN KEY ([ProfId]) REFERENCES [dbo].[Profs] ([Id]);


GO
PRINT N'Création de [dbo].[FK_Modules_Users]...';


GO
ALTER TABLE [dbo].[Modules]
    ADD CONSTRAINT [FK_Modules_Users] FOREIGN KEY ([userId]) REFERENCES [dbo].[Users] ([Id]);


GO
PRINT N'Création de [dbo].[FK_ProfPayment_Modules]...';


GO
ALTER TABLE [dbo].[ProfPayment]
    ADD CONSTRAINT [FK_ProfPayment_Modules] FOREIGN KEY ([ModuleId]) REFERENCES [dbo].[Modules] ([Id]);


GO
PRINT N'Création de [dbo].[FK_ProfPayment_Profs]...';


GO
ALTER TABLE [dbo].[ProfPayment]
    ADD CONSTRAINT [FK_ProfPayment_Profs] FOREIGN KEY ([ProfId]) REFERENCES [dbo].[Profs] ([Id]);


GO
PRINT N'Création de [dbo].[FK_ProfPayment_Users]...';


GO
ALTER TABLE [dbo].[ProfPayment]
    ADD CONSTRAINT [FK_ProfPayment_Users] FOREIGN KEY ([userId]) REFERENCES [dbo].[Users] ([Id]);


GO
PRINT N'Création de [dbo].[FK_Profs_Users]...';


GO
ALTER TABLE [dbo].[Profs]
    ADD CONSTRAINT [FK_Profs_Users] FOREIGN KEY ([userId]) REFERENCES [dbo].[Users] ([Id]);


GO
PRINT N'Création de [dbo].[FK_Students_Niveau]...';


GO
ALTER TABLE [dbo].[Students]
    ADD CONSTRAINT [FK_Students_Niveau] FOREIGN KEY ([Niveau]) REFERENCES [dbo].[Niveaux] ([Id]);


GO
PRINT N'Création de [dbo].[FK_Students_Users]...';


GO
ALTER TABLE [dbo].[Students]
    ADD CONSTRAINT [FK_Students_Users] FOREIGN KEY ([userId]) REFERENCES [dbo].[Users] ([Id]);


GO
PRINT N'Création de [dbo].[FK_StudModule_Students]...';


GO
ALTER TABLE [dbo].[StudModule]
    ADD CONSTRAINT [FK_StudModule_Students] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Students] ([Id]);


GO
PRINT N'Création de [dbo].[FK_StudModule_ToModules]...';


GO
ALTER TABLE [dbo].[StudModule]
    ADD CONSTRAINT [FK_StudModule_ToModules] FOREIGN KEY ([ModuleId]) REFERENCES [dbo].[Modules] ([Id]);


GO
PRINT N'Création de [dbo].[FK_StudModule_Users]...';


GO
ALTER TABLE [dbo].[StudModule]
    ADD CONSTRAINT [FK_StudModule_Users] FOREIGN KEY ([userId]) REFERENCES [dbo].[Users] ([Id]);


GO
PRINT N'Création de [dbo].[FK_StudPayment_Modules]...';


GO
ALTER TABLE [dbo].[StudPayment]
    ADD CONSTRAINT [FK_StudPayment_Modules] FOREIGN KEY ([ModuleId]) REFERENCES [dbo].[Modules] ([Id]);


GO
PRINT N'Création de [dbo].[FK_StudPayment_Student]...';


GO
ALTER TABLE [dbo].[StudPayment]
    ADD CONSTRAINT [FK_StudPayment_Student] FOREIGN KEY ([StudId]) REFERENCES [dbo].[Students] ([Id]);


GO
PRINT N'Création de [dbo].[FK_StudPayment_Users]...';


GO
ALTER TABLE [dbo].[StudPayment]
    ADD CONSTRAINT [FK_StudPayment_Users] FOREIGN KEY ([userId]) REFERENCES [dbo].[Users] ([Id]);


GO
PRINT N'Création de [dbo].[FK_Users_UUserTypes]...';


GO
ALTER TABLE [dbo].[Users]
    ADD CONSTRAINT [FK_Users_UUserTypes] FOREIGN KEY ([type]) REFERENCES [dbo].[UserTypes] ([Id]);


GO
DECLARE @VarDecimalSupported AS BIT;

SELECT @VarDecimalSupported = 0;

IF ((ServerProperty(N'EngineEdition') = 3)
    AND (((@@microsoftversion / power(2, 24) = 9)
          AND (@@microsoftversion & 0xffff >= 3024))
         OR ((@@microsoftversion / power(2, 24) = 10)
             AND (@@microsoftversion & 0xffff >= 1600))))
    SELECT @VarDecimalSupported = 1;

IF (@VarDecimalSupported > 0)
    BEGIN
        EXECUTE sp_db_vardecimal_storage_format N'$(DatabaseName)', 'ON';
    END


GO
PRINT N'Mise à jour terminée.';


GO
