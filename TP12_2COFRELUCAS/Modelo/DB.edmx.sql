
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/19/2021 11:02:51
-- Generated from EDMX file: C:\Users\Don Cofre\source\repos\TP12_2COFRELUCAS\TP12_2COFRELUCAS\Modelo\DB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TPEntity];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Pedidos'
CREATE TABLE [dbo].[Pedidos] (
    [NModelo] nvarchar(max)  NOT NULL,
    [NConcesionaria] nvarchar(max)  NOT NULL,
    [CantPedida] int  NOT NULL
);
GO

-- Creating table 'Stock'
CREATE TABLE [dbo].[Stock] (
    [NroModelo] nvarchar(max)  NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [stock] int  NOT NULL
);
GO

-- Creating table 'StockPiezas'
CREATE TABLE [dbo].[StockPiezas] (
    [NroPieza] nvarchar(max)  NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Stock] int  NOT NULL
);
GO

-- Creating table 'Composicion'
CREATE TABLE [dbo].[Composicion] (
    [NModelo] nvarchar(max)  NOT NULL,
    [NPieza] nvarchar(max)  NOT NULL,
    [CantUsar] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [NModelo] in table 'Pedidos'
ALTER TABLE [dbo].[Pedidos]
ADD CONSTRAINT [PK_Pedidos]
    PRIMARY KEY CLUSTERED ([NModelo] ASC);
GO

-- Creating primary key on [NroModelo] in table 'Stock'
ALTER TABLE [dbo].[Stock]
ADD CONSTRAINT [PK_Stock]
    PRIMARY KEY CLUSTERED ([NroModelo] ASC);
GO

-- Creating primary key on [NroPieza] in table 'StockPiezas'
ALTER TABLE [dbo].[StockPiezas]
ADD CONSTRAINT [PK_StockPiezas]
    PRIMARY KEY CLUSTERED ([NroPieza] ASC);
GO

-- Creating primary key on [NModelo] in table 'Composicion'
ALTER TABLE [dbo].[Composicion]
ADD CONSTRAINT [PK_Composicion]
    PRIMARY KEY CLUSTERED ([NModelo] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------