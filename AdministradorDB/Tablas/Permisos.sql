CREATE TABLE [dbo].[Permisos]
(
	PermisoId INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	RolId INT NOT NULL,
	Inicio BIT NOT NULL,
	Proveedores BIT NOT NULL,
	Gastos BIT NOT NULL,
	NotasCambio BIT NOT NULL,
	Facturas BIT NOT NULL,
	Usuarios BIT NOT NULL,
	Perfiles BIT NOT NULL,	
	ProductosBodega BIT NOT NULL,
	ReporteNC BIT NOT NULL DEFAULT(0),
	ReporteGT BIT NOT NULL DEFAULT(0),
	CONSTRAINT Rol_FK_ermisos 
	FOREIGN KEY (RolId) REFERENCES Roles(RolId)
)
