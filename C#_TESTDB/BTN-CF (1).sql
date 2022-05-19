Create database CaPhe
use CaPhe

--Tạo bảng TAIKHOAN
create table TAIKHOAN
(
	TenTK	nvarchar(50),
	MatKhau varchar(30),
	LoaiTK  char(1)
)

-- Tạo bảng LOAIMON
Create table LOAIMON
(
    MaLoai char(10),
	TenLoai nvarchar(50),
	primary key (MaLoai)
)

--Tạo bảng MON
create table MON
(
	MaMon char(10),
	MaLoai char(10),
	TenMon nvarchar(50),
	DonGiaMon int, 
	primary key(MaMon),
	foreign key (MaLoai) references LOAIMON ON DELETE CASCADE ON UPDATE CASCADE,
)

--Tạo bảng BAN
create table BAN
(
	Maban char(10),
	Tenban  nvarchar(15),
	primary key (Maban)
)

--Tạo bảng NHANVIEN
create table NHANVIEN
(
	MaNV	char(5),
	TenNV	nvarchar(50),
	DiaChiNV nvarchar(200),
	SDT_NV  varchar(15),
	primary key(MaNV)
)

--Tạo bảng HOADON
create table HOADON
(
	MaHD char(10),
	MaNV char(5),
	Maban char(10),
	NgayHD date,
	TongTien int,	
	primary key (MaHD),
	foreign key (Maban) references BAN ON DELETE CASCADE ON UPDATE CASCADE,
	foreign key (MaNV) references NHANVIEN ON DELETE CASCADE ON UPDATE CASCADE,
)

--Tạo bảng HOADON_CT
create table HOADON_CT
(
	MaHD char(10),	
	MaMon char(10),
	SoLuongMon int,
	GiamGia int,
	primary key (MaHD),
	foreign key (MaMon) references MON ON DELETE CASCADE ON UPDATE CASCADE,
	foreign key (MaHD) references HOADON ON DELETE CASCADE ON UPDATE CASCADE,
)

--Tạo bảng NHACUNGCAP
create table NHACUNGCAP
(
	MaNCC	char(5),
	TenNCC	nvarchar(50),
	DiaChi nvarchar(150),
	SDT_NCC  char(10),
	primary key(MaNCC)
)

--Tạo bảng PHIEU_NH
Create table PHIEU_NH
(	
	MaPhieu char(5),
	MaNV char(5),
	MaNCC char(5),
	NgayNhap date,
	DonGiaNhap int,
	TongTien int,
	CK int,
	primary key(MaPhieu),
	foreign key (MaNCC) references NHACUNGCAP ON DELETE CASCADE ON UPDATE CASCADE, 
	foreign key(MaNV)references NHANVIEN ON DELETE CASCADE ON UPDATE CASCADE,
)

--Tạo bảng PHIEUNH_CT
create table PHIEUNH_CT 
(	MaPhieu char(5),
	TenHang nvarchar(30), 
	DonViTinh varchar(10),
	SoLuongNhap int,
	ThanhTien int,
	primary key(MaPhieu),
	foreign key (MaPhieu) references PHIEU_NH ON DELETE CASCADE ON UPDATE CASCADE,
)

--Insert data
insert into TAIKHOAN values('Huy', '12345', '1')
insert into TAIKHOAN values('Son', '12345', '1')
insert into TAIKHOAN values('Hoai', '12345', '0')
insert into TAIKHOAN values('Thao', '12345', '0')

Insert into LOAIMON values ('L01',N'Cà Phê')
Insert into LOAIMON values ('L02',N'Trà')
Insert into LOAIMON values ('L03',N'Đá xay')
Insert into LOAIMON values ('L04',N'Kem')
Insert into LOAIMON values ('L05',N'Nước trái cây')
Insert into LOAIMON values ('L06', N'Thức uống khác')

Insert into MON values ('M001', 'L01', N'Cà phê đen','15000')
Insert into MON values ('M002', 'L01', N'Cà phê sữa','18000')
Insert into MON values ('M003', 'L01', N'Cà phê sữa Sài Gòn','29000')
Insert into MON values ('M004', 'L01', N'Cà phê đen Sài Gòn','29000')
Insert into MON values ('M005', 'L01', N'NCà phê dừa','35000')
Insert into MON values ('M006', 'L01', N'Bạc Xỉu','29000')
Insert into MON values ('M007', 'L01', N'Cappucchino','32000')
Insert into MON values ('M008', 'L01', N'Latte','29000')
Insert into MON values ('M009', 'L02', N'Trà Lipton','30000')
Insert into MON values ('M010', 'L02', N'Trà gừng','32000')
Insert into MON values ('M011', 'L02', N'Trà đào','35000')
Insert into MON values ('M012', 'L02', N'Trà vải','35000')
Insert into MON values ('M013', 'L02', N'Trà xanh xoài','39000')
Insert into MON values ('M014', 'L03', N'Chanh Tuyết','29000')
Insert into MON values ('M015', 'L03', N'Matcha blend','32000')
Insert into MON values ('M016', 'L03', N'Coconut Matcha','39000')
Insert into MON values ('M017', 'L03', N'Sinh tố dâu tây','39000')
Insert into MON values ('M018', 'L03', N'Sinh tố Xoài','39000')
Insert into MON values ('M019', 'L04', N'Kem Vani','32000')
Insert into MON values ('M020', 'L04', N'Kem Dâu','32000')
Insert into MON values ('M021', 'L04', N'Kem Socola','32000')
Insert into MON values ('M022', 'L05', N'Nước chanh','25000')
Insert into MON values ('M023', 'L05', N'Nước ép dứa','29000')
Insert into MON values ('M024', 'L05', N'Nước ép chanh dây','29000')
Insert into MON values ('M025', 'L05', N'Nước ép cà rốt','29000')
Insert into MON values ('M026', 'L05', N'Nước cam tươi','35000')
Insert into MON values ('M027', 'L06', N'Soda Táo Xanh','29000')
Insert into MON values ('M028', 'L06', N'Cacao','35000')
Insert into MON values ('M029', 'L06', N'Socola sữa nóng','35000')
Insert into MON values ('M030', 'L06', N'Sữa tươi trân châu đường đen','39000')
Insert into MON values ('M031', 'L06', N'Cacao trân châu đường đen','39000')

insert into	BAN values ('B01',N'Bàn 1')
insert into	BAN values ('B02',N'Bàn 2')
insert into	BAN values ('B03',N'Bàn 3')
insert into	BAN values ('B04',N'Bàn 4')
insert into	BAN values ('B05',N'Bàn 5')
insert into	BAN values ('B06',N'Bàn 6')
insert into	BAN values ('B07',N'Bàn 7')
insert into	BAN values ('B08',N'Bàn 8')
insert into	BAN values ('B09',N'Bàn 9')
insert into	BAN values ('B10',N'Bàn 10')

insert into NHANVIEN values('NV001',N'Võ Thị Anh Vân', N'28 Tứ Hạ, Hương Trà, TT Huế', '0966654330')
insert into NHANVIEN values('NV002',N'Lê Thị Hương Lan', N'Kiệt 38 Tôn Thất Sơn, Thủy Phương, Hương Thủy, TT Huế', '0955067020')
insert into NHANVIEN values('NV003',N'Đặng Duy Lâm', N'276 Tứ Hạ, Hương Trà, TT Huế', '0900854212')
insert into NHANVIEN values('NV004',N'Nguyễn Bảo Ngọc', N'124 Lê Lợi, Vĩnh Ninh, TT Huế', '0165421777')
insert into NHANVIEN values('NV005',N'Nguyễn Mỹ Duyên', N'78 Tứ Hạ, Hương Trà, TT Huế', '0164663603')
insert into NHANVIEN values('NV006',N'Lê Văn Phước', N'89 Phú Đa, Phú Vang, TT Huế', '0787508522')

insert into HOADON values ('HD001','NV001','B01','2021/11/05','15000')
insert into HOADON values ('HD002','NV001','B03','2021/11/07','29000')
insert into HOADON values ('HD003','NV001','B05','2021/11/09','87000')
insert into HOADON values ('HD004','NV001','B08','2021/11/09','58000')
insert into HOADON values ('HD005','NV001','B01','2021/11/11','116000')
insert into HOADON values ('HD006','NV002','B03','2021/11/14','60000')
insert into HOADON values ('HD007','NV002','B01','2021/11/15','35000')
insert into HOADON values ('HD008','NV002','B05','2021/11/15','96000')
insert into HOADON values ('HD009','NV002','B07','2021/11/15','32000')
insert into HOADON values ('HD010','NV002','B10','2021/11/14','96000') 

Insert into HOADON_CT values ( 'HD001', 'M001','1', '0')
Insert into HOADON_CT values ( 'HD002', 'M006','1', '0')
Insert into HOADON_CT values ( 'HD003', 'M003','3', '0')
Insert into HOADON_CT values ( 'HD004', 'M006','2', '0')
Insert into HOADON_CT values ( 'HD005', 'M004','4', '0')
Insert into HOADON_CT values ( 'HD006', 'M009','2', '0')
Insert into HOADON_CT values ( 'HD007', 'M011','1', '0')
Insert into HOADON_CT values ( 'HD008', 'M007','3', '0')
Insert into HOADON_CT values ( 'HD009', 'M021','1', '0')
Insert into HOADON_CT values ( 'HD010', 'M015','2', '0')

insert into NHACUNGCAP values('NCC01', N'Cửa hàng Gia Ngân', N'Xã Thúy Bằng, TX Hương Thủy, TP Huế', '0232990389')
insert into NHACUNGCAP values('NCC02', N'Gia Cát Coffee', N'61 An Dương Vương - Tp. Huế', '0916440971')
insert into NHACUNGCAP values('NCC03', N'Fin Coffee', N'15 Kiệt 79, Phạm Thị Liên, Huế', '0935661696')
insert into NHACUNGCAP values('NCC04', N'Mart Nhất Hương', N'61A Trần Quang Diệu, Quận 3, TP Hồ Chí Minh', '0911789697')

Insert into PHIEU_NH Values ('MP001','NV001','NCC01','2021/10/2' ,'400000','400000','0')
Insert into PHIEU_NH Values ('MP002','NV001','NCC01','2021/10/8' ,'450000','450000','0')
Insert into PHIEU_NH Values ('MP003','NV001','NCC01','2021/10/10','770000','700000','10')
Insert into PHIEU_NH Values ('MP004','NV004','NCC01','2021/10/14','434000','434000','0')
Insert into PHIEU_NH Values ('MP005','NV004','NCC02','2021/10/17','433000','433000','0')
Insert into PHIEU_NH Values ('MP006','NV004','NCC02','2021/10/20','443000','443000','0')
Insert into PHIEU_NH Values ('MP007','NV004','NCC02','2021/10/25','583000','583000','0')
Insert into PHIEU_NH Values ('MP008','NV003','NCC02','2021/10/29','405000','405000','0')
Insert into PHIEU_NH Values ('MP009','NV003','NCC02','2021/11/1' ,'382000','382000','0')
Insert into PHIEU_NH Values ('MP010','NV003','NCC02','2021/11/3' ,'382000','382000','0')

Insert into PHIEUNH_CT Values ('MP001',N'Sữa đặc Ngôi Sao','Thung','1','400000')
Insert into PHIEUNH_CT Values ('MP002',N'Sữa tươi Vinamilk','Thung','5','2250000')
Insert into PHIEUNH_CT Values ('MP003',N'Sữa chua Vinamilk','Thung','2','1400000')
Insert into PHIEUNH_CT Values ('MP004',N'Socola','Thung','4','1736000')
Insert into PHIEUNH_CT Values ('MP005',N'Đường','Thung','2','866000')
Insert into PHIEUNH_CT Values ('MP006',N'Trân châu','Thung','3','1329000')
Insert into PHIEUNH_CT Values ('MP007',N'Trái cây','Thung','6','3498000')
Insert into PHIEUNH_CT Values ('MP008',N'Cà phê bột','Thung','12','4860000')
Insert into PHIEUNH_CT Values ('MP009',N'Cà phê nguyên chất','Thung','7','2674000')
Insert into PHIEUNH_CT Values ('MP010',N'Cà phê hạt','Thung','3','1146000')

