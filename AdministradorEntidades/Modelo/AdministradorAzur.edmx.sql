
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/10/2022 15:09:10
-- Generated from EDMX file: D:\Proyectos Visual Studio\maikolchf\Administrador\AdministradorEntidades\Modelo\AdministradorAzur.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [AdministradorAzur];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Factura_FK_Estado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Facturas] DROP CONSTRAINT [FK_Factura_FK_Estado];
GO
IF OBJECT_ID(N'[dbo].[FK_Factura_FK_Proveedor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Facturas] DROP CONSTRAINT [FK_Factura_FK_Proveedor];
GO
IF OBJECT_ID(N'[dbo].[FK_Gasto_FK_Estado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Gastos] DROP CONSTRAINT [FK_Gasto_FK_Estado];
GO
IF OBJECT_ID(N'[dbo].[FK_Gasto_FK_Proveedor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Gastos] DROP CONSTRAINT [FK_Gasto_FK_Proveedor];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductoNC_FK_NotaCambio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductosNC] DROP CONSTRAINT [FK_ProductoNC_FK_NotaCambio];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductoNC_FK_ProductoBodega]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductosNC] DROP CONSTRAINT [FK_ProductoNC_FK_ProductoBodega];
GO
IF OBJECT_ID(N'[dbo].[FK_Proveedor_FK_Estado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Proveedores] DROP CONSTRAINT [FK_Proveedor_FK_Estado];
GO
IF OBJECT_ID(N'[dbo].[FK_Rol_FK_ermisos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Permisos] DROP CONSTRAINT [FK_Rol_FK_ermisos];
GO
IF OBJECT_ID(N'[dbo].[FK_Usuarios_FK_Roles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Usuarios] DROP CONSTRAINT [FK_Usuarios_FK_Roles];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Estados]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Estados];
GO
IF OBJECT_ID(N'[dbo].[Facturas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Facturas];
GO
IF OBJECT_ID(N'[dbo].[Gastos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Gastos];
GO
IF OBJECT_ID(N'[dbo].[NotasCambio]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NotasCambio];
GO
IF OBJECT_ID(N'[dbo].[Permisos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Permisos];
GO
IF OBJECT_ID(N'[dbo].[ProductosBodega]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductosBodega];
GO
IF OBJECT_ID(N'[dbo].[ProductosNC]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductosNC];
GO
IF OBJECT_ID(N'[dbo].[Proveedores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Proveedores];
GO
IF OBJECT_ID(N'[dbo].[Roles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Roles];
GO
IF OBJECT_ID(N'[dbo].[Usuarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuarios];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Estados'
CREATE TABLE [dbo].[Estados] (
    [EstadoId] int IDENTITY(1,1) NOT NULL,
    [EstadoCodigo] varchar(2)  NOT NULL,
    [EstadoDescripcion] varchar(30)  NOT NULL
);
GO

-- Creating table 'Gastos'
CREATE TABLE [dbo].[Gastos] (
    [GastoId] int IDENTITY(1,1) NOT NULL,
    [Proveedor] varchar(10)  NOT NULL,
    [Consecutivo] varchar(35)  NOT NULL,
    [FechaVencimiento] datetime  NOT NULL,
    [Monto] decimal(18,2)  NOT NULL,
    [Descripcion] varchar(250)  NOT NULL,
    [Estado] varchar(2)  NOT NULL
);
GO

-- Creating table 'NotasCambio'
CREATE TABLE [dbo].[NotasCambio] (
    [IdNC] int IDENTITY(1,1) NOT NULL,
    [ConsecutivoNC] varchar(30)  NOT NULL,
    [FechaEmisionNC] datetime  NOT NULL,
    [CodProveedorNC] varchar(10)  NOT NULL,
    [MontoNC] decimal(18,2)  NOT NULL,
    [IdFacturaAplicada] int  NOT NULL,
    [EstadoNC] varchar(2)  NOT NULL
);
GO

-- Creating table 'ProductosBodega'
CREATE TABLE [dbo].[ProductosBodega] (
    [IdProducto] int IDENTITY(1,1) NOT NULL,
    [CodigoProducto] varchar(35)  NOT NULL,
    [NombreProducto] varchar(250)  NOT NULL,
    [CantidadProducto] int  NOT NULL
);
GO

-- Creating table 'ProductosNC'
CREATE TABLE [dbo].[ProductosNC] (
    [IdProductoNC] int IDENTITY(1,1) NOT NULL,
    [IdNC] int  NOT NULL,
    [IdProducto] int  NOT NULL,
    [CantidadProdNC] int  NOT NULL,
    [DescripcionProdNC] varchar(350)  NOT NULL,
    [PrecioProdNC] decimal(18,2)  NOT NULL
);
GO

-- Creating table 'Proveedores'
CREATE TABLE [dbo].[Proveedores] (
    [ProveedorId] int IDENTITY(1,1) NOT NULL,
    [ProveedorNombre] varchar(35)  NOT NULL,
    [ProveedorCodigo] varchar(10)  NOT NULL,
    [ProveedorCedula] varchar(20)  NOT NULL,
    [ProveedorTelefono] varchar(25)  NOT NULL,
    [ProveedorGastoFijo] bit  NOT NULL,
    [ProveedorEstado] varchar(2)  NOT NULL
);
GO

-- Creating table 'Facturas'
CREATE TABLE [dbo].[Facturas] (
    [FacturaId] int IDENTITY(1,1) NOT NULL,
    [ProveedorFactura] varchar(10)  NOT NULL,
    [ConsecutivoFactura] varchar(35)  NOT NULL,
    [MontoFactura] decimal(18,2)  NOT NULL,
    [FechaRegistro] datetime  NOT NULL,
    [EstadoFactura] varchar(2)  NOT NULL
);
GO

-- Creating table 'Roles'
CREATE TABLE [dbo].[Roles] (
    [RolId] int IDENTITY(1,1) NOT NULL,
    [NombreRol] varchar(250)  NOT NULL,
    [EstadoRol] varchar(1)  NOT NULL
);
GO

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [UsuarioId] int IDENTITY(1,1) NOT NULL,
    [RolId] int  NOT NULL,
    [NombreUsuario] varchar(250)  NOT NULL,
    [PrimerApellido] varchar(250)  NOT NULL,
    [SegundoApellido] varchar(250)  NOT NULL,
    [Correo] varchar(350)  NOT NULL,
    [Telefono] varchar(250)  NOT NULL,
    [Contrasenna] varchar(250)  NOT NULL,
    [Usuario] varchar(30)  NOT NULL,
    [Estado] varchar(1)  NOT NULL
);
GO

-- Creating table 'Permisos'
CREATE TABLE [dbo].[Permisos] (
    [PermisoId] int IDENTITY(1,1) NOT NULL,
    [RolId] int  NOT NULL,
    [Inicio] bit  NOT NULL,
    [Proveedores] bit  NOT NULL,
    [Gastos] bit  NOT NULL,
    [NotasCambio] bit  NOT NULL,
    [Facturas] bit  NOT NULL,
    [Usuarios] bit  NOT NULL,
    [Perfiles] bit  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [EstadoCodigo] in table 'Estados'
ALTER TABLE [dbo].[Estados]
ADD CONSTRAINT [PK_Estados]
    PRIMARY KEY CLUSTERED ([EstadoCodigo] ASC);
GO

-- Creating primary key on [GastoId] in table 'Gastos'
ALTER TABLE [dbo].[Gastos]
ADD CONSTRAINT [PK_Gastos]
    PRIMARY KEY CLUSTERED ([GastoId] ASC);
GO

-- Creating primary key on [IdNC] in table 'NotasCambio'
ALTER TABLE [dbo].[NotasCambio]
ADD CONSTRAINT [PK_NotasCambio]
    PRIMARY KEY CLUSTERED ([IdNC] ASC);
GO

-- Creating primary key on [IdProducto] in table 'ProductosBodega'
ALTER TABLE [dbo].[ProductosBodega]
ADD CONSTRAINT [PK_ProductosBodega]
    PRIMARY KEY CLUSTERED ([IdProducto] ASC);
GO

-- Creating primary key on [IdProductoNC] in table 'ProductosNC'
ALTER TABLE [dbo].[ProductosNC]
ADD CONSTRAINT [PK_ProductosNC]
    PRIMARY KEY CLUSTERED ([IdProductoNC] ASC);
GO

-- Creating primary key on [ProveedorCodigo] in table 'Proveedores'
ALTER TABLE [dbo].[Proveedores]
ADD CONSTRAINT [PK_Proveedores]
    PRIMARY KEY CLUSTERED ([ProveedorCodigo] ASC);
GO

-- Creating primary key on [FacturaId] in table 'Facturas'
ALTER TABLE [dbo].[Facturas]
ADD CONSTRAINT [PK_Facturas]
    PRIMARY KEY CLUSTERED ([FacturaId] ASC);
GO

-- Creating primary key on [RolId] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [PK_Roles]
    PRIMARY KEY CLUSTERED ([RolId] ASC);
GO

-- Creating primary key on [UsuarioId] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([UsuarioId] ASC);
GO

-- Creating primary key on [PermisoId] in table 'Permisos'
ALTER TABLE [dbo].[Permisos]
ADD CONSTRAINT [PK_Permisos]
    PRIMARY KEY CLUSTERED ([PermisoId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Estado] in table 'Gastos'
ALTER TABLE [dbo].[Gastos]
ADD CONSTRAINT [FK_Gasto_FK_Estado]
    FOREIGN KEY ([Estado])
    REFERENCES [dbo].[Estados]
        ([EstadoCodigo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Gasto_FK_Estado'
CREATE INDEX [IX_FK_Gasto_FK_Estado]
ON [dbo].[Gastos]
    ([Estado]);
GO

-- Creating foreign key on [ProveedorEstado] in table 'Proveedores'
ALTER TABLE [dbo].[Proveedores]
ADD CONSTRAINT [FK_Proveedor_FK_Estado]
    FOREIGN KEY ([ProveedorEstado])
    REFERENCES [dbo].[Estados]
        ([EstadoCodigo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Proveedor_FK_Estado'
CREATE INDEX [IX_FK_Proveedor_FK_Estado]
ON [dbo].[Proveedores]
    ([ProveedorEstado]);
GO

-- Creating foreign key on [Proveedor] in table 'Gastos'
ALTER TABLE [dbo].[Gastos]
ADD CONSTRAINT [FK_Gasto_FK_Proveedor]
    FOREIGN KEY ([Proveedor])
    REFERENCES [dbo].[Proveedores]
        ([ProveedorCodigo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Gasto_FK_Proveedor'
CREATE INDEX [IX_FK_Gasto_FK_Proveedor]
ON [dbo].[Gastos]
    ([Proveedor]);
GO

-- Creating foreign key on [IdNC] in table 'ProductosNC'
ALTER TABLE [dbo].[ProductosNC]
ADD CONSTRAINT [FK_ProductoNC_FK_NotaCambio]
    FOREIGN KEY ([IdNC])
    REFERENCES [dbo].[NotasCambio]
        ([IdNC])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductoNC_FK_NotaCambio'
CREATE INDEX [IX_FK_ProductoNC_FK_NotaCambio]
ON [dbo].[ProductosNC]
    ([IdNC]);
GO

-- Creating foreign key on [IdProducto] in table 'ProductosNC'
ALTER TABLE [dbo].[ProductosNC]
ADD CONSTRAINT [FK_ProductoNC_FK_ProductoBodega]
    FOREIGN KEY ([IdProducto])
    REFERENCES [dbo].[ProductosBodega]
        ([IdProducto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductoNC_FK_ProductoBodega'
CREATE INDEX [IX_FK_ProductoNC_FK_ProductoBodega]
ON [dbo].[ProductosNC]
    ([IdProducto]);
GO

-- Creating foreign key on [EstadoFactura] in table 'Facturas'
ALTER TABLE [dbo].[Facturas]
ADD CONSTRAINT [FK_Factura_FK_Estado]
    FOREIGN KEY ([EstadoFactura])
    REFERENCES [dbo].[Estados]
        ([EstadoCodigo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Factura_FK_Estado'
CREATE INDEX [IX_FK_Factura_FK_Estado]
ON [dbo].[Facturas]
    ([EstadoFactura]);
GO

-- Creating foreign key on [ProveedorFactura] in table 'Facturas'
ALTER TABLE [dbo].[Facturas]
ADD CONSTRAINT [FK_Factura_FK_Proveedor]
    FOREIGN KEY ([ProveedorFactura])
    REFERENCES [dbo].[Proveedores]
        ([ProveedorCodigo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Factura_FK_Proveedor'
CREATE INDEX [IX_FK_Factura_FK_Proveedor]
ON [dbo].[Facturas]
    ([ProveedorFactura]);
GO

-- Creating foreign key on [RolId] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [FK_Usuarios_FK_Roles]
    FOREIGN KEY ([RolId])
    REFERENCES [dbo].[Roles]
        ([RolId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Usuarios_FK_Roles'
CREATE INDEX [IX_FK_Usuarios_FK_Roles]
ON [dbo].[Usuarios]
    ([RolId]);
GO

-- Creating foreign key on [RolId] in table 'Permisos'
ALTER TABLE [dbo].[Permisos]
ADD CONSTRAINT [FK_Rol_FK_ermisos1]
    FOREIGN KEY ([RolId])
    REFERENCES [dbo].[Roles]
        ([RolId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Rol_FK_ermisos1'
CREATE INDEX [IX_FK_Rol_FK_ermisos1]
ON [dbo].[Permisos]
    ([RolId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------