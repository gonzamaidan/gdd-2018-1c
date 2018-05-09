DROP TABLE LOS_MAGIOS.RESERVAS;
DROP TABLE LOS_MAGIOS.ROLES_POR_USUARIO;
DROP TABLE LOS_MAGIOS.HOTELES_POR_USUARIO;
DROP TABLE LOS_MAGIOS.FUNCIONALIDADES_POR_ROL;
DROP TABLE LOS_MAGIOS.HOTELES_POR_USUARIO;
DROP TABLE LOS_MAGIOS.USUARIOS;
DROP TABLE LOS_MAGIOS.ROLES;
DROP TABLE LOS_MAGIOS.FUNCIONALIDADES;
DROP TABLE LOS_MAGIOS.REGIMENES_POR_HOTEL;
DROP TABLE LOS_MAGIOS.REGIMENES;
DROP TABLE LOS_MAGIOS.HABITACIONES;
DROP TABLE LOS_MAGIOS.TIPOS_HABITACION;
DROP TABLE LOS_MAGIOS.HOTELES;
DROP FUNCTION LOS_MAGIOS.FRENTE_TO_UBICACION;
GO
/*DROP TABLE LOS_MAGIOS;

GO
*/
-- # CREACION DE SCHEMA
/*CREATE SCHEMA LOS_MAGIOS AUTHORIZATION gdHotel2018;

GO*/

-- # CREACION FUNCIONES
CREATE FUNCTION LOS_MAGIOS.FRENTE_TO_UBICACION(@FRENTE VARCHAR)
RETURNS VARCHAR(10)
AS BEGIN
	IF(@FRENTE = 'S')	RETURN 'EXTERNO'
	RETURN 'INTERIOR'
END

GO

-- # CREACION DE TABLAS
-- ## CREACION TABLA REGIMENES
CREATE TABLE LOS_MAGIOS.REGIMENES(
	CODIGO_REGIMEN INTEGER IDENTITY(1,1) PRIMARY KEY,
	DESCRIPCION VARCHAR(500),
	PRECIO NUMERIC(18,2)
);

-- ## CREACION TABLA HOTELES
CREATE TABLE LOS_MAGIOS.HOTELES(
	ID_HOTEL INT IDENTITY(1,1) PRIMARY KEY,
	NOMBRE VARCHAR(500),
	MAIL VARCHAR(50),
	TELEFONO INT,
	DIRECCION VARCHAR(100) NOT NULL,
	ESTRELLAS INT NOT NULL,
	CIUDAD VARCHAR(50) NOT NULL,
	PAIS VARCHAR(50) NOT NULL,
	FECHA_CREACION DATE NOT NULL DEFAULT(GETDATE())
);

-- ## CREACION TABLA REGIMENES_POR_HOTEL
CREATE TABLE LOS_MAGIOS.REGIMENES_POR_HOTEL(
	ID_HOTEL INTEGER REFERENCES LOS_MAGIOS.HOTELES(ID_HOTEL),
	CODIGO_REGIMEN INTEGER REFERENCES LOS_MAGIOS.REGIMENES(CODIGO_REGIMEN),
	PRIMARY KEY(ID_HOTEL, CODIGO_REGIMEN)
);

-- ## CREACION TABLA TIPOS_HABITACION

CREATE TABLE LOS_MAGIOS.TIPOS_HABITACION(
	CODIGO_TIPO_HABITACION INTEGER PRIMARY KEY,
	DESCRIPCION_TIPO_HABITACION VARCHAR(50) NOT NULL,
	PORCENTAJE NUMERIC NOT NULL
)


-- ## CREACION TABLA HABITACIONES
CREATE TABLE LOS_MAGIOS.HABITACIONES(
	ID_HOTEL INTEGER FOREIGN KEY REFERENCES LOS_MAGIOS.HOTELES(ID_HOTEL),
	NUMERO INTEGER,
	PISO INTEGER,
	UBICACION VARCHAR(10),
	CODIGO_TIPO_HABITACION INTEGER REFERENCES LOS_MAGIOS.TIPOS_HABITACION(CODIGO_TIPO_HABITACION),
	PRIMARY KEY(ID_HOTEL, NUMERO)
) 

CREATE TABLE LOS_MAGIOS.USUARIOS(
	USUARIO VARCHAR(15) PRIMARY KEY,
	CONTRASENA VARCHAR(15) NOT NULL,
	NOMBRE VARCHAR (50) NOT NULL,
	APELLIDO VARCHAR (50) NOT NULL,
	MAIL VARCHAR(50) NOT NULL,
	TELEFONO INTEGER NOT NULL,
	DIRECCION VARCHAR(50) NOT NULL,
	FECHA_DE_NACIMIENTO DATE NOT NULL
)

CREATE TABLE LOS_MAGIOS.ROLES(
	ID_ROL INTEGER IDENTITY(1,1) PRIMARY KEY,
	NOMBRE VARCHAR(50) NOT NULL,
	ESTADO BIT NOT NULL DEFAULT(1)
)

CREATE TABLE LOS_MAGIOS.FUNCIONALIDADES(
	ID_FUNCIONALIDAD INTEGER IDENTITY(1,1) PRIMARY KEY,
	DESCRIPCION VARCHAR(255)
)

CREATE TABLE LOS_MAGIOS.FUNCIONALIDADES_POR_ROL(
	ID_ROL INTEGER REFERENCES LOS_MAGIOS.ROLES(ID_ROL),
	ID_FUNCIONALIDAD INTEGER REFERENCES LOS_MAGIOS.FUNCIONALIDADES(ID_FUNCIONALIDAD)
	PRIMARY KEY(ID_ROL, ID_FUNCIONALIDAD)
)

CREATE TABLE LOS_MAGIOS.ROLES_POR_USUARIO (
	USUARIO VARCHAR(15) REFERENCES LOS_MAGIOS.USUARIOS(USUARIO),
	ID_ROL INTEGER REFERENCES LOS_MAGIOS.ROLES(ID_ROL),
	PRIMARY KEY(USUARIO, ID_ROL)
)

CREATE TABLE LOS_MAGIOS.HOTELES_POR_USUARIO (
	USUARIO VARCHAR(15) REFERENCES LOS_MAGIOS.USUARIOS(USUARIO),
	ID_HOTEL INTEGER REFERENCES LOS_MAGIOS.HOTELES(ID_HOTEL),
	PRIMARY KEY(USUARIO, ID_HOTEL)
)

CREATE TABLE LOS_MAGIOS.RESERVAS (
	CODIGO_RESERVA INTEGER PRIMARY KEY,
	FECHA_RESERVA DATE,
	FECHA_DESDE DATE NOT NULL,
	FECHA_HASTA DATE NOT NULL,
	ESTADO_RESERVA VARCHAR(20) NOT NULL DEFAULT('CORRECTA')
)

CREATE TABLE LOS_MAGIOS.ESTADIAS (
	CODIGO_RESERVA INTEGER REFERENCES
)

-- # INSERT DE TABLAS
-- ## INSERT TABLA REGIMENES
INSERT INTO LOS_MAGIOS.REGIMENES(DESCRIPCION, PRECIO)
SELECT DISTINCT Regimen_Descripcion, Regimen_Precio
FROM gd_esquema.Maestra

-- ## INSERT TABLA HOTELES
INSERT INTO LOS_MAGIOS.HOTELES(NOMBRE, PAIS, CIUDAD, DIRECCION, ESTRELLAS) 
select distinct Hotel_Ciudad + ' ' + Hotel_Calle, 'ARGENTINA' ,Hotel_Ciudad, Hotel_Calle + ' ' + STR(Hotel_Nro_Calle), Hotel_CantEstrella
from gd_esquema.Maestra 
order by Hotel_Ciudad;

-- ## INSERT TABLA REGIMENES_POR_HOTEL
INSERT INTO LOS_MAGIOS.REGIMENES_POR_HOTEL
SELECT distinct ID_HOTEL, CODIGO_REGIMEN
FROM LOS_MAGIOS.HOTELES, LOS_MAGIOS.REGIMENES;

-- # INSERT TABLA TIPOS_HABITACION
INSERT INTO LOS_MAGIOS.TIPOS_HABITACION(CODIGO_TIPO_HABITACION, DESCRIPCION_TIPO_HABITACION, PORCENTAJE)
SELECT DISTINCT Habitacion_Tipo_Codigo, Habitacion_Tipo_Descripcion, Habitacion_Tipo_Porcentual
FROM gd_esquema.Maestra

-- # INSERT TABLA HABITACIONES
INSERT INTO LOS_MAGIOS.HABITACIONES(NUMERO, PISO, UBICACION, CODIGO_TIPO_HABITACION, ID_HOTEL)
select distinct Habitacion_Numero, Habitacion_Piso, LOS_MAGIOS.FRENTE_TO_UBICACION(Habitacion_Frente), Habitacion_Tipo_Codigo, ID_HOTEL
from gd_esquema.Maestra JOIN LOS_MAGIOS.HOTELES ON Hotel_Calle + ' ' + STR(Hotel_Nro_Calle) = DIRECCION


INSERT INTO LOS_MAGIOS.RESERVAS 
SELECT DISTINCT Reserva_Codigo, NULL, Reserva_Fecha_Inicio, DATEADD(DAY,Reserva_Cant_Noches, Reserva_Fecha_Inicio), 'CANCELADA_NO-SHOW'
from gd_esquema.Maestra
order by Reserva_Codigo;

UPDATE LOS_MAGIOS.RESERVAS
SET ESTADO_RESERVA = 'EFECTIVIZADA'
WHERE CODIGO_RESERVA IN (
SELECT DISTINCT Reserva_Codigo
from gd_esquema.Maestra
where Estadia_Cant_Noches is not null
)