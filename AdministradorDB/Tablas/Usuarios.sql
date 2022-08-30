﻿CREATE TABLE [dbo].[Usuarios]
(
	UsuarioId INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	RolId INT NOT NULL,
	NombreUsuario VARCHAR(250) NOT NULL,
	PrimerApellido VARCHAR(250) NOT NULL,
	SegundoApellido VARCHAR(250) NOT NULL,
	Correo VARCHAR(350) NOT NULL,
	Telefono VARCHAR(250) NOT NULL,
	Contrasenna VARCHAR(250) NOT NULL,
	Usuario VARCHAR(30) NOT NULL,
	Estado VARCHAR(1) NOT NULL,
	FechaGeneraToken DATE NOT NULL DEFAULT GETDATE(),
	Token VARCHAR(250) NOT NULL DEFAULT '',
	CONSTRAINT Usuarios_FK_Roles FOREIGN KEY (RolId) REFERENCES Roles (RolId)
)
