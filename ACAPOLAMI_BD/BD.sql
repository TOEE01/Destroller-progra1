USE master 
GO
DROP database IF exists ACAPOLAMI
GO
CREATE database ACAPOLAMI
GO
USE ACAPOLAMI

--=========================================================
-- Tablas
--=========================================================
GO
CREATE TABLE Comunidades(
	idComunidad int not null IDENTITY PRIMARY KEY,
	nombreComunidad varchar(50) not null,
);

-------------------------------------------------------------------------------------------------

CREATE TABLE Consumidores(
	idConsumidor int not null IDENTITY PRIMARY KEY,
	nombresConsumidor varchar(50) not null,
	apellidosConsumidor varchar(50) not null,
	numeroDocumento varchar(20) not null,
	telefono varchar(20),
	correo varchar(50),
	idComunidad_FK int REFERENCES Comunidades(idComunidad)
);

-------------------------------------------------------------------------------------------------

CREATE TABLE Estados(
	idEstado int not null IDENTITY PRIMARY KEY,
	nombreEstado varchar(50)
);

-------------------------------------------------------------------------------------------------

CREATE TABLE Pagos(
	idPago int not null IDENTITY PRIMARY KEY,
	monto money not null,
	montoCancelado money,
	montoPendiente money,
	fechaPago date not null,
	impuesto money,
	idEstado_FK int REFERENCES Estados(idEstado),
	idConsumidor_FK int REFERENCES Consumidores(idConsumidor)
);

-------------------------------------------------------------------------------------------------

CREATE TABLE Sucesos(
	idSuceso int not null IDENTITY PRIMARY KEY,
	tipoSuceso int,
	descripcion varchar(100),
);

-------------------------------------------------------------------------------------------------

CREATE TABLE Usuarios(
	idComunidad int not null IDENTITY PRIMARY KEY,
	nombre varchar(50) not null,
	clave varchar(100) not null,
	rol varchar(20)
);
GO
--======================================================================================
-- Registros
--======================================================================================
go
--Comunidades
INSERT INTO Comunidades VALUES('Las Lomas'), ('Las minas'), ('Agua Zarca');
go
-------------------------------------------------------------------------------------------------
go
INSERT INTO Consumidores 
VALUES('Manuel', 'Perlera', '312432-4324-32', '71368341', 'manuenitoo@gmail.com', 1),
		('Wilian', 'Leiva', '454235-4324-32', '4524545', 'willianfrifayer@gmail.com', 2),
		('Francisco', 'Miranda', '54523-4324-3243', '74354345', 'Carlosidfgj@gmail.com', 3);
go
-------------------------------------------------------------------------------------------------
go
INSERT INTO Estados VALUES('Cancelado'), ('Retrasado');
go
-------------------------------------------------------------------------------------------------
go
INSERT INTO Pagos 
VALUES(2, 0, 0, getdate(), 0, 1, 1), (2, 0, 0, getdate(), 0, 2, 2), (2, 0, 0, getdate(), 0, 2, 3);
go
-------------------------------------------------------------------------------------------------
go
INSERT INTO Usuarios VALUES ('Manuel', 'frifayer12', 'admin');
go
--SELECTs
go
--SELECT * FROM Comunidades
--SELECT * FROM Consumidores
--SELECT * FROM Estados
--SELECT * FROM Pagos
--SELECT * FROM Usuarios