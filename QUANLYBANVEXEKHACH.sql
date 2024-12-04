
--drop database QuanLyBanVeXeKhach

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
	LOAINV NVARCHAR(128) CHECK (LOAINV IN (N'Quản lý',N'Nhân viên'))
)
GO


CREATE TABLE [LichTrinh] (
  [MA_LICH_TRINH] varchar(128) PRIMARY KEY,
  [ID_TUYEN_DUONG] INT NOT NULL,
  [KHOI_HANH] datetime NOT NULL,
  [KET_THUC] datetime ,
  [GIA_VE] float NOT NULL,
  [ID_XE] INT NOT NULL,
  SOGHETRONG INT,
  [NGAY_TAO_LICH_TRINH]  datetime NOT NULL DEFAULT GETDATE(),
  [TRANG_THAI] NVARCHAR(50) CHECK( [TRANG_THAI] IN (N'Đã đi',N'Chưa đi')) Default N'Chưa đi',
  CHECK (KHOI_HANH < KET_THUC),
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
	--THOIGIAN TIME NOT NULL,
	PRIMARY KEY(ID_TramDungChan, MA_LICH_TRINH),
	FOREIGN KEY (ID_TramDungChan) REFERENCES TRAMDUNGCHAN(ID_TramDungChan),
	FOREIGN KEY (MA_LICH_TRINH) REFERENCES LichTrinh(MA_LICH_TRINH)
)
GO

CREATE TABLE GHE(
	ID_GHE INT IDENTITY(1,1) PRIMARY KEY,
	VI_TRI_NGOI VARCHAR(10),
	[MA_LICH_TRINH] varchar(128),
	TRANG_THAI NVARCHAR(128) Default N'Trống', CHECK (TRANG_THAI IN (N'Trống',N'Đã đặt')),
	FOREIGN KEY ([MA_LICH_TRINH]) REFERENCES [LichTrinh]([MA_LICH_TRINH])
)
GO


CREATE TABLE [Ve] (
  [ID_VE] varchar(128) PRIMARY KEY,
  [ID_LICH_TRINH] varchar(128) NOT NULL,
  [TONG_TIEN] float NOT NULL,
  NHAN_VIEN_TAO VARCHAR(128),
  [TRANG_THAI] Nvarchar(128) NOT NULL CHECK ([TRANG_THAI] IN (N'Hiện tại', N'Đã đi',N'Đã huỷ')),
  [NGAY_DAT_VE]  datetime NOT NULL DEFAULT GETDATE(),
  SOLUONG int ,
  SDT VARCHAR(15) UNIQUE,
  TENKHACHHANG NVARCHAR(128),
  DIEMDON VARCHAR(128),
  DIEMTRA VARCHAR(128),
  HINHTHUCTHANHTOAN NVARCHAR(128) NOT NULL CHECK (HINHTHUCTHANHTOAN in (N'Chuyển khoản',N'Tiền mặt')),
  FOREIGN KEY (DIEMDON) REFERENCES TRAMDUNGCHAN(ID_TramDungChan),
  FOREIGN KEY (DIEMTRA) REFERENCES TRAMDUNGCHAN(ID_TramDungChan),
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
    DECLARE @ma_lich_trinh varchar(128);

    SELECT @num_seats = Xe.SO_GHE, @ma_lich_trinh = MA_LICH_TRINH
    FROM inserted
    INNER JOIN Xe ON inserted.ID_XE = Xe.ID_XE;

    SET @i = 1;
    SET @seat_prefix = 'A';

    IF @num_seats = 20
    BEGIN
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

            -- Chèn ghế với trạng thái 'Trống'
            INSERT INTO Ghe (VI_TRI_NGOI, MA_LICH_TRINH)
            VALUES (CONCAT(@seat_prefix, @seat_number), @ma_lich_trinh);

            SET @i = @i + 1;
        END
    END
    ELSE
    BEGIN
        WHILE @i <= @num_seats
        BEGIN
            IF @i > 22
            BEGIN
                SET @seat_prefix = 'C';
                SET @seat_number = @i - 22;
            END
            ELSE IF @i > 12
            BEGIN
                SET @seat_prefix = 'B';
                SET @seat_number = @i - 12;
            END
            ELSE
            BEGIN
                SET @seat_number = @i;
            END

            -- Chèn ghế với trạng thái 'Trống'
            INSERT INTO Ghe (VI_TRI_NGOI, MA_LICH_TRINH)
            VALUES (CONCAT(@seat_prefix, @seat_number), @ma_lich_trinh);

            SET @i = @i + 1;
        END
    END
END
GO


--trigger tự động set số ghế của lịch trình dựa trên xe đã chọn
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
go



--Trigger tự động update trạng thái khi thêm mới 1 chitietve (đặt 1 chỗ)
Create trigger trg_AutoUpdateState
on ChiTietVe
AFTER INSERT
AS
begin
	DECLARE @ma_lich_trinh VARCHAR(128),@ghe int;
    
    -- Lấy mã lịch trình từ bảng 'Ve' thông qua 'inserted'
    SELECT @ma_lich_trinh = Ve.ID_LICH_TRINH
    FROM Ve
    JOIN inserted ON Ve.ID_VE = inserted.ID_VE;

    -- Cập nhật số ghế trống (giảm đi 1 ghế sau khi một vé được đặt)
    UPDATE GHE
    SET TRANG_THAI = N'Đã đặt'
    WHERE MA_LICH_TRINH = @ma_lich_trinh and ID_GHE = (select ID_GHE from inserted)

end;
go



--Trigger tự động update số ghế trống khi thêm mới 1 vé vào csdl
Create trigger trg_AutoUpdateEmptySeats
on Ve
After insert
as
begin
DECLARE 
	@ma_lich_trinh VARCHAR(128),@ghe int;
    
    -- Lấy mã lịch trình từ bảng 'Ve' thông qua 'inserted'
    SELECT @ma_lich_trinh = Ve.ID_LICH_TRINH
    FROM Ve
    JOIN inserted ON Ve.ID_VE = inserted.ID_VE;


	declare @soghetrong int
	set @soghetrong = (select SOGHETRONG from LichTrinh where MA_LICH_TRINH = @ma_lich_trinh) 


	update LichTrinh
	set SOGHETRONG = @soghetrong - (select SOLUONG from inserted where MA_LICH_TRINH = @ma_lich_trinh)
	where MA_LICH_TRINH =@ma_lich_trinh
end
go



--Trigger tự động thêm ngày kết thúc dựa vào TuyenDuong và Ngay khởi hành
CREATE TRIGGER trg_AutoSetEndDateTime
ON LichTrinh
AFTER INSERT
AS
BEGIN
    DECLARE @ma_lich_trinh VARCHAR(128);
    DECLARE @khoi_hanh DATETIME;
    DECLARE @thoi_gian_di_chuyen FLOAT;


    SELECT @ma_lich_trinh = MA_LICH_TRINH, @khoi_hanh = KHOI_HANH, @thoi_gian_di_chuyen = td.THOI_GIAN_DI_CHUYEN
    FROM inserted i
    JOIN TuyenDuong td ON i.ID_TUYEN_DUONG = td.ID_TUYEN;


    UPDATE LichTrinh
    SET KET_THUC = DATEADD(HOUR, @thoi_gian_di_chuyen, @khoi_hanh)
    WHERE MA_LICH_TRINH = @ma_lich_trinh;
END;
GO


create function ChonXe (@malt varchar(128))
returns bit
as
begin
	declare @soghe int
	select @soghe = x.SO_GHE from LichTrinh lt 
					join Xe x on x.ID_XE = lt.ID_XE
					where lt.MA_LICH_TRINH = @malt
	return iif(@soghe=20,1,0)
end
go



--TRIGGER KHI HUY TOUR THI TRẢ SỐ LƯỢNG GHẾ LẠI TỪ ĐÃ ĐẶT THÀNH TRỐNG
CREATE TRIGGER XuLyKhiHuyVe
on Ve
for update
as
begin
	if UPDATE(TRANG_THAI)
	BEGIN
		UPDATE Ghe
        SET TRANG_THAI = N'Trống'
        FROM Ghe g
        INNER JOIN ChiTietVe ct ON g.ID_GHE = ct.ID_GHE
        INNER JOIN inserted i ON ct.ID_VE = i.ID_VE
        WHERE i.TRANG_THAI = N'Đã huỷ';

		UPDATE LichTrinh
        SET SOGHETRONG = SOGHETRONG + i.SOLUONG
        FROM LichTrinh l
        INNER JOIN inserted i
            ON l.MA_LICH_TRINH = i.ID_LICH_TRINH
        WHERE i.TRANG_THAI = N'Đã huỷ';
	END
end
go

-----------------------Dùng cho crystal report--------------------------


CREATE PROCEDURE sp_ThongKeLichTrinhTheoNgay
    @Ngay DATE
AS
BEGIN
    SELECT 
        lt.MA_LICH_TRINH AS MaLichTrinh,
        td.TEN_TUYEN AS TuyenDuong,
        xe.SO_GHE AS TongSoGhe,
        SUM(v.SOLUONG) AS TongSoLuongVe, -- Tổng số lượng vé bán ra
        (xe.SO_GHE - ISNULL(SUM(v.SOLUONG), 0)) AS SoGheConTrong, -- Số ghế còn trống
        SUM(v.TONG_TIEN) AS TongDoanhThu -- Tổng doanh thu
    FROM LichTrinh lt
    INNER JOIN TuyenDuong td ON lt.ID_TUYEN_DUONG = td.ID_TUYEN
    INNER JOIN Xe xe ON lt.ID_XE = xe.ID_XE
    LEFT JOIN Ve v ON lt.MA_LICH_TRINH = v.ID_LICH_TRINH
    WHERE CAST(v.NGAY_DAT_VE AS DATE) = @Ngay
          AND v.TRANG_THAI <> N'Đã huỷ' -- Thêm điều kiện trạng thái vé
    GROUP BY lt.MA_LICH_TRINH, td.TEN_TUYEN, xe.SO_GHE
    ORDER BY TongDoanhThu DESC;
END
GO






CREATE PROCEDURE sp_BaoCaoNhanVienTheoThang
    @Thang INT,
    @Nam INT
AS
BEGIN
    SELECT 
        nv.HOTEN AS TenNhanVien,
        SUM(v.SOLUONG) AS TongSoLuongVe, -- Tổng số lượng vé
        SUM(v.TONG_TIEN) AS TongDoanhThu -- Tổng doanh thu
    FROM Ve v
    INNER JOIN NHANVIEN nv ON v.NHAN_VIEN_TAO = nv.USERNAME
    WHERE MONTH(v.NGAY_DAT_VE) = @Thang AND YEAR(v.NGAY_DAT_VE) = @Nam AND v.TRANG_THAI <> N'Đã huỷ' -- Thêm điều kiện trạng thái vé
    GROUP BY nv.HOTEN
    ORDER BY TongSoLuongVe DESC;
END
GO



CREATE PROCEDURE sp_ThongKeLichTrinhTheoThang
    @Thang INT,
    @Nam INT
AS
BEGIN
    SELECT 
        lt.MA_LICH_TRINH AS MaLichTrinh,
        td.TEN_TUYEN AS TuyenDuong,
        SUM(v.SOLUONG) AS TongSoLuongVe, -- Tổng số lượng vé bán ra
        SUM(v.TONG_TIEN) AS TongDoanhThu -- Tổng doanh thu
    FROM LichTrinh lt
    INNER JOIN TuyenDuong td ON lt.ID_TUYEN_DUONG = td.ID_TUYEN
    LEFT JOIN Ve v ON lt.MA_LICH_TRINH = v.ID_LICH_TRINH
    WHERE MONTH(lt.KHOI_HANH) = @Thang AND YEAR(lt.KHOI_HANH) = @Nam AND v.TRANG_THAI <> N'Đã huỷ' -- Thêm điều kiện trạng thái vé
    GROUP BY lt.MA_LICH_TRINH, td.TEN_TUYEN
    ORDER BY TongDoanhThu DESC;
END
GO


CREATE PROCEDURE sp_InVeChoKhachHang
    @MaVe VARCHAR(128)
AS
BEGIN
    SELECT 
        v.ID_VE AS MaVe,
        v.TENKHACHHANG AS TenKhachHang,
        v.SDT AS SoDienThoai,
        td.TEN_TUYEN AS TuyenDuong,
        lt.KHOI_HANH AS NgayKhoiHanh,
        -- Lấy tên điểm đón
        dd.TEN_TramDungChan AS DiemDon,
        -- Lấy tên điểm trả
        dt.TEN_TramDungChan AS DiemTra,
        -- Gộp chuỗi vị trí ngồi
         STUFF((
            SELECT ', ' + g.VI_TRI_NGOI
            FROM ChiTietVe ctv, GHE g
            WHERE ctv.ID_VE = v.ID_VE and ctv.ID_GHE = g.ID_GHE
            FOR XML PATH(''), TYPE
        ).value('.', 'NVARCHAR(MAX)'), 1, 2, '') AS ViTriNgoi,
        v.SOLUONG AS SoLuongGhe,
        v.TONG_TIEN AS TongTien,
        v.HINHTHUCTHANHTOAN AS PhuongThucThanhToan
    FROM Ve v
    INNER JOIN LichTrinh lt ON v.ID_LICH_TRINH = lt.MA_LICH_TRINH
    INNER JOIN TuyenDuong td ON lt.ID_TUYEN_DUONG = td.ID_TUYEN
    -- Tham gia thêm với bảng TRAMDUNGCHAN để lấy tên điểm đón và điểm trả
    LEFT JOIN TRAMDUNGCHAN dd ON v.DIEMDON = dd.ID_TramDungChan
    LEFT JOIN TRAMDUNGCHAN dt ON v.DIEMTRA = dt.ID_TramDungChan
    WHERE v.ID_VE = @MaVe
    GROUP BY 
        v.ID_VE, v.TENKHACHHANG, v.SDT, td.TEN_TUYEN, lt.KHOI_HANH, 
        dd.TEN_TramDungChan, dt.TEN_TramDungChan, v.SOLUONG, 
        v.TONG_TIEN, v.HINHTHUCTHANHTOAN;
END;
GO


CREATE TRIGGER trg_CheckSDT
ON Ve
AFTER INSERT, UPDATE
AS
BEGIN
    -- Kiểm tra các bản ghi vừa được chèn hoặc cập nhật
    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE LEN(SDT) <> 10 OR SDT LIKE '%[^0-9]%'
    )
    BEGIN
        -- Nếu có lỗi, rollback và hiển thị thông báo
        ROLLBACK TRANSACTION;
        RAISERROR ('Số điện thoại phải là 10 ký tự và chỉ chứa số.', 16, 1);
    END
END;
GO



--------------- PROCEDURE cập nhật trạng thái lịch trình----------------
CREATE PROCEDURE CapNhatTrangThaiLichTrinh
AS
BEGIN
    -- Bắt đầu transaction để đảm bảo tính nhất quán
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Cập nhật trạng thái thành 'Đã đi' nếu ngày khởi hành nhỏ hơn ngày hiện tại
        UPDATE LichTrinh
        SET TRANG_THAI = N'Đã đi'
        WHERE KHOI_HANH < GETDATE();

        -- Commit transaction nếu không có lỗi
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Rollback transaction nếu có lỗi xảy ra
        ROLLBACK TRANSACTION;

        -- Ném lỗi ra ngoài để xử lý
        THROW;
    END CATCH
END;
GO


------------------------------------Tạo role và phân quyền----------------------------------------
sp_addrole 'QuanLyRole';
GO

GRANT SELECT, INSERT, UPDATE, DELETE, EXECUTE ON SCHEMA::dbo TO QuanLyRole; 
GO


sp_addrole 'NhanVienRole';
GO

GRANT SELECT, INSERT, UPDATE ON Ve TO NhanVienRole
GO
GRANT SELECT, INSERT ON ChiTietVe TO NhanVienRole
GO
GRANT SELECT ON  LichTrinh TO NhanVienRole
GO
GRANT SELECT ON GHE TO NhanVienRole
GO
GRANT SELECT ON DiaDiem TO NhanVienRole
GO
GRANT SELECT ON TRAMDUNGCHAN  TO NhanVienRole
GO
GRANT SELECT ON Xe TO NhanVienRole
GO
GRANT SELECT ON TuyenDuong TO NhanVienRole
GO
GRANT SELECT ON THEMTRAMDUNGCHAN TO NhanVienRole
GO
GRANT EXECUTE ON [dbo].[ChonXe] TO NhanVienRole;
go


CREATE PROCEDURE ThemNhanVien
    @USERNAME NVARCHAR(128),     -- Tên đăng nhập của nhân viên
    @MAT_KHAU NVARCHAR(128),     -- Mật khẩu đăng nhập
    @HOTEN NVARCHAR(128),        -- Họ tên nhân viên
    @SO_DT NVARCHAR(128) = NULL, -- Số điện thoại (tùy chọn)
    @GIOITINH NVARCHAR(5),       -- Giới tính (Nam/Nữ)
    @DIACHI NVARCHAR(128) = NULL,-- Địa chỉ (tùy chọn)
    @LOAINV NVARCHAR(128)        -- Loại nhân viên (Quản lý/Nhân viên)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Thêm nhân viên vào bảng NHANVIEN
        INSERT INTO NHANVIEN (USERNAME, MAT_KHAU, HOTEN, SO_DT, GIOITINH, DIACHI, LOAINV)
        VALUES (@USERNAME, @MAT_KHAU, @HOTEN, @SO_DT, @GIOITINH, @DIACHI, @LOAINV);

        -- Kiểm tra loại nhân viên để gán quyền phù hợp
        DECLARE @ROLE NVARCHAR(128);
        IF (@LOAINV = N'Quản lý')
            SET @ROLE = N'QuanLyRole'; -- Quyền dành cho quản lý
        ELSE
            SET @ROLE = N'NhanVienRole'; -- Quyền dành cho nhân viên

        -- Tạo SQL Server login
        DECLARE @SQL NVARCHAR(MAX);
        SET @SQL = N'CREATE LOGIN [' + @USERNAME + N'] WITH PASSWORD = ''' + @MAT_KHAU + N''';';
        EXEC sp_executesql @SQL;

        -- Tạo database user tương ứng với login
        SET @SQL = N'CREATE USER [' + @USERNAME + N'] FOR LOGIN [' + @USERNAME + N'];';
        EXEC sp_executesql @SQL;

        -- Gán quyền cho user dựa vào vai trò
        SET @SQL = N'EXEC sp_addrolemember ''' + @ROLE + ''', [' + @USERNAME + N'];';
        EXEC sp_executesql @SQL;

        COMMIT TRANSACTION;
		return 1;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        -- Xử lý lỗi
        DECLARE @ErrorMessage NVARCHAR(4000), @ErrorSeverity INT, @ErrorState INT;
        SELECT @ErrorMessage = ERROR_MESSAGE(), @ErrorSeverity = ERROR_SEVERITY(), @ErrorState = ERROR_STATE();
        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
		return -1
    END CATCH
END;
GO



CREATE PROCEDURE sp_DoiMatKhau
    @Username NVARCHAR(50),
    @NewPassword NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT OFF;
    BEGIN TRY
        -- Bắt đầu giao dịch
        BEGIN TRANSACTION;

        -- Cập nhật mật khẩu trong bảng NHANVIENs
        UPDATE NHANVIEN
        SET MAT_KHAU = @NewPassword
        WHERE USERNAME = @Username;

        -- Kiểm tra nếu người dùng tồn tại
        IF @@ROWCOUNT = 0
        BEGIN
            ROLLBACK TRANSACTION;
            return 0;
        END

        -- Đổi mật khẩu login SQL Server
        DECLARE @SQL NVARCHAR(MAX);
        SET @SQL = 'ALTER LOGIN [' + @Username + '] WITH PASSWORD = ''' + @NewPassword + ''';';
        EXEC sp_executesql @SQL;
        -- Commit giao dịch
        COMMIT TRANSACTION;
		return 1;
    END TRY
    BEGIN CATCH
        -- Rollback nếu có lỗi
        ROLLBACK TRANSACTION;
        return -1;
    END CATCH
END
go

