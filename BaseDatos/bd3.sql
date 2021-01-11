drop database if exists tallerShelby;

create database tallerShelby;
use tallerShelby;

create table usuario(

	idUsuario int auto_increment primary key,
    nombre varchar(50),
    correo varchar(50),
    contrasena varchar(50)

);

create table marca (

	idMarca int primary key auto_increment,
    nombre varchar(50)

);

create table sucursal(

	idSucursal int primary key auto_increment,
    nombre varchar(50)

);


create table bodega (

	idBodega int primary key auto_increment,
    nombre varchar(50),
    idSucursal int,
    foreign key (idSucursal) references sucursal (idSucursal)

);

create table detalleAro(
	
	idDetalleAro int primary key auto_increment,
    codigo varchar(25),
    medida int,
    pcd varchar(50),
    pcd2 varchar(50), 
    diseno varchar(25),
    costo decimal(10,2),
    precio decimal(10,2)
    
);

create table aro(

	idAro int auto_increment primary key,
	idDetalleAro int,
    foreign key(idDetalleAro) references detalleAro(idDetalleAro),
    cantidad int,
    fechaModificacion datetime default current_timestamp,
    usuarioModificacion int,
    foreign key (usuarioModificacion) references usuario(idUsuario),
    idSucursal int,
    foreign key (idSucursal) references sucursal(idSucursal),
    idBodega int,
    foreign key (idBodega) references bodega(idBodega)


);

create table detalleLlanta (

	idDetalleLlanta int primary key auto_increment,
    codigo varchar(25),
    medida varchar(50),
    idMarca int,
    foreign key(idMarca) references marca(idMarca),
    costo decimal(10,2),
    precio decimal(10,2)
	
);

#detalleLlanta

create table llanta(

	idLlanta int auto_increment primary key,
	idDetalleLlanta int,
    foreign key(idDetalleLlanta) references detalleLlanta(idDetalleLlanta),
    cantidad int,
    fechaModificacion datetime default current_timestamp,
    usuarioModificacion int,
    foreign key (usuarioModificacion) references usuario(idUsuario),
    idSucursal int,
    foreign key (idSucursal) references sucursal(idSucursal),
    idBodega int,
    foreign key (idBodega) references bodega(idBodega)


);

create table tipoMovimiento(

	idTipoMovimiento int primary key,
    nombre varchar(65)

);

create table movimiento(

	idEntrada int primary key auto_increment,
    idDetalleAro int,
    foreign key(idDetalleAro) references detalleAro(idDetalleAro),
	idDetalleLlanta int,
    foreign key(idDetalleLlanta) references detalleLlanta(idDetalleLlanta),
    idSucursal int,
    foreign key(idSucursal) references sucursal(idSucursal),
    cantidad int,
	fecha datetime,
    idTipoMovimiento int,
    foreign key (idTipoMovimiento) references tipoMovimiento(idTipoMovimiento)
    
    #2 -> ingreso; false -> 0;

);

insert into tipoMovimiento values (0, "Salida"), (1, "Entrada");



