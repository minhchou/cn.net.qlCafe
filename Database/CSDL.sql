USE [master]
GO

CREATE DATABASE [QL_Quancaphe]
go
USE [QL_Quancaphe]
GO
/*Table NHA CUNG CAP*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_NCC](
	[mancc] [nvarchar](10) NOT NULL,
	[tenncc] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[sdt] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_NCC] PRIMARY KEY CLUSTERED 
(
	[mancc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/*Table LOAI*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Loai](
	[maloai] [nvarchar](10) NOT NULL,
	[tenloai] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_Loai] PRIMARY KEY CLUSTERED 
(
	[maloai] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/*Table Khachhang */
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Khachhang](
	[makh] [nvarchar](10) NOT NULL,
	[tenkh] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_Khachhang] PRIMARY KEY CLUSTERED 
(
	[makh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/*Table Que*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Que](
	[maque] [nvarchar](10) NOT NULL,
	[tenque] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_Que] PRIMARY KEY CLUSTERED 
(
	[maque] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/* Table Cong Dung*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Congdung](
	[macongdung] [nvarchar](10) NOT NULL,
	[tencongdung] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_Congdung] PRIMARY KEY CLUSTERED 
(
	[macongdung] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/*Table User*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_User](
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/*Table Sản Phẩm*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Sanpham](
	[masp] [nvarchar](10) NOT NULL,
	[tensp] [nvarchar](50) NULL,
	[maloai] [nvarchar](10) NULL,
	[gianhap] [float]  NULL,-- float [nvarchar](50)
	[giaban] [float](50) NULL,-- float [nvarchar](50)
	[soluong] [float] NULL,
	[macongdung] [nvarchar](10) NULL,
	[hinhanh] [image] NULL,
 CONSTRAINT [PK_tb_Sanpham] PRIMARY KEY CLUSTERED 
(
	[masp] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/*Table NhanVien*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Nhanvien](
	[manv] [nvarchar](10) NOT NULL,
	[tennv] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[gioitinh] [nvarchar](10) NULL,
	[ngaysinh] [datetime] NULL,
	[maque] [nvarchar](10) NULL,
	[sdt] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_Nhanvien] PRIMARY KEY CLUSTERED 
(
	[manv] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/*Table Hoa Don Nhap*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_HDN](
	[mahdn] [nvarchar](10) NOT NULL,
	[ngaynhap] [datetime] NULL,
	[manv] [nvarchar](10) NULL,
	[mancc] [nvarchar](10) NULL,
	[tongtien] [float] NULL,
 CONSTRAINT [PK_tb_HDN] PRIMARY KEY CLUSTERED 
(
	[mahdn] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/*Table Hoa Don Ban*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_HDB](
	[mahdb] [nvarchar](10) NOT NULL,
	[ngayban] [datetime] NULL,
	[manv] [nvarchar](10) NULL,
	[makh] [nvarchar](10) NULL,
	[tongtien] [float] NULL,
 CONSTRAINT [PK_tb_HDB] PRIMARY KEY CLUSTERED 
(
	[mahdb] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/*Table Cong */
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_CTHDN](
	[mahdn] [nvarchar](10) NOT NULL,
	[masp] [nvarchar](10) NOT NULL,
	[soluong] [float] NULL,
	[dongia] [float] NULL,
	[thanhtien] [float] NULL,
	[khuyenmai] [float] NULL,
 CONSTRAINT [PK_tb_CTHDN] PRIMARY KEY CLUSTERED 
(
	[mahdn] ASC,
	[masp] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/*Table CT Hoa Don Ban*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_CTHDB](
	[mahdb] [nvarchar](10) NOT NULL,
	[masp] [nvarchar](50) NOT NULL,
	[tensp] [nvarchar](50) NULL,
	[soluong] [float] NULL,
	[thanhtien] [float] NULL,
	[khuyenmai] [float] NULL,
 CONSTRAINT [PK_tc_CTHDB] PRIMARY KEY CLUSTERED 
(
	[mahdb] ASC,
	[masp] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/* PHUCLAITS03 COMMIT > CHECK => SET ForeignKey [FK_tb_CTHDB_tb_HDB] */
ALTER TABLE [dbo].[tb_CTHDB]  WITH CHECK ADD  CONSTRAINT [FK_tb_CTHDB_tb_HDB] FOREIGN KEY([mahdb])
REFERENCES [dbo].[tb_HDB] ([mahdb])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_CTHDB] CHECK CONSTRAINT [FK_tb_CTHDB_tb_HDB]
GO
/* PHUCLAITS03 COMMIT > CHECK => SET ForeignKey [FK_tb_CTHDN_tb_HDN] */
ALTER TABLE [dbo].[tb_CTHDN]  WITH CHECK ADD  CONSTRAINT [FK_tb_CTHDN_tb_HDN] FOREIGN KEY([mahdn])
REFERENCES [dbo].[tb_HDN] ([mahdn])
GO
ALTER TABLE [dbo].[tb_CTHDN] CHECK CONSTRAINT [FK_tb_CTHDN_tb_HDN]
GO
/* PHUCLAITS03 COMMIT > CHECK => SET ForeignKey [FK_tb_CTHDN_tb_Sanpham] */
ALTER TABLE [dbo].[tb_CTHDN]  WITH CHECK ADD  CONSTRAINT [FK_tb_CTHDN_tb_Sanpham] FOREIGN KEY([masp])
REFERENCES [dbo].[tb_Sanpham] ([masp])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_CTHDN] CHECK CONSTRAINT [FK_tb_CTHDN_tb_Sanpham]
GO
/* PHUCLAITS03 COMMIT > CHECK => SET ForeignKey [FK_tb_CTHDN_tb_Sanpham1]*/
ALTER TABLE [dbo].[tb_CTHDN]  WITH CHECK ADD  CONSTRAINT [FK_tb_CTHDN_tb_Sanpham1] FOREIGN KEY([masp])
REFERENCES [dbo].[tb_Sanpham] ([masp])
GO
ALTER TABLE [dbo].[tb_CTHDN] CHECK CONSTRAINT [FK_tb_CTHDN_tb_Sanpham1]
GO
/* PHUCLAITS03 COMMIT > CHECK => SET ForeignKey [FK_tb_HDB_tb_Khachhang] */
ALTER TABLE [dbo].[tb_HDB]  WITH CHECK ADD  CONSTRAINT [FK_tb_HDB_tb_Khachhang] FOREIGN KEY([makh])
REFERENCES [dbo].[tb_Khachhang] ([makh])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_HDB] CHECK CONSTRAINT [FK_tb_HDB_tb_Khachhang]
GO
/* PHUCLAITS03 COMMIT > CHECK => SET ForeignKey [FK_tb_HDB_tb_Nhanvien]*/
ALTER TABLE [dbo].[tb_HDB]  WITH CHECK ADD  CONSTRAINT [FK_tb_HDB_tb_Nhanvien] FOREIGN KEY([manv])
REFERENCES [dbo].[tb_Nhanvien] ([manv])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_HDB] CHECK CONSTRAINT [FK_tb_HDB_tb_Nhanvien]
GO
/* PHUCLAITS03 COMMIT > CHECK => SET ForeignKey [FK_tb_HDN_tb_NCC]  */
ALTER TABLE [dbo].[tb_HDN]  WITH CHECK ADD  CONSTRAINT [FK_tb_HDN_tb_NCC] FOREIGN KEY([mancc])
REFERENCES [dbo].[tb_NCC] ([mancc])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_HDN] CHECK CONSTRAINT [FK_tb_HDN_tb_NCC]
GO
/* PHUCLAITS03 COMMIT > CHECK => SET ForeignKey [FK_tb_HDN_tb_Nhanvien]  */
ALTER TABLE [dbo].[tb_HDN]  WITH CHECK ADD  CONSTRAINT [FK_tb_HDN_tb_Nhanvien] FOREIGN KEY([manv])
REFERENCES [dbo].[tb_Nhanvien] ([manv])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_HDN] CHECK CONSTRAINT [FK_tb_HDN_tb_Nhanvien]
GO
/* PHUCLAITS03 COMMIT > CHECK => SET ForeignKey [FK_tb_Nhanvien_tb_Que] */
ALTER TABLE [dbo].[tb_Nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_tb_Nhanvien_tb_Que] FOREIGN KEY([maque])
REFERENCES [dbo].[tb_Que] ([maque])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_Nhanvien] CHECK CONSTRAINT [FK_tb_Nhanvien_tb_Que]
GO
/* PHUCLAITS03 COMMIT > CHECK => SET ForeignKey [FK_tb_Sanpham_tb_Congdung]  */
ALTER TABLE [dbo].[tb_Sanpham]  WITH CHECK ADD  CONSTRAINT [FK_tb_Sanpham_tb_Congdung] FOREIGN KEY([macongdung])
REFERENCES [dbo].[tb_Congdung] ([macongdung])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_Sanpham] CHECK CONSTRAINT [FK_tb_Sanpham_tb_Congdung]
GO
/* PHUCLAITS03 COMMIT > CHECK => SET ForeignKey [FK_tb_Sanpham_tb_Loai] */
ALTER TABLE [dbo].[tb_Sanpham]  WITH CHECK ADD  CONSTRAINT [FK_tb_Sanpham_tb_Loai] FOREIGN KEY([maloai])
REFERENCES [dbo].[tb_Loai] ([maloai])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_Sanpham] CHECK CONSTRAINT [FK_tb_Sanpham_tb_Loai]
GO
-- INSERT USER
INSERT INTO tb_User (Username, Password) VALUES('admin','admin') 


-- INSERT QUÊ
go
BULK INSERT [QL_Quancaphe].[DBO].[tb_Que]
	FROM 'C:\Users\ASUS\OneDrive\Desktop\HK_V\Tech.Net\Project.Net\Project\Database\tb_Que.tsv'
	WITH
	(
		FIELDTERMINATOR = '|',
		ROWTERMINATOR = '\n',
		FIRSTROW = 1,
		CODEPAGE='65001' 
	)

SELECT * from [DBO].[tb_Que]
SELECT maque, tenque FROM tb_Que

-- nhap hoa don 
SELECT  tb_CTHDN.mahdn, tb_NCC.tenncc, tb_NCC.diachi, tb_NCC.sdt, tb_Nhanvien.tennv,tb_HDN.ngaynhap
from tb_HDN 
INNER JOIN tb_NCC ON tb_HDN.mancc = tb_NCC.mancc INNER JOIN 
tb_CTHDN ON tb_HDN.mahdn = tb_CTHDN.mahdn INNER JOIN tb_Nhanvien ON tb_HDN.manv = tb_Nhanvien.manv 
where tb_HDN.mahdn='HDN01'

select * from tb_HDN
--- giá cả hóa đơn nhập
SELECT tb_Sanpham.tensp, tb_CTHDN.soluong, tb_CTHDN.dongia, tb_CTHDN.khuyenmai, tb_CTHDN.thanhtien FROM tb_CTHDN INNER JOIN tb_Sanpham ON tb_CTHDN.masp = tb_Sanpham.masp AND tb_CTHDN.masp = tb_Sanpham.masp where tb_CTHDN.mahdn='HDN01';
select * from tb_HDN
select * from tb_CTHDB
SELECT tb_HDB.mahdb,  tb_Khachhang.tenkh,tb_HDB.ngayban,tb_Nhanvien.tennv
FROM  tb_CTHDB 
INNER JOIN tb_HDB ON tb_CTHDB.mahdb = tb_HDB.mahdb 
INNER JOIN tb_Khachhang ON tb_HDB.makh = tb_Khachhang.makh 
INNER JOIN tb_Nhanvien ON tb_HDB.manv = tb_Nhanvien.manv 
where tb_HDB.mahdb='HDB02';

-- tìm kiếm hóa đơn bán
--grid
SELECT mahdb, ngayban,manv, makh,tongtien FROM tb_HDB
--CHI TIẾT HÓA ĐƠN BÁN 
SELECT * FROM tb_CTHDB
-- mã hàng
SELECT tb_HDB.mahdb, tb_HDB.ngayban, tb_HDB.manv, tb_HDB.makh, tb_HDB.tongtien 
FROM tb_HDB 
INNER JOIN tb_CTHDB ON tb_HDB.mahdb = tb_CTHDB.mahdb
WHERE tb_CTHDB.masp= 'SP01'


SELECT tb_HDB.mahdb,  tb_Khachhang.tenkh,tb_HDB.ngayban,tb_Nhanvien.tennv
                    FROM  tb_CTHDB 
                    INNER JOIN tb_HDB ON tb_CTHDB.mahdb = tb_HDB.mahdb 
                    INNER JOIN tb_Khachhang ON tb_HDB.makh = tb_Khachhang.makh 
                    INNER JOIN tb_Nhanvien ON tb_HDB.manv = tb_Nhanvien.manv 
                    where tb_HDB.mahdb='HDB02'

SELECT tb_Sanpham.tensp, tb_CTHDB.soluong, tb_Sanpham.giaban, tb_CTHDB.khuyenmai, tb_CTHDB.thanhtien ,sum(tb_CTHDB.thanhtien) as 'TongTien'
FROM tb_CTHDB INNER JOIN tb_Sanpham ON tb_CTHDB.masp = tb_Sanpham.masp 
where tb_CTHDB.mahdb='HDB02'
group by tb_Sanpham.tensp, tb_CTHDB.soluong, tb_Sanpham.giaban, tb_CTHDB.khuyenmai, tb_CTHDB.thanhtien, tb_CTHDB.mahdb

SELECT sum(tb_CTHDB.thanhtien)
FROM tb_CTHDB INNER JOIN tb_Sanpham ON tb_CTHDB.masp = tb_Sanpham.masp 
where tb_CTHDB.mahdb = 'HDB02'
SELECT sum(tb_CTHDB.thanhtien) FROM tb_CTHDB 
where tb_CTHDB.mahdb='HDB02';

--- thống kê hóa đơn bán
select tb_HDB.mahdb,tb_Nhanvien.tennv,tb_HDB.tongtien from tb_HDB
inner join tb_Nhanvien ON tb_HDB.manv = tb_Nhanvien.manv

select sum(tb_HDB.tongtien) from tb_HDB
inner join tb_Nhanvien ON tb_HDB.manv = tb_Nhanvien.manv
where tb_HDB.ngayban BETWEEN '10/20/2023' AND '10/21/2023'
SELECT mahdb, tongtien FROM  tb_HDB where tb_HDB.ngayban BETWEEN '10/20/2023' AND '10/21/2023' order by tongtien DESC


SELECT tb_HDB.mahdb,tb_HDB.manv, tb_HDB.ngayban ,tb_HDB.makh, tb_HDB.tongtien 
                               FROM tb_HDB 
                               INNER JOIN tb_CTHDB ON tb_HDB.mahdb = tb_CTHDB.mahdb


SELECT tb_HDB.mahdb, tb_HDB.manv, tb_HDB.ngayban, tb_HDB.makh, tb_HDB.tongtien 
                               FROM tb_HDB 
                               INNER JOIN tb_CTHDB ON tb_HDB.mahdb = tb_CTHDB.mahdb 
                               WHERE tb_HDB.mahdb= 'hdb02'





SELECT tb_HDB.makh, tb_Khachhang.tenkh FROM tb_HDB INNER JOIN tb_Khachhang ON tb_HDB.makh = tb_Khachhang.makh 
where tb_HDB.ngayban BETWEEN '" + d1.Text + "' AND '" + d2.Text + "' 
group by tb_HDB.makh, tb_Khachhang.tenkh

GO
SELECT mahdb,manv,ngayban,makh,tongtien FROM tb_HDB
select * from tb_HDB
SELECT * FROM tb_CTHDB
SELECT sum(thanhtien) FROM tb_CTHDB where mahdb = 'hdb05'