USE [master]
GO
/****** Object:  Database [OtraSucursal]    Script Date: 19/06/2022 14:44:18 ******/
CREATE DATABASE [OtraSucursal]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OtraSucursal', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\OtraSucursal.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'OtraSucursal_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\OtraSucursal_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [OtraSucursal] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OtraSucursal].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OtraSucursal] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OtraSucursal] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OtraSucursal] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OtraSucursal] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OtraSucursal] SET ARITHABORT OFF 
GO
ALTER DATABASE [OtraSucursal] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OtraSucursal] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OtraSucursal] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OtraSucursal] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OtraSucursal] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OtraSucursal] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OtraSucursal] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OtraSucursal] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OtraSucursal] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OtraSucursal] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OtraSucursal] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OtraSucursal] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OtraSucursal] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OtraSucursal] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OtraSucursal] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OtraSucursal] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OtraSucursal] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OtraSucursal] SET RECOVERY FULL 
GO
ALTER DATABASE [OtraSucursal] SET  MULTI_USER 
GO
ALTER DATABASE [OtraSucursal] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OtraSucursal] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OtraSucursal] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OtraSucursal] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [OtraSucursal] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [OtraSucursal] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'OtraSucursal', N'ON'
GO
ALTER DATABASE [OtraSucursal] SET QUERY_STORE = OFF
GO
USE [OtraSucursal]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 19/06/2022 14:44:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[dni] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[telefono] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicio]    Script Date: 19/06/2022 14:44:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicio](
	[id] [int] NOT NULL,
	[duracion] [int] NOT NULL,
	[costo] [money] NOT NULL,
	[fecha] [date] NOT NULL,
	[tipo] [varchar](50) NOT NULL,
	[estaPagado] [int] NOT NULL,
	[dniCliente] [int] NOT NULL,
 CONSTRAINT [PK_Servicio] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Servicio]  WITH CHECK ADD  CONSTRAINT [FK_Servicio_Cliente] FOREIGN KEY([dniCliente])
REFERENCES [dbo].[Cliente] ([dni])
GO
ALTER TABLE [dbo].[Servicio] CHECK CONSTRAINT [FK_Servicio_Cliente]
GO
USE [master]
GO
ALTER DATABASE [OtraSucursal] SET  READ_WRITE 
GO
use OtraSucursal;

insert into Cliente (dni, nombre, apellido, telefono) values (44459810, 'Willie', 'Rowan', '7129066335');
insert into Cliente (dni, nombre, apellido, telefono) values (30176966, 'Alexa', 'Dunster', '1835521540');
insert into Cliente (dni, nombre, apellido, telefono) values (36666606, 'Orton', 'Lillo', '7557577754');
insert into Cliente (dni, nombre, apellido, telefono) values (31698526, 'Alessandra', 'Halfhead', '7003526560');
insert into Cliente (dni, nombre, apellido, telefono) values (38593299, 'Kacy', 'Bonhome', '4043177869');
insert into Cliente (dni, nombre, apellido, telefono) values (41722019, 'Herc', 'Antuoni', '4491732482');
insert into Cliente (dni, nombre, apellido, telefono) values (33163851, 'Tudor', 'Mc Gee', '4926600762');
insert into Cliente (dni, nombre, apellido, telefono) values (31396215, 'Mendel', 'Covet', '3598899688');
insert into Cliente (dni, nombre, apellido, telefono) values (31278137, 'Valdemar', 'Handsheart', '3283064675');
insert into Cliente (dni, nombre, apellido, telefono) values (30862150, 'Tova', 'Dubois', '2549857395');
insert into Cliente (dni, nombre, apellido, telefono) values (28691878, 'Orton', 'Buggs', '9015673272');
insert into Cliente (dni, nombre, apellido, telefono) values (28852246, 'Theo', 'Danis', '7355662019');
insert into Cliente (dni, nombre, apellido, telefono) values (34829430, 'Jose', 'Balleine', '5859357262');
insert into Cliente (dni, nombre, apellido, telefono) values (46969205, 'Korey', 'Lamy', '8535377025');
insert into Cliente (dni, nombre, apellido, telefono) values (28185001, 'Harriette', 'Rowbottom', '7348976041');
insert into Cliente (dni, nombre, apellido, telefono) values (49719737, 'Florina', 'Walne', '5854186402');
insert into Cliente (dni, nombre, apellido, telefono) values (26936591, 'Liz', 'Eakly', '3665657303');
insert into Cliente (dni, nombre, apellido, telefono) values (34544493, 'Gunar', 'Tatum', '2771790068');
insert into Cliente (dni, nombre, apellido, telefono) values (26720665, 'Loria', 'Pumphrey', '3762641138');
insert into Cliente (dni, nombre, apellido, telefono) values (45662273, 'Anica', 'Milne', '5034040907');

insert into Servicio (id, duracion, costo, fecha, tipo, estaPagado, dniCliente) values (14225081, 152, 2340, '2022-05-22', 'Sauna', 0, 44459810);
insert into Servicio (id, duracion, costo, fecha, tipo, estaPagado, dniCliente) values (91415613, 165, 3257, '2021-12-20', 'Masaje', 1, 30176966);
insert into Servicio (id, duracion, costo, fecha, tipo, estaPagado, dniCliente) values (82501812, 7, 4837, '2021-08-31', 'Sauna', 1, 36666606);
insert into Servicio (id, duracion, costo, fecha, tipo, estaPagado, dniCliente) values (77005021, 98, 3689, '2022-06-19', 'Sauna', 0, 31698526);
insert into Servicio (id, duracion, costo, fecha, tipo, estaPagado, dniCliente) values (8916387, 54, 1516, '2022-02-24', 'Jacuzzi', 1, 38593299);
insert into Servicio (id, duracion, costo, fecha, tipo, estaPagado, dniCliente) values (67691208, 126, 5157, '2021-07-24', 'Sauna', 0, 41722019);
insert into Servicio (id, duracion, costo, fecha, tipo, estaPagado, dniCliente) values (68708455, 32, 2548, '2021-09-02', 'Sauna', 0, 33163851);
insert into Servicio (id, duracion, costo, fecha, tipo, estaPagado, dniCliente) values (54483723, 62, 5555, '2021-12-05', 'Sauna', 0, 31396215);
insert into Servicio (id, duracion, costo, fecha, tipo, estaPagado, dniCliente) values (58741520, 165, 5823, '2021-07-04', 'Sauna', 1, 31278137);
insert into Servicio (id, duracion, costo, fecha, tipo, estaPagado, dniCliente) values (83907980, 75, 5661, '2022-05-26', 'Sauna', 0, 30862150);
insert into Servicio (id, duracion, costo, fecha, tipo, estaPagado, dniCliente) values (62229871, 33, 4234, '2021-10-02', 'Masaje', 0, 28691878);
insert into Servicio (id, duracion, costo, fecha, tipo, estaPagado, dniCliente) values (71251966, 22, 1869, '2021-06-28', 'Sauna', 1, 28852246);
insert into Servicio (id, duracion, costo, fecha, tipo, estaPagado, dniCliente) values (67030862, 42, 530, '2021-09-10', 'Sauna', 0, 34829430);
insert into Servicio (id, duracion, costo, fecha, tipo, estaPagado, dniCliente) values (76823337, 32, 3638, '2021-11-16', 'Jacuzzi', 0, 46969205);
insert into Servicio (id, duracion, costo, fecha, tipo, estaPagado, dniCliente) values (91549840, 127, 1733, '2022-02-17', 'Jacuzzi', 1, 28185001);
insert into Servicio (id, duracion, costo, fecha, tipo, estaPagado, dniCliente) values (5445004, 23, 1287, '2021-07-25', 'Sauna', 1, 49719737);
insert into Servicio (id, duracion, costo, fecha, tipo, estaPagado, dniCliente) values (50991993, 94, 5613, '2021-11-06', 'Sauna', 1, 26936591);
insert into Servicio (id, duracion, costo, fecha, tipo, estaPagado, dniCliente) values (564932, 106, 5038, '2021-11-24', 'Masaje', 0, 34544493);
insert into Servicio (id, duracion, costo, fecha, tipo, estaPagado, dniCliente) values (36157952, 113, 3107, '2022-01-31', 'Masaje', 1, 26720665);
insert into Servicio (id, duracion, costo, fecha, tipo, estaPagado, dniCliente) values (75215757, 27, 3596, '2022-01-08', 'Sauna', 0, 45662273);