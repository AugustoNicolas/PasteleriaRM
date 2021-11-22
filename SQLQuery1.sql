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
   primary key (idTrabajador)
);

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
   saborMasa varchar(10) ,
   saborRelleno varchar(10) ,
   relleno varchar(10) ,
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


SELECT * FROM tblProducto

Select P.idProducto, p.precio, p.stock, p.categoria, p.tamaño, p.saborMasa, p.saborRelleno, p.relleno, p.nombre
FROM tblProducto p, tblDetallePedido DP
WHERE p.idProducto = DP.idProducto and DP.idPedido = 1

SELECT precio FROM tblProducto WHERE idProducto = 1

SELECT * FROM tblproducto WHERE idProducto = 2

SELECT * FROM tblClientes

INSERT INTO tblProducto (precio, stock, categoria, tamaño, relleno, nombre) 
       VALUES	(20.5,5,'masitas', 'personal' , 'chocolate', 'Brownies');
	   
UPDATE tblClientes SET   nombre = @nombre,   nit=@nit,    telf=@telf,     ref=@ref    WHERE idCliente = @idcli

SELECT * FROM tblDetallePedido

SELECT Count(*)  FROM tblPedido    
SELECT * FROM tblTrabajador