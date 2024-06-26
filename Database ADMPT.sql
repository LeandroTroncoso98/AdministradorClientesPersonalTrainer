USE [ADMPT]
GO
/****** Object:  Table [dbo].[Cuenta]    Script Date: 27/5/2024 01:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cuenta](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Fecha_Pago] [datetime] NOT NULL,
	[Fecha_Vencimiento] [datetime] NOT NULL,
	[Monto] [decimal](13, 2) NOT NULL,
 CONSTRAINT [PK_Cuenta] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dia]    Script Date: 27/5/2024 01:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dia](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[Rutina_Id] [int] NOT NULL,
 CONSTRAINT [PK_Dia] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ejercicio]    Script Date: 27/5/2024 01:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ejercicio](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](500) NOT NULL,
	[LinkVideo] [nvarchar](500) NOT NULL,
	[Dia_Id] [int] NOT NULL,
 CONSTRAINT [PK_Ejercicio] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rutina]    Script Date: 27/5/2024 01:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rutina](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Objetivo] [nvarchar](500) NOT NULL,
	[Cliente_Id] [int] NOT NULL,
 CONSTRAINT [PK_Rutina] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 27/5/2024 01:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Numero] [nchar](10) NOT NULL,
	[Nombre] [nchar](50) NOT NULL,
	[Apellido] [nchar](50) NOT NULL,
	[Contraseña] [nvarchar](250) NULL,
	[Rutina_Id] [int] NULL,
	[Cuenta_Id] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SpCliente_Actualizar]    Script Date: 27/5/2024 01:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Troncoso Leandro
-- Create date: 25/05/2024
-- Description:	Stored Procedure para actualizar Cliente
-- =============================================
CREATE PROCEDURE [dbo].[SpCliente_Actualizar]
	@Id INT,
	@Nombre NCHAR(50),
	@Apellido NCHAR(50),
	@Numero NCHAR(10),
	@Email NVARCHAR(100)

AS
BEGIN
	UPDATE Usuario
	SET Nombre = @Nombre,Apellido =@Apellido, Numero = @Numero, Email =  @Email
	WHERE Id = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[SpCliente_Borrar]    Script Date: 27/5/2024 01:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Troncoso Leandro	
-- Create date: 26/05/2024
-- Description:	Borrar cliente
-- =============================================
CREATE PROCEDURE [dbo].[SpCliente_Borrar] 
	 @Id INT
AS
BEGIN
	DELETE FROM Usuario 
	WHERE Id = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[SpCliente_Crear]    Script Date: 27/5/2024 01:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Troncoso Leandro Nahuel>
-- Create date: <24/05/2024>
-- Description:	<Procedure para insertar clientes>
-- =============================================
CREATE PROCEDURE [dbo].[SpCliente_Crear]
@Nombre nchar(50),
@Apellido nchar(50),
@Email NVARCHAR(100),
@Numero NCHAR(10)
AS
BEGIN
	INSERT INTO Usuario(Nombre,Apellido,Email,Numero)
	VALUES (@Nombre,@Apellido,@Email,@Numero)
END
GO
/****** Object:  StoredProcedure [dbo].[SpCliente_EmailExiste]    Script Date: 27/5/2024 01:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Troncoso Leandro
-- Create date: 26/05/2024
-- Description:	Verifica si un email existe en la base de datos.
-- =============================================
CREATE PROCEDURE [dbo].[SpCliente_EmailExiste]
@Id INT
AS
BEGIN
SELECT
	a.Id,
	a.Email
FROM
	Usuario AS a
WHERE a.Id NOT LIKE @Id
END
GO
/****** Object:  StoredProcedure [dbo].[SpCliente_Listar]    Script Date: 27/5/2024 01:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SpCliente_Listar] 
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select
		a.Id,a.Nombre,a.Apellido,a.Email,a.Numero
	from
		Usuario AS a
END
GO
