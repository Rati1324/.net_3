
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/15/2021 13:29:31
-- Generated from EDMX file: C:\Users\rati\Documents\programming\.Net\.net_3\AllApproaches\ModelFirst\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Temp];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_cityEmployee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_cityEmployee];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Employees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employees];
GO
IF OBJECT_ID(N'[dbo].[Cities1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cities1];
GO
IF OBJECT_ID(N'[dbo].[Departments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Departments];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [cityId] int  NOT NULL
);
GO

-- Creating table 'Cities1'
CREATE TABLE [dbo].[Cities1] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Departments'
CREATE TABLE [dbo].[Departments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Employee_Department'
CREATE TABLE [dbo].[Employee_Department] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EmployeeId] int  NOT NULL,
    [DepartmentId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Cities1'
ALTER TABLE [dbo].[Cities1]
ADD CONSTRAINT [PK_Cities1]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Departments'
ALTER TABLE [dbo].[Departments]
ADD CONSTRAINT [PK_Departments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Employee_Department'
ALTER TABLE [dbo].[Employee_Department]
ADD CONSTRAINT [PK_Employee_Department]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [cityId] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_cityEmployee]
    FOREIGN KEY ([cityId])
    REFERENCES [dbo].[Cities1]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_cityEmployee'
CREATE INDEX [IX_FK_cityEmployee]
ON [dbo].[Employees]
    ([cityId]);
GO

-- Creating foreign key on [EmployeeId] in table 'Employee_Department'
ALTER TABLE [dbo].[Employee_Department]
ADD CONSTRAINT [FK_Employee_DepartmentEmployee]
    FOREIGN KEY ([EmployeeId])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Employee_DepartmentEmployee'
CREATE INDEX [IX_FK_Employee_DepartmentEmployee]
ON [dbo].[Employee_Department]
    ([EmployeeId]);
GO

-- Creating foreign key on [DepartmentId] in table 'Employee_Department'
ALTER TABLE [dbo].[Employee_Department]
ADD CONSTRAINT [FK_DepartmentEmployee_Department]
    FOREIGN KEY ([DepartmentId])
    REFERENCES [dbo].[Departments]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartmentEmployee_Department'
CREATE INDEX [IX_FK_DepartmentEmployee_Department]
ON [dbo].[Employee_Department]
    ([DepartmentId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------