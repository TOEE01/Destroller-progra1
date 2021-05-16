--======================================================================================
-- Procedimientos almacenados para Pagos
--======================================================================================
-- Procedimiento para Mostrar Pagos
CREATE PROC sp_MostrarPagos
AS

BEGIN
--Select para la tabla de pagos
	SELECT a.idPago Id, b.nombresConsumidor Nombres, b.apellidosConsumidor Apellidos, 
	a.monto as Monto, a.montoCancelado as Cancelado, a.montoPendiente as Pendiente, 
	a.impuesto as Impuesto, c.nombreEstado as Estado, a.fechaPago as Fecha 

	FROM Pagos AS a

	INNER JOIN Consumidores AS b on a.idConsumidor_FK = b.idConsumidor
	INNER JOIN Estados AS c on a.idEstado_FK = c.idEstado;
END
go
------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_MostrarPagos
go
-------------------------------------------------------------------------------------------------

-- Procedimiento para Mostrar Pagos filtrados por Consumidor
ALTER PROC sp_MostrarPagosId
@idConsumidor int 

AS
BEGIN
	SET NOCOUNT ON;
	SELECT a.idPago Id, b.nombresConsumidor Nombres, b.apellidosConsumidor Apellidos, 
	a.monto as Monto, a.montoCancelado as Cancelado, a.montoPendiente as Pendiente, 
	a.impuesto as Impuesto, c.nombreEstado as Estado, a.fechaPago as Fecha 

	FROM Pagos AS a

	INNER JOIN Consumidores AS b on a.idConsumidor_FK = b.idConsumidor
	INNER JOIN Estados AS c on a.idEstado_FK = c.idEstado
	WHERE a.idConsumidor_FK = @idConsumidor
END
go
-------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_MostrarPagosId 3;
go
-------------------------------------------------------------------------------------------------
go
--Procedimiento para Insertar Pagos
CREATE PROC sp_InsertarPago
@monto money,
@montoCancelado money,
@montoPendiente money,
@fechaPago date,
@impuesto money,
@idEstado int,
@idConsumidor int

AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO Pagos
	VALUES(@monto, @montoCancelado, @montoPendiente, @fechaPago, @impuesto, @idEstado, @idConsumidor);
END
go
-------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_InsertarPago 2, 2, 0, '2021-05-03', 0, 1, 3;
go
-------------------------------------------------------------------------------------------------

--Procedimiento para Eliminar Pagos
CREATE PROC sp_EliminarPago
@id int

AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM Pagos WHERE idPago = @id
END
go
-------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_EliminarPago 4
go
-------------------------------------------------------------------------------------------------

--Procedimiento de Actualizar Pagos
CREATE PROC sp_ActualizarPago
@id int,
@monto money,
@montoCancelado money,
@montoPendiente money,
@fechaPago date,
@impuesto money,
@idEstado int,
@idConsumidor int

AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Pagos
	SET 
	monto = @monto,
	@montoCancelado = @montoCancelado,
	montoPendiente = @montoPendiente,
	fechaPago = @fechaPago,
	impuesto = @impuesto,
	idEstado_FK = @idEstado,
	idConsumidor_FK = @idConsumidor
	WHERE idPago = @id
END
go
-------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_ActualizarConsumidor 7, 'Jose', 'tejada', '452435243-435', '8834129412',3,'manu@gmail.com';
go