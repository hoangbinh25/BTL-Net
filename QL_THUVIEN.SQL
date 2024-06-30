USE master;
GO

DROP DATABASE IF EXISTS QL_THUVIEN;
GO

CREATE DATABASE QL_THUVIEN;
GO

USE QL_THUVIEN;
GO
-- Table: nguoi_dung
CREATE TABLE nguoi_dung (
    nguoi_dung_id INT PRIMARY KEY,
    ten_nguoi_dung NVARCHAR(100),
    mat_khau NVARCHAR(50),
    vai_tro NVARCHAR(50)
);

-- Table: loai_sach
CREATE TABLE loai_sach (
    loai_sach_id INT PRIMARY KEY,
    ten_loai_sach NVARCHAR(100)
);

-- Table: ngon_ngu
CREATE TABLE ngon_ngu (
    ngon_ngu_id INT PRIMARY KEY,
    ten_ngon_ngu NVARCHAR(50)
);

-- Table: sach
CREATE TABLE sach (
    sach_id INT PRIMARY KEY,
    loai_sach_id INT,
    nha_xb NVARCHAR(100),
    ngon_ngu_id INT,
    ten_sach NVARCHAR(100),
    tac_gia NVARCHAR(100),
    so_luong INT,
    so_luong_con INT,
    ngay_nhap DATE,
    gia_bia FLOAT,
    FOREIGN KEY (loai_sach_id) REFERENCES loai_sach(loai_sach_id),
    FOREIGN KEY (ngon_ngu_id) REFERENCES ngon_ngu(ngon_ngu_id)
);

-- Table: doc_gia
CREATE TABLE doc_gia (
    doc_gia_id INT PRIMARY KEY,
    ten_doc_gia NVARCHAR(100),
	nam_sinh Date,
    dia_chi NVARCHAR(100),
	so_dien_thoai int,
    so_chung_minh_thu VARCHAR(50),
	han_the nvarchar(20)
);

-- Table: phieu_muon
CREATE TABLE phieu_muon (
    phieu_muon_id INT PRIMARY KEY,
    doc_gia_id INT,
    so_luong_muon INT,
    tien_coc FLOAT,
    ngay_muon DATE,
    ngay_hen_tra DATE,
    FOREIGN KEY (doc_gia_id) REFERENCES doc_gia(doc_gia_id)
);

-- Table: chi_tiet_phieu_muon
CREATE TABLE chi_tiet_phieu_muon (
    phieu_muon_id INT,
    sach_id INT,
    ngay_tra DATE,
    PRIMARY KEY (phieu_muon_id, sach_id),
    FOREIGN KEY (phieu_muon_id) REFERENCES phieu_muon(phieu_muon_id),
    FOREIGN KEY (sach_id) REFERENCES sach(sach_id)
);
USE QL_THUVIEN;
GO

-- Insert sample data into nguoi_dung
INSERT INTO nguoi_dung (nguoi_dung_id, ten_nguoi_dung, mat_khau, vai_tro)
VALUES
(1, N'Nguyen Van A', 'password123', N'Admin'),
(2, N'Tran Thi B', 'password456', N'User');

-- Insert sample data into loai_sach
INSERT INTO loai_sach (loai_sach_id, ten_loai_sach)
VALUES
(1, N'Tiểu thuyết'),
(2, N'Khoa học'),
(3, N'Lịch sử');

-- Insert sample data into ngon_ngu
INSERT INTO ngon_ngu (ngon_ngu_id, ten_ngon_ngu)
VALUES
(1, N'Tiếng Việt'),
(2, N'Tiếng Anh'),
(3, N'Tiếng Pháp');

-- Insert sample data into sach
INSERT INTO sach (sach_id, loai_sach_id, nha_xb, ngon_ngu_id, ten_sach, tac_gia, so_luong, so_luong_con, ngay_nhap, gia_bia)
VALUES
(1, 1, N'NXB Kim Dong', 1, N'Truyen Kieu', N'Nguyen Du', 10, 8, '2023-01-15', 50000),
(2, 2, N'NXB Tre', 2, N'A Brief History of Time', N'Stephen Hawking', 5, 5, '2023-03-10', 150000),
(3, 3, N'NXB Giao Duc', 1, N'Lich Su Viet Nam', N'Pham Van Dong', 7, 6, '2023-05-20', 70000);

-- Insert sample data into doc_gia
INSERT INTO doc_gia (doc_gia_id, ten_doc_gia, nam_sinh, dia_chi, so_dien_thoai, so_chung_minh_thu, han_the)
VALUES
(1, N'Le Thi C', '2003-2-23' ,N'123 Duong ABC, Hanoi', '023852351', '123456789', '1-1-2028'),
(2, N'Nguyen Van D', '2002-5-23', N'456 Duong XYZ, HCMC', '097235482', '987654321', '1-1-2028');

-- Insert sample data into phieu_muon
INSERT INTO phieu_muon (phieu_muon_id, doc_gia_id, so_luong_muon, tien_coc, ngay_muon, ngay_hen_tra)
VALUES
(1, 1, 2, 100000, '2024-06-01', '2024-06-15'),
(2, 2, 1, 50000, '2024-06-05', '2024-06-20');

-- Insert sample data into chi_tiet_phieu_muon
INSERT INTO chi_tiet_phieu_muon (phieu_muon_id, sach_id, ngay_tra)
VALUES
(1, 1, NULL),
(1, 2, NULL),
(2, 3, NULL);
