
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/25/2017 11:06:22
-- Generated from EDMX file: C:\Curso .NET\Clase 2\EntityFrameworkConsole\EntityFrameworkConsole\ModelSistemaGestionCliente.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EntityFramework];
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

-- Creating table 'Personas'
CREATE TABLE [dbo].[Personas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Direcciones'
CREATE TABLE [dbo].[Direcciones] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Calle] nvarchar(max)  NOT NULL,
    [Persona_Id] int  NOT NULL
);
GO

-- Creating table 'Telefonos'
CREATE TABLE [dbo].[Telefonos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Numero] nvarchar(max)  NOT NULL,
    [Persona_Id] int  NOT NULL
);
GO

-- Creating table 'Localidades'
CREATE TABLE [dbo].[Localidades] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PersonaLocalidad'
CREATE TABLE [dbo].[PersonaLocalidad] (
    [Personas_Id] int  NOT NULL,
    [Localidades_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Personas'
ALTER TABLE [dbo].[Personas]
ADD CONSTRAINT [PK_Personas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Direcciones'
ALTER TABLE [dbo].[Direcciones]
ADD CONSTRAINT [PK_Direcciones]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Telefonos'
ALTER TABLE [dbo].[Telefonos]
ADD CONSTRAINT [PK_Telefonos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Localidades'
ALTER TABLE [dbo].[Localidades]
ADD CONSTRAINT [PK_Localidades]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Personas_Id], [Localidades_Id] in table 'PersonaLocalidad'
ALTER TABLE [dbo].[PersonaLocalidad]
ADD CONSTRAINT [PK_PersonaLocalidad]
    PRIMARY KEY CLUSTERED ([Personas_Id], [Localidades_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Persona_Id] in table 'Direcciones'
ALTER TABLE [dbo].[Direcciones]
ADD CONSTRAINT [FK_PersonaDireccion]
    FOREIGN KEY ([Persona_Id])
    REFERENCES [dbo].[Personas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonaDireccion'
CREATE INDEX [IX_FK_PersonaDireccion]
ON [dbo].[Direcciones]
    ([Persona_Id]);
GO

-- Creating foreign key on [Persona_Id] in table 'Telefonos'
ALTER TABLE [dbo].[Telefonos]
ADD CONSTRAINT [FK_PersonaTelefono]
    FOREIGN KEY ([Persona_Id])
    REFERENCES [dbo].[Personas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonaTelefono'
CREATE INDEX [IX_FK_PersonaTelefono]
ON [dbo].[Telefonos]
    ([Persona_Id]);
GO

-- Creating foreign key on [Personas_Id] in table 'PersonaLocalidad'
ALTER TABLE [dbo].[PersonaLocalidad]
ADD CONSTRAINT [FK_PersonaLocalidad_Persona]
    FOREIGN KEY ([Personas_Id])
    REFERENCES [dbo].[Personas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Localidades_Id] in table 'PersonaLocalidad'
ALTER TABLE [dbo].[PersonaLocalidad]
ADD CONSTRAINT [FK_PersonaLocalidad_Localidad]
    FOREIGN KEY ([Localidades_Id])
    REFERENCES [dbo].[Localidades]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonaLocalidad_Localidad'
CREATE INDEX [IX_FK_PersonaLocalidad_Localidad]
ON [dbo].[PersonaLocalidad]
    ([Localidades_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------