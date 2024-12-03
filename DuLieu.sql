﻿USE [QuanLyBanVeXeKhach]
GO


SET IDENTITY_INSERT [dbo].[DiaDiem] ON 

GO
INSERT [dbo].[DiaDiem] ([ID_DIADIEM], [TEN_TINH_THANH]) VALUES (1, N'TP. Hồ Chí Minh')
GO
INSERT [dbo].[DiaDiem] ([ID_DIADIEM], [TEN_TINH_THANH]) VALUES (2, N'Lâm Đồng')
GO
INSERT [dbo].[DiaDiem] ([ID_DIADIEM], [TEN_TINH_THANH]) VALUES (3, N'Đăk Lăk')
GO
SET IDENTITY_INSERT [dbo].[DiaDiem] OFF
GO
SET IDENTITY_INSERT [dbo].[TuyenDuong] ON 

GO
INSERT [dbo].[TuyenDuong] ([ID_TUYEN], [TEN_TUYEN], [DIEM_DAU], [DIEM_CUOI], [KHOANG_CACH], [THOI_GIAN_DI_CHUYEN]) VALUES (1, N'TP. Hồ Chí Minh - Lâm Đồng', 1, 2, 280, 7)
GO
INSERT [dbo].[TuyenDuong] ([ID_TUYEN], [TEN_TUYEN], [DIEM_DAU], [DIEM_CUOI], [KHOANG_CACH], [THOI_GIAN_DI_CHUYEN]) VALUES (2, N'Lâm Đồng - TP. Hồ Chí Minh', 2, 1, 285, 7)
GO
INSERT [dbo].[TuyenDuong] ([ID_TUYEN], [TEN_TUYEN], [DIEM_DAU], [DIEM_CUOI], [KHOANG_CACH], [THOI_GIAN_DI_CHUYEN]) VALUES (3, N'TP. Hồ Chí Minh - Đăk Lăk', 1, 3, 350, 8)
GO
INSERT [dbo].[TuyenDuong] ([ID_TUYEN], [TEN_TUYEN], [DIEM_DAU], [DIEM_CUOI], [KHOANG_CACH], [THOI_GIAN_DI_CHUYEN]) VALUES (4, N'Đăk Lăk - TP. Hồ Chí Minh', 3, 1, 350, 8)
GO
SET IDENTITY_INSERT [dbo].[TuyenDuong] OFF
GO
INSERT [dbo].[TRAMDUNGCHAN] ([ID_TramDungChan], [TEN_TramDungChan], [ID_DIADIEM]) VALUES (N'TDC001', N'Bến xe Miền Đông', 1)
GO
INSERT [dbo].[TRAMDUNGCHAN] ([ID_TramDungChan], [TEN_TramDungChan], [ID_DIADIEM]) VALUES (N'TDC002', N'Bến xe An Sương', 1)
GO
INSERT [dbo].[TRAMDUNGCHAN] ([ID_TramDungChan], [TEN_TramDungChan], [ID_DIADIEM]) VALUES (N'TDC003', N'Mũi Tàu Trường Trinh', 1)
GO
INSERT [dbo].[TRAMDUNGCHAN] ([ID_TramDungChan], [TEN_TramDungChan], [ID_DIADIEM]) VALUES (N'TDC004', N'Bến xe Miền Tây', 1)
GO
INSERT [dbo].[TRAMDUNGCHAN] ([ID_TramDungChan], [TEN_TramDungChan], [ID_DIADIEM]) VALUES (N'TDC005', N'Coop Mart Bảo Lộc', 2)
GO
INSERT [dbo].[TRAMDUNGCHAN] ([ID_TramDungChan], [TEN_TramDungChan], [ID_DIADIEM]) VALUES (N'TDC006', N'Bến xe Di Linh', 2)
GO
INSERT [dbo].[TRAMDUNGCHAN] ([ID_TramDungChan], [TEN_TramDungChan], [ID_DIADIEM]) VALUES (N'TDC007', N'Bến xe phía Nam', 3)
GO
INSERT [dbo].[TRAMDUNGCHAN] ([ID_TramDungChan], [TEN_TramDungChan], [ID_DIADIEM]) VALUES (N'TDC008', N'Ngã tư Phạm Ngũ Lão', 3)
GO
INSERT [dbo].[TRAMDUNGCHAN] ([ID_TramDungChan], [TEN_TramDungChan], [ID_DIADIEM]) VALUES (N'TDC009', N'Bến xe phía Bắc', 3)
GO
INSERT [dbo].[TRAMDUNGCHAN] ([ID_TramDungChan], [TEN_TramDungChan], [ID_DIADIEM]) VALUES (N'TDC010', N'Bến xe thành phố Buôn Ma Thuột', 3)
GO
INSERT [dbo].[TRAMDUNGCHAN] ([ID_TramDungChan], [TEN_TramDungChan], [ID_DIADIEM]) VALUES (N'TDC011', N'Bến xe liên tỉnh Đà Lạt', 2)
GO
SET IDENTITY_INSERT [dbo].[Xe] ON 

GO
INSERT [dbo].[Xe] ([ID_XE], [BIEN_SO_XE], [SO_GHE], [NGAY_THEM]) VALUES (1, N'59A-12345', 20, CAST(N'2024-12-03 10:46:35.763' AS DateTime))
GO
INSERT [dbo].[Xe] ([ID_XE], [BIEN_SO_XE], [SO_GHE], [NGAY_THEM]) VALUES (2, N'50B-54321', 34, CAST(N'2024-12-03 10:46:35.763' AS DateTime))
GO
INSERT [dbo].[Xe] ([ID_XE], [BIEN_SO_XE], [SO_GHE], [NGAY_THEM]) VALUES (3, N'81D-11223', 20, CAST(N'2024-12-03 10:46:35.763' AS DateTime))
GO
INSERT [dbo].[Xe] ([ID_XE], [BIEN_SO_XE], [SO_GHE], [NGAY_THEM]) VALUES (4, N'47C-98765', 34, CAST(N'2024-12-03 10:46:35.767' AS DateTime))
GO
INSERT [dbo].[Xe] ([ID_XE], [BIEN_SO_XE], [SO_GHE], [NGAY_THEM]) VALUES (5, N'52G-99001', 20, CAST(N'2024-12-03 10:46:35.767' AS DateTime))
GO
INSERT [dbo].[Xe] ([ID_XE], [BIEN_SO_XE], [SO_GHE], [NGAY_THEM]) VALUES (6, N'59E-44556', 34, CAST(N'2024-12-03 10:46:35.767' AS DateTime))
GO
INSERT [dbo].[Xe] ([ID_XE], [BIEN_SO_XE], [SO_GHE], [NGAY_THEM]) VALUES (7, N'58F-77889', 34, CAST(N'2024-12-03 10:46:35.767' AS DateTime))
GO
INSERT [dbo].[Xe] ([ID_XE], [BIEN_SO_XE], [SO_GHE], [NGAY_THEM]) VALUES (8, N'52H-22334', 34, CAST(N'2024-12-03 10:46:35.767' AS DateTime))
GO
INSERT [dbo].[Xe] ([ID_XE], [BIEN_SO_XE], [SO_GHE], [NGAY_THEM]) VALUES (17, N'xe test', 34, CAST(N'2024-12-03 14:49:35.427' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Xe] OFF
GO
INSERT [dbo].[LichTrinh] ([MA_LICH_TRINH], [ID_TUYEN_DUONG], [KHOI_HANH], [KET_THUC], [GIA_VE], [ID_XE], [SOGHETRONG], [NGAY_TAO_LICH_TRINH]) VALUES (N'LT001', 1, CAST(N'2024-12-19 18:00:00.000' AS DateTime), CAST(N'2024-12-20 01:00:00.000' AS DateTime), 280000, 1, 5, CAST(N'2024-12-03 10:48:40.500' AS DateTime))
GO
INSERT [dbo].[LichTrinh] ([MA_LICH_TRINH], [ID_TUYEN_DUONG], [KHOI_HANH], [KET_THUC], [GIA_VE], [ID_XE], [SOGHETRONG], [NGAY_TAO_LICH_TRINH]) VALUES (N'LT002', 1, CAST(N'2024-12-20 12:30:00.000' AS DateTime), CAST(N'2024-12-20 19:30:00.000' AS DateTime), 280000, 2, 34, CAST(N'2024-12-03 10:48:40.517' AS DateTime))
GO
INSERT [dbo].[LichTrinh] ([MA_LICH_TRINH], [ID_TUYEN_DUONG], [KHOI_HANH], [KET_THUC], [GIA_VE], [ID_XE], [SOGHETRONG], [NGAY_TAO_LICH_TRINH]) VALUES (N'LT003', 2, CAST(N'2024-12-19 19:00:00.000' AS DateTime), CAST(N'2024-12-20 02:00:00.000' AS DateTime), 280000, 3, 13, CAST(N'2024-12-03 10:48:40.517' AS DateTime))
GO
INSERT [dbo].[LichTrinh] ([MA_LICH_TRINH], [ID_TUYEN_DUONG], [KHOI_HANH], [KET_THUC], [GIA_VE], [ID_XE], [SOGHETRONG], [NGAY_TAO_LICH_TRINH]) VALUES (N'LT004', 3, CAST(N'2024-12-20 12:00:00.000' AS DateTime), CAST(N'2024-12-20 20:00:00.000' AS DateTime), 350000, 4, 29, CAST(N'2024-12-03 10:48:40.517' AS DateTime))
GO
INSERT [dbo].[LichTrinh] ([MA_LICH_TRINH], [ID_TUYEN_DUONG], [KHOI_HANH], [KET_THUC], [GIA_VE], [ID_XE], [SOGHETRONG], [NGAY_TAO_LICH_TRINH]) VALUES (N'LT005', 1, CAST(N'2024-12-03 14:10:00.000' AS DateTime), CAST(N'2024-12-03 21:10:00.000' AS DateTime), 250000, 1, 20, CAST(N'2024-12-03 14:10:22.533' AS DateTime))
GO
INSERT [dbo].[LichTrinh] ([MA_LICH_TRINH], [ID_TUYEN_DUONG], [KHOI_HANH], [KET_THUC], [GIA_VE], [ID_XE], [SOGHETRONG], [NGAY_TAO_LICH_TRINH]) VALUES (N'LT006', 4, CAST(N'2024-12-06 19:50:00.000' AS DateTime), CAST(N'2024-12-07 03:50:00.000' AS DateTime), 350000, 1, 20, CAST(N'2024-12-03 19:51:30.640' AS DateTime))
GO
INSERT [dbo].[LichTrinh] ([MA_LICH_TRINH], [ID_TUYEN_DUONG], [KHOI_HANH], [KET_THUC], [GIA_VE], [ID_XE], [SOGHETRONG], [NGAY_TAO_LICH_TRINH]) VALUES (N'LT007', 4, CAST(N'2024-12-06 22:50:00.000' AS DateTime), CAST(N'2024-12-07 06:50:00.000' AS DateTime), 300000, 1, 20, CAST(N'2024-12-03 19:52:01.387' AS DateTime))
GO
INSERT [dbo].[LichTrinh] ([MA_LICH_TRINH], [ID_TUYEN_DUONG], [KHOI_HANH], [KET_THUC], [GIA_VE], [ID_XE], [SOGHETRONG], [NGAY_TAO_LICH_TRINH]) VALUES (N'LT008', 3, CAST(N'2024-12-05 11:50:00.000' AS DateTime), CAST(N'2024-12-05 19:50:00.000' AS DateTime), 300000, 1, 17, CAST(N'2024-12-03 19:52:41.723' AS DateTime))
GO
INSERT [dbo].[LichTrinh] ([MA_LICH_TRINH], [ID_TUYEN_DUONG], [KHOI_HANH], [KET_THUC], [GIA_VE], [ID_XE], [SOGHETRONG], [NGAY_TAO_LICH_TRINH]) VALUES (N'LT009', 3, CAST(N'2024-12-05 12:50:00.000' AS DateTime), CAST(N'2024-12-05 20:50:00.000' AS DateTime), 320000, 1, 20, CAST(N'2024-12-03 19:53:10.090' AS DateTime))
GO
Execute ThemNhanVien N'abc', N'1', N'Nguyễn Văn F', N'0987651234', N'Nam', N'Cà Mau', N'Nhân viên'
GO
Execute ThemNhanVien N'abcd', N'1', N'Nguyễn Thị B', N'0987651234', N'Nữ', N'Hà Nội', N'Quản lý'
GO
INSERT [dbo].[Ve] ([ID_VE], [ID_LICH_TRINH], [TONG_TIEN], [NHAN_VIEN_TAO], [TRANG_THAI], [NGAY_DAT_VE], [SOLUONG], [SDT], [TENKHACHHANG], [DIEMDON], [DIEMTRA], [HINHTHUCTHANHTOAN]) VALUES (N'LT001VE001', N'LT001', 1960000, N'abcd', N'Hiện tại', CAST(N'2024-12-03 10:52:45.950' AS DateTime), 7, N'0794672267', N'Trần Kháng Dĩ', N'TDC002', N'TDC005', N'Tiền mặt')
GO
INSERT [dbo].[Ve] ([ID_VE], [ID_LICH_TRINH], [TONG_TIEN], [NHAN_VIEN_TAO], [TRANG_THAI], [NGAY_DAT_VE], [SOLUONG], [SDT], [TENKHACHHANG], [DIEMDON], [DIEMTRA], [HINHTHUCTHANHTOAN]) VALUES (N'LT001VE002', N'LT001', 560000, N'abcd', N'Hiện tại', CAST(N'2024-12-03 12:47:52.700' AS DateTime), 2, N'123', N'1123', N'TDC002', N'TDC005', N'Tiền mặt')
GO
INSERT [dbo].[Ve] ([ID_VE], [ID_LICH_TRINH], [TONG_TIEN], [NHAN_VIEN_TAO], [TRANG_THAI], [NGAY_DAT_VE], [SOLUONG], [SDT], [TENKHACHHANG], [DIEMDON], [DIEMTRA], [HINHTHUCTHANHTOAN]) VALUES (N'LT001VE003', N'LT001', 840000, N'abc', N'Hiện tại', CAST(N'2024-12-03 12:54:33.020' AS DateTime), 3, N'123', N'123', N'TDC002', N'TDC005', N'Chuyển khoản')
GO
INSERT [dbo].[Ve] ([ID_VE], [ID_LICH_TRINH], [TONG_TIEN], [NHAN_VIEN_TAO], [TRANG_THAI], [NGAY_DAT_VE], [SOLUONG], [SDT], [TENKHACHHANG], [DIEMDON], [DIEMTRA], [HINHTHUCTHANHTOAN]) VALUES (N'LT001VE004', N'LT001', 560000, N'abcd', N'Hiện tại', CAST(N'2024-12-03 13:23:54.133' AS DateTime), 2, N'0794672267', N'Trần Kháng Dĩ', N'TDC002', N'TDC005', N'Tiền mặt')
GO
INSERT [dbo].[Ve] ([ID_VE], [ID_LICH_TRINH], [TONG_TIEN], [NHAN_VIEN_TAO], [TRANG_THAI], [NGAY_DAT_VE], [SOLUONG], [SDT], [TENKHACHHANG], [DIEMDON], [DIEMTRA], [HINHTHUCTHANHTOAN]) VALUES (N'LT001VE005', N'LT001', 280000, N'abcd', N'Hiện tại', CAST(N'2024-12-03 13:25:58.410' AS DateTime), 1, N'0794672267', N'Trần Kháng Dĩ', N'TDC002', N'TDC005', N'Tiền mặt')
GO
INSERT [dbo].[Ve] ([ID_VE], [ID_LICH_TRINH], [TONG_TIEN], [NHAN_VIEN_TAO], [TRANG_THAI], [NGAY_DAT_VE], [SOLUONG], [SDT], [TENKHACHHANG], [DIEMDON], [DIEMTRA], [HINHTHUCTHANHTOAN]) VALUES (N'LT003VE001', N'LT003', 840000, N'abcd', N'Hiện tại', CAST(N'2024-12-03 19:34:27.373' AS DateTime), 3, N'0794672267', N'Trần Kháng Dĩ', N'TDC006', N'TDC004', N'Tiền mặt')
GO
INSERT [dbo].[Ve] ([ID_VE], [ID_LICH_TRINH], [TONG_TIEN], [NHAN_VIEN_TAO], [TRANG_THAI], [NGAY_DAT_VE], [SOLUONG], [SDT], [TENKHACHHANG], [DIEMDON], [DIEMTRA], [HINHTHUCTHANHTOAN]) VALUES (N'LT003VE002', N'LT003', 280000, N'abcd', N'Hiện tại', CAST(N'2024-12-03 19:36:13.197' AS DateTime), 1, N'0794672267', N'Trần Kháng Dĩ', N'TDC006', N'TDC004', N'Tiền mặt')
GO
INSERT [dbo].[Ve] ([ID_VE], [ID_LICH_TRINH], [TONG_TIEN], [NHAN_VIEN_TAO], [TRANG_THAI], [NGAY_DAT_VE], [SOLUONG], [SDT], [TENKHACHHANG], [DIEMDON], [DIEMTRA], [HINHTHUCTHANHTOAN]) VALUES (N'LT003VE003', N'LT003', 280000, N'abcd', N'Hiện tại', CAST(N'2024-12-03 19:38:52.533' AS DateTime), 1, N'079467267', N'Trần Kháng Dĩ', N'TDC006', N'TDC004', N'Chuyển khoản')
GO
INSERT [dbo].[Ve] ([ID_VE], [ID_LICH_TRINH], [TONG_TIEN], [NHAN_VIEN_TAO], [TRANG_THAI], [NGAY_DAT_VE], [SOLUONG], [SDT], [TENKHACHHANG], [DIEMDON], [DIEMTRA], [HINHTHUCTHANHTOAN]) VALUES (N'LT003VE004', N'LT003', 560000, N'abcd', N'Hiện tại', CAST(N'2024-12-03 19:40:13.883' AS DateTime), 2, N'0794672267', N'Trần Kháng Dĩ', N'TDC005', N'TDC003', N'Tiền mặt')
GO
INSERT [dbo].[Ve] ([ID_VE], [ID_LICH_TRINH], [TONG_TIEN], [NHAN_VIEN_TAO], [TRANG_THAI], [NGAY_DAT_VE], [SOLUONG], [SDT], [TENKHACHHANG], [DIEMDON], [DIEMTRA], [HINHTHUCTHANHTOAN]) VALUES (N'LT004VE001', N'LT004', 700000, N'abcd', N'Hiện tại', CAST(N'2024-12-03 14:52:02.327' AS DateTime), 2, N'123', N'Nguyễn Quốc Vương', N'TDC002', N'TDC007', N'Tiền mặt')
GO
INSERT [dbo].[Ve] ([ID_VE], [ID_LICH_TRINH], [TONG_TIEN], [NHAN_VIEN_TAO], [TRANG_THAI], [NGAY_DAT_VE], [SOLUONG], [SDT], [TENKHACHHANG], [DIEMDON], [DIEMTRA], [HINHTHUCTHANHTOAN]) VALUES (N'LT004VE002', N'LT004', 700000, N'abcd', N'Hiện tại', CAST(N'2024-12-03 15:06:28.973' AS DateTime), 2, N'123987', N'Dĩ Trần', N'TDC002', N'TDC007', N'Chuyển khoản')
GO
INSERT [dbo].[Ve] ([ID_VE], [ID_LICH_TRINH], [TONG_TIEN], [NHAN_VIEN_TAO], [TRANG_THAI], [NGAY_DAT_VE], [SOLUONG], [SDT], [TENKHACHHANG], [DIEMDON], [DIEMTRA], [HINHTHUCTHANHTOAN]) VALUES (N'LT004VE003', N'LT004', 350000, N'abcd', N'Đã huỷ', CAST(N'2024-12-03 15:07:50.310' AS DateTime), 1, N'1234567890', N'adsssss', N'TDC002', N'TDC007', N'Tiền mặt')
GO
INSERT [dbo].[Ve] ([ID_VE], [ID_LICH_TRINH], [TONG_TIEN], [NHAN_VIEN_TAO], [TRANG_THAI], [NGAY_DAT_VE], [SOLUONG], [SDT], [TENKHACHHANG], [DIEMDON], [DIEMTRA], [HINHTHUCTHANHTOAN]) VALUES (N'LT008VE001', N'LT008', 300000, N'abcd', N'Hiện tại', CAST(N'2024-12-03 19:59:25.997' AS DateTime), 1, N'0794672267', N'Trần Kháng Dĩ', N'TDC004', N'TDC010', N'Tiền mặt')
GO
INSERT [dbo].[Ve] ([ID_VE], [ID_LICH_TRINH], [TONG_TIEN], [NHAN_VIEN_TAO], [TRANG_THAI], [NGAY_DAT_VE], [SOLUONG], [SDT], [TENKHACHHANG], [DIEMDON], [DIEMTRA], [HINHTHUCTHANHTOAN]) VALUES (N'LT008VE002', N'LT008', 600000, N'abc', N'Hiện tại', CAST(N'2024-12-03 20:01:34.127' AS DateTime), 2, N'0794672267', N'Trần Kháng Dĩ', N'TDC004', N'TDC010', N'Tiền mặt')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC001', N'LT002')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC001', N'LT007')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC001', N'LT009')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC002', N'LT001')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC002', N'LT004')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC002', N'LT008')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC003', N'LT001')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC003', N'LT003')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC003', N'LT005')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC003', N'LT006')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC004', N'LT002')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC004', N'LT003')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC004', N'LT004')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC004', N'LT005')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC004', N'LT006')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC004', N'LT007')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC004', N'LT008')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC004', N'LT009')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC005', N'LT001')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC005', N'LT002')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC005', N'LT003')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC006', N'LT003')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC006', N'LT005')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC007', N'LT004')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC007', N'LT009')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC008', N'LT009')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC009', N'LT006')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC009', N'LT007')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC009', N'LT008')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC010', N'LT004')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC010', N'LT006')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC010', N'LT007')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC010', N'LT008')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC011', N'LT001')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC011', N'LT002')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC011', N'LT005')
GO



GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT001VE001', 3)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT001VE001', 7)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT001VE001', 8)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT001VE001', 9)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT001VE001', 14)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT001VE001', 16)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT001VE001', 17)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT001VE002', 18)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT001VE002', 19)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT001VE003', 1)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT001VE003', 2)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT001VE003', 12)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT001VE004', 6)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT001VE004', 11)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT001VE005', 10)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT003VE001', 61)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT003VE001', 67)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT003VE001', 71)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT003VE002', 72)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT003VE003', 70)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT003VE004', 55)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT003VE004', 65)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT004VE001', 97)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT004VE001', 98)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT004VE002', 75)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT004VE002', 87)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT004VE003', 103)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT008VE001', 169)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT008VE002', 184)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT008VE002', 185)
GO