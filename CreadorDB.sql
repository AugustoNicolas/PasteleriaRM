USE [PasteleriaRM]
GO
/****** Object:  Table [dbo].[tblClientes]    Script Date: 3/12/2021 05:08:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblClientes](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[nit] [int] NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[telf] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDetallePedido]    Script Date: 3/12/2021 05:08:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDetallePedido](
	[idElaboracion] [int] IDENTITY(1,1) NOT NULL,
	[idProducto] [int] NOT NULL,
	[idPedido] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idElaboracion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblIngredientes]    Script Date: 3/12/2021 05:08:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblIngredientes](
	[idIngrediente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[precio] [money] NOT NULL,
	[stock] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idIngrediente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPedido]    Script Date: 3/12/2021 05:08:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPedido](
	[idPedido] [int] IDENTITY(1,1) NOT NULL,
	[numPedido] [int] NOT NULL,
	[fechaInicio] [datetime] NOT NULL,
	[fechaEntrega] [datetime] NULL,
	[costo] [money] NOT NULL,
	[direccion] [varchar](50) NULL,
	[estado] [int] NOT NULL,
	[idCliente] [int] NOT NULL,
	[idTrabajador] [int] NOT NULL,
	[lat] [float] NULL,
	[lng] [float] NULL,
	[descripcionMap] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblProduccion]    Script Date: 3/12/2021 05:08:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProduccion](
	[idProduccion] [int] IDENTITY(1,1) NOT NULL,
	[idProducto] [int] NOT NULL,
	[idIngredinte] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idProduccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblProducto]    Script Date: 3/12/2021 05:08:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProducto](
	[idProducto] [int] IDENTITY(1,1) NOT NULL,
	[precio] [money] NOT NULL,
	[stock] [int] NOT NULL,
	[categoria] [varchar](10) NOT NULL,
	[tamaño] [varchar](10) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[produccion] [int] NOT NULL,
	[estatus] [int] NOT NULL,
	[foto] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTrabajador]    Script Date: 3/12/2021 05:08:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTrabajador](
	[idTrabajador] [int] IDENTITY(1,1) NOT NULL,
	[ciTrabajador] [int] NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[telf] [varchar](20) NOT NULL,
	[estado] [int] NOT NULL,
	[dateMod] [date] NULL,
	[dateIn] [date] NOT NULL,
	[nick] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idTrabajador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblDetallePedido]  WITH CHECK ADD FOREIGN KEY([idProducto])
REFERENCES [dbo].[tblProducto] ([idProducto])
GO
ALTER TABLE [dbo].[tblDetallePedido]  WITH CHECK ADD FOREIGN KEY([idPedido])
REFERENCES [dbo].[tblPedido] ([idPedido])
GO
ALTER TABLE [dbo].[tblPedido]  WITH CHECK ADD FOREIGN KEY([idTrabajador])
REFERENCES [dbo].[tblTrabajador] ([idTrabajador])
GO
ALTER TABLE [dbo].[tblPedido]  WITH CHECK ADD FOREIGN KEY([idCliente])
REFERENCES [dbo].[tblClientes] ([idCliente])
GO
ALTER TABLE [dbo].[tblProduccion]  WITH CHECK ADD FOREIGN KEY([idIngredinte])
REFERENCES [dbo].[tblIngredientes] ([idIngrediente])
GO
ALTER TABLE [dbo].[tblProduccion]  WITH CHECK ADD FOREIGN KEY([idProducto])
REFERENCES [dbo].[tblProducto] ([idProducto])
GO
