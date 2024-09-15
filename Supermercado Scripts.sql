--Crear las entidades
CREATE TABLE Cliente(
    id_cliente INT IDENTITY(1,1) PRIMARY KEY,
    cedula_cliente CHAR(9) NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    sexo CHAR(1) NOT NULL,
);

CREATE TABLE Departamento(
    id_dept INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(30) NOT NULL
);

CREATE TABLE Gerente(
    id_gerente INT IDENTITY(1,1) PRIMARY KEY,
    cedula CHAR(9) NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    departamento_gerente INTEGER NOT NULL,
    FOREIGN KEY (departamento_gerente) REFERENCES departamento (id_dept)
);

CREATE TABLE Sucursal(
    id_sucursal INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    direccion VARCHAR(50) NOT NULL,
    telefono CHAR(8) NOT NULL,
    id_gerente INTEGER,
    FOREIGN KEY (id_gerente) REFERENCES gerente (id_gerente)
);

CREATE TABLE Cajero(
    id_cajero INT IDENTITY(1,1) PRIMARY KEY,
    cedula CHAR(9) NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    id_sucursal INT NOT NULL,
    FOREIGN KEY (id_sucursal) REFERENCES sucursal (id_sucursal)
);

CREATE TABLE Caja(
    id_caja INT IDENTITY(1,1) PRIMARY KEY,
    id_cajero INT,
    estado VARCHAR(7) NOT NULL,
    FOREIGN KEY (id_cajero) REFERENCES Cajero(id_cajero)
);

CREATE TABLE Proveedor(
    id_prov INT IDENTITY(1,1) PRIMARY KEY,
    nombre_proveedor VARCHAR(50) NOT NULL,
    contacto VARCHAR(30) NOT NULL, --numero de telefono o correo
    tipo_proveedor VARCHAR(50) NOT NULL
);

CREATE TABLE Articulo(
    id_articulo INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(40) NOT NULL,
    categoria VARCHAR(30) NOT NULL,
    precio INTEGER NOT NULL,
    id_proveedor INT NOT NULL,
    FOREIGN KEY (id_proveedor) REFERENCES Proveedor(id_prov)
);

CREATE TABLE Pedido(
    id_pedido INT IDENTITY(1,1) PRIMARY KEY,
    fecha_pedido DATE NOT NULL,
    hora_pedido TIME NOT NULL,  
    id_cliente INTEGER NOT NULL,
    id_cajero INTEGER NOT NULL,
    id_articulo INTEGER NOT NULL,
    cantidad_articulo INTEGER NOT NULL,
    FOREIGN KEY (id_cliente) REFERENCES Cliente(id_cliente),
    FOREIGN KEY (id_cajero) REFERENCES Cajero(id_cajero),
    FOREIGN KEY (id_articulo) REFERENCES Articulo(id_articulo)
);

CREATE TABLE Factura(
    id_factura INT IDENTITY(1,1) PRIMARY KEY,
    fecha_factura DATE NOT NULL,
    hora_factura TIME NOT NULL,
    id_pedido INTEGER NOT NULL,
    id_cliente INTEGER NOT NULL,
    precio_total INTEGER NOT NULL,
    FOREIGN KEY (id_pedido) REFERENCES Pedido(id_pedido),
    FOREIGN KEY (id_cliente) REFERENCES Cliente(id_cliente)
);

CREATE TABLE Estanteria(
    id_estanteria INT IDENTITY(1,1) PRIMARY KEY,
    capacidad INTEGER NOT NULL,
    categoria_productos VARCHAR(30) NOT NULL,
);

CREATE TABLE Inventario(
    id_articulo INTEGER NOT NULL,
    cantidad INTEGER NOT NULL,
    FOREIGN KEY (id_articulo) REFERENCES articulo (id_articulo)
);

CREATE TABLE Pasillo(
    id_pasillo INT IDENTITY(1,1) PRIMARY KEY,
    estanteria_pasillo INTEGER NOT NULL,
    FOREIGN KEY (estanteria_pasillo) REFERENCES estanteria (id_estanteria)
);

CREATE TABLE Marca(
    id_marca INT IDENTITY(1,1) PRIMARY KEY,
    nombre_marca VARCHAR(30) NULL
);


--Insertar datos en las tablas

--clientes
INSERT INTO Cliente (cedula_cliente, nombre, sexo) VALUES ('123456789', 'Juan Perez', 'M');
INSERT INTO Cliente (cedula_cliente, nombre, sexo) VALUES ('241064230', 'Maria Lopez', 'F');
INSERT INTO Cliente (cedula_cliente, nombre, sexo) VALUES ('394028592', 'Alberto Zamora', 'M');
INSERT INTO Cliente (cedula_cliente, nombre, sexo) VALUES ('456789456', 'Diego Gomez', 'M');
INSERT INTO Cliente (cedula_cliente, nombre, sexo) VALUES ('123000789', 'Lucia Rojas', 'F');
INSERT INTO Cliente (cedula_cliente, nombre, sexo) VALUES ('133582677', 'Gerardo Sanchez', 'M');
INSERT INTO Cliente (cedula_cliente, nombre, sexo) VALUES ('363339069', 'Mateo Maidana', 'M');
INSERT INTO Cliente (cedula_cliente, nombre, sexo) VALUES ('610798327', 'Rafael Ulloa', 'M');
INSERT INTO Cliente (cedula_cliente, nombre, sexo) VALUES ('689010991', 'Pablo Esquivel', 'M');
INSERT INTO Cliente (cedula_cliente, nombre, sexo) VALUES ('236111527', 'Andrea Matamoros', 'F');
INSERT INTO Cliente (cedula_cliente, nombre, sexo) VALUES ('127895528', 'Oscar Perez', 'M');
INSERT INTO Cliente (cedula_cliente, nombre, sexo) VALUES ('752812845', 'Fabian Vargas', 'M');
INSERT INTO Cliente (cedula_cliente, nombre, sexo) VALUES ('135200482', 'Samuel Solano', 'M');
INSERT INTO Cliente (cedula_cliente, nombre, sexo) VALUES ('782913649', 'Xinia Castro', 'F');
INSERT INTO Cliente (cedula_cliente, nombre, sexo) VALUES ('532954614', 'Gabriel Hernandez', 'M');
INSERT INTO Cliente (cedula_cliente, nombre, sexo) VALUES ('123456479', 'Juan Pou', 'M');
INSERT INTO Cliente (cedula_cliente, nombre, sexo) VALUES ('345789164', 'Mario Antonio', 'M');

--departamentos
INSERT INTO Departamento(nombre) VALUES ('Alimentos');
INSERT INTO Departamento(nombre) VALUES ('Bebidas');
INSERT INTO Departamento(nombre) VALUES ('Limpieza');
INSERT INTO Departamento(nombre) VALUES ('Higiene personal');
INSERT INTO Departamento(nombre) VALUES ('Carnes');
INSERT INTO Departamento(nombre) VALUES ('Frutas y verduras');
INSERT INTO Departamento(nombre) VALUES ('Lacteos');
INSERT INTO Departamento(nombre) VALUES ('Cereales');
INSERT INTO Departamento(nombre) VALUES ('Panes y galletas');
INSERT INTO Departamento(nombre) VALUES ('Administracion');
INSERT INTO Departamento(nombre) VALUES ('Cuidado del hogar');
INSERT INTO Departamento(nombre) VALUES ('Embutidos');
INSERT INTO Departamento(nombre) VALUES ('Pescados y mariscos');
INSERT INTO Departamento(nombre) VALUES ('Comidas congeladas');
INSERT INTO Departamento(nombre) VALUES ('Bebidas alcoholicas');

--marcas
INSERT INTO Marca(nombre_marca) VALUES ('Pepsi');
INSERT INTO Marca(nombre_marca) VALUES ('Coca Cola');
INSERT INTO Marca(nombre_marca) VALUES ('Pantene');
INSERT INTO Marca(nombre_marca) VALUES ('Dove');
INSERT INTO Marca(nombre_marca) VALUES ('Colgate');
INSERT INTO Marca(nombre_marca) VALUES ('Palmolive');
INSERT INTO Marca(nombre_marca) VALUES ('Imperial');
INSERT INTO Marca(nombre_marca) VALUES ('Nesquik');
INSERT INTO Marca(nombre_marca) VALUES ('Kimby');
INSERT INTO Marca(nombre_marca) VALUES ('Dos Pinos');
INSERT INTO Marca(nombre_marca) VALUES ('Zaragoza');
INSERT INTO Marca(nombre_marca) VALUES ('El Arreo');
INSERT INTO Marca(nombre_marca) VALUES ('Don Cristobal');
INSERT INTO Marca(nombre_marca) VALUES ('Great Value');
INSERT INTO Marca(nombre_marca) VALUES ('La Costeña');

--proveedores
INSERT INTO Proveedor(nombre_proveedor, contacto, tipo_proveedor) VALUES ('Yema Dorada', '41031155', 'Nacional');
INSERT INTO Proveedor(nombre_proveedor, contacto, tipo_proveedor) VALUES ('Nomada Fruit Company', 'www.nomadafruit.com', 'Nacional');
INSERT INTO Proveedor(nombre_proveedor, contacto, tipo_proveedor) VALUES ('Andean Terra', 'www.andeanterra.bio', 'Internacional');
INSERT INTO Proveedor(nombre_proveedor, contacto, tipo_proveedor) VALUES ('COAMESA','25499200', 'Internacional');
INSERT INTO Proveedor(nombre_proveedor, contacto, tipo_proveedor) VALUES ('Coca Cola', 'www.cocacola.com', 'Internacional');
INSERT INTO Proveedor(nombre_proveedor, contacto, tipo_proveedor) VALUES ('Pepsi', 'www.pepsi.com', 'Internacional');
INSERT INTO Proveedor(nombre_proveedor, contacto, tipo_proveedor) VALUES ('Palmolive', 'www.palmolive.com', 'Internacional');
INSERT INTO Proveedor(nombre_proveedor, contacto, tipo_proveedor) VALUES ('Colgate', 'www.colgate.com', 'Internacional');
INSERT INTO Proveedor(nombre_proveedor, contacto, tipo_proveedor) VALUES ('Dove', 'www.dove.com', 'Internacional');
INSERT INTO Proveedor(nombre_proveedor, contacto, tipo_proveedor) VALUES ('Pantene', 'www.pantene.com', 'Internacional');
INSERT INTO Proveedor(nombre_proveedor, contacto, tipo_proveedor) VALUES ('Kimby', 'www.kimby.com', 'Internacional');
INSERT INTO Proveedor(nombre_proveedor, contacto, tipo_proveedor) VALUES ('Nesquik', 'www.nesquik.com', 'Internacional');
INSERT INTO Proveedor(nombre_proveedor, contacto, tipo_proveedor) VALUES ('Dos Pinos', 'www.dospinos.com', 'Nacional');
INSERT INTO Proveedor(nombre_proveedor, contacto, tipo_proveedor) VALUES ('Zaragoza', 'www.zaragoza.com', 'Internacional');
INSERT INTO Proveedor(nombre_proveedor, contacto, tipo_proveedor) VALUES ('El Arreo', 'www.elarreo.com', 'Internacional');

--articulos
INSERT INTO Articulo(nombre, categoria, precio, id_proveedor) VALUES ('Arroz Tio Pelon', 'Alimentos', 3895, 1);
INSERT INTO Articulo(nombre, categoria, precio, id_proveedor) VALUES ('Frijoles', 'Alimentos', 1470, 1);
INSERT INTO Articulo(nombre, categoria, precio, id_proveedor) VALUES ('Leche', 'Alimentos', 2600, 1);
INSERT INTO Articulo(nombre, categoria, precio, id_proveedor) VALUES ('Pan', 'Alimentos', 800, 3);
INSERT INTO Articulo(nombre, categoria, precio, id_proveedor) VALUES ('Cafe', 'Alimentos', 6750, 5);
INSERT INTO Articulo(nombre, categoria, precio, id_proveedor) VALUES ('Azucar', 'Alimentos', 3500, 2);
INSERT INTO Articulo(nombre, categoria, precio, id_proveedor) VALUES ('Sal', 'Alimentos', 700, 2);
INSERT INTO Articulo(nombre, categoria, precio, id_proveedor) VALUES ('Aceite', 'Alimentos', 1000, 5);
INSERT INTO Articulo(nombre, categoria, precio, id_proveedor) VALUES ('Galletas', 'Alimentos', 1300, 3);
INSERT INTO Articulo(nombre, categoria, precio, id_proveedor) VALUES ('Jabon', 'Limpieza', 1250, 6);
INSERT INTO Articulo(nombre, categoria, precio, id_proveedor) VALUES ('Shampoo', 'Limpieza', 1500, 6);
INSERT INTO Articulo(nombre, categoria, precio, id_proveedor) VALUES ('Cepillo', 'Limpieza', 1290, 4);
INSERT INTO Articulo(nombre, categoria, precio, id_proveedor) VALUES ('Crema dental', 'Limpieza', 4800, 9);
INSERT INTO Articulo(nombre, categoria, precio, id_proveedor) VALUES ('Papas', 'Alimentos', 1971, 3);

--gerente administrativo
INSERT INTO Gerente(cedula,nombre,departamento_gerente) VALUES ('223006119','Luis Eduardo', 10);
INSERT INTO Gerente(cedula,nombre,departamento_gerente) VALUES ('123006789','Juan Perez', 10);
INSERT INTO Gerente(cedula,nombre,departamento_gerente) VALUES ('353579267','Luis Fernando', 10);
INSERT INTO Gerente(cedula,nombre,departamento_gerente) VALUES ('520197817','Jose Tomas', 10);
INSERT INTO Gerente(cedula,nombre,departamento_gerente) VALUES ('540497298','Luis Miguel', 10);
INSERT INTO Gerente(cedula,nombre,departamento_gerente) VALUES ('469005746','Jesus Perez', 10);

--sucursales (nombre, direccion y telefono)
INSERT INTO Sucursal(nombre, direccion, telefono, id_gerente) VALUES ('San Carlos', 'Florencia, Ciudad Quesada', '24755989', 1);
INSERT INTO Sucursal(nombre, direccion, telefono, id_gerente) VALUES ('San Jose', 'San Jose', '29480030', 2);
INSERT INTO Sucursal(nombre, direccion, telefono, id_gerente) VALUES ('Cartago', 'Cartago', '24560982', 3);
INSERT INTO Sucursal(nombre, direccion, telefono, id_gerente) VALUES ('Heredia', 'Heredia', '40934591', 4);
INSERT INTO Sucursal(nombre, direccion, telefono, id_gerente) VALUES ('Alajuela', 'Alajuela', '20035478', 5);
INSERT INTO Sucursal(nombre, direccion, telefono, id_gerente) VALUES ('Limon', 'Limon', '72305222', 6);

--cajeros
INSERT INTO Cajero(cedula, nombre, id_sucursal) VALUES ('255594248', 'Juanito Espinoza', 1);
INSERT INTO Cajero(cedula, nombre, id_sucursal) VALUES ('274545447', 'Emilia Ulate', 1);
INSERT INTO Cajero(cedula, nombre, id_sucursal) VALUES ('284765655', 'Gabriela Pérez', 1);
INSERT INTO Cajero(cedula, nombre, id_sucursal) VALUES ('274784848', 'Pancrasio Fernandez', 2);
INSERT INTO Cajero(cedula, nombre, id_sucursal) VALUES ('221402548', 'Elizabet Nuñez', 3);
INSERT INTO Cajero(cedula, nombre, id_sucursal) VALUES ('217886735', 'Cristian Tórres', 4);
INSERT INTO Cajero(cedula, nombre, id_sucursal) VALUES ('204112345', 'Luis Porras', 5);
INSERT INTO Cajero(cedula, nombre, id_sucursal) VALUES ('273709543', 'Jefferson Gutierritos', 6);
INSERT INTO Cajero(cedula, nombre, id_sucursal) VALUES ('473454789', 'Sebastian Rodriguez', 4);
INSERT INTO Cajero(cedula, nombre, id_sucursal) VALUES ('173454789', 'Mauricio Gutierrez', 1);

--cajas
INSERT INTO Caja(id_cajero, estado) VALUES (1, 'Abierta');
INSERT INTO Caja(id_cajero, estado) VALUES (2, 'Abierta');
INSERT INTO Caja(id_cajero, estado) VALUES (3, 'Abierta');
INSERT INTO Caja(id_cajero, estado) VALUES (4, 'Cerrada');
INSERT INTO Caja(id_cajero, estado) VALUES (5, 'Abierta');
INSERT INTO Caja(id_cajero, estado) VALUES (6, 'Abierta');
INSERT INTO Caja(id_cajero, estado) VALUES (7, 'Abierta');
INSERT INTO Caja(id_cajero, estado) VALUES (8, 'Abierta');
INSERT INTO Caja(id_cajero, estado) VALUES (9, 'Abierta');

--estanterías
INSERT INTO Estanteria(capacidad,categoria_productos) VALUES (100, 'Bebidas');
INSERT INTO Estanteria(capacidad,categoria_productos) VALUES (125, 'Limpieza');
INSERT INTO Estanteria(capacidad,categoria_productos) VALUES (150, 'Productos enlatados');
INSERT INTO Estanteria(capacidad,categoria_productos) VALUES (110, 'Lácteos');
INSERT INTO Estanteria(capacidad,categoria_productos) VALUES (125, 'Frutas y Verduras');
INSERT INTO Estanteria(capacidad,categoria_productos) VALUES (150, 'Carnes');
INSERT INTO Estanteria(capacidad,categoria_productos) VALUES (120, 'Pescados');
INSERT INTO Estanteria(capacidad,categoria_productos) VALUES (125, 'Cereales');
INSERT INTO Estanteria(capacidad,categoria_productos) VALUES (150, 'Aceites');
INSERT INTO Estanteria(capacidad,categoria_productos) VALUES (100, 'Condimentos');
INSERT INTO Estanteria(capacidad,categoria_productos) VALUES (125, 'Productos congelados');
INSERT INTO Estanteria(capacidad,categoria_productos) VALUES (150, 'Harina y pan');
INSERT INTO Estanteria(capacidad,categoria_productos) VALUES (100, 'Abarrotes');

--Pasillos
INSERT INTO Pasillo(estanteria_pasillo) VALUES (1);
INSERT INTO Pasillo(estanteria_pasillo) VALUES (2);
INSERT INTO Pasillo(estanteria_pasillo) VALUES (3);
INSERT INTO Pasillo(estanteria_pasillo) VALUES (4);
INSERT INTO Pasillo(estanteria_pasillo) VALUES (5);
INSERT INTO Pasillo(estanteria_pasillo) VALUES (6);
INSERT INTO Pasillo(estanteria_pasillo) VALUES (7);
INSERT INTO Pasillo(estanteria_pasillo) VALUES (8);
INSERT INTO Pasillo(estanteria_pasillo) VALUES (9);
INSERT INTO Pasillo(estanteria_pasillo) VALUES (10);
INSERT INTO Pasillo(estanteria_pasillo) VALUES (11);

--Pedidos
INSERT INTO Pedido(fecha_pedido, hora_pedido, id_cliente, id_cajero, id_articulo, cantidad_articulo) VALUES ('2022-11-11', '10:20:07', 1, 1, 1, 15);
INSERT INTO Pedido(fecha_pedido, hora_pedido, id_cliente, id_cajero, id_articulo, cantidad_articulo) VALUES ('2022-11-11', '11:03:12', 2, 2, 2, 20);
INSERT INTO Pedido(fecha_pedido, hora_pedido, id_cliente, id_cajero, id_articulo, cantidad_articulo) VALUES ('2022-11-11', '12:10:45', 3, 3, 3, 20);
INSERT INTO Pedido(fecha_pedido, hora_pedido, id_cliente, id_cajero, id_articulo, cantidad_articulo) VALUES ('2022-11-11', '13:05:24', 4, 4, 4, 20);
INSERT INTO Pedido(fecha_pedido, hora_pedido, id_cliente, id_cajero, id_articulo, cantidad_articulo) VALUES ('2022-11-11', '14:20:34', 5, 5, 5, 20);
INSERT INTO Pedido(fecha_pedido, hora_pedido, id_cliente, id_cajero, id_articulo, cantidad_articulo) VALUES ('2022-11-11', '15:06:59', 6, 6, 6, 20);
INSERT INTO Pedido(fecha_pedido, hora_pedido, id_cliente, id_cajero, id_articulo, cantidad_articulo) VALUES ('2022-11-11', '16:30:59', 7, 7, 7, 20);
INSERT INTO Pedido(fecha_pedido, hora_pedido, id_cliente, id_cajero, id_articulo, cantidad_articulo) VALUES ('2022-11-11', '17:07:01', 8, 8, 8, 20);
INSERT INTO Pedido(fecha_pedido, hora_pedido, id_cliente, id_cajero, id_articulo, cantidad_articulo) VALUES ('2022-11-11', '18:40:00', 9, 1, 9, 20);
INSERT INTO Pedido(fecha_pedido, hora_pedido, id_cliente, id_cajero, id_articulo, cantidad_articulo) VALUES ('2022-11-11', '19:08:06', 10, 2, 10, 12);
INSERT INTO Pedido(fecha_pedido, hora_pedido, id_cliente, id_cajero, id_articulo, cantidad_articulo) VALUES ('2022-11-11', '20:10:07', 11, 3, 11, 12);

--Inventario
INSERT INTO Inventario(id_articulo, cantidad) VALUES (1, 50);
INSERT INTO Inventario(id_articulo, cantidad) VALUES (2, 60);
INSERT INTO Inventario(id_articulo, cantidad) VALUES (3, 50);
INSERT INTO Inventario(id_articulo, cantidad) VALUES (4, 60);
INSERT INTO Inventario(id_articulo, cantidad) VALUES (5, 40);
INSERT INTO Inventario(id_articulo, cantidad) VALUES (6, 60);
INSERT INTO Inventario(id_articulo, cantidad) VALUES (7, 70);
INSERT INTO Inventario(id_articulo, cantidad) VALUES (8, 80);
INSERT INTO Inventario(id_articulo, cantidad) VALUES (9, 90);
INSERT INTO Inventario(id_articulo, cantidad) VALUES (10, 100);
INSERT INTO Inventario(id_articulo, cantidad) VALUES (11, 110);
INSERT INTO Inventario(id_articulo, cantidad) VALUES (12, 85);
INSERT INTO Inventario(id_articulo, cantidad) VALUES (13, 80);
INSERT INTO Inventario(id_articulo, cantidad) VALUES (14, 110);

--Facturas (Año-mes-dia)
INSERT INTO Factura(fecha_factura, hora_factura, id_pedido, id_cliente, precio_total) VALUES ('2022-11-11', '10:20:07', 1, 1, 100);
INSERT INTO Factura(fecha_factura, hora_factura, id_pedido, id_cliente, precio_total) VALUES ('2022-11-11', '11:03:12', 2, 2, 200);
INSERT INTO Factura(fecha_factura, hora_factura, id_pedido, id_cliente, precio_total) VALUES ('2022-11-11', '12:10:45', 3, 3, 300);
INSERT INTO Factura(fecha_factura, hora_factura, id_pedido, id_cliente, precio_total) VALUES ('2022-11-11', '13:05:24', 4, 4, 400);
INSERT INTO Factura(fecha_factura, hora_factura, id_pedido, id_cliente, precio_total) VALUES ('2022-11-11', '14:20:34', 5, 5, 500);
INSERT INTO Factura(fecha_factura, hora_factura, id_pedido, id_cliente, precio_total) VALUES ('2022-11-11', '15:06:59', 6, 6, 600); 
INSERT INTO Factura(fecha_factura, hora_factura, id_pedido, id_cliente, precio_total) VALUES ('2022-11-11', '16:30:59', 7, 7, 700);
INSERT INTO Factura(fecha_factura, hora_factura, id_pedido, id_cliente, precio_total) VALUES ('2022-11-11', '17:07:01', 8, 8, 800);
INSERT INTO Factura(fecha_factura, hora_factura, id_pedido, id_cliente, precio_total) VALUES ('2022-11-11', '18:40:00', 9, 9, 900);
INSERT INTO Factura(fecha_factura, hora_factura, id_pedido, id_cliente, precio_total) VALUES ('2022-11-11', '19:08:06', 10, 10, 1000);
INSERT INTO Factura(fecha_factura, hora_factura, id_pedido, id_cliente, precio_total) VALUES ('2022-11-11', '20:10:07', 11, 11, 1100);

/*SELECT * FROM Articulo;
SELECT * FROM Caja;
SELECT * FROM Cajero;
SELECT * FROM Cliente;
SELECT * FROM Departamento;
SELECT * FROM Estanteria;
SELECT * FROM Factura;
SELECT * FROM Gerente;
SELECT * FROM Inventario;
SELECT * FROM Marca;
SELECT * FROM Pasillo;
SELECT * FROM Pedido;
SELECT * FROM Proveedor;
SELECT * FROM Sucursal;*/

GO

--Creación de usuarios.
--Usuario administrador.
CREATE LOGIN [admin_supermercado]
WITH PASSWORD=N'admin', 
DEFAULT_DATABASE=[Supermercado], 
CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF

CREATE USER [admin_supermercado] FOR LOGIN [admin_supermercado]
ALTER SERVER ROLE [sysadmin] ADD MEMBER [admin_supermercado]

--Usuario normal.
CREATE LOGIN [usuario_supermercado]
WITH PASSWORD=N'usuario',
DEFAULT_DATABASE=[Supermercado],
CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF

CREATE USER [usuario_supermercado] FOR LOGIN [usuario_supermercado]
GRANT SELECT TO usuario_supermercado
GRANT EXECUTE TO usuario_supermercado

--Usuario respaldo.
CREATE LOGIN [usuario_respaldo]
WITH PASSWORD=N'respaldo',
DEFAULT_DATABASE=[Supermercado],
CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF

CREATE USER [usuario_respaldo] FOR LOGIN [usuario_respaldo]
GRANT BACKUP DATABASE TO [usuario_respaldo]

--10 Consultas para la generación de reportes
--1. Mostrar la cantidad de unidades vendidas de Arroz Tio Pelón.
SELECT Articulo.nombre, SUM(Pedido.cantidad_articulo) AS Cantidad_Vendida
FROM Articulo
INNER JOIN Pedido ON Articulo.id_articulo = Pedido.id_articulo
WHERE Articulo.id_articulo = 1
GROUP BY Articulo.nombre;

--2. Mostrar el total de ventas por sucursal.
SELECT Sucursal.nombre AS Sucursal, SUM(Factura.precio_total) AS Total_Ventas
FROM Sucursal
INNER JOIN Cajero ON Cajero.id_sucursal = Sucursal.id_sucursal
INNER JOIN Pedido ON Pedido.id_cajero = Cajero.id_cajero
INNER JOIN Factura ON Factura.id_pedido = Pedido.id_pedido
GROUP BY Sucursal.nombre;

--3. Mostrar el total de ventas por cajero.
SELECT Cajero.nombre AS Cajero, SUM(Factura.precio_total) AS Total_Ventas
FROM Cajero
INNER JOIN Pedido ON Pedido.id_cajero = Cajero.id_cajero
INNER JOIN Factura ON Factura.id_pedido = Pedido.id_pedido
GROUP BY Cajero.nombre;

--4. Mostrar el top 5 de clientes que más han comprado.
SELECT TOP 5 Cliente.nombre AS Cliente, SUM(Factura.precio_total) AS Total_Ventas
FROM Cliente
INNER JOIN Pedido ON Pedido.id_cliente = Cliente.id_cliente
INNER JOIN Factura ON Factura.id_pedido = Pedido.id_pedido
GROUP BY Cliente.nombre
ORDER BY Total_Ventas DESC

--5. Mostrar el top 5 de artículos más vendidos.
SELECT TOP 5 Articulo.nombre AS Articulo, SUM(Pedido.cantidad_articulo) AS Total_Ventas
FROM Articulo
INNER JOIN Inventario ON Inventario.id_articulo = Articulo.id_articulo
INNER JOIN Pedido ON Pedido.id_articulo = Articulo.id_articulo
GROUP BY Articulo.nombre
ORDER BY Total_Ventas DESC;

--6. Mostrar todas las ventas que hubieron en Noviembre 2022.
SELECT Factura.fecha_factura AS Fecha, Factura.hora_factura AS Hora, Factura.precio_total AS Total_Ventas
FROM Factura
WHERE MONTH(Factura.fecha_factura) = 11 AND YEAR(Factura.fecha_factura) = 2022;

--7. Mostrar top 3 artículos menos vendidos, junto con lo que han generado en ventas cada uno.
SELECT TOP 3 Articulo.nombre AS Articulo, 
SUM(Pedido.cantidad_articulo) AS Total_Ventas, 
SUM(Pedido.cantidad_articulo * Articulo.precio) AS Total_Ganancias
FROM Articulo
INNER JOIN Inventario ON Inventario.id_articulo = Articulo.id_articulo
INNER JOIN Pedido ON Pedido.id_articulo = Articulo.id_articulo
GROUP BY Articulo.nombre
ORDER BY Total_Ventas ASC;

--8. Mostrar la cantidad de artículos que tiene cada proveedor.
SELECT Proveedor.nombre_proveedor AS Proveedor, COUNT(*) AS Total_Articulos
FROM Proveedor
INNER JOIN Articulo ON Articulo.id_proveedor = Proveedor.id_prov
GROUP BY Proveedor.nombre_proveedor;

--9. Mostrar todas las facturas
SELECT Factura.fecha_factura AS Fecha, Factura.hora_factura AS Hora,
Cliente.nombre AS Cliente, Cajero.nombre AS Cajero, Factura.precio_total AS Total_Ventas
FROM Factura
INNER JOIN Pedido ON Pedido.id_pedido = Factura.id_pedido
INNER JOIN Cliente ON Cliente.id_cliente = Pedido.id_cliente
INNER JOIN Cajero ON Cajero.id_cajero = Pedido.id_cajero;

--10. Mostrar el artículo con menos reserva en inventario.
SELECT Articulo.nombre AS Articulo, Inventario.cantidad AS Cantidad
FROM Articulo
INNER JOIN Inventario ON Inventario.id_articulo = Articulo.id_articulo
WHERE Inventario.cantidad = (SELECT MIN(Inventario.cantidad) FROM Inventario);

GO
--Vistas
--1. Vista de todas las facturas.
CREATE VIEW [todas las facturas]
AS
SELECT Factura.fecha_factura AS Fecha, Factura.hora_factura AS Hora,
Cliente.nombre AS Cliente, Cajero.nombre AS Cajero, Factura.precio_total AS Precio_Total
FROM Factura
INNER JOIN Pedido ON Pedido.id_pedido = Factura.id_pedido
INNER JOIN Cliente ON Cliente.id_cliente = Pedido.id_cliente
INNER JOIN Cajero ON Cajero.id_cajero = Pedido.id_cajero;
GO

--2. Vista de articulos menos vendidos.
CREATE VIEW [articulos menos vendidos]
AS
SELECT TOP 3 Articulo.nombre AS Articulo,
SUM(Pedido.cantidad_articulo) AS Total_Ventas,
SUM(Pedido.cantidad_articulo * Articulo.precio) AS Total_Ganancias
FROM Articulo
INNER JOIN Inventario ON Inventario.id_articulo = Articulo.id_articulo
INNER JOIN Pedido ON Pedido.id_articulo = Articulo.id_articulo
GROUP BY Articulo.nombre
ORDER BY Total_Ventas ASC;
GO

--3. Vista de articulos más vendidos.
CREATE VIEW [articulos mas vendidos]
AS
SELECT TOP 5 Articulo.nombre AS Articulo, SUM(Pedido.cantidad_articulo) AS Total_Ventas
FROM Articulo
INNER JOIN Inventario ON Inventario.id_articulo = Articulo.id_articulo
INNER JOIN Pedido ON Pedido.id_articulo = Articulo.id_articulo
GROUP BY Articulo.nombre
ORDER BY Total_Ventas DESC;
GO

--4. Vista de clientes que más han comprado.
CREATE VIEW [clientes mas compradores]
AS
SELECT TOP 5 Cliente.nombre AS Cliente, SUM(Factura.precio_total) AS Total_Ventas
FROM Cliente
INNER JOIN Pedido ON Pedido.id_cliente = Cliente.id_cliente
INNER JOIN Factura ON Factura.id_pedido = Pedido.id_pedido
GROUP BY Cliente.nombre
ORDER BY Total_Ventas DESC;
GO

--5. Vista de articulos con menor reserva en inventario. (top 3)
CREATE VIEW [articulos con menos reserva]
AS
SELECT TOP 3 Articulo.nombre AS Articulo, Inventario.cantidad AS Cantidad
FROM Articulo
INNER JOIN Inventario ON Inventario.id_articulo = Articulo.id_articulo
ORDER BY Cantidad ASC;
GO

--Probar las vistas
SELECT * FROM [articulos mas vendidos]; --top 5
SELECT * FROM [articulos menos vendidos]; --top 3
SELECT * FROM [articulos con menos reserva]; --top 3
SELECT * FROM [clientes mas compradores]; --top 5
SELECT * FROM [todas las facturas]; --todas las facturas

GO
--1. ---------------------------------------------------------------------Funciones de inserción--------------------------------------------------------------------
--Insertar cliente
CREATE OR ALTER PROCEDURE insertar_cliente
    @cedula_cliente INT,
    @nombre VARCHAR(50),
    @sexo VARCHAR(1)
AS
BEGIN
    INSERT INTO Cliente (cedula_cliente, nombre, sexo)
    VALUES (@cedula_cliente, @nombre, @sexo)
END
 

GO

--Agregar articulo
CREATE OR ALTER PROCEDURE agregar_articulo
    @nombre VARCHAR(40),
    @categoria VARCHAR(40),
    @precio INT,
    @id_proveedor INT
AS
BEGIN
    INSERT INTO Articulo (nombre, categoria, precio, id_proveedor)
    VALUES (@nombre, @categoria, @precio, @id_proveedor)
END

--EXEC agregar_articulo 'Prueba', 'PruebaCat', 1000, 1 --test


GO

--Agregar cajero
CREATE OR ALTER PROCEDURE agregar_cajero
    @cedula INT,
    @nombre VARCHAR(50),
    @id_sucursal INT
AS
BEGIN
    INSERT INTO Cajero (cedula, nombre, id_sucursal)
    VALUES (@cedula, @nombre, @id_sucursal)
END

--EXEC agregar_cajero 543929509, Michael, 3

GO

--Agregar caja
CREATE OR ALTER PROCEDURE agregar_caja
    @id_cajero INT,
    @estado VARCHAR(7)
AS
BEGIN
    INSERT INTO Caja (id_cajero, estado)
    VALUES (@id_cajero, @estado)
END

/*SELECT * FROM Cajero --test
EXEC agregar_caja 10, 'Abierta'
SELECT * FROM Caja*/

GO

--Agregar gerente
CREATE OR ALTER PROCEDURE agregar_gerente
    @cedula CHAR(9),
    @nombre VARCHAR(50),
    @departamento_gerente INT
AS
BEGIN
    INSERT INTO Gerente (cedula, nombre, departamento_gerente)
    VALUES (@cedula, @nombre, @departamento_gerente)
END

GO

--Agregar marca
CREATE OR ALTER PROCEDURE agregar_marca
    @nombre VARCHAR(50)
AS
BEGIN
    INSERT INTO Marca (nombre_marca)
    VALUES (@nombre)
END

GO

--Función generar_pedido (genera el pedido y por consiguiente la factura)
CREATE OR ALTER PROCEDURE generar_pedido
    @id_cliente INT,
    @id_cajero INT,
    @id_articulo INT,
    @cantidad_articulo INT
AS
BEGIN
    DECLARE @cantidad_actual INT
    DECLARE @precio_total INT
    DECLARE @precio_articulo INT
    DECLARE @id_pedido INT

    SELECT @cantidad_actual = cantidad FROM Inventario WHERE id_articulo = @id_articulo --Cantidad actual del articulo
    SELECT @precio_articulo = precio FROM Articulo WHERE id_articulo = @id_articulo --Se obtiene el precio del articulo, para luego calcular el precio total.

    IF @cantidad_actual >= @cantidad_articulo --Si la cantidad a pedir es menor o igual a la que se posee en el inventario, se genera el pedido
    BEGIN
        SET @precio_total = @cantidad_articulo * @precio_articulo

        INSERT INTO Pedido (fecha_pedido, hora_pedido, id_cliente, id_cajero, id_articulo, cantidad_articulo)
        VALUES (CONVERT(DATE, GETDATE()), CONVERT(TIME(0), GETDATE()), @id_cliente, @id_cajero, @id_articulo, @cantidad_articulo) --Hora y fecha se calculan con GETDATE()

        SELECT @id_pedido = MAX(id_pedido) FROM Pedido --Se obtiene el id del pedido generado

        INSERT INTO Factura (fecha_factura, hora_factura, id_pedido, id_cliente, precio_total)
        VALUES (CONVERT(DATE, GETDATE()), CONVERT(TIME(0), GETDATE()), @id_pedido, @id_cliente, @precio_total) --Hora y fecha se calculan con GETDATE()
    END
    ELSE
    BEGIN
        RAISERROR('ERROR: No es posible realizar el pedido.', 16, 1) ----Si la cantidad a pedir es mayor a la que se posee en el inventario, se genera un error.
    END
END

--EXEC generar_pedido 1, 1, 1, 3 --Cliente 1 genera el pedido, con cajero 1, de artículo 1 (Arroz), comprando solo 3 unidades.


GO
--------------------------------------------------------------------------------------------------------------------------------------------------------------------
--2. ---------------------------------------------------------------------Funciones de eliminar---------------------------------------------------------------------
--Eliminar cliente por cedula.
CREATE OR ALTER PROCEDURE eliminar_cliente
    @cedula_cliente INT
AS
BEGIN
    DECLARE @id_cliente INT

    SELECT @id_cliente = id_cliente FROM Cliente WHERE cedula_cliente = @cedula_cliente --Se obtiene el id del cliente

    DELETE FROM Pedido WHERE id_cliente = @id_cliente --Se eliminan los pedidos del cliente
    DELETE FROM Factura WHERE id_cliente = @id_cliente --Se eliminan las facturas del cliente
    DELETE FROM Cliente WHERE id_cliente = @id_cliente --Se elimina el cliente
END

--EXEC eliminar_cliente 123456789

GO

--Eliminar articulo por id
CREATE OR ALTER PROCEDURE eliminar_articulo
    @id_articulo INT
AS
BEGIN
    DELETE FROM Inventario WHERE id_articulo = @id_articulo
    DELETE FROM Articulo WHERE id_articulo = @id_articulo
END

--EXEC eliminar_articulo 13
SELECT * FROM Articulo
SELECT * FROM Inventario

GO

--Eliminar cajero por cedula, a la caja se le asigna el estado 'Cerrada' y el id_cajero se pone en NULL
CREATE OR ALTER PROCEDURE eliminar_cajero
    @cedula INT
AS
BEGIN
    DECLARE @id_cajero INT

    SELECT @id_cajero = id_cajero FROM Cajero WHERE cedula = @cedula --Se obtiene el id del cajero

    UPDATE Caja SET estado = 'Cerrada', id_cajero = NULL WHERE id_cajero = @id_cajero --Se cierra la caja del cajero
    DELETE FROM Cajero WHERE id_cajero = @id_cajero --Se elimina el cajero
END

/*EXEC eliminar_cajero 255594248
SELECT * FROM Cajero
SELECT * FROM Caja*/

GO

--Eliminar un gerente
CREATE OR ALTER PROCEDURE eliminar_gerente
    @cedula INT
AS
BEGIN
    DECLARE @id_gerente INT

    SELECT @id_gerente = id_gerente FROM Gerente WHERE cedula = @cedula --Se obtiene el id del gerente

    UPDATE Sucursal SET id_gerente = NULL WHERE id_gerente = @id_gerente --Se elimina el id_gerente de la sucursal
    DELETE FROM Gerente WHERE id_gerente = @id_gerente --Se elimina el gerente
END

/*EXEC eliminar_gerente 223006119
SELECT * FROM Gerente
SELECT * FROM Sucursal*/

GO

--Eliminar una marca, si no se encuentra el nombre de la marca, se genera un error
CREATE OR ALTER PROCEDURE eliminar_marca
    @nombre_marca VARCHAR(50)
AS
BEGIN
    DECLARE @id_marca INT
    SELECT @id_marca = id_marca FROM Marca WHERE nombre_marca = @nombre_marca --Se obtiene el id de la marca

    IF @id_marca IS NOT NULL --Si se encuentra la marca, se elimina
    BEGIN
        DELETE FROM Marca WHERE id_marca = @id_marca --Se elimina la marca
    END
    ELSE
    BEGIN
        RAISERROR('ERROR: No se encuentra la marca.', 16, 1) --Si no se encuentra la marca, se genera un error
    END
END

/*EXEC eliminar_marca 'Pantene'
SELECT * FROM Marca*/

GO
--------------------------------------------------------------------------------------------------------------------------------------------------------------------
--3. ---------------------------------------------------------------------Funciones de actualizar-------------------------------------------------------------------
--Actualizar el estado de una caja a "Abierta" o "Cerrada"
CREATE OR ALTER PROCEDURE actualizar_caja
@id_caja INT,
@estado_caja VARCHAR(7)
AS
BEGIN
UPDATE Caja SET estado = @estado_caja WHERE id_caja = @id_caja;
END

/*EXEC actualizar_caja 9, 'Cerrada';
SELECT * FROM Caja;*/

GO

--Actualizar el precio de un articulo
CREATE OR ALTER PROCEDURE actualizar_precio_articulo
    @id_articulo INT,
    @precio INT
AS
BEGIN
    UPDATE Articulo SET precio = @precio WHERE id_articulo = @id_articulo
END

/*EXEC actualizar_precio_articulo 1, 1000
SELECT * FROM Articulo*/

GO

--Actualizar la cantidad de un articulo en inventario
CREATE OR ALTER PROCEDURE actualizar_cantidad_articulo
    @id_articulo INT,
    @cantidad INT
AS
BEGIN
    UPDATE Inventario SET cantidad = @cantidad WHERE id_articulo = @id_articulo
END

GO

--Actualizar la sucursal de un cajero
CREATE OR ALTER PROCEDURE actualizar_sucursal_cajero
    @cedula INT,
    @sucursal INT
AS
BEGIN
    UPDATE Cajero SET id_sucursal = @sucursal WHERE cedula = @cedula
END

/*Probar:
EXEC actualizar_sucursal_cajero 274545447, 2
SELECT * FROM Cajero;*/

GO
--Actualizar el cajero de una caja
CREATE OR ALTER PROCEDURE actualizar_cajero_caja
    @id_caja INT,
    @id_cajero INT
AS
BEGIN
    UPDATE Caja SET id_cajero = @id_cajero WHERE id_caja = @id_caja
END

/*Probar:
EXEC actualizar_cajero_caja 1, 10
SELECT * FROM Caja;*/

GO
--------------------------------------------------------------------------------------------------------------------------------------------------------------------
--4. Triggers para verificar la validez de los valores ingresados al insertar, eliminar y al actualizar.

--Trigger para verificar que el sexo sea M o F
CREATE TRIGGER tr_verificar_sexo
ON Cliente
FOR INSERT
AS
BEGIN
    DECLARE @sexo VARCHAR(1)
    SELECT @sexo = sexo FROM INSERTED
    IF @sexo NOT IN ('M', 'F')
    BEGIN
        RAISERROR('El sexo debe ser M o F', 16, 1)
        ROLLBACK
    END
END

/*EXEC insertar_cliente 124444489, 'Juan Molina', 'X'
SELECT * FROM Cliente WHERE cedula_cliente = 124444489*/

GO

--Trigger para que cuando se inserte un nuevo articulo, se actualice el inventario con la cantidad de 0
CREATE OR ALTER TRIGGER tr_inventario_articulo
ON Articulo
AFTER INSERT
AS
BEGIN
    DECLARE @id_articulo INT
    SELECT @id_articulo = id_articulo FROM INSERTED
    INSERT INTO Inventario (id_articulo, cantidad)
    VALUES (@id_articulo, 0)
END

GO

--Trigger que verifique que la cedula no tenga más ni menos de 9 chars (en la tabla Cliente)
CREATE OR ALTER TRIGGER tr_syntax_cedula_cliente
ON Cliente
FOR INSERT, UPDATE
AS
BEGIN
    DECLARE @cedula CHAR(9)
    SELECT @cedula = cedula_cliente FROM INSERTED
    IF LEN(@cedula) <> 9 --el <> es para verificar que no sea igual
    BEGIN
        RAISERROR('ERROR: La cedula debe tener 9 caracteres.', 16, 1)
        ROLLBACK
    END
END

/*Probar
INSERT INTO Cliente (cedula_cliente, nombre, sexo) VALUES (1223456789, 'Juan Perez', 'M')*/

GO

--Trigger que verifique que la cedula no tenga más de 9 chars (en la tabla Cajero)
CREATE OR ALTER TRIGGER tr_syntax_cedula_cajero
ON Cajero
FOR INSERT, UPDATE
AS
BEGIN
    DECLARE @cedula CHAR(9)
    SELECT @cedula = cedula FROM INSERTED
    IF LEN(@cedula) <> 9
    BEGIN
        RAISERROR('ERROR: La cedula debe tener 9 caracteres.', 16, 1)
        ROLLBACK
    END
END

SELECT * FROM Cajero
/*Probar
INSERT INTO Cajero (cedula, nombre, id_sucursal) VALUES (1223456789, 'Juan Perez', 1)*/

GO

--Trigger que permita verificar que el precio de un producto no sea negativo. (en la tabla Articulo)
CREATE OR ALTER TRIGGER tr_verificar_precio_articulo
ON Articulo
FOR INSERT, UPDATE
AS
BEGIN
    DECLARE @precio DECIMAL(10,2)
    SELECT @precio = precio FROM INSERTED
    IF @precio < 0
    BEGIN
        RAISERROR('El precio no puede ser negativo', 16, 1)
        ROLLBACK
    END
END

/*Probar
UPDATE Articulo SET precio = -1000 WHERE id_articulo = 1*/

GO

--Trigger en la tabla Inventario que verifique que la cantidad de un articulo no sea negativa
CREATE OR ALTER TRIGGER tr_verificar_cantidad_articulo
ON Inventario
FOR INSERT, UPDATE
AS
BEGIN
    DECLARE @cantidad INT
    SELECT @cantidad = cantidad FROM INSERTED
    IF @cantidad < 0
    BEGIN
        RAISERROR('La cantidad no puede ser negativa', 16, 1)
        ROLLBACK
    END
END

/*Probar
UPDATE Inventario SET cantidad = 2 WHERE id_articulo = 1*/

GO

--Trigger que actualice la cantidad en inventario cuando se genere un pedido de un articulo
CREATE OR ALTER TRIGGER tr_actualizar_cantidad_articulo
ON Pedido
AFTER INSERT
AS
BEGIN
    DECLARE @id_articulo INT
    DECLARE @cantidad INT
    SELECT @id_articulo = id_articulo, @cantidad = cantidad_articulo FROM INSERTED --Se obtiene el id del articulo y la cantidad del pedido
    UPDATE Inventario SET cantidad = cantidad - @cantidad WHERE id_articulo = @id_articulo --Se actualiza la cantidad en inventario
END

/*SELECT * FROM Articulo
EXEC generar_pedido 2, 3, 8, 1 --Articulo 8 = Aceite
SELECT * FROM Inventario*/

GO

--Trigger que no permita el mismo cajero en 2 sucursales distintas.
CREATE OR ALTER TRIGGER tr_verificar_cajero_sucursal
ON Cajero
FOR INSERT, UPDATE
AS
BEGIN
    DECLARE @id_cajero INT
    DECLARE @id_sucursal INT
    SELECT @id_cajero = id_cajero, @id_sucursal = id_sucursal FROM INSERTED
    IF EXISTS (SELECT * FROM Cajero WHERE id_cajero = @id_cajero AND id_sucursal <> @id_sucursal) --el <> es para que no se compare con el mismo id
    BEGIN
        RAISERROR('El cajero ya está en otra sucursal', 16, 1)
        ROLLBACK
    END
END

GO

--Trigger en estantería para que la capacidad no sea negativa
CREATE OR ALTER TRIGGER tr_verificar_capacidad_estanteria
ON Estanteria
FOR INSERT, UPDATE
AS
BEGIN
    DECLARE @capacidad INT
    SELECT @capacidad = capacidad FROM INSERTED
    IF @capacidad < 0
    BEGIN
        RAISERROR('La capacidad no puede ser negativa', 16, 1)
        ROLLBACK
    END
END

GO

--Trigger en departamento para que no se pueda repetir el nombre.
CREATE OR ALTER TRIGGER tr_verificar_nombre_departamento
ON Departamento
FOR INSERT, UPDATE
AS
BEGIN
    DECLARE @nombre VARCHAR(50)
    DECLARE @id_departamento INT
    SELECT @nombre = nombre, @id_departamento = id_dept FROM INSERTED
    IF EXISTS (SELECT * FROM Departamento WHERE nombre = @nombre AND id_dept <> @id_departamento) --el <> es para que no se compare con el mismo id
    BEGIN
        RAISERROR('Ya existe un departamento con ese nombre', 16, 1)
        ROLLBACK
    END
END

/*Probar:
INSERT INTO Departamento (nombre) VALUES ('Limpieza 2')
SELECT * FROM Departamento*/

GO

--Trigger en proveedor para que no se repita el nombre
CREATE OR ALTER TRIGGER tr_verificar_nombre_proveedor
ON Proveedor
FOR INSERT, UPDATE
AS
BEGIN
    DECLARE @nombre VARCHAR(50)
    DECLARE @id_proveedor INT
    SELECT @nombre = nombre_proveedor, @id_proveedor = id_prov FROM INSERTED
    IF EXISTS (SELECT * FROM Proveedor WHERE nombre_proveedor = @nombre AND id_prov <> @id_proveedor)
    BEGIN
        RAISERROR('Ya existe un proveedor con ese nombre.', 16, 1)
        ROLLBACK
    END
END

/*Probar:
INSERT INTO Proveedor(nombre_proveedor, contacto, tipo_proveedor) VALUES ('Kimby2', 'asdfa', 'Internacional');
SELECT * FROM Proveedor*/

GO

--Trigger en cliente para que no se pueda repetir la cédula.
CREATE OR ALTER TRIGGER tr_verificar_cedula_cliente
ON Cliente
FOR INSERT, UPDATE
AS
BEGIN
    DECLARE @cedula INT
    DECLARE @id_cliente INT
    SELECT @cedula = cedula_cliente, @id_cliente = id_cliente FROM INSERTED
    IF EXISTS (SELECT * FROM Cliente WHERE cedula_cliente = @cedula AND id_cliente <> @id_cliente)
    BEGIN
        RAISERROR('Ya existe un cliente con esa cédula.', 16, 1)
        ROLLBACK
    END
END

/*Probar:
EXEC insertar_cliente 123010789, 'Juan Test', 'M'
SELECT * FROM Cliente WHERE cedula_cliente = 123010789*/

GO

--Trigger en cajero para que no se pueda repetir la cédula.
CREATE OR ALTER TRIGGER tr_verificar_cedula_cajero
ON Cajero
FOR INSERT, UPDATE
AS
BEGIN
    DECLARE @cedula INT
    DECLARE @id_cajero INT
    SELECT @cedula = cedula, @id_cajero = id_cajero FROM INSERTED
    IF EXISTS (SELECT * FROM Cajero WHERE cedula = @cedula AND id_cajero <> @id_cajero)
    BEGIN
        RAISERROR('Ya existe un cajero con esa cédula.', 16, 1)
        ROLLBACK
    END
END


GO

--Trigger que verifique que un cajero no se pueda estar en más de una caja a la vez.
CREATE OR ALTER TRIGGER tr_verificar_cajero_caja
ON Caja
FOR INSERT, UPDATE
AS
BEGIN
    DECLARE @id_cajero INT
    DECLARE @id_caja INT
    SELECT @id_cajero = id_cajero, @id_caja = id_caja FROM INSERTED
    IF EXISTS (SELECT * FROM Caja WHERE id_cajero = @id_cajero AND id_caja <> @id_caja)
    BEGIN
        RAISERROR('El cajero ya está en otra caja', 16, 1)
        ROLLBACK
    END
END


GO