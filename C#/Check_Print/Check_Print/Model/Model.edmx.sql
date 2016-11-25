
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/26/2016 11:55:43
-- Generated from EDMX file: D:\PROG\Check_Print\Check_Print\Model\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CHECK_PRINT];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Account_Bank1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Account] DROP CONSTRAINT [FK_Account_Bank1];
GO
IF OBJECT_ID(N'[dbo].[FK_Check_DastehCheck]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Check] DROP CONSTRAINT [FK_Check_DastehCheck];
GO
IF OBJECT_ID(N'[dbo].[FK_Check_Status]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Check] DROP CONSTRAINT [FK_Check_Status];
GO
IF OBJECT_ID(N'[dbo].[FK_Check_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Check] DROP CONSTRAINT [FK_Check_User];
GO
IF OBJECT_ID(N'[dbo].[FK_DastehCheck_Account]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DastehCheck] DROP CONSTRAINT [FK_DastehCheck_Account];
GO
IF OBJECT_ID(N'[dbo].[FK_DastehCheck_PrintFormat]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DastehCheck] DROP CONSTRAINT [FK_DastehCheck_PrintFormat];
GO
IF OBJECT_ID(N'[dbo].[FK_PrintFormatDimention_PrintFormat]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PrintFormatDimention] DROP CONSTRAINT [FK_PrintFormatDimention_PrintFormat];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Account]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Account];
GO
IF OBJECT_ID(N'[dbo].[Bank]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bank];
GO
IF OBJECT_ID(N'[dbo].[Check]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Check];
GO
IF OBJECT_ID(N'[dbo].[CheckDoc]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CheckDoc];
GO
IF OBJECT_ID(N'[dbo].[DastehCheck]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DastehCheck];
GO
IF OBJECT_ID(N'[dbo].[PrintFormat]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PrintFormat];
GO
IF OBJECT_ID(N'[dbo].[PrintFormatDimention]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PrintFormatDimention];
GO
IF OBJECT_ID(N'[dbo].[Reciver]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Reciver];
GO
IF OBJECT_ID(N'[dbo].[Status]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Status];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Account'
CREATE TABLE [dbo].[Account] (
    [Hesab_Id] int IDENTITY(1,1) NOT NULL,
    [Bank_id] int  NULL,
    [Hesab_Name] nvarchar(50)  NULL,
    [Hesab_Number] nvarchar(50)  NULL,
    [Branch_Name] nvarchar(50)  NULL,
    [Branch_Tel] nvarchar(50)  NULL,
    [Branch_Adress] nvarchar(50)  NULL,
    [Meli_Code] nvarchar(50)  NULL
);
GO

-- Creating table 'Bank'
CREATE TABLE [dbo].[Bank] (
    [Bank_Id] int IDENTITY(1,1) NOT NULL,
    [Bank_Name] nvarchar(50)  NULL
);
GO

-- Creating table 'Check'
CREATE TABLE [dbo].[Check] (
    [Check_Id] int IDENTITY(1,1) NOT NULL,
    [DC_Id] int  NULL,
    [Status_Id] int  NULL,
    [Serial] int  NULL,
    [SDate] nvarchar(50)  NULL,
    [RDate] nvarchar(50)  NULL,
    [Darvajh] nvarchar(500)  NULL,
    [Mablagh] nvarchar(50)  NULL,
    [User_id] int  NULL
);
GO

-- Creating table 'CheckDoc'
CREATE TABLE [dbo].[CheckDoc] (
    [Shc_Id] int IDENTITY(1,1) NOT NULL,
    [Shc_Doc] nvarchar(500)  NULL
);
GO

-- Creating table 'DastehCheck'
CREATE TABLE [dbo].[DastehCheck] (
    [DC_Id] int IDENTITY(1,1) NOT NULL,
    [DC_Name] nvarchar(50)  NULL,
    [DC_GSerial] nvarchar(50)  NULL,
    [DC_Hesab_Id] int  NULL,
    [DC_Start] int  NULL,
    [DC_End] int  NULL,
    [Print_Formate_Id] int  NULL
);
GO

-- Creating table 'PrintFormat'
CREATE TABLE [dbo].[PrintFormat] (
    [PF_Id] int IDENTITY(1,1) NOT NULL,
    [PF_Name] nvarchar(50)  NULL,
    [Pf_Pic] varbinary(max)  NULL
);
GO

-- Creating table 'Reciver'
CREATE TABLE [dbo].[Reciver] (
    [Riciver_Id] int IDENTITY(1,1) NOT NULL,
    [Reciver_Name] nvarchar(50)  NULL
);
GO

-- Creating table 'Status'
CREATE TABLE [dbo].[Status] (
    [Stat_Id] int IDENTITY(1,1) NOT NULL,
    [Stat_Name] nvarchar(50)  NULL
);
GO

-- Creating table 'User'
CREATE TABLE [dbo].[User] (
    [User_Id] int IDENTITY(1,1) NOT NULL,
    [User_name] nvarchar(50)  NULL,
    [Password] nvarchar(50)  NULL,
    [Name_Family] nvarchar(100)  NULL
);
GO

-- Creating table 'PrintFormatDimention'
CREATE TABLE [dbo].[PrintFormatDimention] (
    [Pfd_id] int IDENTITY(1,1) NOT NULL,
    [Pfd_PF_id] int  NULL,
    [Pfd_Row] int  NULL,
    [Pfd_x] int  NULL,
    [Pfd_y] int  NULL,
    [Pfd_Valid] bit  NULL,
    [Pfd_Font] nvarchar(50)  NULL,
    [Pfd_Size] int  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Hesab_Id] in table 'Account'
ALTER TABLE [dbo].[Account]
ADD CONSTRAINT [PK_Account]
    PRIMARY KEY CLUSTERED ([Hesab_Id] ASC);
GO

-- Creating primary key on [Bank_Id] in table 'Bank'
ALTER TABLE [dbo].[Bank]
ADD CONSTRAINT [PK_Bank]
    PRIMARY KEY CLUSTERED ([Bank_Id] ASC);
GO

-- Creating primary key on [Check_Id] in table 'Check'
ALTER TABLE [dbo].[Check]
ADD CONSTRAINT [PK_Check]
    PRIMARY KEY CLUSTERED ([Check_Id] ASC);
GO

-- Creating primary key on [Shc_Id] in table 'CheckDoc'
ALTER TABLE [dbo].[CheckDoc]
ADD CONSTRAINT [PK_CheckDoc]
    PRIMARY KEY CLUSTERED ([Shc_Id] ASC);
GO

-- Creating primary key on [DC_Id] in table 'DastehCheck'
ALTER TABLE [dbo].[DastehCheck]
ADD CONSTRAINT [PK_DastehCheck]
    PRIMARY KEY CLUSTERED ([DC_Id] ASC);
GO

-- Creating primary key on [PF_Id] in table 'PrintFormat'
ALTER TABLE [dbo].[PrintFormat]
ADD CONSTRAINT [PK_PrintFormat]
    PRIMARY KEY CLUSTERED ([PF_Id] ASC);
GO

-- Creating primary key on [Riciver_Id] in table 'Reciver'
ALTER TABLE [dbo].[Reciver]
ADD CONSTRAINT [PK_Reciver]
    PRIMARY KEY CLUSTERED ([Riciver_Id] ASC);
GO

-- Creating primary key on [Stat_Id] in table 'Status'
ALTER TABLE [dbo].[Status]
ADD CONSTRAINT [PK_Status]
    PRIMARY KEY CLUSTERED ([Stat_Id] ASC);
GO

-- Creating primary key on [User_Id] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [PK_User]
    PRIMARY KEY CLUSTERED ([User_Id] ASC);
GO

-- Creating primary key on [Pfd_id] in table 'PrintFormatDimention'
ALTER TABLE [dbo].[PrintFormatDimention]
ADD CONSTRAINT [PK_PrintFormatDimention]
    PRIMARY KEY CLUSTERED ([Pfd_id] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Bank_id] in table 'Account'
ALTER TABLE [dbo].[Account]
ADD CONSTRAINT [FK_Account_Bank1]
    FOREIGN KEY ([Bank_id])
    REFERENCES [dbo].[Bank]
        ([Bank_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Account_Bank1'
CREATE INDEX [IX_FK_Account_Bank1]
ON [dbo].[Account]
    ([Bank_id]);
GO

-- Creating foreign key on [DC_Hesab_Id] in table 'DastehCheck'
ALTER TABLE [dbo].[DastehCheck]
ADD CONSTRAINT [FK_DastehCheck_Account]
    FOREIGN KEY ([DC_Hesab_Id])
    REFERENCES [dbo].[Account]
        ([Hesab_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DastehCheck_Account'
CREATE INDEX [IX_FK_DastehCheck_Account]
ON [dbo].[DastehCheck]
    ([DC_Hesab_Id]);
GO

-- Creating foreign key on [DC_Id] in table 'Check'
ALTER TABLE [dbo].[Check]
ADD CONSTRAINT [FK_Check_DastehCheck]
    FOREIGN KEY ([DC_Id])
    REFERENCES [dbo].[DastehCheck]
        ([DC_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Check_DastehCheck'
CREATE INDEX [IX_FK_Check_DastehCheck]
ON [dbo].[Check]
    ([DC_Id]);
GO

-- Creating foreign key on [Status_Id] in table 'Check'
ALTER TABLE [dbo].[Check]
ADD CONSTRAINT [FK_Check_Status]
    FOREIGN KEY ([Status_Id])
    REFERENCES [dbo].[Status]
        ([Stat_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Check_Status'
CREATE INDEX [IX_FK_Check_Status]
ON [dbo].[Check]
    ([Status_Id]);
GO

-- Creating foreign key on [User_id] in table 'Check'
ALTER TABLE [dbo].[Check]
ADD CONSTRAINT [FK_Check_User]
    FOREIGN KEY ([User_id])
    REFERENCES [dbo].[User]
        ([User_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Check_User'
CREATE INDEX [IX_FK_Check_User]
ON [dbo].[Check]
    ([User_id]);
GO

-- Creating foreign key on [Print_Formate_Id] in table 'DastehCheck'
ALTER TABLE [dbo].[DastehCheck]
ADD CONSTRAINT [FK_DastehCheck_PrintFormat]
    FOREIGN KEY ([Print_Formate_Id])
    REFERENCES [dbo].[PrintFormat]
        ([PF_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DastehCheck_PrintFormat'
CREATE INDEX [IX_FK_DastehCheck_PrintFormat]
ON [dbo].[DastehCheck]
    ([Print_Formate_Id]);
GO

-- Creating foreign key on [Pfd_id] in table 'PrintFormatDimention'
ALTER TABLE [dbo].[PrintFormatDimention]
ADD CONSTRAINT [FK_PrintFormatDimention_PrintFormat]
    FOREIGN KEY ([Pfd_id])
    REFERENCES [dbo].[PrintFormat]
        ([PF_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------