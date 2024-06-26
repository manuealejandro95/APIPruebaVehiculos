USE [PRUEBAAUTOS]
GO
/****** Object:  Table [dbo].[ARCHIVO]    Script Date: 5/06/2024 12:50:05 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ARCHIVO](
	[IdArchivo] [int] NOT NULL,
	[IdVehiculo] [int] NOT NULL,
	[NombreArchivo] [varchar](max) NOT NULL,
	[Extension] [varchar](5) NOT NULL,
	[Formato] [varchar](200) NOT NULL,
	[Archivo] [image] NOT NULL,
	[Tamaño] [float] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COLOR]    Script Date: 5/06/2024 12:50:05 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COLOR](
	[IdColor] [int] IDENTITY(1,1) NOT NULL,
	[NombreColor] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FASEVEHICULO]    Script Date: 5/06/2024 12:50:05 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FASEVEHICULO](
	[IdFase] [int] IDENTITY(1,1) NOT NULL,
	[NombreFase] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MARCA]    Script Date: 5/06/2024 12:50:05 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MARCA](
	[IdMarca] [int] IDENTITY(1,1) NOT NULL,
	[NombreMarca] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VEHICULO]    Script Date: 5/06/2024 12:50:05 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VEHICULO](
	[IdVehiculo] [int] IDENTITY(1,1) NOT NULL,
	[IdColor] [int] NOT NULL,
	[IdMarca] [int] NOT NULL,
	[IdYear] [int] NOT NULL,
	[IdFase] [int] NOT NULL,
	[Linea] [varchar](50) NOT NULL,
	[Placa] [varchar](9) NOT NULL,
	[Kilometros] [int] NOT NULL,
	[Valor] [numeric](18, 0) NOT NULL,
	[Observaciones] [varchar](200) NOT NULL,
 CONSTRAINT [PK_VEHICULO] PRIMARY KEY CLUSTERED 
(
	[IdVehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[YEARS]    Script Date: 5/06/2024 12:50:05 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YEARS](
	[IdAno] [int] IDENTITY(1,1) NOT NULL,
	[Ano] [int] NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[COLOR] ON 

INSERT [dbo].[COLOR] ([IdColor], [NombreColor]) VALUES (1, N'Rojo')
INSERT [dbo].[COLOR] ([IdColor], [NombreColor]) VALUES (2, N'Vino Tinto')
INSERT [dbo].[COLOR] ([IdColor], [NombreColor]) VALUES (3, N'Azul')
INSERT [dbo].[COLOR] ([IdColor], [NombreColor]) VALUES (4, N'Gris')
INSERT [dbo].[COLOR] ([IdColor], [NombreColor]) VALUES (5, N'Negro')
INSERT [dbo].[COLOR] ([IdColor], [NombreColor]) VALUES (6, N'Blanco')
INSERT [dbo].[COLOR] ([IdColor], [NombreColor]) VALUES (7, N'Plateado')
INSERT [dbo].[COLOR] ([IdColor], [NombreColor]) VALUES (8, N'Amarillo')
INSERT [dbo].[COLOR] ([IdColor], [NombreColor]) VALUES (9, N'Verde')
SET IDENTITY_INSERT [dbo].[COLOR] OFF
GO
SET IDENTITY_INSERT [dbo].[FASEVEHICULO] ON 

INSERT [dbo].[FASEVEHICULO] ([IdFase], [NombreFase]) VALUES (1, N'Disponible')
INSERT [dbo].[FASEVEHICULO] ([IdFase], [NombreFase]) VALUES (2, N'Reparacion')
INSERT [dbo].[FASEVEHICULO] ([IdFase], [NombreFase]) VALUES (3, N'Vitrina')
INSERT [dbo].[FASEVEHICULO] ([IdFase], [NombreFase]) VALUES (4, N'Vendido')
SET IDENTITY_INSERT [dbo].[FASEVEHICULO] OFF
GO
SET IDENTITY_INSERT [dbo].[MARCA] ON 

INSERT [dbo].[MARCA] ([IdMarca], [NombreMarca]) VALUES (1, N'Chevrolet')
INSERT [dbo].[MARCA] ([IdMarca], [NombreMarca]) VALUES (2, N'Renault')
INSERT [dbo].[MARCA] ([IdMarca], [NombreMarca]) VALUES (3, N'Nissan')
INSERT [dbo].[MARCA] ([IdMarca], [NombreMarca]) VALUES (4, N'Mazda')
INSERT [dbo].[MARCA] ([IdMarca], [NombreMarca]) VALUES (5, N'Ford')
SET IDENTITY_INSERT [dbo].[MARCA] OFF
GO
SET IDENTITY_INSERT [dbo].[VEHICULO] ON 

INSERT [dbo].[VEHICULO] ([IdVehiculo], [IdColor], [IdMarca], [IdYear], [IdFase], [Linea], [Placa], [Kilometros], [Valor], [Observaciones]) VALUES (1, 2, 4, 8, 1, N'CX-30', N'UQE433', 12000000, CAST(0 AS Numeric(18, 0)), N'Unico Dueño')
INSERT [dbo].[VEHICULO] ([IdVehiculo], [IdColor], [IdMarca], [IdYear], [IdFase], [Linea], [Placa], [Kilometros], [Valor], [Observaciones]) VALUES (2, 2, 4, 8, 1, N'CX-30', N'UQE439', 12000000, CAST(300000000 AS Numeric(18, 0)), N'Unico Dueño')
INSERT [dbo].[VEHICULO] ([IdVehiculo], [IdColor], [IdMarca], [IdYear], [IdFase], [Linea], [Placa], [Kilometros], [Valor], [Observaciones]) VALUES (3, 2, 4, 8, 4, N'march', N'UQE456', 12000000, CAST(300000000 AS Numeric(18, 0)), N'Unico Dueño')
INSERT [dbo].[VEHICULO] ([IdVehiculo], [IdColor], [IdMarca], [IdYear], [IdFase], [Linea], [Placa], [Kilometros], [Valor], [Observaciones]) VALUES (4, 2, 4, 8, 2, N'march', N'UQE457', 12000000, CAST(300000000 AS Numeric(18, 0)), N'Unico Dueño')
SET IDENTITY_INSERT [dbo].[VEHICULO] OFF
GO
SET IDENTITY_INSERT [dbo].[YEARS] ON 

INSERT [dbo].[YEARS] ([IdAno], [Ano]) VALUES (1, 1950)
INSERT [dbo].[YEARS] ([IdAno], [Ano]) VALUES (2, 1951)
INSERT [dbo].[YEARS] ([IdAno], [Ano]) VALUES (3, 1952)
INSERT [dbo].[YEARS] ([IdAno], [Ano]) VALUES (4, 1953)
INSERT [dbo].[YEARS] ([IdAno], [Ano]) VALUES (5, 1954)
INSERT [dbo].[YEARS] ([IdAno], [Ano]) VALUES (6, 1955)
INSERT [dbo].[YEARS] ([IdAno], [Ano]) VALUES (7, 1956)
INSERT [dbo].[YEARS] ([IdAno], [Ano]) VALUES (8, 1957)
INSERT [dbo].[YEARS] ([IdAno], [Ano]) VALUES (9, 1958)
SET IDENTITY_INSERT [dbo].[YEARS] OFF
GO
/****** Object:  StoredProcedure [dbo].[GuardaVehiculos]    Script Date: 5/06/2024 12:50:05 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Manuel Pacheco>
-- Create date: <Create Date,,04/06/2024>
-- Description:	<Description,,Sp que guarda nuevos vehiculos. Devuelve el ultimo Id insertado de la tabla para posteriormente guardar las imagenes>
-- =============================================
CREATE PROCEDURE [dbo].[GuardaVehiculos]
	@IdColor INT,
	@IdMarca INT,
	@IdAno INT,
	@IdFase INT,
	@Linea VARCHAR(50),
	@Placa VARCHAR(9),
	@Kilometros INT,
	@Valor NUMERIC(18,0),
	@Observaciones VARCHAR(200)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN;
			INSERT INTO [dbo].[VEHICULO]
			   ([IdColor]
			   ,[IdMarca]
			   ,[IdYear]
			   ,[IdFase]
			   ,[Linea]
			   ,[Placa]
			   ,[Kilometros]
			   ,[Valor]
			   ,[Observaciones])
			VALUES
			   (@IdColor
			   ,@IdMarca
			   ,@IdAno
			   ,@IdFase
			   ,@Linea
			   ,@Placa
			   ,@Kilometros
			   ,@Valor
			   ,@Observaciones);
		COMMIT TRAN;
	END TRY
	BEGIN CATCH
		ROLLBACK;
	END CATCH
END
SELECT CAST(SCOPE_IDENTITY() AS int) AS Id
GO
/****** Object:  StoredProcedure [dbo].[VerVehiculos]    Script Date: 5/06/2024 12:50:05 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Manuel Pacheco>
-- Create date: <Create Date,, 05/06/2024>
-- Description:	<Description,,Obtiene todos los carros registrados a exepcion de los que estan vendidos>
-- =============================================
CREATE PROCEDURE [dbo].[VerVehiculos]
AS
BEGIN
	SELECT VEHICULO.IdVehiculo,COLOR.NombreColor AS Color, MARCA.NombreMarca AS Marca, YEARS.Ano AS [Año], FASEVEHICULO.NombreFase AS Fase, VEHICULO.Linea,VEHICULO.Placa,VEHICULO.Kilometros,VEHICULO.Valor,VEHICULO.Observaciones 
	FROM VEHICULO WITH (NOLOCK)
	INNER JOIN COLOR WITH (NOLOCK)
		ON COLOR.IdColor = VEHICULO.IdColor
	INNER JOIN MARCA WITH (NOLOCK)
		ON MARCA.IdMarca = VEHICULO.IdMarca
	INNER JOIN YEARS WITH (NOLOCK)
		ON YEARS.IdAno = VEHICULO.IdYear
	INNER JOIN FASEVEHICULO WITH (NOLOCK)
		ON FASEVEHICULO.IdFase = VEHICULO.IdFase
		AND FASEVEHICULO.IdFase NOT IN (4)
END
GO
