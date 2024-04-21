CREATE DATABASE QLTV
GO

USE QLTV
GO

CREATE TABLE DANGNHAP
(
	UserName CHAR(20) NOT NULL constraint DN_UserName_PK PRIMARY KEY,
	PassWord CHAR(20) NOT NULL
)
GO

CREATE TABLE NHANVIEN
(
	MaNhanVien CHAR(10)  NOT NULL,
	HoTen NVARCHAR(50) NOT NULL,
	NgaySinh DATE,
	DiaChi NVARCHAR(100),
	GioiTinh CHAR(3) constraint NV_GioiTinh_CK CHECK(GioiTinh IN ('Nam', 'Nu')),
	TenDangNhap CHAR(20) NOT NULL,
	constraint NV_MaNhanVien_TenDangNhap_PK primary key (MaNhanVien, TenDangNhap),
	constraint NV_TenDangNhap_FK FOREIGN KEY (TenDangNhap) REFERENCES DANGNHAP(UserName)
)
GO

CREATE TABLE DOCGIA
(
	MaDocGia CHAR(10) NOT NULL constraint DG_MaDG_PK PRIMARY KEY,
	HoTen NVARCHAR(50) NOT NULL,
	NgaySinh DATE,
	GioiTinh CHAR(3) constraint DG_GioiTinh_CK CHECK(GioiTinh IN ('Nam', 'Nu')),
	DiaChi NVARCHAR(100),
	SDT CHAR(12),
	CCCD char(12)
)
GO

CREATE TABLE SACH
(
	MaSach CHAR(10) NOT NULL constraint SACH_MaSach_PK PRIMARY KEY,
	TenSach NVARCHAR(50) NOT NULL,
	LoaiSach NVARCHAR(50),
	TacGia NVARCHAR(50),
	NhaXuatBan NVARCHAR(50),
	NgayXuatBan DATE,
	SoLuong INT
)
GO

CREATE TABLE PHIEUMUON
(
	MaPhieuMuon CHAR(10)NOT NULL constraint PM_MaPhieuMuon_PK PRIMARY KEY,
	MaDocGia CHAR(10)NOT NULL constraint PM_MaDocGia_FK FOREIGN KEY (MaDocGia) REFERENCES DOCGIA(MaDocGia),
	MaSach CHAR(10) NOT NULL constraint PM_MaSach_FK FOREIGN KEY (MaSach) REFERENCES SACH(MaSach),
	NgayTaoPhieuMuon DATE DEFAULT (GETDATE()),
	NgayTra DATE DEFAULT (GETDATE() + 30),
	TinhTrang BIT
)
GO

CREATE TABLE PHIEUTRA
(
	MaPhieuTra CHAR(10) NOT NULL,
	MaPhieuMuon CHAR(10) NOT NULL constraint PT_MaPhieuMuon_FK FOREIGN KEY (MaPhieuMuon) REFERENCES PHIEUMUON(MaPhieuMuon),
	MaDocGia CHAR(10) NOT NULL constraint PT_MaDocGia_FK FOREIGN KEY (MaDocGia) REFERENCES DOCGIA(MaDocGia),
	MaSach CHAR(10) constraint PT_MaSach_FK FOREIGN KEY (MaSach) REFERENCES SACH(MaSach),
	NgayTaoPhieuTra DATE DEFAULT (GETDATE()),
	constraint PT_MaPhieuTra_MaPhieuMuon primary key (MaPhieuTra, MaPhieuMuon)
)
GO

CREATE TABLE PHIEUPHAT
(
	MaPhieuPhat CHAR(10) NOT NULL,
	MaPhieuMuon CHAR(10) NOT NULL constraint PP_MaPhieuMuon_FK FOREIGN KEY (MaPhieuMuon) REFERENCES PHIEUMUON(MaPhieuMuon),
	NgayTaoPhieuPhat DATE,
	TienPhat INT,
	constraint PP_MaPhieuPhat_MaPhieuMuon_PK primary key (MaPhieuPhat, MaPhieuMuon)
)
GO

INSERT INTO dbo.DANGNHAP (UserName, PassWord) VALUES (N'anh', N'123')
INSERT INTO dbo.DANGNHAP (UserName, PassWord) VALUES (N'quang', N'123')
INSERT INTO dbo.DANGNHAP (UserName, PassWord) VALUES (N'binh', N'123')
INSERT INTO dbo.DANGNHAP (UserName, PassWord) VALUES (N'y', N'123')
INSERT INTO dbo.DANGNHAP (UserName, PassWord) VALUES (N'phuong', N'123')
GO

INSERT INTO NHANVIEN VALUES ('NV01', N'Lê Hồng Anh', '2004-09-21', N'Bình Dương','Nam', N'anh')
INSERT INTO NHANVIEN VALUES ('NV02', N'Cao Vinh Quang', '2004-06-23', N'Sài Gòn','Nam', N'quang')
INSERT INTO NHANVIEN VALUES ('NV03', N'Nguyễn Thanh Bình', '2002-01-08', N'Bình Định','Nam', N'binh')
INSERT INTO NHANVIEN VALUES ('NV04', N'Nguyễn Thị Như ý', '2003-05-12', N'Sài Gòn','Nu', N'y')
INSERT INTO NHANVIEN VALUES ('NV05', N'Nguyễn Trần Nam Phương', '2003-03-11', N'Sài Gòn','Nu', N'phuong')
GO

INSERT INTO DOCGIA (MaDocGia, HoTen, NgaySinh, GioiTinh, DiaChi, SDT, CCCD)
VALUES
    ('DG001', N'Nguyễn Văn A', '1990-05-15', 'Nam', N'123 Đường ABC, Thành phố XYZ', '0123456789', '123456789012'),
    ('DG002', N'Trần Thị B', '1985-08-20', 'Nu', N'456 Đường XYZ, Thị trấn LMN', '0987654321', '987654321012'),
    ('DG003', N'Lê Văn C', '1998-03-10', 'Nam', N'789 Đường LMN, Xã PQR', '0123456789', '555555555555'),
    ('DG004', N'Phạm Thị D', '1995-12-02', 'Nu', N'567 Đường XYZ, Thành phố ABC', '0765432109', '456789123456'),
    ('DG005', N'Võ Văn E', '1980-07-18', 'Nam', N'890 Đường DEF, Huyện GHI', '0123456789', '789012345678'),
    ('DG006', N'Hoàng Thị F', '1992-01-25', 'Nu', N'234 Đường LMN, Thị trấn UVW', '0654321098', '321654987321'),
    ('DG007', N'Ngô Văn G', '1988-09-08', 'Nam', N'876 Đường ABC, Xã DEF', '0123456789', '987123456789'),
    ('DG008', N'Đỗ Văn H', '1997-06-14', 'Nam', N'345 Đường XYZ, Thành phố ABC', '0543210987', '654789321654'),
    ('DG009', N'Mai Thị I', '1983-04-30', 'Nu', N'432 Đường DEF, Huyện GHI', '0123456789', '789654123987'),
    ('DG010', N'Trương Văn K', '1994-11-12', 'Nam', N'678 Đường XYZ, Xã PQR', '0321098765', '147258369147');
GO

INSERT INTO SACH (MaSach, TenSach, LoaiSach, TacGia, NhaXuatBan, NgayXuatBan, SoLuong)
VALUES
    ('S001', N'Tiểu thuyết Mắt biếc', N'Tiểu thuyết', N'Nguyễn Nhật Ánh', N'NXB Trẻ', '2005-08-12', 50),
    ('S002', N'Harry Potter và Hòn đá Phù thủy', N'Fantasy', N'J.K. Rowling', N'Scholastic', '1997-09-01', 75),
    ('S003', N'Đắc Nhân Tâm', N'Tự phát triển cá nhân', N'Dale Carnegie', N'Bách Khoa Sách', '1936-01-01', 60),
    ('S004', N'Bí kíp nuôi dạy con thần đồng', N'Tự phát triển cá nhân', N'W. Doyle Gentry', N'Tiến Đạt', '2000-11-20', 80),
    ('S005', N'Nhà Giả Kim', N'Tiểu thuyết', N'Paulo Coelho', N'NXB Văn Học', '1988-08-01', 90),
    ('S006', N'Chú đông vui vẻ', N'Truyện thiếu nhi', N'To Hoai', N'Kim Đồng', '1970-01-01', 70),
    ('S007', N'Kỹ thuật lập trình C', N'Kỹ thuật', N'Kernighan & Ritchie', N'NXB Khoa Học Và Kỹ Thuật', '1978-01-01', 55),
    ('S008', N'Thế giới động vật - Loài chim', N'Khoa học', N'Various', N'Nhà Xuất Bản Đại Học Quốc Gia Hà Nội', '2000-12-31', 65),
    ('S009', N'Toán cao cấp', N'Tài liệu tham khảo', N'Bùi Việt', N'NXB Giáo Dục', '2005-02-10', 45),
    ('S010', N'Sói và sư tử', N'Sách thiếu nhi', N'Trí Huệ', N'Kim Đồng', '1995-03-15', 70);
GO

INSERT INTO PHIEUMUON (MaPhieuMuon, MaDocGia, MaSach, TinhTrang)
VALUES
    ('PM001', 'DG001', 'S001', 1),
    ('PM002', 'DG002', 'S002', 1),
    ('PM003', 'DG003', 'S003', 0),
    ('PM004', 'DG004', 'S004', 1),
    ('PM005', 'DG005', 'S005', 1),
    ('PM006', 'DG006', 'S006', 0),
    ('PM007', 'DG007', 'S007', 0),
    ('PM008', 'DG008', 'S008', 0),
    ('PM009', 'DG009', 'S009', 0),
    ('PM010', 'DG010', 'S010', 0)
GO

INSERT INTO PHIEUMUON (MaPhieuMuon, MaDocGia, MaSach,NgayTaoPhieuMuon, NgayTra, TinhTrang)
VALUES
	('PM011', 'DG001', 'S007', '2023-03-11', '2023-04-11', 0),
	('PM012', 'DG001', 'S004', '2023-04-12', '2023-05-12', 0),
	('PM013', 'DG005', 'S006','2023-02-17', '2023-03-17', 0),
	('PM014', 'DG006', 'S005','2023-01-08', '2023-02-08', 0),
	('PM015', 'DG008', 'S001','2023-06-05', '2023-07-05', 0)
GO

INSERT INTO PHIEUTRA (MaPhieuTra, MaPhieuMuon, MaDocGia, MaSach)
VALUES
    ('PT001', 'PM001', 'DG001', 'S001'),
    ('PT002', 'PM002', 'DG002', 'S002'),
    ('PT003', 'PM004', 'DG004', 'S004'),
    ('PT004', 'PM005', 'DG005', 'S005')
GO

INSERT INTO PHIEUPHAT (MaPhieuPhat, MaPhieuMuon, NgayTaoPhieuPhat, TienPhat)
VALUES
    ('PP001', 'PM011', '2023-04-12', 66000),
	('PP002', 'PM012', '2023-05-13', 46000),
	('PP003', 'PM013', '2023-03-18', 88000),
	('PP004', 'PM014', '2023-02-09', 111000),
	('PP005', 'PM015', '2023-07-06', 34000)
GO


