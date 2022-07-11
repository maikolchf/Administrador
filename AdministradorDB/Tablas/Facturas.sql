CREATE TABLE [dbo].[Facturas]
(
	FacturaId INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	ProveedorFactura VARCHAR(10) NOT NULL,
	ConsecutivoFactura VARCHAR(35) NOT NULL,
	MontoFactura DECIMAL(18,2) NOT NULL,
	FechaRegistro DATE NOT NULL,	
	EstadoFactura VARCHAR(2) NOT NULL,
	CONSTRAINT Factura_FK_Estado FOREIGN KEY (EstadoFactura)
    REFERENCES Estados(EstadoCodigo),
	CONSTRAINT Factura_FK_Proveedor FOREIGN KEY (ProveedorFactura)
    REFERENCES Proveedores(ProveedorCodigo)
)
