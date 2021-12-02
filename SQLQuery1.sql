Create database PasteleriaRM;
use PasteleriaRM;

Create table tblClientes(
   idCliente  int IDENTITY(1,1) NOT NULL ,
   nit int not null,
   nombre varchar(20) not null,
   telf varchar(20) ,
   ref varchar(50),
   primary key (idCliente)
);


Create table tblTrabajador (
   idTrabajador  int IDENTITY(1,1) NOT NULL ,
   ciTrabajador int not null,
   nombre varchar(20) not null,
   telf varchar(20) not null,
   nick varchar(20) not null,
   estado int not null,
   primary key (idTrabajador),
   dateIn date not null,
   dateMod date,
);

alter table tblTrabajador add dateMod date

update tblTrabajador set dateIn='11/30/2021'
select * from tblTrabajador

alter table tblTrabajador alter column dateIn date not null

Create table tblPedido(
   idPedido  int IDENTITY(1,1) NOT NULL ,
   numPedido int not null,
   fechaInicio datetime not null,
   fechaEntrega datetime,
   costo money not null,
   dirreccion varchar(50),
   estado int not null,
   idCliente int not null,
   idTrabajador int not null
   primary key (idPedido),
   foreign key (idCliente) references tblClientes(idCliente),
   foreign key (idTrabajador) references tblTrabajador(idTrabajador)
);

Create table tblProducto (
   idProducto  int IDENTITY(1,1) NOT NULL ,
   nombre varchar(20) not null,
   precio money not null,
   stock int not null,
   categoria varchar(10),
   tamaño varchar(10) not null,
   saborMasa varchar(20) ,
   saborRelleno varchar(20) ,
   relleno varchar(20) ,
   primary key (idProducto)
);

Create table tblIngredientes(
   idIngrediente  int IDENTITY(1,1) NOT NULL ,
   nombre varchar(20) not null,
   precio money not null,
   stock int not null,
   primary key (idIngrediente)
);

Create table tblProduccion(
   idProduccion  int IDENTITY(1,1) NOT NULL ,
   idProducto int not null,
   idIngredinte int not null,   
   primary key (idProduccion),
   foreign key (idProducto) references tblProducto(idProducto),   
   foreign key (idIngredinte) references tblIngredientes(idIngrediente)
);



Create table tblDetallePedido(
   idElaboracion  int IDENTITY(1,1) NOT NULL ,
   idProducto int not null,
   idPedido int not null,   
   cantidad int not null,
   primary key (idElaboracion),
   foreign key (idProducto) references tblProducto(idProducto),   
   foreign key (idPedido) references tblPedido(idPedido)
);


INSERT INTO tblProducto (precio, stock, categoria, tamaño, relleno, nombre) 
       VALUES	(20.5,5,'masitas', 'personal' , 'chocolate', 'Brownies');


INSERT INTO tblProducto (precio, stock, categoria, tamaño, relleno, nombre) 
       VALUES	(20,5,'masitas', 'personal' , 'queso', 'empanadas');

INSERT INTO tblClientes (nombre, nit, telf, ref) values ('Nicolas', 123456, '60019879', 'Palma verde');

INSERT INTO tblClientes (nombre, nit, telf, ref) values ('Yerson', 555555, '6845987', 'Calle Juanjo');

INSERT INTO tblClientes (nombre, nit, telf, ref) values ('Juan', 654321, '258964', 'Ventura mall');

INSERT INTO tblTrabajador(ciTrabajador, nombre, telf) values (9999999, 'Pedro',  '70977597');



SELECT * FROM tblProducto

Select P.idProducto, p.precio, p.stock, p.categoria, p.tamaño, p.saborMasa, p.saborRelleno, p.relleno, p.nombre
FROM tblProducto p, tblDetallePedido DP
WHERE p.idProducto = DP.idProducto and DP.idPedido = 1

SELECT precio FROM tblProducto WHERE idProducto = 1

SELECT * FROM tblproducto WHERE idProducto = 2

SELECT * FROM tblPedido

SELECT * FROM tblDetallePedido

SELECT Count(*)  FROM tblPedido    
SELECT * FROM tblTrabajador