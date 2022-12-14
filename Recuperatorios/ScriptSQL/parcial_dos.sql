USE [master]
GO
/****** Object:  Database [parcial_dos]    Script Date: 1/12/2022 18:16:41 ******/
CREATE DATABASE [parcial_dos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'parcial_dos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SUVA02\MSSQL\DATA\parcial_dos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'parcial_dos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SUVA02\MSSQL\DATA\parcial_dos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [parcial_dos] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [parcial_dos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [parcial_dos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [parcial_dos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [parcial_dos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [parcial_dos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [parcial_dos] SET ARITHABORT OFF 
GO
ALTER DATABASE [parcial_dos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [parcial_dos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [parcial_dos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [parcial_dos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [parcial_dos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [parcial_dos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [parcial_dos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [parcial_dos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [parcial_dos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [parcial_dos] SET  ENABLE_BROKER 
GO
ALTER DATABASE [parcial_dos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [parcial_dos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [parcial_dos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [parcial_dos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [parcial_dos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [parcial_dos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [parcial_dos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [parcial_dos] SET RECOVERY FULL 
GO
ALTER DATABASE [parcial_dos] SET  MULTI_USER 
GO
ALTER DATABASE [parcial_dos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [parcial_dos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [parcial_dos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [parcial_dos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [parcial_dos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [parcial_dos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'parcial_dos', N'ON'
GO
ALTER DATABASE [parcial_dos] SET QUERY_STORE = OFF
GO
USE [parcial_dos]
GO
/****** Object:  Table [dbo].[Administrador]    Script Date: 1/12/2022 18:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrador](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[apellido] [varchar](100) NULL,
	[email] [varchar](100) NULL,
	[contraseña] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Alumno]    Script Date: 1/12/2022 18:16:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumno](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[apellido] [varchar](100) NULL,
	[email] [varchar](100) NULL,
	[contraseña] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AlumnoAsistenciaCorrelativa]    Script Date: 1/12/2022 18:16:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AlumnoAsistenciaCorrelativa](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idMateriaCorrelativa] [int] NULL,
	[idAlumno] [int] NULL,
	[asistencia] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AlumnoAsistenciaMateria]    Script Date: 1/12/2022 18:16:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AlumnoAsistenciaMateria](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idMateria] [int] NULL,
	[idAlumno] [int] NULL,
	[asistencia] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CorrelativasCursadas]    Script Date: 1/12/2022 18:16:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CorrelativasCursadas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idAlumno] [int] NULL,
	[idMateriaCorrelativa] [int] NULL,
	[idParcialesCorrelativas] [int] NULL,
	[condicionMateria] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Correlatividades]    Script Date: 1/12/2022 18:16:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Correlatividades](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idMateria] [int] NULL,
	[idMateriaCorrelativa] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inscripcion]    Script Date: 1/12/2022 18:16:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inscripcion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[condicionAlumno] [varchar](50) NULL,
	[idAlumno] [int] NULL,
	[idMateria] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InscripcionACorrelativa]    Script Date: 1/12/2022 18:16:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InscripcionACorrelativa](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[condicionAlumno] [varchar](50) NULL,
	[idAlumno] [int] NULL,
	[idMateriaCorrelativa] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materia]    Script Date: 1/12/2022 18:16:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materia](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[cuatrimestre] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MateriaCorrelativa]    Script Date: 1/12/2022 18:16:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MateriaCorrelativa](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[cuatrimestre] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MateriaCorrelativaYProfesor]    Script Date: 1/12/2022 18:16:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MateriaCorrelativaYProfesor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idMateriaCorrelativa] [int] NULL,
	[idProfesor] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MateriaYProfesor]    Script Date: 1/12/2022 18:16:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MateriaYProfesor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idMateria] [int] NULL,
	[idProfesor] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Parciales]    Script Date: 1/12/2022 18:16:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parciales](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nota] [int] NULL,
	[fecha] [datetime] NULL,
	[tipoParcial] [varchar](50) NULL,
	[idAlumno] [int] NULL,
	[idMateria] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ParcialesCorrelativas]    Script Date: 1/12/2022 18:16:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ParcialesCorrelativas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nota] [varchar](50) NULL,
	[fecha] [datetime] NULL,
	[tipoParcial] [varchar](50) NULL,
	[idAlumno] [int] NULL,
	[idMateriaCorrelativa] [int] NULL,
 CONSTRAINT [PK__Parciale__3213E83F1B49EDB7] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesor]    Script Date: 1/12/2022 18:16:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[apellido] [varchar](100) NULL,
	[email] [varchar](100) NULL,
	[contraseña] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Administrador] ON 

INSERT [dbo].[Administrador] ([id], [nombre], [apellido], [email], [contraseña]) VALUES (1, N'Valentin', N'Suetta', N'suetta@gmail.com', N'esAdmin123')
SET IDENTITY_INSERT [dbo].[Administrador] OFF
GO
SET IDENTITY_INSERT [dbo].[Alumno] ON 

INSERT [dbo].[Alumno] ([id], [nombre], [apellido], [email], [contraseña]) VALUES (1, N'Felipe', N'Gil', N'felipe@gmail.com', N'esAlumno123')
SET IDENTITY_INSERT [dbo].[Alumno] OFF
GO
SET IDENTITY_INSERT [dbo].[Profesor] ON 

INSERT [dbo].[Profesor] ([id], [nombre], [apellido], [email], [contraseña]) VALUES (1, N'Mario', N'Rampi', N'mario@gmail.com', N'esProfe123')
SET IDENTITY_INSERT [dbo].[Profesor] OFF
GO
ALTER TABLE [dbo].[AlumnoAsistenciaCorrelativa]  WITH CHECK ADD  CONSTRAINT [FK_idAlumno_AlumnoAsistenciaCorrelativa] FOREIGN KEY([idAlumno])
REFERENCES [dbo].[Alumno] ([id])
GO
ALTER TABLE [dbo].[AlumnoAsistenciaCorrelativa] CHECK CONSTRAINT [FK_idAlumno_AlumnoAsistenciaCorrelativa]
GO
ALTER TABLE [dbo].[AlumnoAsistenciaCorrelativa]  WITH CHECK ADD  CONSTRAINT [FK_idMateriaCorrelativa_AlumnoAsistenciaCorrelativa] FOREIGN KEY([idMateriaCorrelativa])
REFERENCES [dbo].[MateriaCorrelativa] ([id])
GO
ALTER TABLE [dbo].[AlumnoAsistenciaCorrelativa] CHECK CONSTRAINT [FK_idMateriaCorrelativa_AlumnoAsistenciaCorrelativa]
GO
ALTER TABLE [dbo].[AlumnoAsistenciaMateria]  WITH CHECK ADD  CONSTRAINT [FK_idAlumno_AlumnoAsistencia] FOREIGN KEY([idAlumno])
REFERENCES [dbo].[Alumno] ([id])
GO
ALTER TABLE [dbo].[AlumnoAsistenciaMateria] CHECK CONSTRAINT [FK_idAlumno_AlumnoAsistencia]
GO
ALTER TABLE [dbo].[AlumnoAsistenciaMateria]  WITH CHECK ADD  CONSTRAINT [FK_idMateria_AlumnoAsistencia] FOREIGN KEY([idMateria])
REFERENCES [dbo].[Materia] ([id])
GO
ALTER TABLE [dbo].[AlumnoAsistenciaMateria] CHECK CONSTRAINT [FK_idMateria_AlumnoAsistencia]
GO
ALTER TABLE [dbo].[CorrelativasCursadas]  WITH CHECK ADD  CONSTRAINT [FK_idAlumno_CorrelativasCursadas] FOREIGN KEY([idAlumno])
REFERENCES [dbo].[Alumno] ([id])
GO
ALTER TABLE [dbo].[CorrelativasCursadas] CHECK CONSTRAINT [FK_idAlumno_CorrelativasCursadas]
GO
ALTER TABLE [dbo].[CorrelativasCursadas]  WITH CHECK ADD  CONSTRAINT [FK_idMateriaCorrelativa_CorrelativasCursadas] FOREIGN KEY([idMateriaCorrelativa])
REFERENCES [dbo].[MateriaCorrelativa] ([id])
GO
ALTER TABLE [dbo].[CorrelativasCursadas] CHECK CONSTRAINT [FK_idMateriaCorrelativa_CorrelativasCursadas]
GO
ALTER TABLE [dbo].[CorrelativasCursadas]  WITH CHECK ADD  CONSTRAINT [FK_idParcialesCorrelativas_CorrelativasCursadas] FOREIGN KEY([idParcialesCorrelativas])
REFERENCES [dbo].[ParcialesCorrelativas] ([id])
GO
ALTER TABLE [dbo].[CorrelativasCursadas] CHECK CONSTRAINT [FK_idParcialesCorrelativas_CorrelativasCursadas]
GO
ALTER TABLE [dbo].[Correlatividades]  WITH CHECK ADD  CONSTRAINT [FK_idMateria_Correlatividades] FOREIGN KEY([idMateria])
REFERENCES [dbo].[Materia] ([id])
GO
ALTER TABLE [dbo].[Correlatividades] CHECK CONSTRAINT [FK_idMateria_Correlatividades]
GO
ALTER TABLE [dbo].[Correlatividades]  WITH CHECK ADD  CONSTRAINT [FK_idMateriaCorrelativa_Correlatividades] FOREIGN KEY([idMateriaCorrelativa])
REFERENCES [dbo].[MateriaCorrelativa] ([id])
GO
ALTER TABLE [dbo].[Correlatividades] CHECK CONSTRAINT [FK_idMateriaCorrelativa_Correlatividades]
GO
ALTER TABLE [dbo].[Inscripcion]  WITH CHECK ADD  CONSTRAINT [FK_idAlumnoInscripcion] FOREIGN KEY([idAlumno])
REFERENCES [dbo].[Alumno] ([id])
GO
ALTER TABLE [dbo].[Inscripcion] CHECK CONSTRAINT [FK_idAlumnoInscripcion]
GO
ALTER TABLE [dbo].[Inscripcion]  WITH CHECK ADD  CONSTRAINT [FK_idMateriaInscripcion] FOREIGN KEY([idMateria])
REFERENCES [dbo].[Materia] ([id])
GO
ALTER TABLE [dbo].[Inscripcion] CHECK CONSTRAINT [FK_idMateriaInscripcion]
GO
ALTER TABLE [dbo].[InscripcionACorrelativa]  WITH CHECK ADD  CONSTRAINT [FK_idAlumnoInscripcionACorrelaiva] FOREIGN KEY([idAlumno])
REFERENCES [dbo].[Alumno] ([id])
GO
ALTER TABLE [dbo].[InscripcionACorrelativa] CHECK CONSTRAINT [FK_idAlumnoInscripcionACorrelaiva]
GO
ALTER TABLE [dbo].[InscripcionACorrelativa]  WITH CHECK ADD  CONSTRAINT [FK_idMateriaCorrelativaInscripcionACorrelativa] FOREIGN KEY([idMateriaCorrelativa])
REFERENCES [dbo].[MateriaCorrelativa] ([id])
GO
ALTER TABLE [dbo].[InscripcionACorrelativa] CHECK CONSTRAINT [FK_idMateriaCorrelativaInscripcionACorrelativa]
GO
ALTER TABLE [dbo].[MateriaCorrelativaYProfesor]  WITH CHECK ADD  CONSTRAINT [FK_idMateriaCorrelativa_MateriaCorrelativaYProfesor] FOREIGN KEY([idMateriaCorrelativa])
REFERENCES [dbo].[MateriaCorrelativa] ([id])
GO
ALTER TABLE [dbo].[MateriaCorrelativaYProfesor] CHECK CONSTRAINT [FK_idMateriaCorrelativa_MateriaCorrelativaYProfesor]
GO
ALTER TABLE [dbo].[MateriaCorrelativaYProfesor]  WITH CHECK ADD  CONSTRAINT [FK_idProfesor_MateriaCorrelativaYProfesor] FOREIGN KEY([idProfesor])
REFERENCES [dbo].[Profesor] ([id])
GO
ALTER TABLE [dbo].[MateriaCorrelativaYProfesor] CHECK CONSTRAINT [FK_idProfesor_MateriaCorrelativaYProfesor]
GO
ALTER TABLE [dbo].[MateriaYProfesor]  WITH CHECK ADD  CONSTRAINT [FK_idMateria_MateriaYProfesor] FOREIGN KEY([idMateria])
REFERENCES [dbo].[Materia] ([id])
GO
ALTER TABLE [dbo].[MateriaYProfesor] CHECK CONSTRAINT [FK_idMateria_MateriaYProfesor]
GO
ALTER TABLE [dbo].[MateriaYProfesor]  WITH CHECK ADD  CONSTRAINT [FK_idProfesor_MateriaYProfesor] FOREIGN KEY([idProfesor])
REFERENCES [dbo].[Profesor] ([id])
GO
ALTER TABLE [dbo].[MateriaYProfesor] CHECK CONSTRAINT [FK_idProfesor_MateriaYProfesor]
GO
ALTER TABLE [dbo].[Parciales]  WITH CHECK ADD  CONSTRAINT [FK_idAlumno] FOREIGN KEY([idAlumno])
REFERENCES [dbo].[Alumno] ([id])
GO
ALTER TABLE [dbo].[Parciales] CHECK CONSTRAINT [FK_idAlumno]
GO
ALTER TABLE [dbo].[Parciales]  WITH CHECK ADD  CONSTRAINT [FK_idMateria] FOREIGN KEY([idMateria])
REFERENCES [dbo].[Materia] ([id])
GO
ALTER TABLE [dbo].[Parciales] CHECK CONSTRAINT [FK_idMateria]
GO
USE [master]
GO
ALTER DATABASE [parcial_dos] SET  READ_WRITE 
GO
