CREATE TABLE [dbo].[Proveedores]
(
	ProveedorId			INT IDENTITY(1,1) NOT NULL PRIMARY KEY ,
	ProveedorNombre		VARCHAR(35) NOT NULL,
	ProveedorCedula		VARCHAR(20) NOT NULL,
	ProveedorTelefono	VARCHAR(25) NOT NULL,
	ProveedorGastoFijo	BIT NOT NULL,
	ProveedorEstado		VARCHAR(2) NOT NULL,
	CONSTRAINT Proveedor_FK_Estado FOREIGN KEY (ProveedorEstado)
    REFERENCES Estados(EstadoCodigo)
)
