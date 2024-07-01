CREATE PROCEDURE proc_TimKiem
@tensach NVARCHAR(MAX)
AS
BEGIN
    SELECT s.sach_id as [Mã Sách], 
	s.nha_xb as [NXB], 
	s.ten_sach as [Tên Sách], 
	s.tac_gia as [Tác Giả], 
	nn.ten_ngon_ngu as [Ngôn Ngữ], 
	ls.ten_loai_sach as [Loại Sách], 
	s.so_luong as [Số Lượng], 
	s.ngay_nhap as [Ngày Nhập], 
	s.gia_bia as [Giá Bán]
	FROM sach s
	JOIN 
		ngon_ngu nn on s.ngon_ngu_id = nn.ngon_ngu_id
	JOIN
		loai_sach ls on s.loai_sach_id = ls.loai_sach_id
	WHERE 
		@tensach IS NULL OR ten_sach LIKE '%' + @tensach + '%'
	ORDER BY ten_sach;
END;
GO