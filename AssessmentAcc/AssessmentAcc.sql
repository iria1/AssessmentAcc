USE [master]
GO

/****** Object:  Database [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92]    Script Date: 9/22/2023 1:01:24 PM ******/
CREATE DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92', FILENAME = N'C:\Users\0708\AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92_log', FILENAME = N'C:\Users\0708\AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET ARITHABORT OFF 
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET  ENABLE_BROKER 
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET READ_COMMITTED_SNAPSHOT ON 
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET  MULTI_USER 
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET DB_CHAINING OFF 
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET QUERY_STORE = OFF
GO

USE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92]
GO

ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO

ALTER DATABASE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92] SET  READ_WRITE 
GO

USE [AssessmentAccContext-db82c6ce-6815-4554-9f52-8a982985ca92]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 9/22/2023 1:00:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[TipeCustomer] [nvarchar](max) NULL,
	[Nama] [nvarchar](max) NULL,
	[NomorTelp] [nvarchar](max) NULL,
	[Alamat] [nvarchar](max) NULL,
	[NomorRekening] [nvarchar](max) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemTransactions]    Script Date: 9/22/2023 1:00:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemTransactions](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[TransaksiId] [bigint] NOT NULL,
	[Jumlah] [int] NOT NULL,
	[Nama] [nvarchar](max) NULL,
	[Satuan] [nvarchar](max) NULL,
 CONSTRAINT [PK_ItemTransactions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 9/22/2023 1:00:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[NomorUrut] [nvarchar](max) NULL,
	[CustomerId] [bigint] NOT NULL,
	[TanggalPemesanan] [datetime2](7) NOT NULL,
	[TanggalPengiriman] [datetime2](7) NOT NULL,
	[TermOfPayment] [nvarchar](max) NULL,
	[JumlahNominal] [float] NOT NULL,
	[StatusApproval] [nvarchar](max) NULL,
 CONSTRAINT [PK_Transactions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
