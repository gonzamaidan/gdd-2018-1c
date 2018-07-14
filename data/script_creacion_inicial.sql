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
	PORCENTAJE NUMERIC(18,2) NOT NULL,
	CANTIDAD_PERSONAS INTEGER NOT NULL
)


-- ## CREACION TABLA HABITACIONES
CREATE TABLE LOS_MAGIOS.HABITACIONES(
	ID_HOTEL INTEGER FOREIGN KEY REFERENCES LOS_MAGIOS.HOTELES(ID_HOTEL),
	NUMERO_HABITACION INTEGER,
	PISO INTEGER,
	UBICACION VARCHAR(10),
	CODIGO_TIPO_HABITACION INTEGER REFERENCES LOS_MAGIOS.TIPOS_HABITACION(CODIGO_TIPO_HABITACION),
	HABILITADO BIT DEFAULT 1
	PRIMARY KEY(ID_HOTEL, NUMERO_HABITACION)
) 


CREATE TABLE LOS_MAGIOS.TIPOS_IDENTIFICACION (
	TIPO_IDENTIFICACION INTEGER IDENTITY(1,1) PRIMARY KEY,
	DESCRIPCION VARCHAR(50)
)

CREATE TABLE LOS_MAGIOS.USUARIOS(
	USUARIO VARCHAR(50) PRIMARY KEY,
	CONTRASENA VARCHAR(100) NOT NULL,
	NOMBRE VARCHAR (50) NOT NULL,
	APELLIDO VARCHAR (50) NOT NULL,
	MAIL VARCHAR(50) NOT NULL,
	TELEFONO INTEGER NOT NULL,
	DIRECCION VARCHAR(100) NOT NULL,
	FECHA_DE_NACIMIENTO DATE NOT NULL,
	IDENTIFICACION INT NOT NULL,
	TIPO_IDENTIFICACION INT REFERENCES LOS_MAGIOS.TIPOS_IDENTIFICACION(TIPO_IDENTIFICACION),
	ESTADO BIT NOT NULL DEFAULT(1)
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
	FECHA_EGRESO DATE NULL,
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
	FORMA_DE_PAGO VARCHAR(20) NULL,
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
	DUPLICADO BIT DEFAULT 0,
	HABILITADO BIT DEFAULT 1
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

CREATE TABLE LOS_MAGIOS.FORMAS_DE_PAGO(	
	CODIGO_PAGO INTEGER PRIMARY KEY,	
	DESCRIPCION_PAGO VARCHAR(50) NOT NULL	
)	
	
CREATE TABLE LOS_MAGIOS.ITEM_PAGO(	
	CODIGO_PAGO INTEGER REFERENCES LOS_MAGIOS.FORMAS_DE_PAGO(CODIGO_PAGO)NOT NULL,	
	NUMERO_FACTURA INTEGER REFERENCES LOS_MAGIOS.FACTURA(NUMERO_FACTURA),	
	NUMERO_TARJETA VARCHAR(16) NULL,	
	VENCIMIENTO_TARJETA VARCHAR(7) NULL,	
	PRIMARY KEY (NUMERO_FACTURA)	
)	
GO

-- # INSERT DE TABLAS
INSERT INTO LOS_MAGIOS.TIPOS_IDENTIFICACION(DESCRIPCION) VALUES('Pasaporte'),('DNI');

-- ## INSERT TABLA REGIMENES
INSERT INTO LOS_MAGIOS.REGIMENES(DESCRIPCION, PRECIO_DOLARES)
SELECT DISTINCT Regimen_Descripcion, Regimen_Precio
FROM gd_esquema.Maestra

-- ## INSERT TABLA HOTELES
INSERT INTO LOS_MAGIOS.HOTELES(NOMBRE, PAIS, CIUDAD, DIRECCION, ESTRELLAS) 
select distinct LTRIM(RTRIM(Hotel_Ciudad)) + ' ' + LTRIM(RTRIM(Hotel_Calle)), 'ARGENTINA' , LTRIM(RTRIM(Hotel_Ciudad)), LTRIM(RTRIM(Hotel_Calle)) + ' ' + LTRIM(RTRIM((STR(Hotel_Nro_Calle)))), Hotel_CantEstrella
from gd_esquema.Maestra 
order by LTRIM(RTRIM(Hotel_Ciudad))

-- ## INSERT TABLA REGIMENES_POR_HOTEL
INSERT INTO LOS_MAGIOS.REGIMENES_POR_HOTEL
SELECT distinct ID_HOTEL, CODIGO_REGIMEN
FROM LOS_MAGIOS.HOTELES, LOS_MAGIOS.REGIMENES;

-- # INSERT TABLA TIPOS_HABITACION
INSERT INTO LOS_MAGIOS.TIPOS_HABITACION(CODIGO_TIPO_HABITACION, DESCRIPCION_TIPO_HABITACION, PORCENTAJE, CANTIDAD_PERSONAS)
SELECT DISTINCT Habitacion_Tipo_Codigo, Habitacion_Tipo_Descripcion, Habitacion_Tipo_Porcentual, Habitacion_Tipo_Codigo - 1000
FROM gd_esquema.Maestra

-- # INSERT TABLA HABITACIONES
INSERT INTO LOS_MAGIOS.HABITACIONES(NUMERO_HABITACION, PISO, UBICACION, CODIGO_TIPO_HABITACION, ID_HOTEL)
select distinct Habitacion_Numero, Habitacion_Piso, LOS_MAGIOS.FRENTE_TO_UBICACION(Habitacion_Frente), Habitacion_Tipo_Codigo, ID_HOTEL
from gd_esquema.Maestra JOIN LOS_MAGIOS.HOTELES ON LTRIM(RTRIM(Hotel_Calle)) + ' ' + LTRIM(RTRIM(STR(Hotel_Nro_Calle))) = DIRECCION

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
FROM gd_esquema.Maestra JOIN LOS_MAGIOS.HOTELES ON LTRIM(RTRIM(Hotel_Calle)) + ' ' + LTRIM(RTRIM(STR(Hotel_Nro_Calle))) = DIRECCION
ORDER BY Reserva_Codigo

INSERT INTO LOS_MAGIOS.CLIENTES(IDENTIFICACION, TIPO_IDENTIFICACION, APELLIDO, NOMBRE, FECHA_NACIMIENTO, NACIONALIDAD, MAIL, DIRECCION) (
SELECT DISTINCT Cliente_Pasaporte_Nro, 1, Cliente_Apellido, Cliente_Nombre, Cliente_Fecha_Nac, Cliente_Nacionalidad, Cliente_Mail, Cliente_Dom_Calle + ' ' + STR(Cliente_Nro_Calle) + ' ' + STR(Cliente_Piso) + ' ' + Cliente_Depto
FROM gd_esquema.Maestra
);

UPDATE LOS_MAGIOS.CLIENTES
SET DUPLICADO = 1,
	HABILITADO = 0 
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

INSERT INTO LOS_MAGIOS.CONSUMIBLES(CODIGO_CONSUMIBLE, DESCRIPCION, PRECIO_CONSUMIBLE) VALUES (1,'Beneficio All-Inclusive',0);

INSERT INTO LOS_MAGIOS.CONSUMIBLES(CODIGO_CONSUMIBLE, DESCRIPCION, PRECIO_CONSUMIBLE)
SELECT DISTINCT Consumible_Codigo, Consumible_Descripcion, Consumible_Precio
FROM gd_esquema.Maestra
WHERE Consumible_Codigo IS NOT NULL

INSERT INTO LOS_MAGIOS.FACTURA(CODIGO_RESERVA,FECHA_FACTURA, NUMERO_FACTURA, TOTAL_FACTURA)
SELECT DISTINCT Reserva_Codigo, Factura_Fecha, Factura_Nro, Factura_Total
FROM gd_esquema.Maestra
WHERE Factura_Nro IS NOT NULL

INSERT INTO LOS_MAGIOS.ITEM_FACTURA(PRECIO_UNIDAD, CANTIDAD, CODIGO_CONSUMIBLE, NUMERO_FACTURA)
SELECT Item_Factura_Cantidad, Item_Factura_Monto, Consumible_Codigo, Factura_Nro
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

INSERT INTO LOS_MAGIOS.ROLES(NOMBRE,ESTADO) VALUES
('ADMINISTRADOR',1),
('RECEPCIONISTA',1),
('GUEST',1)

--Ver si vale la pena aceptar en todos los campos nulos, para no tener que completar todos los datos en este insert.					   
INSERT INTO LOS_MAGIOS.USUARIOS(USUARIO,NOMBRE,CONTRASENA, APELLIDO, MAIL, TELEFONO, DIRECCION, FECHA_DE_NACIMIENTO,TIPO_IDENTIFICACION, IDENTIFICACION) VALUES
('admin','admin',HASHBYTES('SHA2_256','admin'), 'admin', 'admin@admin.com', '48638459', 'Admin 458 9D', DATEFROMPARTS (1993,03,14), 1, 0),

('guest','',HASHBYTES('SHA2_256','0'), '', '', '', '', DATEFROMPARTS (1993,03,14), 1, 1);					   

INSERT INTO LOS_MAGIOS.ROLES_POR_USUARIO(USUARIO,ID_ROL) VALUES
('admin',1),	

('guest', 3);


INSERT INTO LOS_MAGIOS.FUNCIONALIDADES(DESCRIPCION) VALUES
('ABM Clientes'),
('ABM Hoteles'),
('ABM Rol'),
('ABM Usuario'),
('Cancelar reserva'),
('Generar Reserva'),
('Modificar Reserva'),
('Listado estadistico'),
('Registrar consumible'),
('Registrar estadia'),
('Facturar estadia');

INSERT INTO LOS_MAGIOS.FUNCIONALIDADES_POR_ROL(ID_ROL,ID_FUNCIONALIDAD) VALUES
(1,1),
(1,2),
(1,3),
(1,4),
(1,5),
(1,6),
(1,7),
(1,8),
(1,9),
(1,10),
(1,11),
(2,1),
(2,5),
(2,6),
(2,7),
(2,8),
(2,9),
(2,10),
(2,11),
(3,5),
(3,6),
(3,7);
INSERT LOS_MAGIOS.HOTELES_POR_USUARIO(ID_HOTEL,USUARIO) 
SELECT ID_HOTEL, 'admin' FROM LOS_MAGIOS.HOTELES

INSERT INTO LOS_MAGIOS.FORMAS_DE_PAGO(CODIGO_PAGO, DESCRIPCION_PAGO) VALUES
(1,'Efectivo'),
(2,'Tarjeta de Debito'),
(3,'Tarjeta de Credito');
GO

CREATE FUNCTION LOS_MAGIOS.INCREMENTO_POR_ESTRELLAS(@ESTRELLAS INT) 
RETURNS INTEGER
AS BEGIN
	RETURN @ESTRELLAS * 10
END
GO

CREATE FUNCTION LOS_MAGIOS.PRECIO_HABITACION(@PRECIO_REGIMEN NUMERIC, @CANTIDAD_PERSONAS INT, @ESTRELLAS INT)
RETURNS NUMERIC(18,2)
AS BEGIN
	RETURN @PRECIO_REGIMEN * @CANTIDAD_PERSONAS + LOS_MAGIOS.INCREMENTO_POR_ESTRELLAS(@ESTRELLAS)
END
GO	 

CREATE FUNCTION LOS_MAGIOS.DAR_DISPONIBILIDAD_CON_REGIMEN(@FECHA_DESDE DATE, @FECHA_HASTA DATE, @CODIGO_REGIMEN INTEGER, @CANTIDAD_PERSONAS INTEGER)
RETURNS TABLE
AS 
	RETURN SELECT DISTINCT	HT.ID_HOTEL,
							HT.NOMBRE, 
							H.NUMERO_HABITACION, 
							H.PISO, H.UBICACION, 
							LOS_MAGIOS.PRECIO_HABITACION(RG.PRECIO_DOLARES, @CANTIDAD_PERSONAS, HT.ESTRELLAS) AS PRECIO_HABITACION
	FROM LOS_MAGIOS.HABITACIONES H,
		 LOS_MAGIOS.HOTELES HT,
		 LOS_MAGIOS.REGIMENES_POR_HOTEL RH,
		 LOS_MAGIOS.REGIMENES RG,
		 LOS_MAGIOS.TIPOS_HABITACION TH
	WHERE 
		HT.ID_HOTEL = H.ID_HOTEL 
		AND HT.ID_HOTEL = RH.ID_HOTEL
		AND RG.CODIGO_REGIMEN = RH.CODIGO_REGIMEN
		AND RG.CODIGO_REGIMEN = @CODIGO_REGIMEN
		AND H.CODIGO_TIPO_HABITACION = TH.CODIGO_TIPO_HABITACION
		AND TH.CANTIDAD_PERSONAS = @CANTIDAD_PERSONAS
		AND H.HABILITADO = 1
		AND NOT EXISTS ( 
			SELECT 1 
			FROM 
				LOS_MAGIOS.HABITACIONES_POR_RESERVA HR,
				LOS_MAGIOS.RESERVAS R, 
				LOS_MAGIOS.ESTADOS_RESERVA ER
			WHERE
				H.ID_HOTEL = HR.ID_HOTEL 
				AND H.NUMERO_HABITACION = HR.NUMERO_HABITACION 
				AND R.CODIGO_RESERVA = HR.CODIGO_RESERVA 
				AND R.ID_ESTADO_RESERVA = ER.ID_ESTADO_RESERVA 
				AND ER.DESCRIPCION_ESTADO_RESERVA NOT IN ('CANCELADA-NO-SHOW','CANCELADA-CLIENTE', 'CANCELADA-RECEPCION')
				AND (
					R.FECHA_DESDE BETWEEN @FECHA_DESDE AND @FECHA_HASTA OR 
					R.FECHA_HASTA BETWEEN @FECHA_DESDE AND @FECHA_HASTA OR
					@FECHA_DESDE BETWEEN R.FECHA_DESDE AND R.FECHA_HASTA OR
					@FECHA_HASTA BETWEEN R.FECHA_DESDE AND R.FECHA_HASTA
					)
			)
			AND HT.ID_HOTEL NOT IN 
			(
				SELECT ID_HOTEL FROM LOS_MAGIOS.BAJA_HOTELES
				WHERE 
					
					FECHA_INICIO_BAJA BETWEEN @FECHA_DESDE AND @FECHA_HASTA OR 
					FECHA_FIN_BAJA BETWEEN @FECHA_DESDE AND @FECHA_HASTA OR
					@FECHA_DESDE BETWEEN FECHA_INICIO_BAJA AND FECHA_FIN_BAJA OR
					@FECHA_HASTA BETWEEN FECHA_INICIO_BAJA AND FECHA_FIN_BAJA
					
			)
		
GO

CREATE FUNCTION LOS_MAGIOS.DAR_DISPONIBILIDAD_SIN_REGIMEN(@FECHA_DESDE DATE, @FECHA_HASTA DATE, @CANTIDAD_PERSONAS INTEGER)
RETURNS TABLE
AS 
	RETURN SELECT DISTINCT	HT.ID_HOTEL,
							HT.NOMBRE,
							H.NUMERO_HABITACION, 
							H.PISO,
							H.UBICACION,
							RG.DESCRIPCION as REGIMEN, 
							LOS_MAGIOS.PRECIO_HABITACION(RG.PRECIO_DOLARES, @CANTIDAD_PERSONAS, HT.ESTRELLAS) AS PRECIO_HABITACION,
							RG.CODIGO_REGIMEN							
	FROM LOS_MAGIOS.HABITACIONES H,
		 LOS_MAGIOS.HOTELES HT,
		 LOS_MAGIOS.REGIMENES_POR_HOTEL RH,
		 LOS_MAGIOS.REGIMENES RG,
		 LOS_MAGIOS.TIPOS_HABITACION TH
	WHERE 
		HT.ID_HOTEL = H.ID_HOTEL 
		AND HT.ID_HOTEL = RH.ID_HOTEL
		AND RG.CODIGO_REGIMEN = RH.CODIGO_REGIMEN
		AND H.CODIGO_TIPO_HABITACION = TH.CODIGO_TIPO_HABITACION
		AND TH.CANTIDAD_PERSONAS = @CANTIDAD_PERSONAS
		AND H.HABILITADO = 1
		AND NOT EXISTS ( 
			SELECT 1 
			FROM 
				LOS_MAGIOS.HABITACIONES_POR_RESERVA HR,
				LOS_MAGIOS.RESERVAS R, 
				LOS_MAGIOS.ESTADOS_RESERVA ER
			WHERE
				H.ID_HOTEL = HR.ID_HOTEL 
				AND H.NUMERO_HABITACION = HR.NUMERO_HABITACION 
				AND R.CODIGO_RESERVA = HR.CODIGO_RESERVA 
				AND R.ID_ESTADO_RESERVA = ER.ID_ESTADO_RESERVA 
				AND ER.DESCRIPCION_ESTADO_RESERVA NOT IN ('CANCELADA-NO-SHOW','CANCELADA-CLIENTE', 'CANCELADA-RECEPCION')
				AND (
					R.FECHA_DESDE BETWEEN @FECHA_DESDE AND @FECHA_HASTA OR 
					R.FECHA_HASTA BETWEEN @FECHA_DESDE AND @FECHA_HASTA OR
					@FECHA_DESDE BETWEEN R.FECHA_DESDE AND R.FECHA_HASTA OR
					@FECHA_HASTA BETWEEN R.FECHA_DESDE AND R.FECHA_HASTA
					)
			)
		AND HT.ID_HOTEL NOT IN 
		(
			SELECT ID_HOTEL FROM LOS_MAGIOS.BAJA_HOTELES
			WHERE 
					
				FECHA_INICIO_BAJA BETWEEN @FECHA_DESDE AND @FECHA_HASTA OR 
				FECHA_FIN_BAJA BETWEEN @FECHA_DESDE AND @FECHA_HASTA OR
				@FECHA_DESDE BETWEEN FECHA_INICIO_BAJA AND FECHA_FIN_BAJA OR
				@FECHA_HASTA BETWEEN FECHA_INICIO_BAJA AND FECHA_FIN_BAJA
					
		)
GO
