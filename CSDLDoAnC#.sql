USE [master]
GO

CREATE DATABASE [QLQuanCF]
GO
USE [QLQuanCF]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [admin](
	 [ID] [varchar](5) NOT NULL,
	 [Ho] [nvarchar](20) NOT NULL,
	 [Ten] [nvarchar](20) NOT NULL,
	 [PhoneNumber] [varchar](15) NOT NULL,
	 [Email] [varchar](50) NOT NULL UNIQUE,
	 [Password] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [nhanvien](
	 [ID] [varchar](5) NOT NULL,
	 [Ho] [nvarchar](20) NOT NULL,
	 [Ten] [nvarchar](20) NOT NULL,
	 [Luong] [DECIMAL](15,2) NOT NULL,
	 [PhoneNumber] [varchar](15) NOT NULL,
	 [Email] [varchar](50) NOT NULL UNIQUE,
	 [Password] [varchar](255) NOT NULL,
	 [CreatedAt] [datetime] DEFAULT GETDATE(),
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [theTV](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [varchar](5) NOT NULL,--FK
	[FullName] [nvarchar](100) NOT NULL,
	[PhoneNumber] [varchar](15) NOT NULL,
	[DiaChi] [nvarchar](255) NOT NULL, 
	[TrangThai] [bit] NOT NULL,
	[CreatedAt] [datetime] DEFAULT GETDATE(),
 CONSTRAINT [PK_TheTV] PRIMARY KEY CLUSTERED
 (
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [tables](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED
 (
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [products](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Gia] [DECIMAL](10,2) NOT NULL,
	[CategoryID] [int] NOT NULL,--FK
	[MoTa] [nvarchar](255) NULL,
	[ImageFood] [nvarchar](255) NULL,
	[TrangThai] [bit] NOT NULL,
	[KhuyenMai] [int] NULL,
	[CreatedAt] [datetime] DEFAULT GETDATE(),
	[UpdatedAt] [datetime] DEFAULT GETDATE(),
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED
 (
 [ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [category](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED
 (
 [ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [bill](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TableID] [int] NULL,--FK
	[UserID] [varchar](5) NOT NULL,--FK
	[TheID] [int] NULL,--FK
	[Status] [bit] DEFAULT 0,
	[TienKhachDua] [DECIMAL](10,2)  NULL,
	[TienTraKhach] [DECIMAL](10,2)  NULL,
	[Sum] [DECIMAL](10,2) NOT NULL,
	[CreatedAt] [datetime] DEFAULT GETDATE(),
	[TimeOutBill] [datetime] DEFAULT GETDATE(),
	[GroupTableID] [int] NULL,--FK
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED
 (
 [ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
)ON [PRIMARY]

CREATE TABLE [billInfo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BillID] [int] NOT NULL,--FK
	[ProductsID] [int] NOT NULL,--FK
	[SoLuong] [int] NOT NULL,
	[Gia] [DECIMAL](10,2) NOT NULL,
	[ThanhTien] [DECIMAL](10,2) NOT NULL,
	[KhuyenMai] [int] NULL,
 CONSTRAINT [PK_BillInfo] PRIMARY KEY CLUSTERED
(
 [ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
)ON [PRIMARY]

CREATE TABLE [chamcong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [varchar](5) NOT NULL,--PK
	[Ngay] [datetime] DEFAULT GETDATE(),
	[GioVao] [time] NULL,
	[GioRa] [time] NULL,
	[WorkingTime] [int] NULL,
 CONSTRAINT [PK_ChamCong] PRIMARY KEY CLUSTERED
(
 [ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
)ON [PRIMARY]	

ALTER TABLE [products]
ADD CONSTRAINT FK_Products_Category 
FOREIGN KEY ([CategoryID]) 
REFERENCES [category]([ID]) 
ON DELETE CASCADE ;

ALTER TABLE [bill]
ADD CONSTRAINT FK_Bill_Tables
FOREIGN KEY ([TableID])
REFERENCES [tables](ID)
ON DELETE CASCADE ;

ALTER TABLE [bill]
ADD CONSTRAINT FK_Bill_TheTV
FOREIGN KEY ([TheID])
REFERENCES [TheTV](ID)


ALTER TABLE [billInfo]
ADD CONSTRAINT FK_BillInfo_Bill
FOREIGN KEY ([BillID])
REFERENCES [bill](ID)
ON DELETE CASCADE ;

ALTER TABLE [billInfo]
ADD CONSTRAINT FK_BillInfo_Products
FOREIGN KEY ([ProductsID])
REFERENCES [products](ID)

ALTER TABLE [bill]
ADD CONSTRAINT PK_bill_tableGroup
FOREIGN KEY ([GroupTableID])
REFERENCES [tables](ID)


SELECT * FROM dbo.category
INSERT INTO dbo.category(Name)
VALUES(N'Cafe')

SELECT * FROM dbo.[admin]
INSERT INTO dbo.admin (ID, Ho, Ten, PhoneNumber, Email, Password)
VALUES ('ADM01', N'Trần', N'Trí', '0123456789', 'trantri@gmail.con', '123'),
('ADM02', N'Đỗ', N'Thương', '0999999999', 'thuongne@gmail.con', '123');

SELECT * FROM dbo.nhanvien
INSERT INTO dbo.nhanvien (ID, Ho, Ten, Luong, PhoneNumber, Email, Password)
VALUES ('NV01', N'Tran',N'Trung', 30000, '0147852369', 'trantrung@gmail.com', '123'),
('NV02', N'Nguyen',N'Si', 40000, '024688642', 'Nnguyensi@gmail.com', '123'),
('NV03', N'Nguyen',N'Huong', 50000, '0147852369', 'nguyenhuong@gmail.com', '123')

SELECT * FROM dbo.products
INSERT INTO dbo.products(Name, Gia, CategoryID, MoTa, ImageFood, TrangThai, KhuyenMai)
VALUES (N'Cafe Muối', 15000, 1, N'Cafe có vị muối , đặc sản chú Long', N'Cafe Muối', 1, 0),
(N'Cafe Sữa', 20000, 1, N'Cafe có sữa , ngọt + đắng phê', N'Cafe Sữa', 1, 0),
(N'Cafe Đen', 13000, 1, N'Cafe đen , đậm chất cà phê , hương vị vùng cao', N'Cafe Đen', 1, 0),
(N'Cafe Nghệ Thuật', 100000, 1, N'Siêu đẹp nhaaaaaaaa', N'Cafe Nghệ Thuật', 1, 0)

SELECT * FROM dbo.theTV
INSERT INTO dbo.theTV(UserID, FullName, PhoneNumber, DiaChi, TrangThai)
VALUES (N'NV01', N'Nguyễn Thị Hương Hoa', '0369963333', N'Long An', 1),
(N'NV02', N'Đào Thị Mai Trâm', '0374125487', N'TP.HCM', 1),
(N'NV02', N'Trần Tuấn Anh', '0123321111', N'Hà Nội', 1)

SELECT * FROM dbo.[tables]
INSERT INTO dbo.[tables]( Name, Status)
VALUES ( N'Bàn 01', 0),
( N'Bàn 02', 0),
( N'Bàn 03', 0),
( N'Bàn 04', 0),
( N'Bàn 05', 0),
( N'Bàn 06', 0),
( N'Bàn 07', 0),
( N'Bàn 08', 0),
( N'Bàn 09', 0),
( N'Bàn 10', 0),
( N'Bàn 11', 0),
( N'Bàn 12', 0),
( N'Bàn 13', 0),
( N'Bàn 14', 0),
( N'Bàn 15', 0)

SELECT * FROM dbo.bill
INSERT INTO dbo.bill(TableID, Status, Sum, TienKhachDua, TienTraKhach, TimeOutBill, UserID, TheID)
VALUES(1, 1, 150000, 200000, 50000, '2025-04-29 19:30:00', 'NV01', 1),
(2, 1, 100000, 200000, 100000, '2025-04-29 19:30:00', 'NV02', 2),
(3, 1, 50000, 100000, 50000, '2025-04-29 19:30:00', 'NV02', 3)


SELECT * FROM dbo.chamcong
INSERT INTO dbo.chamcong(UserID, GioVao, GioRa, WorkingTime)
VALUES ('NV01', '05:00:00', '11:00:00', DATEDIFF(HOUR, '5:00:00', '11:00:00')),--demo time
('NV02', '11:00:00', '18:00:00', DATEDIFF(HOUR, '11:00:00', '18:00:00')),
('NV03', '18:00:00', '23:00:00', DATEDIFF(HOUR, '18:00:00', '23:00:00'))

SELECT * FROM dbo.billInfo
INSERT INTO dbo.billInfo(BillID, ProductsID, SoLuong, Gia, ThanhTien, KhuyenMai)
VALUES (1, 1, 10, 15000, 150000, 0),
(2, 1, 4, 15000, 60000, 0),
(2, 2, 2, 20000, 40000, 0),
(3, 1, 2, 15000, 30000, 0),
(3, 2, 1, 20000, 20000, 0)

GO
CREATE PROC CheckLoginAD
    @Email varchar(50),
    @Password varchar(255) 
AS
BEGIN
    SELECT * 
    FROM admin 
    WHERE Email like @Email and Password LIKE @Password
END


GO
CREATE PROC CheckLoginNV
    @Email varchar(50),
    @Password varchar(255) 
AS
BEGIN
    SELECT * 
    FROM nhanvien 
    WHERE Email like @Email and Password LIKE @Password
END





