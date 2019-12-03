create database app

use app

drop database app


create table persona 
(
idpersona int primary key identity(1,1),
nombre varchar (50),
apellido varchar(50),
cuil_cuit varchar (50),
dni varchar(10), 
)

create table permisos
(
	idpermisos int primary key identity(1,1),
	tipo varchar(10),
	descripcion varchar(100)
)

create table usuario 
(
	idusuario int primary key identity(1,1),
	password varchar (20),
	nickname varchar(10),
	refidpersona int foreign key REFERENCES persona(idpersona),
	refidpermiso int foreign key REFERENCES permisos(idpermisos),
)

create table actividad
(
	idactividad int identity (1,1),
	tipo varchar(5)primary key,
	descripcion varchar(100)
)
create table cliente 
(
	idcliente int primary key identity (1,1),
	razon varchar (50),
	refidtipoactividad varchar(5)foreign key REFERENCES actividad(tipo),
	refidpersona int foreign key REFERENCES persona(idpersona)
)

create table negocio
(
	idnegocio int primary key identity (1,1),
	refidpersona int foreign key REFERENCES persona(idpersona),
	razon varchar (50),
)
create table negoClientes
(
	idnegoPers int primary key identity (1,1),
	refidcliente int foreign key REFERENCES cliente(idcliente),
	refidnegocio int foreign key REFERENCES negocio(idnegocio)
)



create table categoria
(
	idcategoria int identity (1,1),
	tipoCategoria varchar (10)primary key,
	descripcion varchar(50)
)
create table producto
(
	idproducto int primary key identity (1,1),
	codigo varchar (50),
	nombre varchar (50),
	descripción varchar (50),
	refidtipoCategoria varchar(10) foreign key REFERENCES categoria(tipoCategoria),
)
create table stock
(
	idstock int primary key identity (1,1),
	precio NUMERIC(5,2),
	cantidad int,
	porcentaje NUMERIC(5,2),
	refidproducto int foreign key REFERENCES producto(idproducto),
)
create table modoPago 
(
	idmodopago int identity (1,1),
	tipoPago varchar (10)primary key,
	descripcion varchar (50)
)
drop table factura
create table factura
(
	idfactura int primary key identity (1,1),
	fecha datetime default null,
	refidcliente int foreign key REFERENCES cliente(idcliente),
	refidtipoPago varchar(10) foreign key REFERENCES modoPago(tipoPago)
)

drop table detalle
create table detalle
(
	iddetalle int primary key identity (1,1),
	precioV NUMERIC(5,2),
	cantidadV int,
	refidfactura int foreign key REFERENCES factura(idfactura),
	refidproducto int foreign key REFERENCES producto(idproducto)
)



CREATE TABLE [dbo].[fichaStock](
	[IdFichaStock] int IDENTITY(1,1) NOT NULL,
	[idProducto] int NOT NULL,
	[Fecha] datetime NOT NULL,
	[Entrada_Unidad] int NOT NULL,
	[Entrada_Precio] real NOT NULL,
	[Entrada_Total] real NOT NULL,
	[Salida_Unidad] int NOT NULL,
	[Salida_Precio] real NOT NULL,
	[Salida_Total] real NOT NULL,
	[Stock_Unidad] int NOT NULL,
	[Stock_Precio] real NOT NULL,
	[Stock_Total] real NOT NULL,
 CONSTRAINT [PK_fichaStock] PRIMARY KEY CLUSTERED 
(
	[IdFichaStock] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[fichaStock]  WITH CHECK ADD  CONSTRAINT [FK_fichaStock_producto] FOREIGN KEY([idProducto])
REFERENCES [dbo].[producto] ([idproducto])
GO

ALTER TABLE [dbo].[fichaStock] CHECK CONSTRAINT [FK_fichaStock_producto]
GO 






insert into permisos(tipo,descripcion)
values('admin','Posee permisos para el manejo de toda la aplicaciòn')
insert into permisos(tipo,descripcion)
values('ven','Posee permisos tipo vendedor')

insert into persona(nombre,apellido,cuil_cuit,dni)
values('Uriel','La Roca','20364587999','36458799') 
insert into persona(nombre,apellido,cuil_cuit,dni)
values('Ulises','Guzman','20355587888','35558788') 
insert into persona(nombre,apellido,cuil_cuit,dni)
values('Leon','Pudin','20366687888','36668788') 
insert into persona(nombre,apellido,cuil_cuit,dni)
values('Peter','sanchez','20364414499','36441449')
insert into persona(nombre,apellido,cuil_cuit,dni)
values('Ema','Degraff','20368587999','36858799') 
insert into persona(nombre,apellido,cuil_cuit,dni)
values('Nico','Degiacobbe','24555587888','24558788') 

insert into usuario(password,nickname,refidpersona,refidpermiso)
values('1234','usuNico','5','1')
insert into usuario(password,nickname,refidpersona,refidpermiso)
values('1234','usuEma','6','2')


insert into actividad(tipo,descripcion)
values('RI','Responsable Inscripto A')
insert into actividad(tipo,descripcion)
values('CF','Consumidor Final B')


insert into cliente(razon,refidtipoactividad,refidpersona)
values('empresaA','RI','1')
insert into cliente(razon,refidtipoactividad,refidpersona)
values('empresaC','CF','2')

insert into cliente(razon,refidtipoactividad,refidpersona)
values('empresaA','RI','1')
insert into cliente(razon,refidtipoactividad,refidpersona)
values('empresaC','CF','2')
insert into cliente (razon,refidtipoactividad,refidpersona)
values('','RI',3)
insert into cliente (razon,refidtipoactividad,refidpersona)
values('','CF',4)

insert into negocio(razon,refidpersona)
values('FERRE-PEPE','4')

insert into negoClientes(refidnegocio,refidcliente)
values('1','1')
insert into negoClientes(refidnegocio,refidcliente)
values('1','2')
insert into negoClientes(refidnegocio,refidcliente)
values('1','3')

insert into categoria(tipoCategoria,descripcion)
values('LACTEOS','Articulos de LACTEOS')
insert into categoria(tipoCategoria,descripcion)
values('FRUTAS','Articulos de FRUTAS')
insert into categoria(tipoCategoria,descripcion)
values('VERDURA','Articulos de VERDURA')
insert into categoria(tipoCategoria,descripcion)
values('CONSERVAS','Articulos de CONSERVAS')
insert into categoria(tipoCategoria,descripcion)
values('LIMPIEZA','Articulos de LIMPIEZA')
insert into categoria(tipoCategoria,descripcion)
values('PERFUMERIA','Articulos de PERFUMERIA')
insert into categoria(tipoCategoria,descripcion)
values('CONGELADOS','Articulos de CONGELADOS')
insert into categoria(tipoCategoria,descripcion)
values('BEBIDAS','Articulos de BEBIDAS')
insert into categoria(tipoCategoria,descripcion)
values('CARNICERIA','Articulos de CARNICERIA')
insert into categoria(tipoCategoria,descripcion)
values('PESCADERIA','Articulos de PESCADERIA incluye MARISQUERIA')
insert into categoria(tipoCategoria,descripcion)
values('LEGUMBRES','Articulos de LEGUMBRES')
insert into categoria(tipoCategoria,descripcion)
values('ALMACEN','Articulos de ALMACEN')
insert into categoria(tipoCategoria,descripcion)
values('VARIOS','Articulos sin una categoria definida')

insert into producto(codigo,nombre,descripción,refidtipoCategoria)
values('00001','TestProd','Es un producto de prueba','VARIOS')
insert into producto(codigo,nombre,descripción,refidtipoCategoria)
values('00002','TestProd2','Es un producto de prueba2','ALMACEN')
insert into producto(codigo,nombre,descripción,refidtipoCategoria)
values('00003','TestProd3','Es un producto de prueba3','LEGUMBRES')

select top(1) idproducto from producto 

select * from producto
select * from stock
select * from categoria order by 1 asc

select * from usuario
select * from permisos
select * from persona
select * from actividad
select * from cliente
select * from negocio
select * from negoClientes
select * from fichaStock

SELECT top(1) cuil_cuit FROM persona 

drop table persona
drop table negocio
drop table usuario
drop table permisos
drop table actividad
drop table cliente
drop table negoClientes

drop table stock
drop table detalle
drop table producto
drop table categoria
drop table factura
drop table modoPago



select p.nombre,p.apellido,cli.razon,tipo,descripcion,p.cuil_cuit,n.razon as negRazon,due.cuil_cuit as negCuit 
from persona p inner join cliente cli on p.idpersona = cli.refidpersona 
inner join actividad actCli on cli.refidtipoactividad = actCli.tipo 
inner join negoPers neg on p.idpersona = neg.refidpersona 
inner join persona due on due.idpersona = neg.refidpersona 
inner join negocio n on neg.refidnegocio = n.idnegocio 
where cli.razon = 'empresaA'



,apellido,c.razon
select p.cuil_cuit from  negoPers neg inner join negocio n on neg.refidnegocio = n.idnegocio inner join persona p on p.idpersona = neg.refidpersona inner join cliente c on p.idpersona = c.refidpersona 

select * from persona p inner join cliente c on p.idpersona = c.refidpersona 

select nombre from persona p inner join cliente c on p.idpersona = c.refidpersona 
select apellido from persona p inner join cliente c on p.idpersona = c.refidpersona 
select razon from persona p inner join cliente c on p.idpersona = c.refidpersona 


