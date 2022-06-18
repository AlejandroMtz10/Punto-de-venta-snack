Create database Snack

use Snack

/* Tablas */

create table Bebidas(
FolioB char(6) primary key,
Marca varchar(30) not null,
tipo varchar(30) not null,
sabor varchar(30) not null,
precio int not null,
disponibles int not null
)

create table ingredientes(
FolioI char(6) primary key,
ingrediente varchar(40) not null,
tipo varchar(50) not null,
disponibles int not null
)

create table comidas(
FolioC char(6) primary key,
comida varchar(40) not null,
precio int not null
)

create table Ventas(
FolioVenta int primary key,
Vendedor varchar(50) not null,
Comprador varchar(50),
Total int not null,
)

create table estatusCaja(
idRegistro int primary key,
fecha datetime not null default getdate(),
numeroCaja int not null,
montoInicial int not null,
montoActual int not null,
montoFinal_generado int not null,
atendidaPor varchar(50) not null,
retirosPrevios int not null
)

create table Retiros(
idRetiro int primary key,
idRegistro int not null,
Fecha datetime not null default getdate(),
Persona varchar(50) not null,
Monto int not null,
tipoRetiro varchar (50) not null
Foreign Key (idRegistro) References estatusCaja(idRegistro)
)

create table usuarios(
FolioUsuario char(4) primary key,
nombre varchar(50) not null,
apellidos varchar(50) not null,
tipo varchar(20) not null,
usuario varchar(50) unique not null,
pass varchar(50) not null
)

create table Bitacora(
Id int primary key identity(1,1),
evento varchar(50) not null,
tabla varchar(50) not null,
fecha datetime not null default getdate(),
hostname varchar(50) not null,
)

/*Para el momento de insertar retiros nuevos*/
create trigger tr_retiros_insertar on Retiros
for insert as begin
	insert into Bitacora (evento, tabla, fecha, hostname) values ('Nuevo retiro','Retiros',GETDATE(),HOST_NAME())
end

/*Para cuando se realice un cambio en la tabla de Bebidas*/
create trigger tr_bebidas_update on Bebidas
for update
as begin
	insert into bitacora(evento, tabla, fecha, hostname) values ('Actualizacion','Bebidas',GETDATE(), HOST_NAME())
end

/*Para el momento de insertar alimentos nuevos*/
create trigger tr_ingredientes_insertar on ingredientes
for insert as begin
	insert into Bitacora (evento, tabla, fecha, hostname) values ('Nuevo ingrediente','Ingredientes',GETDATE(),HOST_NAME())
end

/*Para realizar cambios en la tabla de alimentos*/
create trigger tr_ingredientes_update on ingredientes
for update
as begin
	insert into bitacora(evento, tabla, fecha, hostname) values ('Actualizacion','Ingredientes',GETDATE(), HOST_NAME())
end

/* Para eliminar un alimento de la tabla de alimentos */
create trigger tr_ingredientes_eliminar on ingredientes
for delete
as begin
	insert into bitacora(evento, tabla, fecha, hostname) values ('Eliminado','Ingrediente',GETDATE(), HOST_NAME())
end

/* Para cambios en la tabla de comidas */
create trigger tr_comidas_update on Comidas
for update
as begin
	insert into bitacora(evento, tabla, fecha, hostname) values ('Actualizacion','Comidas',GETDATE(), HOST_NAME())
end

/* Para capturar un nuevo estatus en la caja */

create trigger tr_estatusCaja_insertar on estatusCaja
for insert as begin
	insert into Bitacora (evento, tabla, fecha, hostname) values ('Nuevo estado de la caja','Estatus caja',GETDATE(),HOST_NAME())
end

/* Para cambios dentro de la caja*/
create trigger tr_estatusCaja_update on estatusCaja
for update
as begin
	insert into bitacora(evento, tabla, fecha, hostname) values ('Actualizado','Estatus caja',GETDATE(), HOST_NAME())
end

/*Para eliminar un estatus de la caja*/

create trigger tr_estatusCaja_eliminar on estatusCaja
for delete
as begin
	insert into bitacora(evento, tabla, fecha, hostname) values ('Eliminado','Estatus caja',GETDATE(), HOST_NAME())
end

/* Para insertar usuarios */
create trigger tr_usuarios_insertar on usuarios
for insert as begin
	insert into Bitacora (evento, tabla, fecha, hostname) values ('Nuevo usuario','Usuarios',GETDATE(),HOST_NAME())
end

/* Para cambios dentro de los usuarios */
create trigger tr_usuarios_update on usuarios
for update
as begin
	insert into bitacora(evento, tabla, fecha, hostname) values ('Cambios en el usuario','Usuarios',GETDATE(), HOST_NAME())
end

/* Para insertar una venta */
create trigger tr_ventas_insertar on Ventas
for insert as begin
	insert into Bitacora (evento, tabla, fecha, hostname) values ('Nueva venta','Ventas',GETDATE(),HOST_NAME())
end

/* Para cambios dentro de las ventas */
create trigger tr_ventas_update on ventas
for update
as begin
	insert into bitacora(evento, tabla, fecha, hostname) values ('Cambios en la venta','Ventas',GETDATE(), HOST_NAME())
end

/*Para eliminar una venta*/
create trigger tr_ventas_eliminar on Ventas
for delete
as begin
	insert into bitacora(evento, tabla, fecha, hostname) values ('Venta eliminada','Venta',GETDATE(), HOST_NAME())
end

/* Registro de usuarios */
/*Administrador*/
insert into usuarios(FolioUsuario,nombre,apellidos,tipo,usuario,pass) values ('aces','Cesar Humberto','Rodriguez Briseño','Administrador','Cesar Rodriguez','00C01H')
/*estandar*/
insert into usuarios(FolioUsuario,nombre,apellidos,tipo,usuario,pass) values ('evic','Victor Hugo','Sifuentes Piña','Estandar','Victor Sifuentes','01V02S')

select * from usuarios

select * from Bitacora

/* Registro de bebidas */
insert into Bebidas(FolioB,marca,tipo,sabor,precio,disponibles) values ('cocaco','Coca - Cola','Lata 355 ml','Cola',15,20)
insert into Bebidas(FolioB,marca,tipo,sabor,precio,disponibles) values ('drpepp','Dr.Pepper','Lata 355 ml','Caramelo',15,20)
insert into Bebidas(FolioB,marca,tipo,sabor,precio,disponibles) values ('fantan','Fanta Naranja','Lata 355 ml','Naranja',15,20)
insert into Bebidas(FolioB,marca,tipo,sabor,precio,disponibles) values ('fantaf','Fanta Fresa','Lata 355 ml','Fresa',15,20)
insert into Bebidas(FolioB,marca,tipo,sabor,precio,disponibles) values ('sprite','Sprite','Lata 355 ml','Lima limon',15,20)
insert into Bebidas(FolioB,marca,tipo,sabor,precio,disponibles) values ('fresca','Fresca','Botella 500 ml','Cola',15,20)
insert into Bebidas(FolioB,marca,tipo,sabor,precio,disponibles) values ('aguana','Agua','Botella 500 ml','Agua natural',13,20)

select * from bebidas

/* Registro de alimentos disponibles */

insert into ingredientes(FolioI,ingrediente,tipo,disponibles) values ('panhot','Pan para hot dog','Bolsa de 8 panes',5)
insert into ingredientes(FolioI,ingrediente,tipo,disponibles) values ('salchi','Salchichas','Paquete de 50 salchichas',5)
insert into ingredientes(FolioI,ingrediente,tipo,disponibles) values ('catsup','Catsup','Galón de 4 Kg',3)
insert into ingredientes(FolioI,ingrediente,tipo,disponibles) values ('mayone','Mayonesa','Bote de 3.5 Kg',5)
insert into ingredientes(FolioI,ingrediente,tipo,disponibles) values ('mostaz','Mostaza','Bote de 3.5 Kg',3)
insert into ingredientes(FolioI,ingrediente,tipo,disponibles) values ('fritos','Fritos','Fritos bolsa chica',30)
insert into ingredientes(FolioI,ingrediente,tipo,disponibles) values ('nachos','Nachos','Bolsa de 1 Kg',9)
insert into ingredientes(FolioI,ingrediente,tipo,disponibles) values ('quesoC','Queso Chedar','Lata de 3 Kg',6)
insert into ingredientes(FolioI,ingrediente,tipo,disponibles) values ('papasF','Papas Francesas','Bolsa de 2 Kg',10)
insert into ingredientes(FolioI,ingrediente,tipo,disponibles) values ('jalape','Chiles jalapeño en rodajas','Lata 2 Kg',3)
insert into ingredientes(FolioI,ingrediente,tipo,disponibles) values ('ceboll','Cebollas blancas','Individuales',8)
insert into ingredientes(FolioI,ingrediente,tipo,disponibles) values ('tomate','Tomates','Individuales',10)
insert into ingredientes(FolioI,ingrediente,tipo,disponibles) values ('lecheG','Leche','Galon de 3.78 lts',3)

select * from ingredientes

/* Registro de comidas */
insert into comidas(FolioC,comida,precio) values ('hotdog','Hot-dogs',20)
insert into comidas(FolioC,comida,precio) values ('nachos','Nachos',25)
insert into comidas(FolioC,comida,precio) values ('frique','Fritos con queso',30)
insert into comidas(FolioC,comida,precio) values ('fritos','Fritos',17)
insert into comidas(FolioC,comida,precio) values ('papasq','Papas con queso',30)
insert into comidas(FolioC,comida,precio) values ('papass','Orden de papas (solas)',32)

select * from comidas