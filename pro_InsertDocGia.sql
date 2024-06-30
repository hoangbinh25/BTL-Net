CREATE PROC proc_InsertDocGia 
@MaDocGia int,
@TenDocGia nvarchar(100),
@NamSinh date,
@DiaChi nvarchar(100),
@SoDienThoai int,
@SoCMT varchar(50),
@HanThe nvarchar(20)
AS
BEGIN
	INSERT INTO doc_gia (doc_gia_id, ten_doc_gia, nam_sinh, dia_chi, so_dien_thoai, so_chung_minh_thu, han_the)
	VALUES (@MaDocGia, @TenDocGia, @NamSinh, @DiaChi, @SoDienThoai, @SoCMT, @HanThe)
END