CREATE PROC proc_account
	@username nvarchar(50),
	@password nvarchar(50)
AS
BEGIN	
	SELECT COUNT(1)
	FROM nguoi_dung
	WHERE ten_nguoi_dung = @username AND mat_khau = @password
END
