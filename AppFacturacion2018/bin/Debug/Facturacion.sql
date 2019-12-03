create database Facturacion
go
use Facturacion
go
--Nivel 1 Administrador
--Nivel 2 Usuario
create table Login
(
usuario varchar(15),
contraseña varchar(15),
nivel int
primary key(usuario)
)
go
create table DatosEstablecimiento
(
id_datosEstablecimiento int,
nombre varchar(30),
cuit varchar(20),
telefono varchar(20),
celular varchar (20),
direccion varchar (30),
localidad varchar (30),
provincia varchar (30),
email varchar(30),
codigoPostal varchar(10),
fechaInicio date,
)
go
--Tipo documento 0 DNI (Documento nacional de identidad)
--Tipo documento 1 CI (Cedula de identidad)
--Tipo documento 2 LC (Libreta civica)
--Tipo cliente 0 Consumidor final
--Tipo cliente 1 Responsable inscripto
--Sexo 0 Masculino
--Sexo 1 Femenino
create table Clientes
(
id_cliente int identity,
tipoDocumento int,
numDocumento varchar(15),
cuit varchar(20),
nombre varchar(20),
apellido varchar(20),
telefono varchar(20),
celular varchar (20),
direccion varchar (30),
localidad varchar (30),
provincia varchar (30),
email varchar(30),
codigoPostal varchar(10),
fechaNac date,
tipoCliente int,
sexo int,
primary key(tipoDocumento,numDocumento)
)
go
create table Productos
(
id_producto int,
nombre varchar(20),
stockMinimo int,
ganancia int,
primary key(id_producto)
)
go
create table ProductosStock
(
id_stock int identity,
id_producto int,
precio int,
cantidad int,
precioTotal as precio*cantidad,
primary key (id_stock),
foreign key(id_producto) references Productos(id_producto)
)
go
create table Naturalezas
(
id_naturaleza int,
nombre nvarchar(20),
tipoSaldo nvarchar(10),
primary key (id_naturaleza)
)
go
create table Rubros
(
id_rubro int identity,
rubro int,
naturaleza int,
nombre nvarchar(20)
primary key (id_rubro)
foreign key(naturaleza) references Naturalezas(id_naturaleza)
)
go
create table Cuentas
(
id_cuenta int identity,
naturaleza int,
rubro int,
codigo int,
nombre varchar(50),
base int,
primary key(id_cuenta),
foreign key(rubro) references Rubros(id_rubro)
)
go
create table Asientos
(
id_asiento int identity,
codigoAsiento nvarchar(5),
fecha date,
debe float,
haber float,
sAcreedor float,
sDeudor float,
id_cuenta int,
primary key (id_asiento),
foreign key(id_cuenta) references Cuentas(id_cuenta)
)
go
create table Facturas
(
id_factura int identity,
fecha datetime,
cuit varchar(20),
numeroa int,
numeroc int,
primary key (id_factura)
)
go
create table FacturasProductos
(
id_producto int,
id_factura int,
cantidad int,
primary key(id_producto,id_factura),
foreign key(id_producto) references Productos(id_producto),
foreign key(id_factura) references Facturas(id_factura)
)
go
create function CalcularPPP
(@id_producto int)
returns float
as
begin
declare @cantidad int
select @cantidad = SUM(cantidad) from ProductosStock where id_producto=@id_producto
declare @precio int
select @precio = SUM(precioTotal) from ProductosStock where id_producto=@id_producto
return @precio/@cantidad
end
go
--create view vFactura2 as
--select fp.id_producto as Codigo, p.nombre as Nombre, fp.cantidad as Cantidad, dbo.CalcularPPP(fp.id_producto)*fp.cantidad as Precio, fp.id_factura from FacturasProductos fp
--join Productos p on fp.id_producto=p.id_producto
--go
create view vClientes as
select *,clientes.nombre+' '+clientes.apellido as 'nomapel' from Clientes
go
create view vStock as
select id_producto,precio as Precio, cantidad as Cantidad, precioTotal as 'Precio Total' from ProductosStock
go
create view vProductos as
select productos.id_producto as Codigo, 
nombre as Nombre, 
stockMinimo as 'Stock Minimo', 
ganancia as Ganancia,
SUM(ProductosStock.precioTotal)/NULLIF(SUM(productosstock.cantidad), 0)+SUM(ProductosStock.precioTotal)/NULLIF(SUM(productosstock.cantidad), 0)*ganancia/100 as 'Precio Venta'
from Productos
inner join productosstock 
on productos.id_producto = productosstock.id_producto
group by productos.id_producto, nombre, stockMinimo, ganancia
go
create view vFactura as
select fp.cantidad as Cantidad, p.nombre as Nombre, v.[Precio Venta] as Precio , v.[Precio Venta]*fp.cantidad as Importe, fp.id_factura from FacturasProductos fp
join Productos p on fp.id_producto=p.id_producto
join vProductos v on fp.id_producto=v.Codigo
go
create procedure pBalanceActivo @desde date, @hasta date
as
select r.nombre as Nombre,isNull(aux.Total,0)AS Total FROM (SELECT r.id_rubro,r.nombre as Nombre,isNull(SUM(a.sDeudor + a.sAcreedor),0) as Total 
from cuentas c
left join rubros r on c.rubro = r.id_rubro
left join naturalezas n on (n.id_naturaleza=r.naturaleza) and (n.id_naturaleza=c.naturaleza)
left join asientos a on c.id_cuenta = a.id_cuenta
where n.id_naturaleza=1 
and a.fecha between @desde and @hasta
group by r.id_rubro,r.nombre ) as aux
full join rubros r on r.id_rubro = aux.id_rubro
where r.naturaleza=1
go
create procedure pBalancePasivo @desde date, @hasta date
as
select r.nombre as Nombre,isNull(aux.Total,0)AS Total FROM (SELECT r.id_rubro,r.nombre as Nombre,isNull(SUM(a.sDeudor + a.sAcreedor),0) as Total 
from cuentas c
left join rubros r on c.rubro = r.id_rubro
left join naturalezas n on (n.id_naturaleza=r.naturaleza) and (n.id_naturaleza=c.naturaleza)
left join asientos a on c.id_cuenta = a.id_cuenta
where n.id_naturaleza=2 
and a.fecha between @desde and @hasta
group by r.id_rubro,r.nombre ) as aux
full join rubros r on r.id_rubro = aux.id_rubro
where r.naturaleza=2
go
create procedure pBalanceCapital @desde date, @hasta date
as
select isNull(SUM(sAcreedor)+SUM(sDeudor),0) as suma from Asientos a
inner join Cuentas c on a.id_cuenta=c.id_cuenta
where c.naturaleza=3 and c.rubro=1 and a.fecha between @desde and @hasta
go
create procedure pBalanceVentas @desde date, @hasta date
as
select isNull(SUM(sAcreedor)+SUM(sDeudor),0) as suma from Asientos a
inner join Cuentas c on a.id_cuenta=c.id_cuenta
where c.naturaleza=4 and c.rubro=1 and a.fecha between @desde and @hasta
go
create procedure pBalanceCMercVen @desde date, @hasta date
as
select isNull(SUM(sAcreedor)+SUM(sDeudor),0) as suma from Asientos a
inner join Cuentas c on a.id_cuenta=c.id_cuenta
where c.naturaleza=5 and c.rubro=1 and a.fecha between @desde and @hasta
go
create procedure pBalanceIngresos @desde date, @hasta date
as
select isNull(SUM(sAcreedor)+SUM(sDeudor),0) as suma from Asientos a
inner join Cuentas c on a.id_cuenta=c.id_cuenta
where c.naturaleza=4 and a.fecha between @desde and @hasta
go
create procedure pBalanceEgresos @desde date, @hasta date
as
select isNull(SUM(sAcreedor)+SUM(sDeudor),0) as suma from Asientos a
inner join Cuentas c on a.id_cuenta=c.id_cuenta
where c.naturaleza=5 and a.fecha between @desde and @hasta
go
CREATE Function [dbo].[SUMAR_S_DEBE](@Cuenta_ID int)
RETURNS float
AS
BEGIN
 Return (SELECT SUM(DEBE) FROM ASIENTOS WHERE id_cuenta = @Cuenta_ID)
END
GO
CREATE Function [dbo].[SUMAR_S_HABER](@Cuenta_ID int)
RETURNS float
AS
BEGIN
 Return (SELECT SUM(HABER) FROM ASIENTOS WHERE id_cuenta = @Cuenta_ID)
END
go
insert into Login
values('admin','1234',1)
go
insert into Login
values('uriel','1234',2)
go
insert into DatosEstablecimiento
values(1,'Ferreteria San','10-1111111111-20','422-000','2224444444','Espora 200','San Vicente','Buenos Aires','prueba@email.com','1666','10-05-05')

insert into Clientes values (0,'37458085','20-37458085-0','Uriel','Gonzalez','422-365','480516','Brasil 735','Alejandro Korn','Bs As','uriel_6@hotmail.es','1864','16/03/1993','2','0')
insert into Clientes values (0,'34876238','20-34876238-0','Roberto','Perez','411-365','435633','Esmeralda 662','Alejandro Korn','Bs As','robertito@hotmail.es','1864','16/10/1995','1','0')


insert into Productos values (1234,'Tornillo',20,10)
insert into Productos values (1224,'Tuerca',25,10)
insert into Productos values (1334,'Arandela',15,20)
insert into Productos values (1444,'Clavo',10,10)
insert into Productos values (1554,'Remache',40,20)
insert into Productos values (1664,'Tarugo',25,15)

insert into ProductosStock values(1234,120,100)
insert into ProductosStock values(1234,90,50)
insert into ProductosStock values(1234,64,77)
insert into ProductosStock values(1234,43,74)
insert into ProductosStock values(1224,111,111)
insert into ProductosStock values(1224,120,100)
insert into ProductosStock values(1224,133,90)
insert into ProductosStock values(1224,90,80)
insert into ProductosStock values(1334,120,100)
insert into ProductosStock values(1334,100,100)
insert into ProductosStock values(1334,100,150)
insert into ProductosStock values(1444,135,100)
insert into ProductosStock values(1444,120,165)
insert into ProductosStock values(1554,200,100)
insert into ProductosStock values(1554,100,200)
insert into ProductosStock values(1664,175,100)
insert into ProductosStock values(1664,175,175)

insert into Naturalezas values(1,'Activo','Deudor')
insert into Naturalezas values(2,'Pasivo','Acreedor')
insert into Naturalezas values(3,'Patrimonio neto','Acreedor')
insert into Naturalezas values(4,'Ingreso','Acreedor')
insert into Naturalezas values(5,'Egreso','Deudor')

insert into Rubros values(1,1,'Cajas y Bancos')
insert into Rubros values(2,1,'Inversiones')
insert into Rubros values(3,1,'Creditos')
insert into Rubros values(4,1,'Bienes de cambio')
insert into Rubros values(5,1,'Bienes de uso')
insert into Rubros values(6,1,'Bienes intangibles')
insert into Rubros values(1,2,'Obligaciones')
insert into Rubros values(2,2,'Previsiones')

insert into Cuentas values (1,1,01,'Caja',0)
insert into Cuentas values (1,1,02,'Banco',0)
insert into Cuentas values (1,1,03,'Fondo fijo',0)
insert into Cuentas values (1,2,01,'Banco plazo fijo',0)
insert into Cuentas values (1,2,02,'Titulos publicos',0)
insert into Cuentas values (1,2,03,'Accion',0)
insert into Cuentas values (1,3,01,'Deudores por ventas',0)
insert into Cuentas values (1,4,01,'Mercaderia',0)
insert into Cuentas values (1,4,02,'Materia prima',0)
insert into Cuentas values (1,4,03,'Produccion de procesos',0)
insert into Cuentas values (1,5,01,'Rodados',0)
insert into Cuentas values (1,5,02,'Mobiliario',0)
insert into Cuentas values (1,5,03,'Instalaciones',0)
insert into Cuentas values (1,6,01,'Marcas',0)
insert into Cuentas values (1,6,02,'Franquicias',0)
insert into Cuentas values (2,7,01,'Proveedores',0)
insert into Cuentas values (2,7,02,'Doc a pagar',0)
insert into Cuentas values (2,7,03,'Acreedores generados',0)
insert into Cuentas values (2,8,01,'Par despidos',0)
insert into Cuentas values (2,8,02,'Par incendios',0)
insert into Cuentas values (3,1,01,'Capital',0)
insert into Cuentas values (3,2,01,'R Legal',0)
insert into Cuentas values (3,3,01,'Resultado acumulado',0)
insert into Cuentas values (3,4,01,'Resultado del ejercicio',0)
insert into Cuentas values (4,1,01,'Ventas',0)
insert into Cuentas values (4,2,01,'Intereses obtenidos',0)
insert into Cuentas values (4,3,01,'Alquileres obtenidos',0)
insert into Cuentas values (5,1,01,'Costo mercaderia vendida',0)
insert into Cuentas values (5,2,01,'Intereses cedidos',0)
insert into Cuentas values (5,3,01,'Alquileres cedidos',0)

SET IDENTITY_INSERT [dbo].[Asientos] ON
INSERT [dbo].[Asientos] ([id_asiento], [codigoAsiento], [fecha], [debe], [haber], [sAcreedor], [sDeudor], [id_cuenta]) VALUES (1, N'0001', CAST(0x063F0B00 AS Date), 1000, 0, 0, 1000, 1)
INSERT [dbo].[Asientos] ([id_asiento], [codigoAsiento], [fecha], [debe], [haber], [sAcreedor], [sDeudor], [id_cuenta]) VALUES (2, N'0001', CAST(0x063F0B00 AS Date), 0, 900, 900, 0, 21)
INSERT [dbo].[Asientos] ([id_asiento], [codigoAsiento], [fecha], [debe], [haber], [sAcreedor], [sDeudor], [id_cuenta]) VALUES (3, N'0001', CAST(0x063F0B00 AS Date), 0, 100, 100, 0, 17)
INSERT [dbo].[Asientos] ([id_asiento], [codigoAsiento], [fecha], [debe], [haber], [sAcreedor], [sDeudor], [id_cuenta]) VALUES (4, N'0003', CAST(0x063F0B00 AS Date), 1000, 0, 0, 1000, 8)
INSERT [dbo].[Asientos] ([id_asiento], [codigoAsiento], [fecha], [debe], [haber], [sAcreedor], [sDeudor], [id_cuenta]) VALUES (5, N'0003', CAST(0x063F0B00 AS Date), 100, 0, 0, 100, 29)
INSERT [dbo].[Asientos] ([id_asiento], [codigoAsiento], [fecha], [debe], [haber], [sAcreedor], [sDeudor], [id_cuenta]) VALUES (6, N'0003', CAST(0x063F0B00 AS Date), 0, 1100, 1100, 0, 17)
INSERT [dbo].[Asientos] ([id_asiento], [codigoAsiento], [fecha], [debe], [haber], [sAcreedor], [sDeudor], [id_cuenta]) VALUES (7, N'0005', CAST(0x063F0B00 AS Date), 2000, 0, 0, 2000, 1)
INSERT [dbo].[Asientos] ([id_asiento], [codigoAsiento], [fecha], [debe], [haber], [sAcreedor], [sDeudor], [id_cuenta]) VALUES (8, N'0005', CAST(0x063F0B00 AS Date), 0, 2000, 2000, 0, 25)
INSERT [dbo].[Asientos] ([id_asiento], [codigoAsiento], [fecha], [debe], [haber], [sAcreedor], [sDeudor], [id_cuenta]) VALUES (9, N'0008', CAST(0x063F0B00 AS Date), 900, 0, 0, 900, 1)
INSERT [dbo].[Asientos] ([id_asiento], [codigoAsiento], [fecha], [debe], [haber], [sAcreedor], [sDeudor], [id_cuenta]) VALUES (10, N'0008', CAST(0x063F0B00 AS Date), 0, 900, 900, 0, 26)
SET IDENTITY_INSERT [dbo].[Asientos] OFF
