USE [master]
GO
/****** Object:  Database [NaukariDb]    Script Date: 3/24/2020 8:41:03 AM ******/
CREATE DATABASE [NaukariDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NaukariDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\NaukariDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'NaukariDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\NaukariDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [NaukariDb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NaukariDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NaukariDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NaukariDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NaukariDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NaukariDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NaukariDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [NaukariDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [NaukariDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NaukariDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NaukariDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NaukariDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NaukariDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NaukariDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NaukariDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NaukariDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NaukariDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [NaukariDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NaukariDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NaukariDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NaukariDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NaukariDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NaukariDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [NaukariDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NaukariDb] SET RECOVERY FULL 
GO
ALTER DATABASE [NaukariDb] SET  MULTI_USER 
GO
ALTER DATABASE [NaukariDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NaukariDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NaukariDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NaukariDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [NaukariDb] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'NaukariDb', N'ON'
GO
ALTER DATABASE [NaukariDb] SET QUERY_STORE = OFF
GO
USE [NaukariDb]
GO
/****** Object:  Table [dbo].[educations]    Script Date: 3/24/2020 8:41:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[educations](
	[educationId] [int] IDENTITY(1,1) NOT NULL,
	[userId] [int] NOT NULL,
	[highestQualification] [varchar](10) NOT NULL,
	[course] [varchar](50) NOT NULL,
	[specialization] [varchar](50) NOT NULL,
	[university] [varchar](50) NOT NULL,
	[courseType] [varchar](50) NOT NULL,
	[passingYear] [varchar](50) NOT NULL,
	[skill] [varchar](50) NOT NULL,
 CONSTRAINT [PK_educations] PRIMARY KEY CLUSTERED 
(
	[educationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employments]    Script Date: 3/24/2020 8:41:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employments](
	[employmentId] [int] IDENTITY(1,1) NOT NULL,
	[userId] [int] NOT NULL,
	[currentDesignation] [varchar](50) NOT NULL,
	[currentCompany] [varchar](50) NOT NULL,
	[annualSalary] [varchar](50) NOT NULL,
	[workStart] [date] NOT NULL,
	[workEnd] [date] NOT NULL,
	[currentLocation] [varchar](10) NOT NULL,
	[contry] [varchar](50) NULL,
	[cityName] [varchar](50) NULL,
	[noticePeriod] [varchar](50) NULL,
	[skill] [varchar](10) NOT NULL,
	[industry] [varchar](50) NULL,
	[functionalArea] [varchar](50) NULL,
	[role] [varchar](50) NULL,
 CONSTRAINT [PK_employments] PRIMARY KEY CLUSTERED 
(
	[employmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[otherEducations]    Script Date: 3/24/2020 8:41:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[otherEducations](
	[otherEducationId] [int] IDENTITY(1,1) NOT NULL,
	[educationId] [int] NOT NULL,
	[qualification] [varchar](50) NULL,
	[course] [varchar](50) NULL,
	[specialization] [varchar](50) NULL,
	[university] [nchar](10) NULL,
	[passingYear] [varchar](50) NULL,
 CONSTRAINT [PK_otherEducations] PRIMARY KEY CLUSTERED 
(
	[otherEducationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[otherEmployments]    Script Date: 3/24/2020 8:41:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[otherEmployments](
	[otherEmploymentId] [int] IDENTITY(1,1) NOT NULL,
	[employmentId] [int] NOT NULL,
	[designation] [varchar](50) NULL,
	[company] [varchar](50) NULL,
	[startDate] [date] NULL,
	[endDate] [date] NULL,
 CONSTRAINT [PK_otherEmployments] PRIMARY KEY CLUSTERED 
(
	[otherEmploymentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[userObject]    Script Date: 3/24/2020 8:41:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[userObject](
	[userObjectId] [int] IDENTITY(1,1) NOT NULL,
	[userObjectTypeId] [int] NOT NULL,
	[userObjectName] [varchar](10) NOT NULL,
 CONSTRAINT [PK_userObject] PRIMARY KEY CLUSTERED 
(
	[userObjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[userObjectType]    Script Date: 3/24/2020 8:41:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[userObjectType](
	[userObjectTypeId] [int] IDENTITY(1,1) NOT NULL,
	[userId] [int] NOT NULL,
 CONSTRAINT [PK_userObjectType] PRIMARY KEY CLUSTERED 
(
	[userObjectTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 3/24/2020 8:41:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[userId] [int] NOT NULL,
	[name] [int] NOT NULL,
	[emailId] [varchar](50) NOT NULL,
	[password] [varchar](10) NOT NULL,
	[mobileNumber] [varchar](10) NOT NULL,
	[currentLocation] [varchar](50) NOT NULL,
	[country] [varchar](50) NULL,
	[cityName] [varchar](10) NULL,
	[resume] [varchar](10) NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[educations]  WITH CHECK ADD  CONSTRAINT [FK_educations_users] FOREIGN KEY([userId])
REFERENCES [dbo].[users] ([userId])
GO
ALTER TABLE [dbo].[educations] CHECK CONSTRAINT [FK_educations_users]
GO
ALTER TABLE [dbo].[employments]  WITH CHECK ADD  CONSTRAINT [FK_employments_users] FOREIGN KEY([userId])
REFERENCES [dbo].[users] ([userId])
GO
ALTER TABLE [dbo].[employments] CHECK CONSTRAINT [FK_employments_users]
GO
ALTER TABLE [dbo].[otherEducations]  WITH CHECK ADD  CONSTRAINT [FK_otherEducations_educations] FOREIGN KEY([educationId])
REFERENCES [dbo].[educations] ([educationId])
GO
ALTER TABLE [dbo].[otherEducations] CHECK CONSTRAINT [FK_otherEducations_educations]
GO
ALTER TABLE [dbo].[otherEmployments]  WITH CHECK ADD  CONSTRAINT [FK_otherEmployments_employments] FOREIGN KEY([employmentId])
REFERENCES [dbo].[employments] ([employmentId])
GO
ALTER TABLE [dbo].[otherEmployments] CHECK CONSTRAINT [FK_otherEmployments_employments]
GO
ALTER TABLE [dbo].[userObject]  WITH CHECK ADD  CONSTRAINT [FK_userObject_userObjectType] FOREIGN KEY([userObjectTypeId])
REFERENCES [dbo].[userObjectType] ([userObjectTypeId])
GO
ALTER TABLE [dbo].[userObject] CHECK CONSTRAINT [FK_userObject_userObjectType]
GO
ALTER TABLE [dbo].[userObjectType]  WITH CHECK ADD  CONSTRAINT [FK_userObjectType_users] FOREIGN KEY([userId])
REFERENCES [dbo].[users] ([userId])
GO
ALTER TABLE [dbo].[userObjectType] CHECK CONSTRAINT [FK_userObjectType_users]
GO
USE [master]
GO
ALTER DATABASE [NaukariDb] SET  READ_WRITE 
GO
