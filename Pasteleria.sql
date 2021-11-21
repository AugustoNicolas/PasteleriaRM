Create database pasteleria;

use pasteleria;

Create table tblClientes(
   idCliente  int IDENTITY(1,1) NOT NULL ,
   nit int not null,
   nombre varchar(20) not null,
   telf varchar(20) ,
   ref varchar(50),
   primary key (idCliente)
);

Create table tblPedido(
   idPedido  int IDENTITY(1,1) NOT NULL ,
   numPedido int not null,
   fechaInicio datetime not null,
   fechaEntrega datetime,
   costo money not null,
   dirreccion varchar(50),
   estado int not null,
   nitCliente int not null,
   primary key (idPedido),
   foreign key (nitCliente) references tblClientes(idCliente)
);

Create table tblTrabajador (
   idTrabajador  int IDENTITY(1,1) NOT NULL ,
   ciTrabajador int not null,
   nombre varchar(20) not null,
   telf varchar(20) not null,
   primary key (idTrabajador)
);

Create table tblProducto (
   idProducto  int IDENTITY(1,1) NOT NULL ,
   precio money not null,
   stock int not null,
   categoria varchar(10),
   primary key (idProducto)
);

Create table tblTortas (
   idTorta  int IDENTITY(1,1) NOT NULL ,
   tamaño varchar(10) not null,
   saborMasa varchar(10) not null,
   saborRelleno varchar(10) not null,
   idProducto int not null
   primary key (idTorta)
   foreign key (idProducto) references tblProducto(idProducto)
);

Create table tblmasas(
   idMasa  int IDENTITY(1,1) NOT NULL ,
   relleno varchar(10) not null,
   idProducto int not null
   primary key (idMasa)
   foreign key (idProducto) references tblProducto(idProducto)
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

Create table tblElaboracion(
   idElaboracion  int IDENTITY(1,1) NOT NULL ,
   idTrabajador int not null,
   numPed int not null,   
   primary key (idElaboracion),
   foreign key (idTrabajador) references tblTrabajador(idTrabajador),   
   foreign key (numPed) references tblPedido(idPedido)
);

Create table tblDetallePedido(
   idElaboracion  int IDENTITY(1,1) NOT NULL ,
   idProducto int not null,
   numPed int not null,   
   primary key (idElaboracion),
   foreign key (idProducto) references tblProducto(idProducto),   
   foreign key (numPed) references tblPedido(idPedido)
);