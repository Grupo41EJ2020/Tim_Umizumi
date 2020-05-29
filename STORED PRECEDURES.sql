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


CREATE PROCEDURE sp_Curso_Insertar
@descripcion NVARCHAR(200),
@idempleado INT
AS
BEGIN
	INSERT INTO Curso(Descripcion,IdEmpleado)
	VALUES(@descripcion,@idempleado);

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

--PARTE JAHIR ADRIAN GRANADOS FLORES

CREATE PROCEDURE sp_Curso_Tema_Video_Consultar_Todo
AS
BEGIN 
	SELECT * FROM curso_tema_video;
END;
GO

CREATE PROCEDURE sp_Curso_Tema_Video_Consultar_PorID
@IdCTV int
AS
BEGIN
	SELECT CTV.IdCTV,CTV.IdCT,CTV.IdVideo,V.Nombre FROM Curso_Tema_Video AS CTV
	INNER JOIN Video AS V
	ON CTV.IdVideo = V.IdVideo
	WHERE CTV.IdCTV = @IdCTV;
END;
GO


CREATE PROCEDURE sp_Curso_Tema_Video_Actualizar
@IdCTV int,
@IdCT int,
@IdVideo int
AS 
BEGIN
	UPDATE curso_tema_video
	SET IdCT = @IdCT, IdVideo = @IdVideo
	WHERE IdCTV = @IdCTV;
END;
GO


CREATE PROCEDURE sp_Curso_Tema_Video_Insertar
@IdCT INT,
@IdVideo INT
AS
BEGIN
	INSERT INTO curso_tema_video(IdCT,IdVideo)
	VALUES(@IdCT,@IdVideo);

END;
GO

CREATE PROCEDURE sp_Curso_Tema_Video_Eliminar
@idcurso int
AS
BEGIN
	DELETE FROM curso_tema_video
	WHERE IdCTV = @IdCTV;
END;
GO



--FIN PARTE JAHIR GRANADOS



--Parte Jonathan Yair Vazquez Buenrostro
Create Procedure sp_Video_ConsultarTodo
As
Begin
Select * From Video
End;

Create Procedure sp_Video_ConsultarPorId
@IdVideo int
As
Begin
Select * From Video Where IdVideo=@IdVideo
End;

Create Procedure sp_Video_Actualizar
@IdVideo int,
@Nombre nvarchar(200),
@Url nvarchar(100),
@FechaPublicacion datetime
As
Begin
Update Video Set Nombre=@Nombre,Url=@Url,FechaPublicacion=@FechaPublicacion where IdVideo=@IdVideo
End;

Create Procedure sp_Video_Inserta
@Nombre nvarchar(200),
@Url nvarchar(100),
@FechaPublicacion datetime
As
Begin
Insert Into Video(Nombre,Url,FechaPublicacion) Values(@Nombre,@Url,@FechaPublicacion)
End;
GO

Create Procedure sp_Video_Eliminar
@IdVideo int
As
Begin
Delete From Video where IdVideo=@IdVideo
End;

Create Procedure sp_Tema_ConsultarTodo
As
Begin
Select * From Tema
End;

Create Procedure sp_Tema_ConsultarPorId
@IdTema int
As
Begin
Select * From Tema Where IdTema=@IdTema
End;
GO

Create Procedure sp_Tema_Insertar
@Nombre nvarchar(100)
As
Begin
Insert Into Tema(Nombre) Values(@Nombre)
End;
GO

Create Procedure sp_Tema_Actualizar
@IdTema int,
@Nombre nvarchar(100)
As
Begin
Update Tema Set Nombre=@Nombre Where IdTema=@IdTema
End;
GO

Create Procedure sp_Tema_Eliminar
@IdTema int
As
Begin
Delete From Tema Where IdTema=@IdTema
End;
GO