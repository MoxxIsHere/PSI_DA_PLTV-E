
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/20/2022 13:38:27
-- Generated from EDMX file: C:\Users\Botas\Desktop\DEV\ProjectodeDA\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DA];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_RestauranteMorada]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Restaurantes] DROP CONSTRAINT [FK_RestauranteMorada];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemMenuRestaurante_ItemMenu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemMenuRestaurante] DROP CONSTRAINT [FK_ItemMenuRestaurante_ItemMenu];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemMenuRestaurante_Restaurante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemMenuRestaurante] DROP CONSTRAINT [FK_ItemMenuRestaurante_Restaurante];
GO
IF OBJECT_ID(N'[dbo].[FK_CategoriaItemMenu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemMenus] DROP CONSTRAINT [FK_CategoriaItemMenu];
GO
IF OBJECT_ID(N'[dbo].[FK_PedidoRestaurante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pedidos] DROP CONSTRAINT [FK_PedidoRestaurante];
GO
IF OBJECT_ID(N'[dbo].[FK_PedidoItemMenu_Pedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PedidoItemMenu] DROP CONSTRAINT [FK_PedidoItemMenu_Pedido];
GO
IF OBJECT_ID(N'[dbo].[FK_PedidoItemMenu_ItemMenu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PedidoItemMenu] DROP CONSTRAINT [FK_PedidoItemMenu_ItemMenu];
GO
IF OBJECT_ID(N'[dbo].[FK_EstadoPedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pedidos] DROP CONSTRAINT [FK_EstadoPedido];
GO
IF OBJECT_ID(N'[dbo].[FK_PessoaMorada]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas] DROP CONSTRAINT [FK_PessoaMorada];
GO
IF OBJECT_ID(N'[dbo].[FK_RestauranteTrabalhador]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Trabalhador] DROP CONSTRAINT [FK_RestauranteTrabalhador];
GO
IF OBJECT_ID(N'[dbo].[FK_PedidoCliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pedidos] DROP CONSTRAINT [FK_PedidoCliente];
GO
IF OBJECT_ID(N'[dbo].[FK_TrabalhadorPedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pedidos] DROP CONSTRAINT [FK_TrabalhadorPedido];
GO
IF OBJECT_ID(N'[dbo].[FK_PedidoPagamento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pagamentos] DROP CONSTRAINT [FK_PedidoPagamento];
GO
IF OBJECT_ID(N'[dbo].[FK_MetodoPagamentoPagamento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pagamentos] DROP CONSTRAINT [FK_MetodoPagamentoPagamento];
GO
IF OBJECT_ID(N'[dbo].[FK_Trabalhador_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Trabalhador] DROP CONSTRAINT [FK_Trabalhador_inherits_Pessoa];
GO
IF OBJECT_ID(N'[dbo].[FK_Cliente_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Cliente] DROP CONSTRAINT [FK_Cliente_inherits_Pessoa];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Moradas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Moradas];
GO
IF OBJECT_ID(N'[dbo].[Restaurantes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Restaurantes];
GO
IF OBJECT_ID(N'[dbo].[ItemMenus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemMenus];
GO
IF OBJECT_ID(N'[dbo].[Categorias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categorias];
GO
IF OBJECT_ID(N'[dbo].[Pedidos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pedidos];
GO
IF OBJECT_ID(N'[dbo].[Estadoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Estadoes];
GO
IF OBJECT_ID(N'[dbo].[Pessoas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoas];
GO
IF OBJECT_ID(N'[dbo].[Pagamentos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pagamentos];
GO
IF OBJECT_ID(N'[dbo].[MetodosPagamento]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MetodosPagamento];
GO
IF OBJECT_ID(N'[dbo].[Pessoas_Trabalhador]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoas_Trabalhador];
GO
IF OBJECT_ID(N'[dbo].[Pessoas_Cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoas_Cliente];
GO
IF OBJECT_ID(N'[dbo].[ItemMenuRestaurante]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemMenuRestaurante];
GO
IF OBJECT_ID(N'[dbo].[PedidoItemMenu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PedidoItemMenu];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Moradas'
CREATE TABLE [dbo].[Moradas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Rua] nvarchar(max)  NOT NULL,
    [Cidade] nvarchar(max)  NOT NULL,
    [CodPostal] nvarchar(max)  NOT NULL,
    [Pais] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Restaurantes'
CREATE TABLE [dbo].[Restaurantes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [IdMorada] int  NOT NULL,
    [Moradas_Id] int  NOT NULL
);
GO

-- Creating table 'ItemMenus'
CREATE TABLE [dbo].[ItemMenus] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdCategoria] int  NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Fotografia] nvarchar(max)  NOT NULL,
    [Ingredientes] nvarchar(max)  NOT NULL,
    [Preco] float  NOT NULL,
    [Ativo] bit  NOT NULL,
    [Categoria_Id] int  NOT NULL
);
GO

-- Creating table 'Categorias'
CREATE TABLE [dbo].[Categorias] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Ativo] bit  NOT NULL
);
GO

-- Creating table 'Pedidos'
CREATE TABLE [dbo].[Pedidos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdTrabalhador] int  NOT NULL,
    [IdCliente] int  NOT NULL,
    [IdRestaurante] int  NOT NULL,
    [IdEstado] int  NOT NULL,
    [ValorTotal] float  NOT NULL,
    [Restaurantes_Id] int  NOT NULL,
    [Estado_Id] int  NOT NULL,
    [Clientes_Id] int  NOT NULL,
    [Trabalhador_Id] int  NOT NULL
);
GO

-- Creating table 'Estadoes'
CREATE TABLE [dbo].[Estadoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [estado] bit  NOT NULL
);
GO

-- Creating table 'Pessoas'
CREATE TABLE [dbo].[Pessoas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [IdMorada] int  NOT NULL,
    [Telemovel] int  NOT NULL,
    [Moradas_Id] int  NOT NULL
);
GO

-- Creating table 'Pagamentos'
CREATE TABLE [dbo].[Pagamentos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdPedido] int  NOT NULL,
    [IdMetodoPagamento] int  NOT NULL,
    [Valor] float  NOT NULL,
    [Pedido_Id] int  NOT NULL,
    [MetodoPagamento_Id] int  NOT NULL
);
GO

-- Creating table 'MetodosPagamento'
CREATE TABLE [dbo].[MetodosPagamento] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Metodopagamento] nvarchar(max)  NOT NULL,
    [Ativo] bit  NOT NULL
);
GO

-- Creating table 'Pessoas_Trabalhador'
CREATE TABLE [dbo].[Pessoas_Trabalhador] (
    [IdRestaurante] int  NOT NULL,
    [Salario] float  NOT NULL,
    [Posicao] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL,
    [Restaurante_Id] int  NOT NULL
);
GO

-- Creating table 'Pessoas_Cliente'
CREATE TABLE [dbo].[Pessoas_Cliente] (
    [TotalGasto] float  NOT NULL,
    [NumContribuinte] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'ItemMenuRestaurante'
CREATE TABLE [dbo].[ItemMenuRestaurante] (
    [ItemMenu_Id] int  NOT NULL,
    [Restaurantes_Id] int  NOT NULL
);
GO

-- Creating table 'PedidoItemMenu'
CREATE TABLE [dbo].[PedidoItemMenu] (
    [Pedido_Id] int  NOT NULL,
    [ItemMenus_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Moradas'
ALTER TABLE [dbo].[Moradas]
ADD CONSTRAINT [PK_Moradas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Restaurantes'
ALTER TABLE [dbo].[Restaurantes]
ADD CONSTRAINT [PK_Restaurantes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ItemMenus'
ALTER TABLE [dbo].[ItemMenus]
ADD CONSTRAINT [PK_ItemMenus]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Categorias'
ALTER TABLE [dbo].[Categorias]
ADD CONSTRAINT [PK_Categorias]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pedidos'
ALTER TABLE [dbo].[Pedidos]
ADD CONSTRAINT [PK_Pedidos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Estadoes'
ALTER TABLE [dbo].[Estadoes]
ADD CONSTRAINT [PK_Estadoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pessoas'
ALTER TABLE [dbo].[Pessoas]
ADD CONSTRAINT [PK_Pessoas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pagamentos'
ALTER TABLE [dbo].[Pagamentos]
ADD CONSTRAINT [PK_Pagamentos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MetodosPagamento'
ALTER TABLE [dbo].[MetodosPagamento]
ADD CONSTRAINT [PK_MetodosPagamento]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pessoas_Trabalhador'
ALTER TABLE [dbo].[Pessoas_Trabalhador]
ADD CONSTRAINT [PK_Pessoas_Trabalhador]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pessoas_Cliente'
ALTER TABLE [dbo].[Pessoas_Cliente]
ADD CONSTRAINT [PK_Pessoas_Cliente]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [ItemMenu_Id], [Restaurantes_Id] in table 'ItemMenuRestaurante'
ALTER TABLE [dbo].[ItemMenuRestaurante]
ADD CONSTRAINT [PK_ItemMenuRestaurante]
    PRIMARY KEY CLUSTERED ([ItemMenu_Id], [Restaurantes_Id] ASC);
GO

-- Creating primary key on [Pedido_Id], [ItemMenus_Id] in table 'PedidoItemMenu'
ALTER TABLE [dbo].[PedidoItemMenu]
ADD CONSTRAINT [PK_PedidoItemMenu]
    PRIMARY KEY CLUSTERED ([Pedido_Id], [ItemMenus_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Moradas_Id] in table 'Restaurantes'
ALTER TABLE [dbo].[Restaurantes]
ADD CONSTRAINT [FK_RestauranteMorada]
    FOREIGN KEY ([Moradas_Id])
    REFERENCES [dbo].[Moradas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestauranteMorada'
CREATE INDEX [IX_FK_RestauranteMorada]
ON [dbo].[Restaurantes]
    ([Moradas_Id]);
GO

-- Creating foreign key on [ItemMenu_Id] in table 'ItemMenuRestaurante'
ALTER TABLE [dbo].[ItemMenuRestaurante]
ADD CONSTRAINT [FK_ItemMenuRestaurante_ItemMenu]
    FOREIGN KEY ([ItemMenu_Id])
    REFERENCES [dbo].[ItemMenus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Restaurantes_Id] in table 'ItemMenuRestaurante'
ALTER TABLE [dbo].[ItemMenuRestaurante]
ADD CONSTRAINT [FK_ItemMenuRestaurante_Restaurante]
    FOREIGN KEY ([Restaurantes_Id])
    REFERENCES [dbo].[Restaurantes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemMenuRestaurante_Restaurante'
CREATE INDEX [IX_FK_ItemMenuRestaurante_Restaurante]
ON [dbo].[ItemMenuRestaurante]
    ([Restaurantes_Id]);
GO

-- Creating foreign key on [Categoria_Id] in table 'ItemMenus'
ALTER TABLE [dbo].[ItemMenus]
ADD CONSTRAINT [FK_CategoriaItemMenu]
    FOREIGN KEY ([Categoria_Id])
    REFERENCES [dbo].[Categorias]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoriaItemMenu'
CREATE INDEX [IX_FK_CategoriaItemMenu]
ON [dbo].[ItemMenus]
    ([Categoria_Id]);
GO

-- Creating foreign key on [Restaurantes_Id] in table 'Pedidos'
ALTER TABLE [dbo].[Pedidos]
ADD CONSTRAINT [FK_PedidoRestaurante]
    FOREIGN KEY ([Restaurantes_Id])
    REFERENCES [dbo].[Restaurantes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoRestaurante'
CREATE INDEX [IX_FK_PedidoRestaurante]
ON [dbo].[Pedidos]
    ([Restaurantes_Id]);
GO

-- Creating foreign key on [Pedido_Id] in table 'PedidoItemMenu'
ALTER TABLE [dbo].[PedidoItemMenu]
ADD CONSTRAINT [FK_PedidoItemMenu_Pedido]
    FOREIGN KEY ([Pedido_Id])
    REFERENCES [dbo].[Pedidos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ItemMenus_Id] in table 'PedidoItemMenu'
ALTER TABLE [dbo].[PedidoItemMenu]
ADD CONSTRAINT [FK_PedidoItemMenu_ItemMenu]
    FOREIGN KEY ([ItemMenus_Id])
    REFERENCES [dbo].[ItemMenus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoItemMenu_ItemMenu'
CREATE INDEX [IX_FK_PedidoItemMenu_ItemMenu]
ON [dbo].[PedidoItemMenu]
    ([ItemMenus_Id]);
GO

-- Creating foreign key on [Estado_Id] in table 'Pedidos'
ALTER TABLE [dbo].[Pedidos]
ADD CONSTRAINT [FK_EstadoPedido]
    FOREIGN KEY ([Estado_Id])
    REFERENCES [dbo].[Estadoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EstadoPedido'
CREATE INDEX [IX_FK_EstadoPedido]
ON [dbo].[Pedidos]
    ([Estado_Id]);
GO

-- Creating foreign key on [Moradas_Id] in table 'Pessoas'
ALTER TABLE [dbo].[Pessoas]
ADD CONSTRAINT [FK_PessoaMorada]
    FOREIGN KEY ([Moradas_Id])
    REFERENCES [dbo].[Moradas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PessoaMorada'
CREATE INDEX [IX_FK_PessoaMorada]
ON [dbo].[Pessoas]
    ([Moradas_Id]);
GO

-- Creating foreign key on [Restaurante_Id] in table 'Pessoas_Trabalhador'
ALTER TABLE [dbo].[Pessoas_Trabalhador]
ADD CONSTRAINT [FK_RestauranteTrabalhador]
    FOREIGN KEY ([Restaurante_Id])
    REFERENCES [dbo].[Restaurantes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestauranteTrabalhador'
CREATE INDEX [IX_FK_RestauranteTrabalhador]
ON [dbo].[Pessoas_Trabalhador]
    ([Restaurante_Id]);
GO

-- Creating foreign key on [Clientes_Id] in table 'Pedidos'
ALTER TABLE [dbo].[Pedidos]
ADD CONSTRAINT [FK_PedidoCliente]
    FOREIGN KEY ([Clientes_Id])
    REFERENCES [dbo].[Pessoas_Cliente]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoCliente'
CREATE INDEX [IX_FK_PedidoCliente]
ON [dbo].[Pedidos]
    ([Clientes_Id]);
GO

-- Creating foreign key on [Trabalhador_Id] in table 'Pedidos'
ALTER TABLE [dbo].[Pedidos]
ADD CONSTRAINT [FK_TrabalhadorPedido]
    FOREIGN KEY ([Trabalhador_Id])
    REFERENCES [dbo].[Pessoas_Trabalhador]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TrabalhadorPedido'
CREATE INDEX [IX_FK_TrabalhadorPedido]
ON [dbo].[Pedidos]
    ([Trabalhador_Id]);
GO

-- Creating foreign key on [Pedido_Id] in table 'Pagamentos'
ALTER TABLE [dbo].[Pagamentos]
ADD CONSTRAINT [FK_PedidoPagamento]
    FOREIGN KEY ([Pedido_Id])
    REFERENCES [dbo].[Pedidos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoPagamento'
CREATE INDEX [IX_FK_PedidoPagamento]
ON [dbo].[Pagamentos]
    ([Pedido_Id]);
GO

-- Creating foreign key on [MetodoPagamento_Id] in table 'Pagamentos'
ALTER TABLE [dbo].[Pagamentos]
ADD CONSTRAINT [FK_MetodoPagamentoPagamento]
    FOREIGN KEY ([MetodoPagamento_Id])
    REFERENCES [dbo].[MetodosPagamento]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MetodoPagamentoPagamento'
CREATE INDEX [IX_FK_MetodoPagamentoPagamento]
ON [dbo].[Pagamentos]
    ([MetodoPagamento_Id]);
GO

-- Creating foreign key on [Id] in table 'Pessoas_Trabalhador'
ALTER TABLE [dbo].[Pessoas_Trabalhador]
ADD CONSTRAINT [FK_Trabalhador_inherits_Pessoa]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Pessoas]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Pessoas_Cliente'
ALTER TABLE [dbo].[Pessoas_Cliente]
ADD CONSTRAINT [FK_Cliente_inherits_Pessoa]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Pessoas]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------