CREATE TABLE [dbo].[Gastos]
(
	GastoId INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	Consecutivo VARCHAR(35) NOT NULL,
	FechaVencimiento DATE NOT NULL,
	Monto DECIMAL NOT NULL,
	Descripcion VARCHAR(250) NOT NULL,
	Estado VARCHAR(2) NOT NULL,
	CONSTRAINT Gasto_FK_Estado FOREIGN KEY (Estado)
    REFERENCES Estados(EstadoCodigo)
)
