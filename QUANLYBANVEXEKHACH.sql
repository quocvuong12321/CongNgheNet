
drop database QuanLyBanVeXeKhach

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
  CHECK (DIEM_DAU != DIEM_CUOI),
  FOREIGN KEY (DIEM_DAU) REFERENCES DiaDiem(ID_DIADIEM), 
  FOREIGN KEY (DIEM_CUOI) REFERENCES DiaDiem(ID_DIADIEM)
)
GO


CREATE TABLE [Xe] (
  [ID_XE] INT IDENTITY(1,1) PRIMARY KEY,
  [BIEN_SO_XE] varchar(128) UNIQUE,
  [SO_GHE] int NOT NULL check ([SO_GHE] in (20,34)),
  [NGAY_THEM] datetime NOT NULL DEFAULT GETDATE()
)
GO

CREATE TABLE NHANVIEN(
	USERNAME VARCHAR(128) NOT NULL PRIMARY KEY,
	MAT_KHAU VARCHAR(128) NOT NULL,
	HOTEN NVARCHAR(128) NOT NULL,
	SO_DT VARCHAR(128),
	GIOITINH NVARCHAR(5) NOT NULL check (GIOITINH IN (N'Nam',N'Nữ')),
	DIACHI NVARCHAR(128),
	LOAINV NVARCHAR(128) CHECK (LOAINV IN (N'Quản lý',N'Nhân viên',N'Tài xế'))
)
GO

CREATE TABLE [LichTrinh] (
  [MA_LICH_TRINH] varchar(128) PRIMARY KEY,
  [ID_TUYEN_DUONG] INT NOT NULL,
  [KHOI_HANH] datetime NOT NULL,
  [KET_THUC] datetime NOT NULL,
  [GIA_VE] float NOT NULL,
  [ID_XE] INT NOT NULL,
  [TAIXE] varchar(128),
  SOGHETRONG INT,
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
	VI_TRI_NGOI VARCHAR(10),
	[MA_LICH_TRINH] varchar(128),
	TRANG_THAI VARCHAR(128) Default N'Trống', CHECK (TRANG_THAI IN (N'Trống',N'Đang chọn',N'Đã đặt')),
	FOREIGN KEY ([MA_LICH_TRINH]) REFERENCES [LichTrinh]([MA_LICH_TRINH])
)
GO


CREATE TABLE [Ve] (
  [ID_VE] varchar(128) PRIMARY KEY,
  TENKHACHHANG Nvarchar(128) NOT NULL,
  [ID_LICH_TRINH] varchar(128) NOT NULL,
  [TONG_TIEN] float NOT NULL,
  NHAN_VIEN_TAO VARCHAR(128),
  [TRANG_THAI] varchar(128) NOT NULL CHECK ([TRANG_THAI] IN (N'Đã thanh toán', N'Chưa thanh toán')),
  [NGAY_DAT_VE]  datetime NOT NULL DEFAULT GETDATE(),
  FOREIGN KEY (ID_LICH_TRINH) REFERENCES LichTrinh(MA_LICH_TRINH),
  FOREIGN KEY (NHAN_VIEN_TAO) REFERENCES NHANVIEN(USERNAME)
)
GO

CREATE TABLE [ChiTietVe] (
  [ID_VE] varchar(128) NOT NULL,
  [ID_GHE] INT NOT NULL,
  PRIMARY KEY(ID_VE, ID_GHE),
  FOREIGN KEY (ID_VE) REFERENCES Ve(ID_VE),
  FOREIGN KEY (ID_GHE) REFERENCES GHE(ID_GHE)
)
GO


CREATE TABLE THONGKE(
	[ID_THONG_KE] INT PRIMARY KEY IDENTITY(1,1),
	[MA_LICH_TRINH] varchar(128) NOT NULL,
	[SO_VE_DA_BAN] INT NOT NULL DEFAULT 0,
	[TONG_DOANH_THU] float NOT NULL DEFAULT 0,
	[SO_GHE_CON_TRONG] INT NOT NULL,
	FOREIGN KEY (MA_LICH_TRINH) REFERENCES LichTrinh(MA_LICH_TRINH)
)



-------------------------TRIGGER---------------------------------

-------Trigger Tự Động Thêm Ghế---------
go
CREATE TRIGGER AutoAddSeats
ON LichTrinh
AFTER INSERT
AS
BEGIN
    DECLARE @num_seats INT;
    DECLARE @seat_prefix CHAR(1);
    DECLARE @seat_number INT;
    DECLARE @i INT;

    SELECT @num_seats = Xe.SO_GHE
    FROM inserted
    INNER JOIN Xe ON inserted.ID_XE = Xe.ID_XE;

    SET @i = 1;
    SET @seat_prefix = 'A';
	if @num_seats =  20
		begin
			WHILE @i <= @num_seats
				BEGIN
					IF @i > 10
						BEGIN
							SET @seat_prefix = 'B';
							SET @seat_number = @i - 10;
						END
					ELSE
						BEGIN
							SET @seat_number = @i;
						END

					INSERT INTO Ghe (VI_TRI_NGOI,MA_LICH_TRINH)
					VALUES (CONCAT(@seat_prefix, @seat_number), (SELECT MA_LICH_TRINH FROM inserted));

					SET @i = @i + 1;
				END
		end
	else
		begin
			WHILE @i <= @num_seats
				BEGIN
					if @i > 22 
						BEGIN
							SET @seat_prefix = 'C';
							SET @seat_number = @i - 22;
						END
					else IF @i > 12
						BEGIN
							SET @seat_prefix = 'B';
							SET @seat_number = @i - 12;
						END
					ELSE
						BEGIN
							SET @seat_number = @i;
						END

					INSERT INTO Ghe (VI_TRI_NGOI,MA_LICH_TRINH)
					VALUES (CONCAT(@seat_prefix, @seat_number), (SELECT MA_LICH_TRINH FROM inserted));

					SET @i = @i + 1;
				END
		end
END
go


CREATE TRIGGER trg_SetSoGheTrong
ON [LichTrinh]
AFTER INSERT
AS
BEGIN
    UPDATE LichTrinh
    SET SOGHETRONG = Xe.SO_GHE
    FROM LichTrinh lt
    JOIN Xe ON Xe.ID_XE = lt.ID_XE
    WHERE lt.MA_LICH_TRINH = (SELECT MA_LICH_TRINH FROM inserted)
END

insert into NHANVIEN values ('abc','1',N'Nguyễn Văn A','0987651234',N'Nam',N'Cà Mau',N'Nhân viên')
insert into NHANVIEN values ('abcd','1',N'Nguyễn Thị B','0987651234',N'Nữ',N'Hà Nội',N'Quản lý')
insert into NHANVIEN values ('abcde','1',N'Nguyễn Văn C','0987651234',N'Nam',N'TP. Hồ Chí Minh',N'Tài xế')



