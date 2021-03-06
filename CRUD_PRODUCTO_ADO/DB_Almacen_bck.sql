USE [master]
GO
/****** Object:  Database [DB_Almacen]    Script Date: 29/03/2021 21:10:51 ******/
CREATE DATABASE [DB_Almacen]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_Almacen', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DB_Almacen.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DB_Almacen_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DB_Almacen_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DB_Almacen] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_Almacen].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_Almacen] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_Almacen] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_Almacen] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_Almacen] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_Almacen] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_Almacen] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DB_Almacen] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_Almacen] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_Almacen] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_Almacen] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_Almacen] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_Almacen] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_Almacen] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_Almacen] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_Almacen] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DB_Almacen] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_Almacen] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_Almacen] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_Almacen] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_Almacen] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_Almacen] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_Almacen] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_Almacen] SET RECOVERY FULL 
GO
ALTER DATABASE [DB_Almacen] SET  MULTI_USER 
GO
ALTER DATABASE [DB_Almacen] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_Almacen] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_Almacen] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_Almacen] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DB_Almacen] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DB_Almacen', N'ON'
GO
ALTER DATABASE [DB_Almacen] SET QUERY_STORE = OFF
GO
USE [DB_Almacen]
GO
/****** Object:  Table [dbo].[Categoria_Producto]    Script Date: 29/03/2021 21:10:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria_Producto](
	[CategoriaId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Categoria_Producto] PRIMARY KEY CLUSTERED 
(
	[CategoriaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 29/03/2021 21:10:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[ProductoId] [int] IDENTITY(1,1) NOT NULL,
	[CategoriaId] [int] NOT NULL,
	[Nombre] [varchar](250) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Precio] [decimal](18, 2) NULL,
	[Estado] [char](1) NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[ProductoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 29/03/2021 21:10:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](250) NULL,
	[Password] [varchar](250) NULL,
	[Estado] [char](1) NULL,
	[Nombre] [varchar](250) NULL,
	[Apellido] [varchar](250) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categoria_Producto] ON 

INSERT [dbo].[Categoria_Producto] ([CategoriaId], [Nombre]) VALUES (1, N'Gaseosa')
INSERT [dbo].[Categoria_Producto] ([CategoriaId], [Nombre]) VALUES (2, N'Galleta')
INSERT [dbo].[Categoria_Producto] ([CategoriaId], [Nombre]) VALUES (3, N'Gomitas')
INSERT [dbo].[Categoria_Producto] ([CategoriaId], [Nombre]) VALUES (5, N'Chicle')
INSERT [dbo].[Categoria_Producto] ([CategoriaId], [Nombre]) VALUES (6, N'Abarrotes')
INSERT [dbo].[Categoria_Producto] ([CategoriaId], [Nombre]) VALUES (7, N'Cereal')
SET IDENTITY_INSERT [dbo].[Categoria_Producto] OFF
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([ProductoId], [CategoriaId], [Nombre], [Cantidad], [Precio], [Estado]) VALUES (1, 1, N'Inka Cola', 100, CAST(2.50 AS Decimal(18, 2)), N'A')
INSERT [dbo].[Producto] ([ProductoId], [CategoriaId], [Nombre], [Cantidad], [Precio], [Estado]) VALUES (2, 1, N'Coca Cola', 100, CAST(2.50 AS Decimal(18, 2)), N'A')
INSERT [dbo].[Producto] ([ProductoId], [CategoriaId], [Nombre], [Cantidad], [Precio], [Estado]) VALUES (3, 2, N'Margarita', 100, CAST(0.80 AS Decimal(18, 2)), N'A')
INSERT [dbo].[Producto] ([ProductoId], [CategoriaId], [Nombre], [Cantidad], [Precio], [Estado]) VALUES (4, 1, N'Fanta', 200, CAST(2.00 AS Decimal(18, 2)), N'A')
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserId], [Username], [Password], [Estado], [Nombre], [Apellido]) VALUES (1, N'dalza', N'ujJTh2rta8ItSm/1PYQGxq2GQZXtFEq1yHYhtsIztUi66uaVbfNG7IwX9eoQ817jy8UUeX7X3dMUVGTioLq0Ew==', N'A', N'Diego', N'Alza')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Categoria_Producto] FOREIGN KEY([CategoriaId])
REFERENCES [dbo].[Categoria_Producto] ([CategoriaId])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Categoria_Producto]
GO
/****** Object:  StoredProcedure [dbo].[USP_ActualizarCategoriaProducto]    Script Date: 29/03/2021 21:10:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Diego Alza
-- Create date: 26/03/2021
-- Description:	Actualizar Categoria
-- =============================================
CREATE PROCEDURE [dbo].[USP_ActualizarCategoriaProducto]
@CategoriaId int,
@Nombre varchar(250)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	UPDATE [dbo].[Categoria_Producto]
	SET [Nombre] = @Nombre
	WHERE CategoriaId = @CategoriaId

END
GO
/****** Object:  StoredProcedure [dbo].[USP_ActualizarProducto]    Script Date: 29/03/2021 21:10:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Diego Alza
-- Create date: 26/03/2021
-- Description:	Actualizar Producto
-- =============================================
CREATE PROCEDURE [dbo].[USP_ActualizarProducto]
@ProductoId int,
@CategoriaId int,
@Nombre varchar(250), @Cantidad int, @Precio decimal(18,2), @Estado char(1)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	UPDATE [dbo].[Producto]
	SET [CategoriaId] = @CategoriaId
      ,[Nombre] = @Nombre
      ,[Cantidad] = @Cantidad
      ,[Precio] = @Precio
      ,[Estado] = @Estado
	 WHERE ProductoId = @ProductoId

END
GO
/****** Object:  StoredProcedure [dbo].[USP_CreateProduct]    Script Date: 29/03/2021 21:10:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Diego Alza
-- Create date: 24/03/2021
-- Description:	Insertar Producto
-- =============================================
CREATE PROCEDURE [dbo].[USP_CreateProduct] 
	
	@CategoriaId int, @Nombre varchar(250), @Cantidad int,
	@Precio decimal(18,2), @Estado char(1)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO [dbo].[Producto]
           ([CategoriaId]
           ,[Nombre]
           ,[Cantidad]
           ,[Precio]
           ,[Estado])
     VALUES
           (@CategoriaId
           ,@Nombre
           ,@Cantidad
           ,@Precio
           ,@Estado)

END
GO
/****** Object:  StoredProcedure [dbo].[USP_EliminarCategoriaProducto]    Script Date: 29/03/2021 21:10:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Diego Alza
-- Create date: 26/03/2021
-- Description:	Eliminar Categoria
-- =============================================
CREATE PROCEDURE [dbo].[USP_EliminarCategoriaProducto]

@CategoriaID int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	Delete
	Categoria_Producto 
	where CategoriaId = @CategoriaID

END
GO
/****** Object:  StoredProcedure [dbo].[USP_EliminarProducto]    Script Date: 29/03/2021 21:10:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Diego Alza
-- Create date: 26/03/2021
-- Description:	Eliminar Producto
-- =============================================
CREATE PROCEDURE [dbo].[USP_EliminarProducto]
@ProductoId int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	Delete Producto where @ProductoId = @ProductoId
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetProductById]    Script Date: 29/03/2021 21:10:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Diego ALza
-- Create date: 24/03/2021
-- Description:	Obtener producto por Id
-- =============================================
CREATE PROCEDURE [dbo].[USP_GetProductById]

@ProductId int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	
	Select	p.ProductoId, p.CategoriaId, p.Nombre, p.Cantidad, p.Precio, p.Estado
	from Producto p
	where p.ProductoId = @ProductId

END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertarCategoriaProducto]    Script Date: 29/03/2021 21:10:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Diego Alza
-- Create date: 26/03/2021
-- Description:	Insertar Categoria
-- =============================================
CREATE PROCEDURE [dbo].[USP_InsertarCategoriaProducto]

@Nombre varchar(250)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO [dbo].[Categoria_Producto]
           ([Nombre])
     VALUES
           (@Nombre)

END
GO
/****** Object:  StoredProcedure [dbo].[USP_ListarCategoriaProducto]    Script Date: 29/03/2021 21:10:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Diego Alza
-- Create date: 26/03/2021
-- Description:	Listar Categoria
-- =============================================
CREATE PROCEDURE [dbo].[USP_ListarCategoriaProducto]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	Select cp.CategoriaId, cp.Nombre
	from Categoria_Producto cp

END
GO
/****** Object:  StoredProcedure [dbo].[USP_ListProducts]    Script Date: 29/03/2021 21:10:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Diego ALza
-- Create date: 24/03/2021
-- Description:	Listar Productos con el nombre de la categoria
-- =============================================
CREATE PROCEDURE [dbo].[USP_ListProducts]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	
	Select	p.ProductoId, cp.Nombre as Categoria, p.Nombre, p.Cantidad, p.Precio, p.Estado
	from Producto p
	inner join Categoria_Producto cp on p.CategoriaId = cp.CategoriaId
	order by p.Nombre 

END
GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 29/03/2021 21:10:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Diego Alza
-- Create date: <Create Date,,>
-- Description:	login
-- =============================================
CREATE PROCEDURE [dbo].[USP_Login]
	@username varchar(250), @password varchar(250)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select *
	from [dbo].[User] u
	where u.Username = @username and u.Password = @password

END
GO
/****** Object:  StoredProcedure [dbo].[USP_ObtenerCategoriaProducto]    Script Date: 29/03/2021 21:10:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Diego Alza
-- Create date: 26/03/2021
-- Description:	Obtener Categoria
-- =============================================
CREATE PROCEDURE [dbo].[USP_ObtenerCategoriaProducto]

@CategoriaID int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	Select cp.CategoriaId, cp.Nombre
	from Categoria_Producto cp
	where cp.CategoriaId = @CategoriaID

END
GO
USE [master]
GO
ALTER DATABASE [DB_Almacen] SET  READ_WRITE 
GO
