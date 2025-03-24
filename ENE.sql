CREATE DATABASE ENE
GO

USE ENE
GO

CREATE TABLE Usuario (
IdUsuario INT IDENTITY PRIMARY KEY,
Nombre NVARCHAR(MAX) NOT NULL,
Contrasena NVARCHAR(MAX) NOT NULL,
EsAdministrador INT NOT NULL
)
GO

CREATE TABLE Trabajador (
IdTrabajador INT IDENTITY PRIMARY KEY,
Rut NVARCHAR(MAX) NOT NULL,
Nombre NVARCHAR(MAX) NOT NULL,
Direccion NVARCHAR(MAX) NOT NULL,
Telefono NVARCHAR(MAX) NOT NULL,
HorasTrabajadas INT NOT NULL,
HorasExtras INT NOT NULL,
AFP INT NOT NULL,
Salud INT NOT NULL
)
GO

CREATE PROCEDURE [Login]
    @Nombre NVARCHAR(MAX),
    @Contrasena NVARCHAR(MAX),
    @IdUsuario INT OUTPUT,
    @EsAdministrador INT OUTPUT
AS
BEGIN
    SET @IdUsuario = 0
    SET @EsAdministrador = 0
    
    IF EXISTS(SELECT * FROM Usuario WHERE [Nombre] COLLATE Latin1_General_CS_AS = @Nombre AND Contrasena COLLATE Latin1_General_CS_AS = @Contrasena)
    BEGIN
        SELECT TOP 1 @IdUsuario = IdUsuario, @EsAdministrador = EsAdministrador
        FROM Usuario 
        WHERE [Nombre] COLLATE Latin1_General_CS_AS = @Nombre 
        AND Contrasena COLLATE Latin1_General_CS_AS = @Contrasena
    END
END
GO

CREATE PROCEDURE Bus_Trabajador
AS
BEGIN
	SELECT * FROM Trabajador
END
GO

CREATE PROCEDURE Ing_Trabajador
	@Rut NVARCHAR(MAX),
	@Nombre NVARCHAR(MAX),
	@Direccion NVARCHAR(MAX),
	@Telefono NVARCHAR(MAX),
	@HorasTrabajadas INT,
	@HorasExtras INT,
	@AFP INT,
	@Salud INT,
	@Resultado BIT OUTPUT
AS
BEGIN
	SET @Resultado = 1
		IF NOT EXISTS(Select * From Trabajador Where Rut=@Rut)
		INSERT INTO Trabajador (Rut, Nombre, Direccion, Telefono, HorasTrabajadas, HorasExtras, AFP, Salud) VALUES (@Rut, @Nombre, @Direccion, @Telefono, @HorasTrabajadas, @HorasExtras, @AFP, @Salud)
	ELSE
		SET @Resultado = 0
END
GO

CREATE PROCEDURE Act_Trabajador
@IdTrabajador INT,
	@Rut NVARCHAR(MAX),
	@Nombre NVARCHAR(MAX),
	@Direccion NVARCHAR(MAX),
	@Telefono NVARCHAR(MAX),
	@HorasTrabajadas INT,
	@HorasExtras INT,
	@AFP INT,
	@Salud INT,
	@Resultado BIT OUTPUT
AS
BEGIN
	SET @Resultado = 1
	IF(EXISTS(SELECT * FROM Trabajador WHERE IdTrabajador = @IdTrabajador))
	BEGIN
		IF(NOT EXISTS(SELECT * FROM Trabajador WHERE Rut = @Rut AND IdTrabajador != @IdTrabajador))
		BEGIN
			UPDATE Trabajador 
			SET Rut = @Rut, 
				Nombre = @Nombre, 
				Direccion = @Direccion, 
				Telefono = @Telefono, 
				HorasTrabajadas = @HorasTrabajadas, 
				HorasExtras = @HorasExtras, 
				AFP = @AFP, 
				Salud = @Salud 
			WHERE IdTrabajador = @IdTrabajador
		END
		ELSE
			SET @Resultado = 0
	END
	ELSE
		SET @Resultado = 0
END
GO

CREATE PROCEDURE Eli_Trabajador
@IdTrabajador INT,
@Resultado BIT OUTPUT
AS
BEGIN
	SET @Resultado = 1
	If(EXISTS(SELECT * FROM Trabajador WHERE IdTrabajador=@IdTrabajador))
		DELETE FROM Trabajador WHERE IdTrabajador= @IdTrabajador
	ELSE
		SET @Resultado = 0
END
GO

INSERT INTO Usuario (Nombre, Contrasena, EsAdministrador) VALUES ('admin', 'admin', 1)
GO

INSERT INTO Usuario (Nombre, Contrasena, EsAdministrador) VALUES ('user', 'user', 0)
GO

INSERT INTO Trabajador (Rut, Nombre, Direccion, Telefono, HorasTrabajadas, HorasExtras, AFP, Salud)
VALUES ('12.345.678-5', 'Juan Pérez', 'Calle Falsa 123', '987654321', 160, 10, 0, 0);

INSERT INTO Trabajador (Rut, Nombre, Direccion, Telefono, HorasTrabajadas, HorasExtras, AFP, Salud)
VALUES ('18.765.432-1', 'María López', 'Av. Siempre Viva 742', '912345678', 150, 5, 1, 1);

INSERT INTO Trabajador (Rut, Nombre, Direccion, Telefono, HorasTrabajadas, HorasExtras, AFP, Salud)
VALUES ('21.234.567-9', 'Pedro González', 'Calle Los Robles 456', '912345678', 170, 8, 2, 2);

INSERT INTO Trabajador (Rut, Nombre, Direccion, Telefono, HorasTrabajadas, HorasExtras, AFP, Salud)
VALUES ('10.987.654-3', 'Ana Martínez', 'Calle Las Flores 789', '923456789', 160, 0, 3, 3);

INSERT INTO Trabajador (Rut, Nombre, Direccion, Telefono, HorasTrabajadas, HorasExtras, AFP, Salud)
VALUES ('15.876.543-2', 'Carlos Rodríguez', 'Calle La Paz 321', '934567890', 140, 20, 0, 1);

