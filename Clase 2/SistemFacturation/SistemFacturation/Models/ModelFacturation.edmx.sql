
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/30/2017 10:34:27
-- Generated from EDMX file: C:\Curso .NET\Clase 2\SistemFacturation\SistemFacturation\Models\ModelFacturation.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SistemFacturation];
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

-- Creating table 'Facturas'
CREATE TABLE [dbo].[Facturas] (
    [id] int IDENTITY(1,1) NOT NULL,
    [fecha] nvarchar(max)  NOT NULL,
    [Cliente_Id] int  NOT NULL
);
GO

-- Creating table 'Productos'
CREATE TABLE [dbo].[Productos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Precio] nvarchar(max)  NOT NULL,
    [stock] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Clientes'
CREATE TABLE [dbo].[Clientes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nombre] nvarchar(max)  NOT NULL,
    [apellido] nvarchar(max)  NOT NULL,
    [edad] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Detalles'
CREATE TABLE [dbo].[Detalles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [cantidad] nvarchar(max)  NOT NULL,
    [precio] nvarchar(max)  NOT NULL,
    [Factura_id] int  NOT NULL,
    [Producto_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'Facturas'
ALTER TABLE [dbo].[Facturas]
ADD CONSTRAINT [PK_Facturas]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Id] in table 'Productos'
ALTER TABLE [dbo].[Productos]
ADD CONSTRAINT [PK_Productos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [PK_Clientes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Detalles'
ALTER TABLE [dbo].[Detalles]
ADD CONSTRAINT [PK_Detalles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Cliente_Id] in table 'Facturas'
ALTER TABLE [dbo].[Facturas]
ADD CONSTRAINT [FK_ClienteFactura]
    FOREIGN KEY ([Cliente_Id])
    REFERENCES [dbo].[Clientes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteFactura'
CREATE INDEX [IX_FK_ClienteFactura]
ON [dbo].[Facturas]
    ([Cliente_Id]);
GO

-- Creating foreign key on [Factura_id] in table 'Detalles'
ALTER TABLE [dbo].[Detalles]
ADD CONSTRAINT [FK_FacturaDetalle]
    FOREIGN KEY ([Factura_id])
    REFERENCES [dbo].[Facturas]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FacturaDetalle'
CREATE INDEX [IX_FK_FacturaDetalle]
ON [dbo].[Detalles]
    ([Factura_id]);
GO

-- Creating foreign key on [Producto_Id] in table 'Detalles'
ALTER TABLE [dbo].[Detalles]
ADD CONSTRAINT [FK_ProductoDetalle]
    FOREIGN KEY ([Producto_Id])
    REFERENCES [dbo].[Productos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductoDetalle'
CREATE INDEX [IX_FK_ProductoDetalle]
ON [dbo].[Detalles]
    ([Producto_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------