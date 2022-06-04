CREATE TABLE [dbo].[Gastos]
(
	GastoId INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	Proveedor VARCHAR(10) NOT NULL,
	Consecutivo VARCHAR(35) NOT NULL,
	FechaVencimiento DATE NOT NULL,
	Monto DECIMAL NOT NULL,
	Descripcion VARCHAR(250) NOT NULL,
	Estado VARCHAR(2) NOT NULL,
	CONSTRAINT Gasto_FK_Estado FOREIGN KEY (Estado)
    REFERENCES Estados(EstadoCodigo),
	CONSTRAINT Gasto_FK_Proveedor FOREIGN KEY (Proveedor)
    REFERENCES Proveedores(ProveedorCodigo)
)
