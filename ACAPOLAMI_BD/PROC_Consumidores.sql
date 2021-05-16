--======================================================================================
-- Procedimientos almacenados para Consumidores
--======================================================================================

-- Procedimiento para Mostrar Consumidores
Create PROC sp_MostrarConsumidores
AS
BEGIN
	SET NOCOUNT ON;
	SELECT a.idConsumidor 'Id', a.nombresConsumidor AS 'Nombres', a.apellidosConsumidor AS 'Apellidos', 
	a.numeroDocumento AS 'DUI', a.correo AS 'Correo electrónico', a.telefono AS 'Teléfono', 
	b.nombreComunidad AS 'Comunidad'

	FROM Consumidores AS a
	inner join Comunidades AS b
	ON b.idComunidad = a.idComunidad_FK;
END
go
------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_MostrarConsumidores
go
-------------------------------------------------------------------------------------------------

-- Procedimiento para Mostrar Consumidores filtrados por comunidad
CREATE PROC sp_MostrarConsumidoresId
@idComunidad int 

AS
BEGIN
	SET NOCOUNT ON;
	SELECT a.idConsumidor 'Id',a.nombresConsumidor AS 'Nombres', a.apellidosConsumidor AS 'Apellidos', 
	a.numeroDocumento AS 'DUI', a.correo AS 'Correo electrónico', a.telefono AS 'Teléfono', 
	b.nombreComunidad AS 'Comunidad'

	FROM Consumidores AS a
	inner join Comunidades AS b
	ON b.idComunidad = a.idComunidad_FK
	WHERE b.idComunidad = @idComunidad
END
go
-------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_MostrarConsumidoresId 3;
go
-------------------------------------------------------------------------------------------------
go
--Procedimiento para Insertar Consumidores
CREATE PROC sp_InsertarConsumidor
@nombres varchar(50),
@apellidos varchar(50),
@dui varchar(20),
@telefono varchar(20),
@correo varchar(50),
@idComunidad int

AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO Consumidores
	VALUES(@nombres, @apellidos, @dui, @telefono, @correo, @idComunidad)
END
go
-------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_InsertarConsumidor 'Manuel', 'Perlera', '12123-12321-32', '77388082', 'manuenitoo@gmail.com', 1;
go
-------------------------------------------------------------------------------------------------

--Procedimiento para Eliminar Consumidores
CREATE PROC sp_EliminarConsumidor
@id int

AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM Consumidores WHERE idConsumidor = @id
END
go
-------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_EliminarConsumidor 4
go
-------------------------------------------------------------------------------------------------

--Procedimiento de Actualizar los Consumidores
CREATE PROC sp_ActualizarConsumidor
@id int,
@nombres varchar(50),
@apellidos varchar(50),
@dui varchar(20),
@telefono varchar(20),
@idComunidad int,
@correo varchar(50)

AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Consumidores
	SET 
	nombresConsumidor = @nombres,
	apellidosConsumidor = @apellidos,
	numeroDocumento = @dui,
	telefono = @telefono,
	correo = @correo,
	idComunidad_FK = @idComunidad
	WHERE idConsumidor = @id
END
go
-------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_ActualizarConsumidor 7, 'Jose', 'tejada', '452435243-435', '8834129412',3,'manu@gmail.com';
go