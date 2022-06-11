CREATE TABLE [dbo].[ProductosBodega]
(
	IdProducto INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	CodigoProducto	VARCHAR(35) NOT NULL ,
	NombreProducto	VARCHAR(250) NOT NULL,
	CantidadProducto	INT NOT NULL,
)
