--======================================================================================
-- Procedimientos almacenados para Consumidores
--======================================================================================

-- Procedimiento para mostrar las comunidades
Create PROC sp_MostrarComunidades
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM Comunidades;
END
go
------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_MostrarComunidades
go
-------------------------------------------------------------------------------------------------

--Procedimiento para insertar comunidades
CREATE PROC sp_InsertarComunidad
@nombreComunidad varchar(50)

AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO Comunidades
	VALUES(@nombreComunidad)
END
go
-------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_InsertarComunidad 'Agua Fria';
go
-------------------------------------------------------------------------------------------------

--Procedimiento para eliminar comunidades
CREATE PROC sp_EliminarComunidad
@id int

AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM Comunidades WHERE idComunidad = @id
END
go
-------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_EliminarComunidad 4
go
-------------------------------------------------------------------------------------------------

--Procedimiento de Actualizar los Consumidores
CREATE PROC sp_ActualizarComunidad
@id int,
@nombreComunidad varchar(50)

AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Comunidades
	SET 
	nombreComunidad = @nombreComunidad
	WHERE idComunidad = @id
END
go
-------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_ActualizarComunidad 3, 'Agua Caliente';
go

------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_MostrarComunidades
--Procedimiento para insertar comunidades
