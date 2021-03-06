USE [master]
GO
/****** Object:  Database [QL_KhoHang]    Script Date: 9/23/2016 9:51:04 AM ******/
CREATE DATABASE [QL_KhoHang]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QL_KhoHang', FILENAME = N'D:\QL_KhoHang.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QL_KhoHang_log', FILENAME = N'D:\QL_KhoHang_log.ldf' , SIZE = 5120KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QL_KhoHang] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_KhoHang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_KhoHang] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_KhoHang] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_KhoHang] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_KhoHang] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_KhoHang] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_KhoHang] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QL_KhoHang] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QL_KhoHang] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_KhoHang] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_KhoHang] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_KhoHang] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_KhoHang] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_KhoHang] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_KhoHang] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_KhoHang] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_KhoHang] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QL_KhoHang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_KhoHang] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_KhoHang] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_KhoHang] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_KhoHang] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_KhoHang] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_KhoHang] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_KhoHang] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QL_KhoHang] SET  MULTI_USER 
GO
ALTER DATABASE [QL_KhoHang] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_KhoHang] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_KhoHang] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_KhoHang] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QL_KhoHang', N'ON'
GO
USE [QL_KhoHang]
GO
/****** Object:  StoredProcedure [dbo].[ThemCTPN]    Script Date: 9/23/2016 9:51:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemCTPN] @mapn varchar(10), @mahh varchar(10), @soluong int, @dongia float, @thanhtien float
AS
BEGIN
INSERT INTO CHITIETPHIEUNHAP(MaPN, MaHH, SoLuong, DonGia, ThanhTien) values (@mapn, @mahh, @soluong, @dongia, @thanhtien)
END

GO
/****** Object:  StoredProcedure [dbo].[ThemHH]    Script Date: 9/23/2016 9:51:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemHH] @tenhh nvarchar(50), @soluong int, @gianhap bigint, @giaxuat bigint, @nsx nvarchar(50), @thongtin text
AS
BEGIN
DECLARE @MaHH varchar(10)
DECLARE @Sott int
DECLARE contro CURSOR FORWARD_ONLY FOR SELECT MaHH from HANGHOA
SET @Sott = 0

OPEN contro
FETCH NEXT FROM contro INTO @MaHH
WHILE(@@FETCH_STATUS = 0)
BEGIN
	IF((CAST(right(@MaHH, 8) AS int) - @sott) = 1)
		BEGIN
			SET @Sott = CAST(right(@MaHH, 8) AS int)
		END
	ELSE BREAK
	FETCH NEXT FROM contro INTO @MaHH
END

DECLARE @cdai int
DECLARE @i int
SET @MaHH = CAST((@sott + 1) as varchar(8))
SET @cdai = LEN(@MaHH)
SET @i = 1
while ( @i <= 8 - @cdai)
BEGIN
	SET @MaHH = '0' + @MaHH
	SET @i = @i + 1
END
SET @MaHH = 'HH' + @MaHH

INSERT INTO HANGHOA(MaHH, TenHH, SoLuong, GiaNhap, GiaXuat, NSX, ThongTin) values ( @MaHH, @tenhh, @soluong, @gianhap, @giaxuat, @nsx, @thongtin)
SELECT @MaHH
CLOSE contro
DEALLOCATE contro
END

GO
/****** Object:  StoredProcedure [dbo].[ThemPN]    Script Date: 9/23/2016 9:51:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemPN] @mancc varchar(10), @ngaynhap date
AS
BEGIN
DECLARE @MaPN varchar(10)
DECLARE @Sott int
DECLARE contro CURSOR FORWARD_ONLY FOR SELECT MaPN from PHIEUNHAP
SET @Sott = 0

OPEN contro
FETCH NEXT FROM contro INTO @MaPN
WHILE(@@FETCH_STATUS = 0)
BEGIN
	IF((CAST(right(@MaPN, 8) AS int) - @sott) = 1)
		BEGIN
			SET @Sott = @Sott + 1
		END
	ELSE BREAK
	FETCH NEXT FROM contro INTO @MaPN
END
DECLARE @cdai int
DECLARE @i int
SET @MaPN = CAST((@sott + 1) as varchar(8))
SET @cdai = LEN(@MaPN)
SET @i = 1
while ( @i <= 8 - @cdai)
BEGIN
	SET @MaPN = '0' + @MaPN
	SET @i = @i + 1
END
SET @MaPN = 'PN' + @MaPN

INSERT INTO PHIEUNHAP(MaPN, MaNCC, NgayNhap) values (@MaPN, @mancc, @ngaynhap)
SELECT @MaPN
CLOSE contro
DEALLOCATE contro
END

GO
/****** Object:  Table [dbo].[tblChiNhanh]    Script Date: 9/23/2016 9:51:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblChiNhanh](
	[MaCN] [varchar](10) NOT NULL,
	[TenCN] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SDT] [varchar](20) NULL,
 CONSTRAINT [PK_CHINHANH] PRIMARY KEY CLUSTERED 
(
	[MaCN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblChiTietPhieuNhap]    Script Date: 9/23/2016 9:51:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblChiTietPhieuNhap](
	[MaPN] [varchar](10) NOT NULL,
	[MaHH] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
 CONSTRAINT [PK_CHITIETPHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC,
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblChiTietPhieuXuat]    Script Date: 9/23/2016 9:51:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblChiTietPhieuXuat](
	[MaPX] [varchar](10) NOT NULL,
	[MaHH] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
 CONSTRAINT [PK_CHITIETPHIEUXUAT] PRIMARY KEY CLUSTERED 
(
	[MaPX] ASC,
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblDangNhap]    Script Date: 9/23/2016 9:51:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDangNhap](
	[UserName] [nvarchar](20) NULL,
	[Pass] [nvarchar](20) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblHangHoa]    Script Date: 9/23/2016 9:51:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblHangHoa](
	[MaHH] [varchar](10) NOT NULL,
	[TenHH] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[GiaNhap] [float] NULL,
	[GiaXuat] [float] NULL,
	[NSX] [nvarchar](50) NULL,
	[ThongTin] [ntext] NULL,
 CONSTRAINT [PK_HANGHOA] PRIMARY KEY CLUSTERED 
(
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblNhaCungCap]    Script Date: 9/23/2016 9:51:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblNhaCungCap](
	[MaNCC] [varchar](10) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SDT] [varchar](20) NULL,
 CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPhieuNhap]    Script Date: 9/23/2016 9:51:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPhieuNhap](
	[MaPN] [varchar](10) NOT NULL,
	[MaNCC] [varchar](10) NOT NULL,
	[NgayNhap] [datetime] NULL,
	[TongTien] [float] NULL,
 CONSTRAINT [PK_PHIEUNHAP_1] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPhieuXuat]    Script Date: 9/23/2016 9:51:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPhieuXuat](
	[MaPX] [varchar](10) NOT NULL,
	[MaCN] [varchar](10) NOT NULL,
	[NgayXuat] [datetime] NULL,
	[TongTien] [float] NULL,
 CONSTRAINT [PK_PHIEUXUAT_1] PRIMARY KEY CLUSTERED 
(
	[MaPX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblDangNhap] ([UserName], [Pass]) VALUES (N'ManhLinh', N'0204')
INSERT [dbo].[tblDangNhap] ([UserName], [Pass]) VALUES (N'DuyHung', N'0204')
INSERT [dbo].[tblDangNhap] ([UserName], [Pass]) VALUES (N'QuangHung', N'0204')
INSERT [dbo].[tblDangNhap] ([UserName], [Pass]) VALUES (N'VanCong', N'0204')
INSERT [dbo].[tblDangNhap] ([UserName], [Pass]) VALUES (N'QuynhNga', N'0204')
INSERT [dbo].[tblHangHoa] ([MaHH], [TenHH], [SoLuong], [GiaNhap], [GiaXuat], [NSX], [ThongTin]) VALUES (N'HH00000001', N'Dell Inspiron 14 3443 70055103 Black', 70, 12390000, 14248500, N'DELL', N'CPU Intel Core i5-5200U Broadwell (2.2Ghz upto 2.7Ghz, 3MB Cache L3)/ Ram 4GB Buss 1600Mhz/ HDD 1TB ')
INSERT [dbo].[tblHangHoa] ([MaHH], [TenHH], [SoLuong], [GiaNhap], [GiaXuat], [NSX], [ThongTin]) VALUES (N'HH00000002', N'aaa', 24, 2345600, 234566, N'ASUS', N'bbb')
INSERT [dbo].[tblHangHoa] ([MaHH], [TenHH], [SoLuong], [GiaNhap], [GiaXuat], [NSX], [ThongTin]) VALUES (N'HH00000003', N'ASUS A500', 45, 13500, 14500, N'ASUS', N'CPU Intel Core i5 Ram:4G')
ALTER TABLE [dbo].[tblChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUNHAP_HANGHOA] FOREIGN KEY([MaHH])
REFERENCES [dbo].[tblHangHoa] ([MaHH])
GO
ALTER TABLE [dbo].[tblChiTietPhieuNhap] CHECK CONSTRAINT [FK_CHITIETPHIEUNHAP_HANGHOA]
GO
ALTER TABLE [dbo].[tblChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUNHAP_PHIEUNHAP] FOREIGN KEY([MaPN])
REFERENCES [dbo].[tblPhieuNhap] ([MaPN])
GO
ALTER TABLE [dbo].[tblChiTietPhieuNhap] CHECK CONSTRAINT [FK_CHITIETPHIEUNHAP_PHIEUNHAP]
GO
ALTER TABLE [dbo].[tblChiTietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUXUAT_HANGHOA] FOREIGN KEY([MaHH])
REFERENCES [dbo].[tblHangHoa] ([MaHH])
GO
ALTER TABLE [dbo].[tblChiTietPhieuXuat] CHECK CONSTRAINT [FK_CHITIETPHIEUXUAT_HANGHOA]
GO
ALTER TABLE [dbo].[tblChiTietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUXUAT_PHIEUXUAT] FOREIGN KEY([MaPX])
REFERENCES [dbo].[tblPhieuXuat] ([MaPX])
GO
ALTER TABLE [dbo].[tblChiTietPhieuXuat] CHECK CONSTRAINT [FK_CHITIETPHIEUXUAT_PHIEUXUAT]
GO
ALTER TABLE [dbo].[tblPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NHACUNGCAP] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[tblNhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[tblPhieuNhap] CHECK CONSTRAINT [FK_PHIEUNHAP_NHACUNGCAP]
GO
ALTER TABLE [dbo].[tblPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUXUAT_CHINHANH] FOREIGN KEY([MaCN])
REFERENCES [dbo].[tblChiNhanh] ([MaCN])
GO
ALTER TABLE [dbo].[tblPhieuXuat] CHECK CONSTRAINT [FK_PHIEUXUAT_CHINHANH]
GO
USE [master]
GO
ALTER DATABASE [QL_KhoHang] SET  READ_WRITE 
GO
