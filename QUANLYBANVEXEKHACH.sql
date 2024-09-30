create database QuanLyBanVeXeKhach
go

use QuanLyBanVeXeKhach
go


CREATE TABLE [DiaDiem] (
  [ID_DIADIEM] int IDENTITY(1,1) PRIMARY KEY ,
  [TEN_TINH_THANH] nvarchar(255) NOT NULL
)
GO

CREATE TABLE [TuyenDuong] (
  [ID_TUYEN] int IDENTITY(1,1)  PRIMARY KEY,
  [TEN_TUYEN] nvarchar(255) NOT NULL,
  [DIEM_DAU] int NOT NULL, 
  [DIEM_CUOI] int NOT NULL,
  [KHOANG_CACH] float NOT NULL,
  [THOI_GIAN_DI_CHUYEN] float NOT NULL,
  [TINH_TRANG] varchar(128) NOT NULL CHECK ([TINH_TRANG] IN ('CON_HOAT_DONG', 'KHONG_HOAT_DONG')),
  CHECK (DIEM_DAU != DIEM_CUOI),
  FOREIGN KEY (DIEM_DAU) REFERENCES DiaDiem(ID_DIADIEM), 
  FOREIGN KEY (DIEM_CUOI) REFERENCES DiaDiem(ID_DIADIEM)
)
GO


CREATE TABLE [Xe] (
  [ID_XE] INT IDENTITY(1,1) PRIMARY KEY,
  [BIEN_SO_XE] varchar(128) UNIQUE,
  [SO_GHE] int NOT NULL,
  [NGAY_THEM] datetime NOT NULL DEFAULT GETDATE()
)
GO

CREATE TABLE NHANVIEN(
	USERNAME VARCHAR(128) NOT NULL PRIMARY KEY,
	MAT_KHAU VARCHAR(128) NOT NULL,
	HOTEN NVARCHAR(128) NOT NULL,
	EMAIL VARCHAR(128),
	SO_DT VARCHAR(128),
	LOAINV VARCHAR(128) CHECK (LOAINV IN ('QUAN_LY','NHAN_VIEN','TAI_XE'))
)
GO

CREATE TABLE [LichTrinh] (
  [MA_LICH_TRINH] varchar(128) PRIMARY KEY,
  [ID_TUYEN_DUONG] INT NOT NULL,
  [KHOI_HANH] datetime NOT NULL,
  [KET_THUC] datetime NOT NULL,
  [GIA_VE] float NOT NULL,
  [ID_XE] INT NOT NULL,
  [CHI_PHI_PHAT_SINH] money,
  [TAIXE] varchar(128),
  [NGAY_TAO_LICH_TRINH]  datetime NOT NULL DEFAULT GETDATE(),
  CHECK (KHOI_HANH < KET_THUC),
  FOREIGN KEY (TAIXE) REFERENCES NHANVIEN(USERNAME),
  FOREIGN KEY (ID_TUYEN_DUONG) REFERENCES TuyenDuong(ID_TUYEN),
  FOREIGN KEY (ID_XE) REFERENCES Xe(ID_XE)
)
GO

CREATE TABLE TRAMDUNGCHAN(
	ID_TramDungChan VARCHAR(128) NOT NULL PRIMARY KEY,
	TEN_TramDungChan NVARCHAR(128) NOT NULL,
	ID_DIADIEM int NOT NULL,
	FOREIGN KEY (ID_DIADIEM) REFERENCES DiaDiem(ID_DIADIEM)
)
GO

CREATE TABLE THEMTRAMDUNGCHAN(
	ID_TramDungChan VARCHAR(128) NOT NULL,
	MA_LICH_TRINH VARCHAR(128) NOT NULL,
	THOIGIAN TIME NOT NULL,
	PRIMARY KEY(ID_TramDungChan, MA_LICH_TRINH),
	FOREIGN KEY (ID_TramDungChan) REFERENCES TRAMDUNGCHAN(ID_TramDungChan),
	FOREIGN KEY (MA_LICH_TRINH) REFERENCES LichTrinh(MA_LICH_TRINH)
)
GO

CREATE TABLE GHE(
	ID_GHE INT IDENTITY(1,1) PRIMARY KEY,
	[ID_XE] INT NOT NULL,
	VI_TRI_NGOI VARCHAR(10),
	UNIQUE (ID_XE, VI_TRI_NGOI),
	TRANG_THAI VARCHAR(128) CHECK (TRANG_THAI IN ('TRONG','DANG_CHON','DA_DAT')),
	FOREIGN KEY (ID_XE) REFERENCES Xe(ID_XE)
)
GO



CREATE TABLE [Ve] (
  [ID_VE] varchar(128) PRIMARY KEY,
  [ID_KHACH_HANG] varchar(128) NOT NULL,
  [ID_LICH_TRINH] varchar(128) NOT NULL,
  [TONG_TIEN] float NOT NULL,
  NHAN_VIEN_TAO VARCHAR(128),
  [TRANG_THAI] varchar(128) NOT NULL CHECK ([TRANG_THAI] IN ('da_xac_nhan', 'chua_thanh_toan', 'huy_ve')),
  [NGAY_DAT_VE]  datetime NOT NULL DEFAULT GETDATE(),
  FOREIGN KEY (ID_LICH_TRINH) REFERENCES LichTrinh(MA_LICH_TRINH),
  FOREIGN KEY (NHAN_VIEN_TAO) REFERENCES NHANVIEN(USERNAME)
)
GO

CREATE TABLE [ChiTietVe] (
  [ID_VE] varchar(128) NOT NULL,
  [ID_GHE] INT NOT NULL,
  UNIQUE (ID_GHE),
  PRIMARY KEY(ID_VE, ID_GHE),
  FOREIGN KEY (ID_VE) REFERENCES Ve(ID_VE),
  FOREIGN KEY (ID_GHE) REFERENCES GHE(ID_GHE)
)
GO

CREATE TABLE THANHTOAN (
	ID_THANHTOAN INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[ID_VE] varchar(128),
	NGAYTHANTOAN DATETIME NOT NULL DEFAULT GETDATE(),
	TONGTIEN MONEY,
	UNIQUE (ID_VE),
	FOREIGN KEY (ID_VE) REFERENCES Ve(ID_VE)
)