CREATE PROC proc_AddNgonNgu
@mangonngu int,
@tenngonngu nvarchar(20) 
AS 
BEGIN
	INSERT INTO ngon_ngu(ngon_ngu_id, ten_ngon_ngu)
	VALUES (@mangonngu, @tenngonngu)
END