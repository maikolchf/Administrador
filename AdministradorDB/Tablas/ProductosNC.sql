CREATE TABLE [dbo].[ProductosNC]
(
	IdProductoNC INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	IdNC		INT NOT NULL,
	IdProducto	INT NOT NULL,
	CantidadProdNC	INT NOT NULL,
	DescripcionProdNC VARCHAR(350) NOT NULL,
	PrecioProdNC		DECIMAL(18,2) NOT NULL,
	CONSTRAINT ProductoNC_FK_ProductoBodega FOREIGN KEY (IdProducto)
	REFERENCES ProductosBodega(IdProducto),
	CONSTRAINT ProductoNC_FK_NotaCambio FOREIGN KEY (IdNC)
	REFERENCES NotasCambio(IdNC)
)
