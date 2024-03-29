USE [master]
GO
/****** Object:  Database [AnaOkulu]    Script Date: 14.01.2023 17:29:54 ******/
CREATE DATABASE [AnaOkulu]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AnaOkulu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\AnaOkulu.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AnaOkulu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\AnaOkulu_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [AnaOkulu] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AnaOkulu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AnaOkulu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AnaOkulu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AnaOkulu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AnaOkulu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AnaOkulu] SET ARITHABORT OFF 
GO
ALTER DATABASE [AnaOkulu] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [AnaOkulu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AnaOkulu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AnaOkulu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AnaOkulu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AnaOkulu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AnaOkulu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AnaOkulu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AnaOkulu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AnaOkulu] SET  ENABLE_BROKER 
GO
ALTER DATABASE [AnaOkulu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AnaOkulu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AnaOkulu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AnaOkulu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AnaOkulu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AnaOkulu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AnaOkulu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AnaOkulu] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AnaOkulu] SET  MULTI_USER 
GO
ALTER DATABASE [AnaOkulu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AnaOkulu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AnaOkulu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AnaOkulu] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AnaOkulu] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AnaOkulu] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [AnaOkulu] SET QUERY_STORE = OFF
GO
USE [AnaOkulu]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 14.01.2023 17:29:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[AdminID] [int] IDENTITY(1,1) NOT NULL,
	[Kullanici_Adi] [varchar](30) NOT NULL,
	[Sifre] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AdminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Notlar]    Script Date: 14.01.2023 17:29:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notlar](
	[OgrenciTC] [varchar](11) NOT NULL,
	[OgrNot] [varchar](1) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ogrenci]    Script Date: 14.01.2023 17:29:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogrenci](
	[TC] [varchar](11) NOT NULL,
	[Ad] [varchar](30) NOT NULL,
	[Soyad] [varchar](30) NOT NULL,
	[DogumTarihi] [date] NOT NULL,
	[KayitTarihi] [date] NOT NULL,
	[Sinif] [varchar](3) NULL,
	[Adres] [varchar](150) NOT NULL,
	[VeliTC] [varchar](11) NULL,
	[OgretmenTC] [varchar](11) NULL,
PRIMARY KEY CLUSTERED 
(
	[TC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ogretmen]    Script Date: 14.01.2023 17:29:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogretmen](
	[OgretmenTC] [varchar](11) NOT NULL,
	[Ad] [varchar](30) NOT NULL,
	[Soyad] [varchar](30) NOT NULL,
	[Sinif] [varchar](3) NULL,
	[Kullanici_Adi] [varchar](30) NOT NULL,
	[Sifre] [varchar](30) NOT NULL,
	[Adres] [varchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OgretmenTC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SilinenOgrenci]    Script Date: 14.01.2023 17:29:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SilinenOgrenci](
	[OgrTC] [varchar](11) NOT NULL,
	[Ad] [varchar](30) NOT NULL,
	[Soyad] [varchar](30) NOT NULL,
	[DogumTarihi] [date] NOT NULL,
	[KayitTarihi] [date] NOT NULL,
	[Sinif] [varchar](3) NULL,
	[Adres] [varchar](150) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SilinenOgretmen]    Script Date: 14.01.2023 17:29:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SilinenOgretmen](
	[OgretmenTC] [varchar](11) NOT NULL,
	[Ad] [varchar](30) NOT NULL,
	[Soyad] [varchar](30) NOT NULL,
	[Sinif] [varchar](3) NULL,
	[Kullanici_Adi] [varchar](30) NOT NULL,
	[Sifre] [varchar](30) NOT NULL,
	[Adres] [varchar](150) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SilinenVeli]    Script Date: 14.01.2023 17:29:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SilinenVeli](
	[VeliTC] [varchar](11) NOT NULL,
	[Ad] [varchar](30) NOT NULL,
	[Soyad] [varchar](30) NOT NULL,
	[Kullanici_Adi] [varchar](30) NOT NULL,
	[Sifre] [varchar](20) NOT NULL,
	[Adres] [varchar](150) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Veli]    Script Date: 14.01.2023 17:29:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Veli](
	[VeliTC] [varchar](11) NOT NULL,
	[Ad] [varchar](30) NOT NULL,
	[Soyad] [varchar](30) NOT NULL,
	[Kullanici_Adi] [varchar](30) NOT NULL,
	[Sifre] [varchar](20) NOT NULL,
	[Adres] [varchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[VeliTC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Notlar]  WITH CHECK ADD  CONSTRAINT [FK_Notlar_Ogrenci] FOREIGN KEY([OgrenciTC])
REFERENCES [dbo].[Ogrenci] ([TC])
GO
ALTER TABLE [dbo].[Notlar] CHECK CONSTRAINT [FK_Notlar_Ogrenci]
GO
ALTER TABLE [dbo].[Ogrenci]  WITH CHECK ADD  CONSTRAINT [FK_Ogrenci_Ogretmen] FOREIGN KEY([OgretmenTC])
REFERENCES [dbo].[Ogretmen] ([OgretmenTC])
GO
ALTER TABLE [dbo].[Ogrenci] CHECK CONSTRAINT [FK_Ogrenci_Ogretmen]
GO
ALTER TABLE [dbo].[Ogrenci]  WITH CHECK ADD  CONSTRAINT [FK_Ogrenci_Veli] FOREIGN KEY([VeliTC])
REFERENCES [dbo].[Veli] ([VeliTC])
GO
ALTER TABLE [dbo].[Ogrenci] CHECK CONSTRAINT [FK_Ogrenci_Veli]
GO
ALTER TABLE [dbo].[Notlar]  WITH CHECK ADD  CONSTRAINT [ck_not] CHECK  (([OgrNot] like '[1-5]'))
GO
ALTER TABLE [dbo].[Notlar] CHECK CONSTRAINT [ck_not]
GO
ALTER TABLE [dbo].[Ogrenci]  WITH CHECK ADD  CONSTRAINT [ck_sinif] CHECK  (([Sinif]='C' OR [Sinif]='B' OR [Sinif]='A'))
GO
ALTER TABLE [dbo].[Ogrenci] CHECK CONSTRAINT [ck_sinif]
GO
ALTER TABLE [dbo].[Ogretmen]  WITH CHECK ADD  CONSTRAINT [ck_ogretmensinif] CHECK  (([Sinif]='C' OR [Sinif]='B' OR [Sinif]='A'))
GO
ALTER TABLE [dbo].[Ogretmen] CHECK CONSTRAINT [ck_ogretmensinif]
GO
ALTER TABLE [dbo].[SilinenOgrenci]  WITH CHECK ADD  CONSTRAINT [ck_siniff] CHECK  (([Sinif]='C' OR [Sinif]='B' OR [Sinif]='A'))
GO
ALTER TABLE [dbo].[SilinenOgrenci] CHECK CONSTRAINT [ck_siniff]
GO
ALTER TABLE [dbo].[SilinenOgretmen]  WITH CHECK ADD  CONSTRAINT [ck_ogretmensiniff] CHECK  (([Sinif]='C' OR [Sinif]='B' OR [Sinif]='A'))
GO
ALTER TABLE [dbo].[SilinenOgretmen] CHECK CONSTRAINT [ck_ogretmensiniff]
GO
/****** Object:  StoredProcedure [dbo].[SinifA]    Script Date: 14.01.2023 17:29:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SinifA]
as
begin

select TC,Ad,Soyad,n.OgrNot from Ogrenci o Left Outer Join Notlar n on
o.TC=n.OgrenciTC where Sinif like 'A'

end
GO
/****** Object:  StoredProcedure [dbo].[SinifB]    Script Date: 14.01.2023 17:29:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SinifB]
as
begin

select TC,Ad,Soyad,n.OgrNot from Ogrenci o Left Outer Join Notlar n on
o.TC=n.OgrenciTC where Sinif like 'B'

end
GO
/****** Object:  StoredProcedure [dbo].[SinifC]    Script Date: 14.01.2023 17:29:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SinifC]
as
begin

Select TC,Ad,Soyad,n.OgrNot from Ogrenci o Left Outer Join Notlar n on
o.TC=n.OgrenciTC where Sinif like 'C'

end
GO
/****** Object:  StoredProcedure [dbo].[VeliProc]    Script Date: 14.01.2023 17:29:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[VeliProc]
as
begin

Select o.TC,o.Ad,o.Soyad,n.OgrNot from Notlar n 
Inner Join Ogrenci o on n.OgrenciTC =o.TC
Inner Join Veli v on o.Soyad=v.Soyad

end
GO
USE [master]
GO
ALTER DATABASE [AnaOkulu] SET  READ_WRITE 
GO
