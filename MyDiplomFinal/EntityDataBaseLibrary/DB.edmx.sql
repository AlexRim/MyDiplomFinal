
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/21/2017 23:11:13
-- Generated from EDMX file: e:\MyDiplomFinal\MyDiplomFinal\EntityDataBaseLibrary\DB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DataBase];
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

-- Creating table 'ClientSet'
CREATE TABLE [dbo].[ClientSet] (
    [ClientID] int IDENTITY(1,1) NOT NULL,
    [ClientName] nvarchar(200)  NOT NULL,
    [ClientAdress] nvarchar(250)  NOT NULL,
    [ClientUNN] nvarchar(9)  NULL,
    [ClientPassport] nvarchar(9)  NULL,
    [ClientPhonePhax] nvarchar(200)  NULL
);
GO

-- Creating table 'BankSet'
CREATE TABLE [dbo].[BankSet] (
    [BankID] int IDENTITY(1,1) NOT NULL,
    [BankName] nvarchar(250)  NOT NULL,
    [BankCode] nvarchar(9)  NOT NULL,
    [BankPhonePhax] nvarchar(200)  NULL,
    [BankUNN] nvarchar(9)  NOT NULL,
    [Client_ClientID] int  NULL
);
GO

-- Creating table 'ContractSet'
CREATE TABLE [dbo].[ContractSet] (
    [ContractID] int IDENTITY(1,1) NOT NULL,
    [ContractNumber] nvarchar(100)  NOT NULL,
    [ContractDate] nvarchar(80)  NOT NULL,
    [ContractObject] nvarchar(max)  NOT NULL,
    [ContractPrice] float  NOT NULL,
    [ClientClientID] int  NULL
);
GO

-- Creating table 'WorkSet'
CREATE TABLE [dbo].[WorkSet] (
    [WorkID] int IDENTITY(1,1) NOT NULL,
    [WorkName] nvarchar(250)  NOT NULL,
    [WorkAmmount] float  NOT NULL,
    [WorkUnit] nvarchar(50)  NOT NULL,
    [WorkUnitPrice] float  NOT NULL,
    [TypeOfWorkTypeOfWorkID] int  NULL
);
GO

-- Creating table 'MaterialSet'
CREATE TABLE [dbo].[MaterialSet] (
    [MaterialID] int IDENTITY(1,1) NOT NULL,
    [MaterialName] nvarchar(200)  NOT NULL,
    [MaterialAmmount] float  NOT NULL,
    [MaterialUnitPrice] float  NOT NULL,
    [MaterialUnit] nvarchar(50)  NOT NULL,
    [WorkWorkID] int  NULL
);
GO

-- Creating table 'TypeOfWorkSet'
CREATE TABLE [dbo].[TypeOfWorkSet] (
    [TypeOfWorkID] int IDENTITY(1,1) NOT NULL,
    [TypeOfWorkName] nvarchar(200)  NOT NULL,
    [ContractContractID] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ClientID] in table 'ClientSet'
ALTER TABLE [dbo].[ClientSet]
ADD CONSTRAINT [PK_ClientSet]
    PRIMARY KEY CLUSTERED ([ClientID] ASC);
GO

-- Creating primary key on [BankID] in table 'BankSet'
ALTER TABLE [dbo].[BankSet]
ADD CONSTRAINT [PK_BankSet]
    PRIMARY KEY CLUSTERED ([BankID] ASC);
GO

-- Creating primary key on [ContractID] in table 'ContractSet'
ALTER TABLE [dbo].[ContractSet]
ADD CONSTRAINT [PK_ContractSet]
    PRIMARY KEY CLUSTERED ([ContractID] ASC);
GO

-- Creating primary key on [WorkID] in table 'WorkSet'
ALTER TABLE [dbo].[WorkSet]
ADD CONSTRAINT [PK_WorkSet]
    PRIMARY KEY CLUSTERED ([WorkID] ASC);
GO

-- Creating primary key on [MaterialID] in table 'MaterialSet'
ALTER TABLE [dbo].[MaterialSet]
ADD CONSTRAINT [PK_MaterialSet]
    PRIMARY KEY CLUSTERED ([MaterialID] ASC);
GO

-- Creating primary key on [TypeOfWorkID] in table 'TypeOfWorkSet'
ALTER TABLE [dbo].[TypeOfWorkSet]
ADD CONSTRAINT [PK_TypeOfWorkSet]
    PRIMARY KEY CLUSTERED ([TypeOfWorkID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Client_ClientID] in table 'BankSet'
ALTER TABLE [dbo].[BankSet]
ADD CONSTRAINT [FK_ClientBank]
    FOREIGN KEY ([Client_ClientID])
    REFERENCES [dbo].[ClientSet]
        ([ClientID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientBank'
CREATE INDEX [IX_FK_ClientBank]
ON [dbo].[BankSet]
    ([Client_ClientID]);
GO

-- Creating foreign key on [ClientClientID] in table 'ContractSet'
ALTER TABLE [dbo].[ContractSet]
ADD CONSTRAINT [FK_ClientContract]
    FOREIGN KEY ([ClientClientID])
    REFERENCES [dbo].[ClientSet]
        ([ClientID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientContract'
CREATE INDEX [IX_FK_ClientContract]
ON [dbo].[ContractSet]
    ([ClientClientID]);
GO

-- Creating foreign key on [ContractContractID] in table 'TypeOfWorkSet'
ALTER TABLE [dbo].[TypeOfWorkSet]
ADD CONSTRAINT [FK_ContractTypeOfWork]
    FOREIGN KEY ([ContractContractID])
    REFERENCES [dbo].[ContractSet]
        ([ContractID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ContractTypeOfWork'
CREATE INDEX [IX_FK_ContractTypeOfWork]
ON [dbo].[TypeOfWorkSet]
    ([ContractContractID]);
GO

-- Creating foreign key on [TypeOfWorkTypeOfWorkID] in table 'WorkSet'
ALTER TABLE [dbo].[WorkSet]
ADD CONSTRAINT [FK_TypeOfWorkWork]
    FOREIGN KEY ([TypeOfWorkTypeOfWorkID])
    REFERENCES [dbo].[TypeOfWorkSet]
        ([TypeOfWorkID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TypeOfWorkWork'
CREATE INDEX [IX_FK_TypeOfWorkWork]
ON [dbo].[WorkSet]
    ([TypeOfWorkTypeOfWorkID]);
GO

-- Creating foreign key on [WorkWorkID] in table 'MaterialSet'
ALTER TABLE [dbo].[MaterialSet]
ADD CONSTRAINT [FK_WorkMaterial]
    FOREIGN KEY ([WorkWorkID])
    REFERENCES [dbo].[WorkSet]
        ([WorkID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_WorkMaterial'
CREATE INDEX [IX_FK_WorkMaterial]
ON [dbo].[MaterialSet]
    ([WorkWorkID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------