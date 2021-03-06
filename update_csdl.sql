USE [QL_KhoHang]
GO
/****** Object:  StoredProcedure [dbo].[ThemCTPN]    Script Date: 22/11/2016 10:44:58 PM ******/
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
/****** Object:  StoredProcedure [dbo].[ThemHH]    Script Date: 22/11/2016 10:44:58 PM ******/
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
/****** Object:  StoredProcedure [dbo].[ThemPN]    Script Date: 22/11/2016 10:44:58 PM ******/
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
/****** Object:  Table [dbo].[tblChiNhanh]    Script Date: 22/11/2016 10:44:58 PM ******/
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
/****** Object:  Table [dbo].[tblChiTietPhieuNhap]    Script Date: 22/11/2016 10:44:58 PM ******/
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
	[DonGia] [int] NULL,
	[ThanhTien] [int] NULL,
 CONSTRAINT [PK_CHITIETPHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC,
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblChiTietPhieuXuat]    Script Date: 22/11/2016 10:44:58 PM ******/
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
/****** Object:  Table [dbo].[tblDangNhap]    Script Date: 22/11/2016 10:44:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDangNhap](
	[UserName] [nvarchar](20) NULL,
	[Pass] [nvarchar](20) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblHangHoa]    Script Date: 22/11/2016 10:44:58 PM ******/
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
/****** Object:  Table [dbo].[tblNhaCungCap]    Script Date: 22/11/2016 10:44:58 PM ******/
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
/****** Object:  Table [dbo].[tblPhieuNhap]    Script Date: 22/11/2016 10:44:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPhieuNhap](
	[MaPN] [varchar](10) NOT NULL,
	[MaNCC] [varchar](10) NOT NULL,
	[NgayNhap] [date] NULL,
	[TongTien] [float] NULL,
 CONSTRAINT [PK_PHIEUNHAP_1] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPhieuXuat]    Script Date: 22/11/2016 10:44:58 PM ******/
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
/****** Object:  View [dbo].[HangHoaTheoNSX]    Script Date: 22/11/2016 10:44:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[HangHoaTheoNSX]
AS
SELECT        SUM(SoLuong) AS TongSL, NSX
FROM            dbo.tblHangHoa
GROUP BY NSX

GO
/****** Object:  View [dbo].[phieu_nhap_phieu_xuat]    Script Date: 22/11/2016 10:44:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[phieu_nhap_phieu_xuat]
AS
SELECT        COUNT(dbo.tblChiTietPhieuNhap.SoLuong) AS Expr1, COUNT(dbo.tblChiTietPhieuXuat.SoLuong) AS Expr3, MONTH(dbo.tblPhieuXuat.NgayXuat) AS Expr2
FROM            dbo.tblPhieuXuat INNER JOIN
                         dbo.tblPhieuNhap ON MONTH(dbo.tblPhieuXuat.NgayXuat) = MONTH(dbo.tblPhieuNhap.NgayNhap) INNER JOIN
                         dbo.tblChiTietPhieuNhap INNER JOIN
                         dbo.tblChiTietPhieuXuat ON dbo.tblChiTietPhieuNhap.MaHH = dbo.tblChiTietPhieuXuat.MaHH INNER JOIN
                         dbo.tblHangHoa ON dbo.tblChiTietPhieuNhap.MaHH = dbo.tblHangHoa.MaHH AND dbo.tblChiTietPhieuXuat.MaHH = dbo.tblHangHoa.MaHH ON dbo.tblPhieuNhap.MaPN = dbo.tblChiTietPhieuNhap.MaPN AND 
                         dbo.tblPhieuXuat.MaPX = dbo.tblChiTietPhieuXuat.MaPX
GROUP BY MONTH(dbo.tblPhieuXuat.NgayXuat)

GO
INSERT [dbo].[tblDangNhap] ([UserName], [Pass]) VALUES (N'admin', N'admin')
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
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tblHangHoa"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'HangHoaTheoNSX'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'HangHoaTheoNSX'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tblChiTietPhieuNhap"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tblChiTietPhieuXuat"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tblHangHoa"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 136
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "tblPhieuNhap"
            Begin Extent = 
               Top = 6
               Left = 662
               Bottom = 136
               Right = 832
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tblPhieuXuat"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 144' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'phieu_nhap_phieu_xuat'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'0
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'phieu_nhap_phieu_xuat'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'phieu_nhap_phieu_xuat'
GO
