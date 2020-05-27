CREATE PROCEDURE sp_Empleado_Insertar
	@Nombre nvarchar(100),
	@Direccion nvarchar(100)
AS
BEGIN
	INSERT INTO Empleado(Nombre,Direccion)
	VALUES(@Nombre,@Direccion)
END;

GO
CREATE PROCEDURE sp_Empleado_ConsultarTodo
AS
BEGIN
	SELECT * FROM Empleado
END;

GO
CREATE PROCEDURE sp_Empleado_ConsultarPorID
	@IdEmpleado int
AS
BEGIN
	SELECT * FROM Empleado
	WHERE IdEmpleado = @IdEmpleado
END;

GO
CREATE PROCEDURE sp_Empleado_Eliminar
	@IdEmpleado int
AS
BEGIN
	DELETE FROM Empleado
	WHERE IdEmpleado = @IdEmpleado
END;

GO
CREATE PROCEDURE sp_Empleado_Actualizar
	@IdEmpleado int,
	@Nombre nvarchar(100),
	@Direccion nvarchar(100)
AS
BEGIN
	UPDATE Empleado SET Nombre=@Nombre,Direccion=@Direccion
	WHERE IdEmpleado = @IdEmpleado
END;