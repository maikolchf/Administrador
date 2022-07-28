CREATE TABLE [dbo].[Persmisos]
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
	CONSTRAINT Permisos_FK_Rol 
	FOREIGN KEY (RolId) REFERENCES Roles(RolId)
)
