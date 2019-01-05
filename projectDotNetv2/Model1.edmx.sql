
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/05/2019 12:39:44
-- Generated from EDMX file: C:\Users\Acer-PC\source\repos\projectDotNetv2\projectDotNetv2\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Database1];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_data_tableBookMeeting]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BookMeetings] DROP CONSTRAINT [FK_data_tableBookMeeting];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[data_table]', 'U') IS NOT NULL
    DROP TABLE [dbo].[data_table];
GO
IF OBJECT_ID(N'[dbo].[LoginTables]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LoginTables];
GO
IF OBJECT_ID(N'[dbo].[BookMeetings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BookMeetings];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'data_table'
CREATE TABLE [dbo].[data_table] (
    [lecturer] varchar(50)  NULL,
    [Lct_ID] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'LoginTables'
CREATE TABLE [dbo].[LoginTables] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [username] varchar(50)  NULL,
    [password] varchar(50)  NULL
);
GO

-- Creating table 'BookMeetings'
CREATE TABLE [dbo].[BookMeetings] (
    [Book_ID] int IDENTITY(1,1) NOT NULL,
    [LecturerName] varchar(50)  NOT NULL,
    [DateTime] datetime  NOT NULL,
    [Description] varchar(max)  NOT NULL,
    [data_tableLct_ID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Lct_ID] in table 'data_table'
ALTER TABLE [dbo].[data_table]
ADD CONSTRAINT [PK_data_table]
    PRIMARY KEY CLUSTERED ([Lct_ID] ASC);
GO

-- Creating primary key on [Id] in table 'LoginTables'
ALTER TABLE [dbo].[LoginTables]
ADD CONSTRAINT [PK_LoginTables]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Book_ID] in table 'BookMeetings'
ALTER TABLE [dbo].[BookMeetings]
ADD CONSTRAINT [PK_BookMeetings]
    PRIMARY KEY CLUSTERED ([Book_ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------