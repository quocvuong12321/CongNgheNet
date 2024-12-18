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
INSERT [dbo].[Xe] ([ID_XE], [BIEN_SO_XE], [SO_GHE], [NGAY_THEM]) VALUES (18, N'47-AB14072', 20, CAST(N'2024-12-05 12:35:09.523' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Xe] OFF
GO
INSERT [dbo].[LichTrinh] ([MA_LICH_TRINH], [ID_TUYEN_DUONG], [KHOI_HANH], [KET_THUC], [GIA_VE], [ID_XE], [SOGHETRONG], [NGAY_TAO_LICH_TRINH], [TRANG_THAI]) VALUES (N'LT001', 1, CAST(N'2024-12-19 18:00:00.000' AS DateTime), CAST(N'2024-12-20 01:00:00.000' AS DateTime), 280000, 1, 17, CAST(N'2024-12-03 10:48:40.500' AS DateTime), N'Chưa đi')
GO
INSERT [dbo].[LichTrinh] ([MA_LICH_TRINH], [ID_TUYEN_DUONG], [KHOI_HANH], [KET_THUC], [GIA_VE], [ID_XE], [SOGHETRONG], [NGAY_TAO_LICH_TRINH], [TRANG_THAI]) VALUES (N'LT002', 1, CAST(N'2024-12-20 12:30:00.000' AS DateTime), CAST(N'2024-12-20 19:30:00.000' AS DateTime), 280000, 2, 34, CAST(N'2024-12-03 10:48:40.517' AS DateTime), N'Chưa đi')
GO
INSERT [dbo].[LichTrinh] ([MA_LICH_TRINH], [ID_TUYEN_DUONG], [KHOI_HANH], [KET_THUC], [GIA_VE], [ID_XE], [SOGHETRONG], [NGAY_TAO_LICH_TRINH], [TRANG_THAI]) VALUES (N'LT003', 2, CAST(N'2024-12-19 19:00:00.000' AS DateTime), CAST(N'2024-12-20 02:00:00.000' AS DateTime), 280000, 3, 16, CAST(N'2024-12-03 10:48:40.517' AS DateTime), N'Chưa đi')
GO
INSERT [dbo].[LichTrinh] ([MA_LICH_TRINH], [ID_TUYEN_DUONG], [KHOI_HANH], [KET_THUC], [GIA_VE], [ID_XE], [SOGHETRONG], [NGAY_TAO_LICH_TRINH], [TRANG_THAI]) VALUES (N'LT004', 3, CAST(N'2024-12-20 12:00:00.000' AS DateTime), CAST(N'2024-12-20 20:00:00.000' AS DateTime), 350000, 4, 34, CAST(N'2024-12-03 10:48:40.517' AS DateTime), N'Chưa đi')
GO
INSERT [dbo].[LichTrinh] ([MA_LICH_TRINH], [ID_TUYEN_DUONG], [KHOI_HANH], [KET_THUC], [GIA_VE], [ID_XE], [SOGHETRONG], [NGAY_TAO_LICH_TRINH], [TRANG_THAI]) VALUES (N'LT005', 1, CAST(N'2024-12-03 14:10:00.000' AS DateTime), CAST(N'2024-12-03 21:10:00.000' AS DateTime), 250000, 1, 20, CAST(N'2024-12-03 14:10:22.533' AS DateTime), N'Đã đi')
GO
INSERT [dbo].[LichTrinh] ([MA_LICH_TRINH], [ID_TUYEN_DUONG], [KHOI_HANH], [KET_THUC], [GIA_VE], [ID_XE], [SOGHETRONG], [NGAY_TAO_LICH_TRINH], [TRANG_THAI]) VALUES (N'LT006', 4, CAST(N'2024-12-06 19:50:00.000' AS DateTime), CAST(N'2024-12-07 03:50:00.000' AS DateTime), 350000, 1, 20, CAST(N'2024-12-03 19:51:30.640' AS DateTime), N'Đã đi')
GO
INSERT [dbo].[LichTrinh] ([MA_LICH_TRINH], [ID_TUYEN_DUONG], [KHOI_HANH], [KET_THUC], [GIA_VE], [ID_XE], [SOGHETRONG], [NGAY_TAO_LICH_TRINH], [TRANG_THAI]) VALUES (N'LT007', 4, CAST(N'2024-12-06 22:50:00.000' AS DateTime), CAST(N'2024-12-07 06:50:00.000' AS DateTime), 300000, 1, 20, CAST(N'2024-12-03 19:52:01.387' AS DateTime), N'Đã đi')
GO
INSERT [dbo].[LichTrinh] ([MA_LICH_TRINH], [ID_TUYEN_DUONG], [KHOI_HANH], [KET_THUC], [GIA_VE], [ID_XE], [SOGHETRONG], [NGAY_TAO_LICH_TRINH], [TRANG_THAI]) VALUES (N'LT008', 3, CAST(N'2024-12-05 11:50:00.000' AS DateTime), CAST(N'2024-12-05 19:50:00.000' AS DateTime), 300000, 1, 20, CAST(N'2024-12-03 19:52:41.723' AS DateTime), N'Đã đi')
GO
INSERT [dbo].[LichTrinh] ([MA_LICH_TRINH], [ID_TUYEN_DUONG], [KHOI_HANH], [KET_THUC], [GIA_VE], [ID_XE], [SOGHETRONG], [NGAY_TAO_LICH_TRINH], [TRANG_THAI]) VALUES (N'LT009', 3, CAST(N'2024-12-05 12:50:00.000' AS DateTime), CAST(N'2024-12-05 20:50:00.000' AS DateTime), 320000, 1, 20, CAST(N'2024-12-03 19:53:10.090' AS DateTime), N'Đã đi')
GO
INSERT [dbo].[LichTrinh] ([MA_LICH_TRINH], [ID_TUYEN_DUONG], [KHOI_HANH], [KET_THUC], [GIA_VE], [ID_XE], [SOGHETRONG], [NGAY_TAO_LICH_TRINH], [TRANG_THAI]) VALUES (N'LT010', 1, CAST(N'2024-12-16 10:26:00.000' AS DateTime), CAST(N'2024-12-16 17:26:00.000' AS DateTime), 350000, 1, 20, CAST(N'2024-12-05 10:27:24.860' AS DateTime), N'Chưa đi')
GO
INSERT [dbo].[LichTrinh] ([MA_LICH_TRINH], [ID_TUYEN_DUONG], [KHOI_HANH], [KET_THUC], [GIA_VE], [ID_XE], [SOGHETRONG], [NGAY_TAO_LICH_TRINH], [TRANG_THAI]) VALUES (N'LT011', 2, CAST(N'2024-12-17 10:35:00.000' AS DateTime), CAST(N'2024-12-17 17:35:00.000' AS DateTime), 320000, 1, 20, CAST(N'2024-12-05 10:36:40.343' AS DateTime), N'Chưa đi')
GO
INSERT [dbo].[LichTrinh] ([MA_LICH_TRINH], [ID_TUYEN_DUONG], [KHOI_HANH], [KET_THUC], [GIA_VE], [ID_XE], [SOGHETRONG], [NGAY_TAO_LICH_TRINH], [TRANG_THAI]) VALUES (N'LT012', 1, CAST(N'2024-12-26 11:05:00.000' AS DateTime), CAST(N'2024-12-26 18:05:00.000' AS DateTime), 280000, 4, 34, CAST(N'2024-12-05 11:06:06.823' AS DateTime), N'Chưa đi')
GO
INSERT [dbo].[LichTrinh] ([MA_LICH_TRINH], [ID_TUYEN_DUONG], [KHOI_HANH], [KET_THUC], [GIA_VE], [ID_XE], [SOGHETRONG], [NGAY_TAO_LICH_TRINH], [TRANG_THAI]) VALUES (N'LT013', 1, CAST(N'2024-12-28 11:11:00.000' AS DateTime), CAST(N'2024-12-28 18:11:00.000' AS DateTime), 320000, 2, 34, CAST(N'2024-12-05 11:12:30.110' AS DateTime), N'Chưa đi')
GO
INSERT [dbo].[LichTrinh] ([MA_LICH_TRINH], [ID_TUYEN_DUONG], [KHOI_HANH], [KET_THUC], [GIA_VE], [ID_XE], [SOGHETRONG], [NGAY_TAO_LICH_TRINH], [TRANG_THAI]) VALUES (N'LT014', 3, CAST(N'2024-12-28 20:47:00.000' AS DateTime), CAST(N'2024-12-29 04:47:00.000' AS DateTime), 320000, 1, 20, CAST(N'2024-12-05 20:48:23.180' AS DateTime), N'Chưa đi')
GO
INSERT [dbo].[LichTrinh] ([MA_LICH_TRINH], [ID_TUYEN_DUONG], [KHOI_HANH], [KET_THUC], [GIA_VE], [ID_XE], [SOGHETRONG], [NGAY_TAO_LICH_TRINH], [TRANG_THAI]) VALUES (N'LT015', 4, CAST(N'2025-01-29 12:00:00.000' AS DateTime), CAST(N'2025-01-29 20:00:00.000' AS DateTime), 350000, 2, 34, CAST(N'2024-12-07 09:43:25.727' AS DateTime), N'Chưa đi')
GO
INSERT [dbo].[LichTrinh] ([MA_LICH_TRINH], [ID_TUYEN_DUONG], [KHOI_HANH], [KET_THUC], [GIA_VE], [ID_XE], [SOGHETRONG], [NGAY_TAO_LICH_TRINH], [TRANG_THAI]) VALUES (N'LT016', 4, CAST(N'2025-01-29 12:00:00.000' AS DateTime), CAST(N'2025-01-29 20:00:00.000' AS DateTime), 300000, 6, 34, CAST(N'2024-12-07 09:44:07.977' AS DateTime), N'Chưa đi')
GO
INSERT [dbo].[LichTrinh] ([MA_LICH_TRINH], [ID_TUYEN_DUONG], [KHOI_HANH], [KET_THUC], [GIA_VE], [ID_XE], [SOGHETRONG], [NGAY_TAO_LICH_TRINH], [TRANG_THAI]) VALUES (N'LT017', 4, CAST(N'2025-01-28 12:00:00.000' AS DateTime), CAST(N'2025-01-28 20:00:00.000' AS DateTime), 300000, 8, 34, CAST(N'2024-12-07 09:44:33.903' AS DateTime), N'Chưa đi')
GO
exec ThemNhanVien N'abc', N'1', N'Nguyễn Văn F', N'0987651234', N'Nam', N'Cà Mau', N'Nhân viên'
GO
exec ThemNhanVien N'abcd', N'1', N'Nguyễn Thị B', N'0987651234', N'Nữ', N'Hà Nội', N'Quản lý'
GO
INSERT [dbo].[Ve] ([ID_VE], [ID_LICH_TRINH], [TONG_TIEN], [NHAN_VIEN_TAO], [TRANG_THAI], [NGAY_DAT_VE], [SOLUONG], [SDT], [TENKHACHHANG], [DIEMDON], [DIEMTRA], [HINHTHUCTHANHTOAN]) VALUES (N'LT001VE001', N'LT001', 280000, N'abcd', N'Hiện tại', CAST(N'2024-12-07 10:32:54.713' AS DateTime), 1, N'1234567890', N'1', N'TDC002', N'TDC005', N'Tiền mặt')
GO
INSERT [dbo].[Ve] ([ID_VE], [ID_LICH_TRINH], [TONG_TIEN], [NHAN_VIEN_TAO], [TRANG_THAI], [NGAY_DAT_VE], [SOLUONG], [SDT], [TENKHACHHANG], [DIEMDON], [DIEMTRA], [HINHTHUCTHANHTOAN]) VALUES (N'LT001VE002', N'LT001', 560000, N'abcd', N'Hiện tại', CAST(N'2024-12-07 10:38:07.737' AS DateTime), 2, N'0794672367', N'Dĩ', N'TDC002', N'TDC005', N'Tiền mặt')
GO
INSERT [dbo].[Ve] ([ID_VE], [ID_LICH_TRINH], [TONG_TIEN], [NHAN_VIEN_TAO], [TRANG_THAI], [NGAY_DAT_VE], [SOLUONG], [SDT], [TENKHACHHANG], [DIEMDON], [DIEMTRA], [HINHTHUCTHANHTOAN]) VALUES (N'LT003VE001', N'LT003', 560000, N'abcd', N'Hiện tại', CAST(N'2024-12-05 11:52:50.727' AS DateTime), 2, N'0794672267', N'Trần Kháng Dĩ', N'TDC005', N'TDC003', N'Tiền mặt')
GO
INSERT [dbo].[Ve] ([ID_VE], [ID_LICH_TRINH], [TONG_TIEN], [NHAN_VIEN_TAO], [TRANG_THAI], [NGAY_DAT_VE], [SOLUONG], [SDT], [TENKHACHHANG], [DIEMDON], [DIEMTRA], [HINHTHUCTHANHTOAN]) VALUES (N'LT003VE002', N'LT003', 560000, N'abcd', N'Hiện tại', CAST(N'2024-12-07 10:36:09.793' AS DateTime), 2, N'0794673367', N'Trần Kháng Dĩ', N'TDC005', N'TDC003', N'Tiền mặt')
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
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC003', N'LT006')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC004', N'LT002')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC004', N'LT003')
GO
INSERT [dbo].[THEMTRAMDUNGCHAN] ([ID_TramDungChan], [MA_LICH_TRINH]) VALUES (N'TDC004', N'LT004')
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
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT001VE001', 6)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT001VE002', 1)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT001VE002', 2)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT003VE001', 55)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT003VE001', 65)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT003VE002', 56)
GO
INSERT [dbo].[ChiTietVe] ([ID_VE], [ID_GHE]) VALUES (N'LT003VE002', 57)
GO


