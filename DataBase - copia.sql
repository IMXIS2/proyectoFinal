-- Creación de la base de datos
CREATE DATABASE Prestamos;
USE Prestamos;

-- Creación de la tabla Clientes
CREATE TABLE Clientes (
    Identificacion VARCHAR(100) PRIMARY KEY NOT NULL,
    primer_nombre VARCHAR(100),
    segundo_nombre VARCHAR(100),
    primer_apellido VARCHAR(100),
    segundo_apellido VARCHAR(100)
);

-- Creación de la tabla Cuenta
CREATE TABLE Cuenta (
    id_cuenta INT PRIMARY KEY NOT NULL,
    Identificacion VARCHAR(100) NOT NULL,
    Tipo_Cuenta VARCHAR(50),
    fecha_Apertura DATE, 
    Limite_crediticio VARCHAR(200),
    Saldo_Actual DECIMAL(10,2),
    Estado BIT,
    FOREIGN KEY (Identificacion) REFERENCES Clientes(Identificacion) ON DELETE CASCADE
);

-- Creación de la tabla Historial_Crediticio
CREATE TABLE Historial_Crediticio (
    id_historial INT PRIMARY KEY NOT NULL,
    id_cuenta INT NOT NULL,
    fecha_reporte DATE,
    puntuacion_crediticia INT,
    comentarios VARCHAR(300),
    FOREIGN KEY (id_cuenta) REFERENCES Cuenta(id_cuenta) ON DELETE CASCADE
);

-- Creación de la tabla Tipo_contacto
CREATE TABLE Tipo_contacto (
    tipo_C INT PRIMARY KEY NOT NULL,
    nombre VARCHAR(100),
    identificacion VARCHAR(100) NOT NULL,
    FOREIGN KEY (identificacion) REFERENCES Clientes(Identificacion) ON DELETE CASCADE
);

-- Creación de la tabla Contacto
CREATE TABLE Contacto (
    id_C INT PRIMARY KEY NOT NULL,
    contacto VARCHAR(200),
    identificacion VARCHAR(100) NOT NULL,
    FOREIGN KEY (identificacion) REFERENCES Clientes(Identificacion) ON DELETE CASCADE
);

-- Creación de la tabla Direcciones
CREATE TABLE Direcciones (
    id_direccion INT PRIMARY KEY NOT NULL,
    id_cliente VARCHAR(100) NOT NULL,
    latitud DECIMAL(9,6),
    longitud DECIMAL(9,6),
    FOREIGN KEY (id_cliente) REFERENCES Clientes(Identificacion) ON DELETE CASCADE
);

-- Creación de la tabla Prestamos
CREATE TABLE Prestamos (
    id_prestamo INT PRIMARY KEY NOT NULL,
    id_cuenta INT NOT NULL,
    monto DECIMAL(10,2),
    tasa_interes DECIMAL(5,2),
    fecha_solicitud DATE,
    fecha_aprobacion DATE,
    estado BIT,
    FOREIGN KEY (id_cuenta) REFERENCES Cuenta(id_cuenta) ON DELETE CASCADE
);

-- Creación de la tabla Pagos
CREATE TABLE Pagos (
    id_pago INT PRIMARY KEY NOT NULL,
    id_prestamo INT NOT NULL,
    monto DECIMAL(10,2),
    fecha_pago DATE,
    metodo_pago VARCHAR(50),
    FOREIGN KEY (id_prestamo) REFERENCES Prestamos(id_prestamo) ON DELETE CASCADE
);

-- Creación de la tabla Garantias
CREATE TABLE Garantias (
    id_garantia INT PRIMARY KEY NOT NULL,
    id_prestamo INT NOT NULL,
    tipo_garantia VARCHAR(100),
    valor DECIMAL(10,2),
    descripcion VARCHAR(200),
    FOREIGN KEY (id_prestamo) REFERENCES Prestamos(id_prestamo) ON DELETE CASCADE
);
