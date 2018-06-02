DROP TABLE LOS_MAGIOS.CLIENTES_POR_RESERVA;
DROP TABLE LOS_MAGIOS.BAJA_HOTELES;
DROP TABLE LOS_MAGIOS.ITEM_FACTURA;
DROP TABLE LOS_MAGIOS.FACTURA;
DROP TABLE LOS_MAGIOS.ESTADIAS;
DROP TABLE LOS_MAGIOS.REGISTRO_RESERVAS;
DROP TABLE LOS_MAGIOS.HABITACIONES_POR_RESERVA;
DROP TABLE LOS_MAGIOS.RESERVAS;
DROP TABLE LOS_MAGIOS.ESTADOS_RESERVA;
DROP TABLE LOS_MAGIOS.ROLES_POR_USUARIO;
DROP TABLE LOS_MAGIOS.HOTELES_POR_USUARIO;
DROP TABLE LOS_MAGIOS.FUNCIONALIDADES_POR_ROL;
DROP TABLE LOS_MAGIOS.USUARIOS;
DROP TABLE LOS_MAGIOS.ROLES;
DROP TABLE LOS_MAGIOS.FUNCIONALIDADES;
DROP TABLE LOS_MAGIOS.REGIMENES_POR_HOTEL;
DROP TABLE LOS_MAGIOS.REGIMENES;
DROP TABLE LOS_MAGIOS.HABITACIONES;
DROP TABLE LOS_MAGIOS.TIPOS_HABITACION;
DROP TABLE LOS_MAGIOS.HOTELES;
DROP TABLE LOS_MAGIOS.CONSUMIBLES;
DROP TABLE LOS_MAGIOS.CLIENTES;
DROP TABLE LOS_MAGIOS.TIPOS_IDENTIFICACION;
DROP FUNCTION LOS_MAGIOS.FRENTE_TO_UBICACION;
GO
DROP SCHEMA LOS_MAGIOS;

GO

-- # CREACION DE SCHEMA
CREATE SCHEMA LOS_MAGIOS AUTHORIZATION gdHotel2018;

GO

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
	PRECIO_DOLARES NUMERIC(18,2),
	ESTADO BIT NOT NULL DEFAULT(1)
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
	NUMERO_HABITACION INTEGER,
	PISO INTEGER,
	UBICACION VARCHAR(10),
	CODIGO_TIPO_HABITACION INTEGER REFERENCES LOS_MAGIOS.TIPOS_HABITACION(CODIGO_TIPO_HABITACION),
	PRIMARY KEY(ID_HOTEL, NUMERO_HABITACION)
) 

CREATE TABLE LOS_MAGIOS.USUARIOS(
	USUARIO VARCHAR(50) PRIMARY KEY,
	CONTRASENA VARCHAR(100) NOT NULL,
	NOMBRE VARCHAR (50) NOT NULL,
	APELLIDO VARCHAR (50) NOT NULL,
	MAIL VARCHAR(50) NOT NULL,
	TELEFONO INTEGER NOT NULL,
	DIRECCION VARCHAR(100) NOT NULL,
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
	USUARIO VARCHAR(50) REFERENCES LOS_MAGIOS.USUARIOS(USUARIO),
	ID_ROL INTEGER REFERENCES LOS_MAGIOS.ROLES(ID_ROL),
	PRIMARY KEY(USUARIO, ID_ROL)
)

CREATE TABLE LOS_MAGIOS.HOTELES_POR_USUARIO (
	USUARIO VARCHAR(50) REFERENCES LOS_MAGIOS.USUARIOS(USUARIO),
	ID_HOTEL INTEGER REFERENCES LOS_MAGIOS.HOTELES(ID_HOTEL),
	PRIMARY KEY(USUARIO, ID_HOTEL)
)

CREATE TABLE LOS_MAGIOS.ESTADOS_RESERVA (
	ID_ESTADO_RESERVA INTEGER IDENTITY(1,1) PRIMARY KEY,
	DESCRIPCION_ESTADO_RESERVA VARCHAR(20) NOT NULL
)

CREATE TABLE LOS_MAGIOS.RESERVAS (
	CODIGO_RESERVA INTEGER PRIMARY KEY,
	FECHA_RESERVA DATE,
	FECHA_DESDE DATE NOT NULL,
	FECHA_HASTA DATE NOT NULL,
	ID_ESTADO_RESERVA INTEGER NOT NULL DEFAULT(1) REFERENCES LOS_MAGIOS.ESTADOS_RESERVA(ID_ESTADO_RESERVA),
	CODIGO_REGIMEN INTEGER NOT NULL REFERENCES LOS_MAGIOS.REGIMENES(CODIGO_REGIMEN)
)


CREATE TABLE LOS_MAGIOS.ESTADIAS (
	CODIGO_RESERVA INTEGER REFERENCES LOS_MAGIOS.RESERVAS(CODIGO_RESERVA),
	FECHA_INGRESO DATE NOT NULL,
	FECHA_EGRESO DATE NOT NULL,
	PRIMARY KEY (CODIGO_RESERVA)
)

CREATE TABLE LOS_MAGIOS.HABITACIONES_POR_RESERVA (
	NUMERO_HABITACION INT NOT NULL,
	ID_HOTEL INT NOT NULL,
	CODIGO_RESERVA INT REFERENCES LOS_MAGIOS.RESERVAS(CODIGO_RESERVA),
	PRIMARY KEY(NUMERO_HABITACION, ID_HOTEL, CODIGO_RESERVA),
	FOREIGN KEY(ID_HOTEL,NUMERO_HABITACION) REFERENCES LOS_MAGIOS.HABITACIONES(ID_HOTEL, NUMERO_HABITACION)
)
CREATE TABLE LOS_MAGIOS.REGISTRO_RESERVAS(
	ID_REGISTRO INT IDENTITY(1,1) PRIMARY KEY,
	CODIGO_RESERVA INT REFERENCES LOS_MAGIOS.RESERVAS(CODIGO_RESERVA),
	USUARIO VARCHAR(50) REFERENCES LOS_MAGIOS.USUARIOS(USUARIO),
	ACCION VARCHAR(50) NOT NULL,
	FECHA DATE NOT NULL DEFAULT(GETDATE())
)

CREATE TABLE LOS_MAGIOS.FACTURA(
	NUMERO_FACTURA INTEGER PRIMARY KEY,
	CODIGO_RESERVA INTEGER REFERENCES LOS_MAGIOS.ESTADIAS(CODIGO_RESERVA),
	FECHA_FACTURA DATE NOT NULL,
	TOTAL_FACTURA NUMERIC NOT NULL,
	INCONSISTENTE BIT DEFAULT(0)
)

CREATE TABLE LOS_MAGIOS.CONSUMIBLES(
	CODIGO_CONSUMIBLE INTEGER PRIMARY KEY,
	DESCRIPCION VARCHAR(255),
	PRECIO_CONSUMIBLE NUMERIC(18,2)
)

CREATE TABLE LOS_MAGIOS.ITEM_FACTURA(
	ID_ITEM_FACTURA INTEGER IDENTITY(1,1) PRIMARY KEY,
	NUMERO_FACTURA INTEGER REFERENCES LOS_MAGIOS.FACTURA(NUMERO_FACTURA),
	CANTIDAD INTEGER NOT NULL,
	PRECIO_UNIDAD NUMERIC(18,2) NOT NULL,
	CODIGO_CONSUMIBLE INTEGER REFERENCES LOS_MAGIOS.CONSUMIBLES(CODIGO_CONSUMIBLE)
)

CREATE TABLE LOS_MAGIOS.TIPOS_IDENTIFICACION (
	TIPO_IDENTIFICACION INTEGER IDENTITY(1,1) PRIMARY KEY,
	DESCRIPCION VARCHAR(50)
)

CREATE TABLE LOS_MAGIOS.CLIENTES (
	CODIGO_CLIENTE INTEGER IDENTITY(1,1) PRIMARY KEY,
	NOMBRE VARCHAR(255),
	APELLIDO VARCHAR(255),
	IDENTIFICACION INT NOT NULL,
	TIPO_IDENTIFICACION INT REFERENCES LOS_MAGIOS.TIPOS_IDENTIFICACION(TIPO_IDENTIFICACION),
	MAIL VARCHAR(255) NOT NULL,
	TELEFONO INTEGER,
	DIRECCION VARCHAR(255) NOT NULL,
	LOCALIDAD VARCHAR(255),
	PAIS VARCHAR(255),
	NACIONALIDAD VARCHAR(255) NOT NULL,
	FECHA_NACIMIENTO DATE NOT NULL,
	DUPLICADO BIT DEFAULT 0
)

CREATE TABLE LOS_MAGIOS.BAJA_HOTELES (
	ID_BAJA_HOTEL INTEGER IDENTITY(1,1) PRIMARY KEY,
	ID_HOTEL INTEGER REFERENCES LOS_MAGIOS.HOTELES(ID_HOTEL),
	FECHA_INICIO_BAJA DATE NOT NULL,
	FECHA_FIN_BAJA DATE
)

CREATE TABLE LOS_MAGIOS.CLIENTES_POR_RESERVA (
	CODIGO_CLIENTE INTEGER REFERENCES LOS_MAGIOS.CLIENTES(CODIGO_CLIENTE),
	CODIGO_RESERVA INTEGER REFERENCES LOS_MAGIOS.RESERVAS(CODIGO_RESERVA),
	PRIMARY KEY (CODIGO_CLIENTE, CODIGO_RESERVA)
)

-- # INSERT DE TABLAS
-- ## INSERT TABLA REGIMENES
INSERT INTO LOS_MAGIOS.REGIMENES(DESCRIPCION, PRECIO_DOLARES)
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
INSERT INTO LOS_MAGIOS.HABITACIONES(NUMERO_HABITACION, PISO, UBICACION, CODIGO_TIPO_HABITACION, ID_HOTEL)
select distinct Habitacion_Numero, Habitacion_Piso, LOS_MAGIOS.FRENTE_TO_UBICACION(Habitacion_Frente), Habitacion_Tipo_Codigo, ID_HOTEL
from gd_esquema.Maestra JOIN LOS_MAGIOS.HOTELES ON Hotel_Calle + ' ' + STR(Hotel_Nro_Calle) = DIRECCION

INSERT INTO LOS_MAGIOS.ESTADOS_RESERVA(DESCRIPCION_ESTADO_RESERVA) VALUES
('CORRECTA'),
('MODIFICADA'),
('CANCELADA-RECEPCION'),
('CANCELADA-CLIENTE'),
('CANCELADA-NO-SHOW'),
('EFECTIVIZADA')

INSERT INTO LOS_MAGIOS.RESERVAS 
SELECT DISTINCT Reserva_Codigo, NULL, Reserva_Fecha_Inicio, DATEADD(DAY,Reserva_Cant_Noches, Reserva_Fecha_Inicio), 5, CODIGO_REGIMEN
from gd_esquema.Maestra JOIN LOS_MAGIOS.REGIMENES ON DESCRIPCION = Regimen_Descripcion
order by Reserva_Codigo;

UPDATE LOS_MAGIOS.RESERVAS
SET ID_ESTADO_RESERVA = 6
WHERE CODIGO_RESERVA IN (
SELECT DISTINCT Reserva_Codigo
from gd_esquema.Maestra
where Estadia_Cant_Noches is not null
)

-- #FALTA INSERT HABITACIONES_POR_RESERVA 
INSERT INTO LOS_MAGIOS.HABITACIONES_POR_RESERVA(CODIGO_RESERVA,NUMERO_HABITACION, ID_HOTEL)
SELECT DISTINCT Reserva_Codigo,Habitacion_Numero, ID_HOTEL
FROM gd_esquema.Maestra JOIN LOS_MAGIOS.HOTELES ON Hotel_Calle + ' ' + STR(Hotel_Nro_Calle) = DIRECCION
ORDER BY Reserva_Codigo


INSERT INTO LOS_MAGIOS.TIPOS_IDENTIFICACION(DESCRIPCION) VALUES('Pasaporte');

INSERT INTO LOS_MAGIOS.CLIENTES(IDENTIFICACION, TIPO_IDENTIFICACION, APELLIDO, NOMBRE, FECHA_NACIMIENTO, NACIONALIDAD, MAIL, DIRECCION) (
SELECT DISTINCT Cliente_Pasaporte_Nro, 1, Cliente_Apellido, Cliente_Nombre, Cliente_Fecha_Nac, Cliente_Nacionalidad, Cliente_Mail, Cliente_Dom_Calle + ' ' + STR(Cliente_Nro_Calle) + ' ' + STR(Cliente_Piso) + ' ' + Cliente_Depto
FROM gd_esquema.Maestra
);

UPDATE LOS_MAGIOS.CLIENTES
SET DUPLICADO = 1 
WHERE IDENTIFICACION IN 
(SELECT Cliente_Pasaporte_Nro 
FROM gd_esquema.Maestra
GROUP BY Cliente_Pasaporte_Nro
HAVING COUNT(DISTINCT Cliente_Apellido + 
			Cliente_Nombre + Cliente_Mail +	
			Cliente_Dom_Calle + str(Cliente_Nro_Calle) + str(Cliente_Piso) + Cliente_Depto ) > 1);

INSERT INTO LOS_MAGIOS.ESTADIAS(CODIGO_RESERVA, FECHA_INGRESO, FECHA_EGRESO) 
(SELECT DISTINCT Reserva_Codigo, Estadia_Fecha_Inicio, DATEADD(DAY,Estadia_Cant_Noches, Estadia_Fecha_Inicio)
FROM gd_esquema.Maestra
WHERE Estadia_Fecha_Inicio IS NOT NULL);

INSERT INTO LOS_MAGIOS.CONSUMIBLES(CODIGO_CONSUMIBLE, DESCRIPCION, PRECIO_CONSUMIBLE)
SELECT DISTINCT Consumible_Codigo, Consumible_Descripcion, Consumible_Precio
FROM gd_esquema.Maestra
WHERE Consumible_Codigo IS NOT NULL

INSERT INTO LOS_MAGIOS.FACTURA(CODIGO_RESERVA,FECHA_FACTURA, NUMERO_FACTURA, TOTAL_FACTURA)
SELECT DISTINCT Reserva_Codigo, Factura_Fecha, Factura_Nro, Factura_Total
FROM gd_esquema.Maestra
WHERE Factura_Nro IS NOT NULL

INSERT INTO LOS_MAGIOS.ITEM_FACTURA(PRECIO_UNIDAD, CANTIDAD, CODIGO_CONSUMIBLE, NUMERO_FACTURA)
SELECT Item_Factura_Monto / Item_Factura_Cantidad, Item_Factura_Cantidad, Consumible_Codigo, Factura_Nro
FROM gd_esquema.Maestra
WHERE Factura_Nro IS NOT NULL

UPDATE LOS_MAGIOS.FACTURA 
SET INCONSISTENTE = 1
WHERE NUMERO_FACTURA IN (
SELECT F.NUMERO_FACTURA
FROM LOS_MAGIOS.FACTURA F JOIN LOS_MAGIOS.ITEM_FACTURA I ON F.NUMERO_FACTURA = I.NUMERO_FACTURA
GROUP BY F.NUMERO_FACTURA, TOTAL_FACTURA
HAVING SUM(PRECIO_UNIDAD * CANTIDAD) != TOTAL_FACTURA
)

INSERT INTO LOS_MAGIOS.CLIENTES_POR_RESERVA(CODIGO_RESERVA, CODIGO_CLIENTE)
SELECT DISTINCT Reserva_Codigo, CODIGO_CLIENTE
FROM gd_esquema.Maestra JOIN LOS_MAGIOS.CLIENTES ON (IDENTIFICACION = Cliente_Pasaporte_Nro AND (Cliente_Apellido + 
			Cliente_Nombre) = (APELLIDO + NOMBRE ))