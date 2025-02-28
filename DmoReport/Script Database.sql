USE [master]
GO
/****** Object:  Database [DuLieuSach]    Script Date: 23/10/2024 1:39:15 PM ******/
CREATE DATABASE [DuLieuSach]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DuLieuSach', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DuLieuSach.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 


USE [DuLieuSach]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 23/10/2024 1:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[Ma] [int] IDENTITY(1,1) NOT NULL,
	[TenSach] [nvarchar](50) NULL,
	[NamXB] [int] NULL,
	[MaLoai] [int] NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Sach] ON 

GO
INSERT [dbo].[Sach] ([Ma], [TenSach], [NamXB], [MaLoai]) VALUES (1, N'Vi Tu Si Ban Chiec Ferrari', 2024, 1)
GO
INSERT [dbo].[Sach] ([Ma], [TenSach], [NamXB], [MaLoai]) VALUES (2, N'Lược sử loài ngoài', 2020, 2)
GO
SET IDENTITY_INSERT [dbo].[Sach] OFF
GO
USE [master]
GO
ALTER DATABASE [DuLieuSach] SET  READ_WRITE 
GO
