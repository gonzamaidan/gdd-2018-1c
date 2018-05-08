-- HOTELES

/*select distinct Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella
from gd_esquema.Maestra 
order by Hotel_Ciudad;

-- HABITACION POR HOTEL

select distinct Habitacion_Numero, Habitacion_Piso, Habitacion_Frente, Habitacion_Tipo_Codigo, Habitacion_Tipo_Descripcion, Habitacion_Tipo_Porcentual, Hotel_Calle
from gd_esquema.Maestra
order by Hotel_Calle, Habitacion_Numero;

-- TIPOS DE HABITACION
select distinct Habitacion_Tipo_Codigo, Habitacion_Tipo_Descripcion, Habitacion_Tipo_Porcentual
from gd_esquema.Maestra
*/
-- CLIENTES
--SELECT distinct Cliente_Mail, Cliente_Pasaporte_Nro from gd_esquema.Maestra

--select * from gd_esquema.Maestra where Cliente_Mail = 'aaron_Castillo@gmail.com'order by Hotel_Ciudad
/*select distinct Cliente_Pasaporte_Nro, Cliente_Mail, Cliente_Nacionalidad from gd_esquema.Maestra
where Cliente_Nacionalidad not like 'ARGENTINO' and 
order by Cliente_Pasaporte_Nro*/
