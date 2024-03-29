USE [master]
GO
/****** Object:  Database [Bill_Management_System]    Script Date: 7/16/2021 11:49:59 AM ******/
CREATE DATABASE [Bill_Management_System]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Bill_Management_System', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Bill_Management_System.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Bill_Management_System_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Bill_Management_System_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Bill_Management_System] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Bill_Management_System].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Bill_Management_System] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Bill_Management_System] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Bill_Management_System] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Bill_Management_System] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Bill_Management_System] SET ARITHABORT OFF 
GO
ALTER DATABASE [Bill_Management_System] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Bill_Management_System] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Bill_Management_System] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Bill_Management_System] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Bill_Management_System] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Bill_Management_System] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Bill_Management_System] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Bill_Management_System] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Bill_Management_System] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Bill_Management_System] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Bill_Management_System] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Bill_Management_System] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Bill_Management_System] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Bill_Management_System] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Bill_Management_System] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Bill_Management_System] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [Bill_Management_System] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Bill_Management_System] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Bill_Management_System] SET  MULTI_USER 
GO
ALTER DATABASE [Bill_Management_System] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Bill_Management_System] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Bill_Management_System] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Bill_Management_System] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Bill_Management_System] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Bill_Management_System] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Bill_Management_System] SET QUERY_STORE = OFF
GO
USE [Bill_Management_System]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 7/16/2021 11:50:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TestRequests]    Script Date: 7/16/2021 11:50:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestRequests](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Bill_Number] [nvarchar](255) NULL,
	[PatientName] [nvarchar](max) NULL,
	[DOB] [datetime2](7) NULL,
	[MobileNo] [bigint] NOT NULL,
	[TestSetupId] [bigint] NULL,
	[ReqTestFee] [real] NULL,
	[EntryDate] [datetime2](7) NULL,
	[DueDate] [datetime2](7) NULL,
	[PayAmount] [real] NULL,
	[Slno] [bigint] NULL,
 CONSTRAINT [PK_TestRequests] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TestSetups]    Script Date: 7/16/2021 11:50:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestSetups](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[TestName] [nvarchar](255) NULL,
	[TestFee] [real] NULL,
	[Slno] [bigint] NULL,
	[TestTypeSetupId] [bigint] NULL,
 CONSTRAINT [PK_TestSetups] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TestTypeSetups]    Script Date: 7/16/2021 11:50:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestTypeSetups](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[TestType_Name] [nvarchar](255) NULL,
	[Slno] [bigint] NULL,
 CONSTRAINT [PK_TestTypeSetups] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210713054200_initial', N'5.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210713055147_columnModity', N'5.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210713164901_someModity', N'5.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210715190503_fullUpdate', N'5.0.8')
GO
SET IDENTITY_INSERT [dbo].[TestRequests] ON 

INSERT [dbo].[TestRequests] ([Id], [Bill_Number], [PatientName], [DOB], [MobileNo], [TestSetupId], [ReqTestFee], [EntryDate], [DueDate], [PayAmount], [Slno]) VALUES (1, N'BN-288069', N'MD. Imran Hosen', CAST(N'1995-01-21T00:00:00.0000000' AS DateTime2), 1617553723, 4, 3500, CAST(N'2021-07-12T00:00:00.0000000' AS DateTime2), NULL, 0, NULL)
INSERT [dbo].[TestRequests] ([Id], [Bill_Number], [PatientName], [DOB], [MobileNo], [TestSetupId], [ReqTestFee], [EntryDate], [DueDate], [PayAmount], [Slno]) VALUES (2, N'BN-782492', N'Nayim Islam', CAST(N'1995-01-21T00:00:00.0000000' AS DateTime2), 1617553724, 1, 5000, CAST(N'2021-07-13T00:00:00.0000000' AS DateTime2), NULL, 0, NULL)
INSERT [dbo].[TestRequests] ([Id], [Bill_Number], [PatientName], [DOB], [MobileNo], [TestSetupId], [ReqTestFee], [EntryDate], [DueDate], [PayAmount], [Slno]) VALUES (3, N'BN-273272', N'Anika Rahman', CAST(N'1990-07-10T00:00:00.0000000' AS DateTime2), 19453423, 2, 1500, CAST(N'2021-07-14T00:00:00.0000000' AS DateTime2), CAST(N'2021-07-16T00:00:00.0000000' AS DateTime2), 1500, NULL)
INSERT [dbo].[TestRequests] ([Id], [Bill_Number], [PatientName], [DOB], [MobileNo], [TestSetupId], [ReqTestFee], [EntryDate], [DueDate], [PayAmount], [Slno]) VALUES (4, N'BN-454695', N'MD. Hemel', CAST(N'1995-04-10T00:00:00.0000000' AS DateTime2), 17645783, 4, 3500, CAST(N'2021-07-15T00:00:00.0000000' AS DateTime2), NULL, 0, NULL)
INSERT [dbo].[TestRequests] ([Id], [Bill_Number], [PatientName], [DOB], [MobileNo], [TestSetupId], [ReqTestFee], [EntryDate], [DueDate], [PayAmount], [Slno]) VALUES (5, N'BN-323533', N'MD. Rasel Ahmed', CAST(N'1977-07-05T00:00:00.0000000' AS DateTime2), 1845678321, 3, 2000, CAST(N'2021-07-16T01:45:30.0254712' AS DateTime2), NULL, 0, NULL)
INSERT [dbo].[TestRequests] ([Id], [Bill_Number], [PatientName], [DOB], [MobileNo], [TestSetupId], [ReqTestFee], [EntryDate], [DueDate], [PayAmount], [Slno]) VALUES (6, N'BN-840572', N'Santa', CAST(N'1998-07-07T00:00:00.0000000' AS DateTime2), 1234567890, 2, 1500, CAST(N'2021-07-16T04:13:25.6621738' AS DateTime2), NULL, 0, NULL)
INSERT [dbo].[TestRequests] ([Id], [Bill_Number], [PatientName], [DOB], [MobileNo], [TestSetupId], [ReqTestFee], [EntryDate], [DueDate], [PayAmount], [Slno]) VALUES (7, N'BN-399876', N'Zahirul Islam', CAST(N'1997-07-08T00:00:00.0000000' AS DateTime2), 1617553723, 4, 3500, CAST(N'2021-07-16T11:25:01.7105591' AS DateTime2), NULL, 0, NULL)
SET IDENTITY_INSERT [dbo].[TestRequests] OFF
GO
SET IDENTITY_INSERT [dbo].[TestSetups] ON 

INSERT [dbo].[TestSetups] ([Id], [TestName], [TestFee], [Slno], [TestTypeSetupId]) VALUES (1, N'Whole Abdomen', 5000, NULL, 3)
INSERT [dbo].[TestSetups] ([Id], [TestName], [TestFee], [Slno], [TestTypeSetupId]) VALUES (2, N'Pregnancy Profile', 1500, NULL, 1)
INSERT [dbo].[TestSetups] ([Id], [TestName], [TestFee], [Slno], [TestTypeSetupId]) VALUES (3, N'Urine C/S-200', 2000, NULL, 2)
INSERT [dbo].[TestSetups] ([Id], [TestName], [TestFee], [Slno], [TestTypeSetupId]) VALUES (4, N'X-Ray LS Spine', 3500, NULL, 4)
INSERT [dbo].[TestSetups] ([Id], [TestName], [TestFee], [Slno], [TestTypeSetupId]) VALUES (5, N'Hemoglobin A1C', 500, NULL, 1)
SET IDENTITY_INSERT [dbo].[TestSetups] OFF
GO
SET IDENTITY_INSERT [dbo].[TestTypeSetups] ON 

INSERT [dbo].[TestTypeSetups] ([Id], [TestType_Name], [Slno]) VALUES (1, N'Blood', NULL)
INSERT [dbo].[TestTypeSetups] ([Id], [TestType_Name], [Slno]) VALUES (2, N'Urine', NULL)
INSERT [dbo].[TestTypeSetups] ([Id], [TestType_Name], [Slno]) VALUES (3, N'ECG', NULL)
INSERT [dbo].[TestTypeSetups] ([Id], [TestType_Name], [Slno]) VALUES (4, N'X-Ray', NULL)
INSERT [dbo].[TestTypeSetups] ([Id], [TestType_Name], [Slno]) VALUES (5, N'DNA', NULL)
SET IDENTITY_INSERT [dbo].[TestTypeSetups] OFF
GO
/****** Object:  Index [IX_TestRequests_TestSetupId]    Script Date: 7/16/2021 11:50:00 AM ******/
CREATE NONCLUSTERED INDEX [IX_TestRequests_TestSetupId] ON [dbo].[TestRequests]
(
	[TestSetupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_TestSetups_TestTypeSetupId]    Script Date: 7/16/2021 11:50:00 AM ******/
CREATE NONCLUSTERED INDEX [IX_TestSetups_TestTypeSetupId] ON [dbo].[TestSetups]
(
	[TestTypeSetupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TestRequests]  WITH CHECK ADD  CONSTRAINT [FK_TestRequests_TestSetups_TestSetupId] FOREIGN KEY([TestSetupId])
REFERENCES [dbo].[TestSetups] ([Id])
GO
ALTER TABLE [dbo].[TestRequests] CHECK CONSTRAINT [FK_TestRequests_TestSetups_TestSetupId]
GO
ALTER TABLE [dbo].[TestSetups]  WITH CHECK ADD  CONSTRAINT [FK_TestSetups_TestTypeSetups_TestTypeSetupId] FOREIGN KEY([TestTypeSetupId])
REFERENCES [dbo].[TestTypeSetups] ([Id])
GO
ALTER TABLE [dbo].[TestSetups] CHECK CONSTRAINT [FK_TestSetups_TestTypeSetups_TestTypeSetupId]
GO
/****** Object:  StoredProcedure [dbo].[Proc_TestTypeWiseReport]    Script Date: 7/16/2021 11:50:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Proc_TestTypeWiseReport] 
(@FormDate as datetime,@Todate as datetime)
AS
BEGIN
SET NOCOUNT ON;



select TestSetupId, count(isnull(TestSetupId,0)) as TotalTest, sum(isnull(ReqTestFee,0)) as TotalAmount into #TmTest from TestRequests 
where EntryDate  between @FormDate and @Todate
group by TestSetupId

select ts.TestTypeSetupId, count(ts.TestTypeSetupId) as totalTestType, sum(t.TotalAmount) as TotalTypeAmount into #TmTestType from #TmTest t left join TestSetups ts on t.TestSetupId = ts.Id
group by ts.TestTypeSetupId

select ty.TestTypeSetupId, ts.TestType_Name, isnull(ty.totalTestType,0) as totalTestType, isnull(ty.TotalTypeAmount,0) as TotalTypeAmount from #TmTestType ty 
right join TestTypeSetups ts on ty.TestTypeSetupId = ts.Id

--select * from TestTypeSetups
--select * from TestRequests

END

--exec Proc_TestTypeWiseReport '2021-07-13','2021-07-17'
GO
/****** Object:  StoredProcedure [dbo].[Proc_TestWiseReport]    Script Date: 7/16/2021 11:50:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Proc_TestWiseReport] 
(@FormDate as datetime,@Todate as datetime)
AS
BEGIN
SET NOCOUNT ON;

select TestSetupId, count(isnull(TestSetupId,0)) as TotalTest, sum(isnull(ReqTestFee,0)) as TotalAmount into #TmTest from TestRequests 
where EntryDate between @FormDate and @Todate
group by TestSetupId

--select TestSetupId, ts.TestName,  TotalTest, TotalAmount from #TmTest t left join TestSetups ts on t.TestSetupId = ts.Id

select TestSetupId, ts.TestName,  isnull(TotalTest,0) as TotalTest, isnull(TotalAmount,0) as TotalAmount from #TmTest t with(nolock)  
right JOIN TestSetups ts on t.TestSetupId = ts.Id




--select * from TestTypeSetups
--select * from TestRequests

END

--exec Proc_TestWiseReport '2021-07-13','2021-07-17'
GO
/****** Object:  StoredProcedure [dbo].[Proc_TestWiseReport2]    Script Date: 7/16/2021 11:50:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Proc_TestWiseReport2] 
(@FormDate as datetime,@Todate as datetime)
AS
BEGIN
SET NOCOUNT ON;

select TestSetupId, count(isnull(TestSetupId,0)) as TotalTest, sum(isnull(ReqTestFee,0)) as TotalAmount into #TmTest from TestRequests 
where EntryDate between @FormDate and @Todate
group by TestSetupId

select TestSetupId, ts.TestName,  isnull(TotalTest,0) as TotalTest, isnull(TotalAmount,0) as TotalAmount from #TmTest t with(nolock)  right JOIN TestSetups ts on t.TestSetupId = ts.Id

--select * from TestTypeSetups
--select * from TestRequests

END

--exec Proc_TestWiseReport '2021-07-13','2021-07-17'
GO
USE [master]
GO
ALTER DATABASE [Bill_Management_System] SET  READ_WRITE 
GO
