
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 01/17/2014 13:24:44
-- Generated from EDMX file: C:\Users\stepanov.vasiliy\Documents\Dx\CodeCentral\E5059\E5059\Models\NWindModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [NWind];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[NWindModelStoreContainer].[Categories]', 'U') IS NOT NULL
    DROP TABLE [NWindModelStoreContainer].[Categories];
GO
IF OBJECT_ID(N'[NWindModelStoreContainer].[Products]', 'U') IS NOT NULL
    DROP TABLE [NWindModelStoreContainer].[Products];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [CategoryID] int  NOT NULL,
    [CategoryName] nvarchar(15)  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [Picture] varbinary(max)  NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [ProductID] int  NOT NULL,
    [ProductName] nvarchar(40)  NOT NULL,
    [SupplierID] int  NULL,
    [CategoryID] int  NULL,
    [QuantityPerUnit] nvarchar(20)  NULL,
    [UnitPrice] decimal(10,4)  NULL,
    [UnitsInStock] smallint  NULL,
    [UnitsOnOrder] smallint  NULL,
    [ReorderLevel] smallint  NULL,
    [Discontinued] bit  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CategoryID] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([CategoryID] ASC);
GO

-- Creating primary key on [ProductID] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([ProductID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CategoryID] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_CategoryProduct]
    FOREIGN KEY ([CategoryID])
    REFERENCES [dbo].[Categories]
        ([CategoryID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoryProduct'
CREATE INDEX [IX_FK_CategoryProduct]
ON [dbo].[Products]
    ([CategoryID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------