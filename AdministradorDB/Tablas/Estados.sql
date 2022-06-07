CREATE TABLE [dbo].[Estados]
(
	EstadoId INT IDENTITY(1,1) NOT NULL,
	EstadoCodigo VARCHAR(2) NOT NULL PRIMARY KEY,
	EstadoDescripcion VARCHAR(30) NOT NULL
)
