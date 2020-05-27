-- PARTE EDGAR ALEJANDRO MARES JIMENEZ

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


-- PARTE RAUL ANTONIO RODRIGUEZ CHAVIRA

CREATE PROCEDURE sp_Curso_Consultar_Todo
AS
BEGIN 
	SELECT * FROM Curso;
END;
GO

CREATE PROCEDURE sp_Curso_Consultar_PorID
@idcurso int
AS
BEGIN
	SELECT C.IdCurso,C.Descripcion,C.IdEmpleado,E.Nombre FROM Curso AS c
	INNER JOIN Empleado AS e
	ON e.IdEmpleado = C.IdEmpleado
	WHERE c.IdCurso = @idcurso;
END;
GO


CREATE PROCEDURE sp_Curso_CargarEmpleados
AS
BEGIN
	SELECT DISTINCT c.IdEmpleado, e.Nombre 
	FROM Empleado as e
	LEFT JOIN Curso as c
	ON c.IdEmpleado = e.IdEmpleado;
END;
GO


CREATE PROCEDURE sp_Curso_Actualizar
@idcurso int,
@descripcion nvarchar(200),
@idempleado int
AS 
BEGIN
	UPDATE Curso
	SET Descripcion = @descripcion, IdEmpleado = @idempleado
	WHERE IdCurso = @idcurso;
END;
GO



CREATE PROCEDURE sp_Curso_Eliminar
@idcurso int
AS
BEGIN
	DELETE FROM Curso
	WHERE IdCurso = @idcurso;
END;
GO

alter table curso
drop constraint fk_idEmp;

alter table curso 
add constraint fk_idEmp Foreign Key (IdEmpleado) References Empleado (IdEmpleado)
On Delete Cascade On Update Cascade;

alter table curso_tema
drop constraint fk_idtema;

alter table curso_tema
add constraint fk_idtema Foreign Key (IdTema) References Tema (IdTema)
On Delete Cascade;

alter table curso_tema_video
drop constraint fk_idCT;

alter table curso_tema_video
add constraint fk_idCT Foreign Key (IdCT) References curso_tema (IdCT)
On Delete Cascade;

alter table curso_tema_video
drop constraint fk_idVideo;

alter table curso_tema_video
add constraint fk_idVideo Foreign Key (IdVideo) References video (IdVideo)
On Delete Cascade;

alter table curso_tema
drop constraint fk_idCurso;

alter table curso_tema
add constraint fk_idCurso Foreign Key (IdCurso) References Curso (IdCurso)
On Delete Cascade;

