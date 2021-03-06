USE [master]
GO
/****** Object:  Database [MQ163]    Script Date: 03/04/2013 03:28:46 ******/
CREATE DATABASE [MQ163] ON  PRIMARY 
( NAME = N'MQ163', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.KOTARUVEXPRESSR2\MSSQL\DATA\MQ163.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MQ163_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.KOTARUVEXPRESSR2\MSSQL\DATA\MQ163_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MQ163] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MQ163].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MQ163] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [MQ163] SET ANSI_NULLS OFF
GO
ALTER DATABASE [MQ163] SET ANSI_PADDING OFF
GO
ALTER DATABASE [MQ163] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [MQ163] SET ARITHABORT OFF
GO
ALTER DATABASE [MQ163] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [MQ163] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [MQ163] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [MQ163] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [MQ163] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [MQ163] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [MQ163] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [MQ163] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [MQ163] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [MQ163] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [MQ163] SET  DISABLE_BROKER
GO
ALTER DATABASE [MQ163] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [MQ163] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [MQ163] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [MQ163] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [MQ163] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [MQ163] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [MQ163] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [MQ163] SET  READ_WRITE
GO
ALTER DATABASE [MQ163] SET RECOVERY SIMPLE
GO
ALTER DATABASE [MQ163] SET  MULTI_USER
GO
ALTER DATABASE [MQ163] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [MQ163] SET DB_CHAINING OFF
GO
USE [MQ163]
GO
/****** Object:  Table [dbo].[Prospect]    Script Date: 03/04/2013 03:28:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prospect](
	[Id] [int] NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[IsCustomer] [bit] NOT NULL,
	[Car] [nvarchar](50) NOT NULL,
	[Features] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Prospect] ([Id], [FullName], [email], [IsCustomer], [Car], [Features]) VALUES (1, N'Tom Hanks', N'tom@gmail.com', 1, N'Ferrari', N'Convertible, one push sport mode')
INSERT [dbo].[Prospect] ([Id], [FullName], [email], [IsCustomer], [Car], [Features]) VALUES (2, N'Robert Downey Jr.', N'Robert@hotmail.com', 1, N'Audi A6', N'Dirver sleep detection')
INSERT [dbo].[Prospect] ([Id], [FullName], [email], [IsCustomer], [Car], [Features]) VALUES (3, N'Liam Neeson', N'Liam@neeson.com', 1, N'Toyota Corolla', N'Auto shift, rear AC controls')
INSERT [dbo].[Prospect] ([Id], [FullName], [email], [IsCustomer], [Car], [Features]) VALUES (4, N'Angelina Jolie', N'Ange@yahoo.com', 1, N'BMW', N'Convertible, Manual gear shirt')
INSERT [dbo].[Prospect] ([Id], [FullName], [email], [IsCustomer], [Car], [Features]) VALUES (5, N'Sachin Tendulkar', N'sachin@rediff.com', 0, N'Ferrari', N'Convertible, manual gear shift')
INSERT [dbo].[Prospect] ([Id], [FullName], [email], [IsCustomer], [Car], [Features]) VALUES (6, N'M Singh Dhoni', N'dhoni@yahoo.com', 0, N'Hummer', N'All weather control')
INSERT [dbo].[Prospect] ([Id], [FullName], [email], [IsCustomer], [Car], [Features]) VALUES (7, N'Rahul Dravid', N'rahul@gmail.com', 0, N'Audi A1', N'Proximity sensors')
INSERT [dbo].[Prospect] ([Id], [FullName], [email], [IsCustomer], [Car], [Features]) VALUES (8, N'Seshu Miriyala', N'seshu@gmail.com', 0, N'Mercedes ', N'Automatic gear shirt, sport mode.')
/****** Object:  Table [dbo].[MerchandizeOffer]    Script Date: 03/04/2013 03:28:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MerchandizeOffer](
	[Id] [int] NOT NULL,
	[Title] [nvarchar](50) NULL,
	[Details] [nvarchar](256) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[MerchandizeOffer] ([Id], [Title], [Details]) VALUES (1, N'Iron man meets dealership.', N'Robert Downey Jr. will be here on April 8th. Are you going to be there?')
INSERT [dbo].[MerchandizeOffer] ([Id], [Title], [Details]) VALUES (2, N'2012 Camrey for sale', N'Monthly less than $200')
INSERT [dbo].[MerchandizeOffer] ([Id], [Title], [Details]) VALUES (3, N'Insurance offer on BMWs', N'First year insurance from Gieco free.')
