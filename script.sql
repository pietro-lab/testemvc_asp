USE [master]
GO
/****** Object:  Database [cms]    Script Date: 06/01/2021 20:23:12 ******/
CREATE DATABASE [cms]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'cms', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\cms.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'cms_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\cms_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [cms] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [cms].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [cms] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [cms] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [cms] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [cms] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [cms] SET ARITHABORT OFF 
GO
ALTER DATABASE [cms] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [cms] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [cms] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [cms] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [cms] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [cms] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [cms] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [cms] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [cms] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [cms] SET  DISABLE_BROKER 
GO
ALTER DATABASE [cms] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [cms] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [cms] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [cms] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [cms] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [cms] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [cms] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [cms] SET RECOVERY FULL 
GO
ALTER DATABASE [cms] SET  MULTI_USER 
GO
ALTER DATABASE [cms] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [cms] SET DB_CHAINING OFF 
GO
ALTER DATABASE [cms] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [cms] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [cms] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [cms] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'cms', N'ON'
GO
ALTER DATABASE [cms] SET QUERY_STORE = OFF
GO
USE [cms]
GO
/****** Object:  Table [dbo].[paginas]    Script Date: 06/01/2021 20:23:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[paginas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [nchar](10) NULL,
	[data] [datetime] NULL,
	[conteudo] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [cms] SET  READ_WRITE 
GO
