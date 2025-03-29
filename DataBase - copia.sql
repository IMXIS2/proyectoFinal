--Creacion de la base de datos
create database Prestamos

--[Notas]--
-- tenemos de tablas:
--				Historial Crediticio, cuenta, clientes , prestamos, garantias y pagos

--Creacion de la tabla HIstorial de credito
CREATE TABLE Historial_Crediticio (
    id_historial INT PRIMARY KEY,
    id_cliente INT,
    fecha_reporte DATE,
    puntuacion_crediticia INT,
    comentarios varchar(300)
);

--Creacion de la tabla Cuenta
CREATE TABLE Cuenta (
	id_cuenta int primary key not null,
	Tipo_Cuenta varchar(50),
	fecha_Apertura date, 
	Limite_crediticio varchar(200),
	Saldo_Actual decimal,
	Id_historial int references Historial_Crediticio(id_historial),
	Estado bit
);

--Creacion de tabla clientes
CREATE TABLE Clientes (
    Identificacion varchar(100) PRIMARY KEY not null,
    primer_nombre VARCHAR(100),
	segundo_nombre VARCHAR(100),
    primer_apellido VARCHAR(100),
	segundo_apellido varchar(100),
	id_cuenta int references Cuenta(id_cuenta)
);

--Normalizacion de la tabla contacto
CREATE TABLE Tipo_contacto (
tipo_C int primary key not null,
nombre varchar(100),
identificacion varchar(100) references Clientes(identificacion)
);

CREATE TABLE contacto (
id_C int primary key not null,
contacto varchar(200),
identificacion varchar(100) references Clientes(identificacion)
)

--Creacion de la tabla direcciones
CREATE TABLE direcciones(
	id_cliente varchar(100) references Clientes(identificacion),
	id_direccion int primary key,
	latitud decimal(9,6),
	longitud decimal(9,6)
);

--Creacion de la tabla Prestamos
CREATE TABLE Prestamos (
    id_prestamo INT PRIMARY KEY,
    id_cliente varchar(100) references clientes(identificacion),
    monto DECIMAL(10, 2),
    tasa_interes DECIMAL(5, 2),
    fecha_solicitud DATE,
    fecha_aprobacion DATE,
    estado Bit
);

--Creacion de la tabla Pagos
CREATE TABLE Pagos (
    id_pago INT PRIMARY KEY,
    id_prestamo INT REFERENCES Prestamos(id_prestamo),
    monto DECIMAL(10, 2),
    fecha_pago DATE,
    metodo_pago VARCHAR(50),
);

--Creacion de la tabla Garantia
CREATE TABLE Garantias (
    id_garantia INT PRIMARY KEY,
    id_prestamo INT REFERENCES Prestamos(id_prestamo),
    tipo_garantia VARCHAR(100),
    valor DECIMAL(10, 2),
    descripcion varchar(200)
);
