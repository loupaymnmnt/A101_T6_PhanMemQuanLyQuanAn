USE [master]
GO
/****** Object:  Database [LOUPAY]    Script Date: 06/11/2023 9:38:15 PM ******/
CREATE DATABASE [LOUPAY]
 
GO
ALTER DATABASE [LOUPAY] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LOUPAY].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LOUPAY] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LOUPAY] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LOUPAY] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LOUPAY] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LOUPAY] SET ARITHABORT OFF 
GO
ALTER DATABASE [LOUPAY] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [LOUPAY] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LOUPAY] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LOUPAY] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LOUPAY] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LOUPAY] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LOUPAY] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LOUPAY] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LOUPAY] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LOUPAY] SET  ENABLE_BROKER 
GO
ALTER DATABASE [LOUPAY] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LOUPAY] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LOUPAY] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LOUPAY] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LOUPAY] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LOUPAY] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LOUPAY] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LOUPAY] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LOUPAY] SET  MULTI_USER 
GO
ALTER DATABASE [LOUPAY] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LOUPAY] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LOUPAY] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LOUPAY] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [LOUPAY]
GO
/****** Object:  Table [dbo].[Ban]    Script Date: 06/11/2023 9:38:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ban](
	[IDBan] [varchar](10) NOT NULL,
	[IDKhuVuc] [varchar](10) NULL,
	[TrangThai] [nvarchar](255) NULL,
 CONSTRAINT [PK_Ban] PRIMARY KEY CLUSTERED 
(
	[IDBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatHangHoaNhap]    Script Date: 06/11/2023 9:38:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatHangHoaNhap](
	[IDHoaDonNhap] [varchar](10) NOT NULL,
	[IDHangHoaNhap] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_DatHangHoaNhap] PRIMARY KEY CLUSTERED 
(
	[IDHoaDonNhap] ASC,
	[IDHangHoaNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatMon]    Script Date: 06/11/2023 9:38:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatMon](
	[IDHoaDon] [varchar](10) NOT NULL,
	[IDMon] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Form]    Script Date: 06/11/2023 9:38:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Form](
	[IDForm] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Form] PRIMARY KEY CLUSTERED 
(
	[IDForm] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangHoaNhap]    Script Date: 06/11/2023 9:38:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoaNhap](
	[IDHangHoaNhap] [varchar](10) NOT NULL,
	[TenHangHoaNhap] [nvarchar](255) NULL,
	[DonViTinh] [nvarchar](255) NULL,
	[GiaHangHoaNhap] [decimal](18, 0) NULL,
 CONSTRAINT [PK_HangHoaNhap] PRIMARY KEY CLUSTERED 
(
	[IDHangHoaNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 06/11/2023 9:38:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[IDHoaDon] [varchar](10) NOT NULL,
	[IDBan] [varchar](10) NULL,
	[IDNguoiDung] [varchar](10) NULL,
	[ThanhTien] [decimal](18, 0) NULL,
	[GiamGia] [int] NULL,
	[TienKhachDua] [decimal](18, 0) NULL,
	[TienTraLai] [decimal](18, 0) NULL,
	[NgayLap] [datetime] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[IDHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonNhap]    Script Date: 06/11/2023 9:38:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonNhap](
	[IDHoaDonNhap] [varchar](10) NOT NULL,
	[IDNguoiDung] [varchar](10) NULL,
	[ThanhTien] [decimal](18, 0) NULL,
	[NgayLap] [datetime] NULL,
	[TenDonViCungCap] [nvarchar](255) NULL,
 CONSTRAINT [PK_HoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[IDHoaDonNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhuVuc]    Script Date: 06/11/2023 9:38:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuVuc](
	[IDKhuVuc] [varchar](10) NOT NULL,
	[TenKhuVuc] [nvarchar](255) NULL,
 CONSTRAINT [PK_KhuVuc] PRIMARY KEY CLUSTERED 
(
	[IDKhuVuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiMon]    Script Date: 06/11/2023 9:38:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiMon](
	[IDLoaiMon] [varchar](10) NOT NULL,
	[TenLoaiMon] [nvarchar](255) NULL,
 CONSTRAINT [PK_LoaiMon] PRIMARY KEY CLUSTERED 
(
	[IDLoaiMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mon]    Script Date: 06/11/2023 9:38:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mon](
	[IDMon] [varchar](10) NOT NULL,
	[IDLoaiMon] [varchar](10) NULL,
	[TenMon] [nvarchar](255) NULL,
	[GiaMon] [decimal](18, 0) NULL,
	[DonViTinh] [nvarchar](255) NULL,
	[FileAnh] [nvarchar](255) NULL,
 CONSTRAINT [PK_Mon] PRIMARY KEY CLUSTERED 
(
	[IDMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 06/11/2023 9:38:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[IDNguoiDung] [varchar](10) NOT NULL,
	[IDQuyenNguoiDung] [varchar](10) NULL,
	[TenNguoiDung] [varchar](50) NULL,
	[MatKhau] [varchar](50) NULL,
	[BiKhoa] [bit] NULL,
 CONSTRAINT [PK_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[IDNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 06/11/2023 9:38:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyen](
	[IDQuyenNguoiDung] [varchar](10) NOT NULL,
	[IDForm] [varchar](10) NOT NULL,
	[CoQuyen] [bit] NULL,
 CONSTRAINT [PK_PhanQuyen] PRIMARY KEY CLUSTERED 
(
	[IDQuyenNguoiDung] ASC,
	[IDForm] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuyenNguoiDung]    Script Date: 06/11/2023 9:38:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyenNguoiDung](
	[IDQuyenNguoiDung] [varchar](10) NOT NULL,
 CONSTRAINT [PK_QuyenNguoiDung] PRIMARY KEY CLUSTERED 
(
	[IDQuyenNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongTinNguoiDung]    Script Date: 06/11/2023 9:38:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinNguoiDung](
	[IDNguoiDung] [varchar](10) NOT NULL,
	[HoTen] [nvarchar](255) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[Email] [varchar](255) NULL,
	[SoDienThoai] [varchar](20) NULL,
	[GioiTinh] [nvarchar](20) NULL,
	[NgaySinh] [date] NULL,
	[CanCuocCD] [varchar](20) NULL,
	[FileAnh] [nvarchar](255) NULL,
 CONSTRAINT [PK_ThongTinNguoiDung] PRIMARY KEY CLUSTERED 
(
	[IDNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [IDQuyenNguoiDung], [TenNguoiDung], [MatKhau], [BiKhoa]) VALUES (N'ND00001', N'Admin', N'test', N'1234', 0)
GO
INSERT [dbo].[QuyenNguoiDung] ([IDQuyenNguoiDung]) VALUES (N'Admin')
INSERT [dbo].[QuyenNguoiDung] ([IDQuyenNguoiDung]) VALUES (N'Employee')
INSERT [dbo].[QuyenNguoiDung] ([IDQuyenNguoiDung]) VALUES (N'Manager')
GO
INSERT [dbo].[ThongTinNguoiDung] ([IDNguoiDung], [HoTen], [DiaChi], [Email], [SoDienThoai], [GioiTinh], [NgaySinh], [CanCuocCD], [FileAnh]) VALUES (N'ND00001', N'Trần Nam Anh', N'Ba Đình, Hà Nội', N'test@test.com', N'0938668118', N'Nam', CAST(N'2000-08-12' AS Date), N'07020300335533', N'notanimage.jpg')
GO
ALTER TABLE [dbo].[Ban]  WITH CHECK ADD  CONSTRAINT [FK_Ban_KhuVuc] FOREIGN KEY([IDKhuVuc])
REFERENCES [dbo].[KhuVuc] ([IDKhuVuc])
GO
ALTER TABLE [dbo].[Ban] CHECK CONSTRAINT [FK_Ban_KhuVuc]
GO
ALTER TABLE [dbo].[DatHangHoaNhap]  WITH CHECK ADD  CONSTRAINT [FK_DatHangHoaNhap_HangHoaNhap] FOREIGN KEY([IDHangHoaNhap])
REFERENCES [dbo].[HangHoaNhap] ([IDHangHoaNhap])
GO
ALTER TABLE [dbo].[DatHangHoaNhap] CHECK CONSTRAINT [FK_DatHangHoaNhap_HangHoaNhap]
GO
ALTER TABLE [dbo].[DatHangHoaNhap]  WITH CHECK ADD  CONSTRAINT [FK_DatHangHoaNhap_HoaDonNhap] FOREIGN KEY([IDHoaDonNhap])
REFERENCES [dbo].[HoaDonNhap] ([IDHoaDonNhap])
GO
ALTER TABLE [dbo].[DatHangHoaNhap] CHECK CONSTRAINT [FK_DatHangHoaNhap_HoaDonNhap]
GO
ALTER TABLE [dbo].[DatMon]  WITH CHECK ADD  CONSTRAINT [FK_DatMon_HoaDon] FOREIGN KEY([IDHoaDon])
REFERENCES [dbo].[HoaDon] ([IDHoaDon])
GO
ALTER TABLE [dbo].[DatMon] CHECK CONSTRAINT [FK_DatMon_HoaDon]
GO
ALTER TABLE [dbo].[DatMon]  WITH CHECK ADD  CONSTRAINT [FK_DatMon_Mon] FOREIGN KEY([IDMon])
REFERENCES [dbo].[Mon] ([IDMon])
GO
ALTER TABLE [dbo].[DatMon] CHECK CONSTRAINT [FK_DatMon_Mon]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_Ban] FOREIGN KEY([IDBan])
REFERENCES [dbo].[Ban] ([IDBan])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_Ban]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NguoiDung] FOREIGN KEY([IDNguoiDung])
REFERENCES [dbo].[NguoiDung] ([IDNguoiDung])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NguoiDung]
GO
ALTER TABLE [dbo].[HoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonNhap_NguoiDung] FOREIGN KEY([IDNguoiDung])
REFERENCES [dbo].[NguoiDung] ([IDNguoiDung])
GO
ALTER TABLE [dbo].[HoaDonNhap] CHECK CONSTRAINT [FK_HoaDonNhap_NguoiDung]
GO
ALTER TABLE [dbo].[Mon]  WITH CHECK ADD  CONSTRAINT [FK_Mon_LoaiMon] FOREIGN KEY([IDLoaiMon])
REFERENCES [dbo].[LoaiMon] ([IDLoaiMon])
GO
ALTER TABLE [dbo].[Mon] CHECK CONSTRAINT [FK_Mon_LoaiMon]
GO
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_NguoiDung_QuyenNguoiDung] FOREIGN KEY([IDQuyenNguoiDung])
REFERENCES [dbo].[QuyenNguoiDung] ([IDQuyenNguoiDung])
GO
ALTER TABLE [dbo].[NguoiDung] CHECK CONSTRAINT [FK_NguoiDung_QuyenNguoiDung]
GO
ALTER TABLE [dbo].[PhanQuyen]  WITH CHECK ADD  CONSTRAINT [FK_PhanQuyen_Form] FOREIGN KEY([IDForm])
REFERENCES [dbo].[Form] ([IDForm])
GO
ALTER TABLE [dbo].[PhanQuyen] CHECK CONSTRAINT [FK_PhanQuyen_Form]
GO
ALTER TABLE [dbo].[PhanQuyen]  WITH CHECK ADD  CONSTRAINT [FK_PhanQuyen_QuyenNguoiDung] FOREIGN KEY([IDQuyenNguoiDung])
REFERENCES [dbo].[QuyenNguoiDung] ([IDQuyenNguoiDung])
GO
ALTER TABLE [dbo].[PhanQuyen] CHECK CONSTRAINT [FK_PhanQuyen_QuyenNguoiDung]
GO
ALTER TABLE [dbo].[ThongTinNguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_ThongTinNguoiDung_NguoiDung] FOREIGN KEY([IDNguoiDung])
REFERENCES [dbo].[NguoiDung] ([IDNguoiDung])
GO
ALTER TABLE [dbo].[ThongTinNguoiDung] CHECK CONSTRAINT [FK_ThongTinNguoiDung_NguoiDung]
GO
USE [master]
GO
ALTER DATABASE [LOUPAY] SET  READ_WRITE 
GO
