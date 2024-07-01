USE [QL_THUVIEN]
GO
/****** Object:  StoredProcedure [dbo].[pro_selectAllNgonNgu]    Script Date: 7/1/2024 4:47:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[pro_selectAllNgonNgu]
AS
BEGIN 
	SELECT ngon_ngu.ngon_ngu_id as [Mã], 
	ngon_ngu.ten_ngon_ngu as [Tên ngôn ngữ] FROM ngon_ngu 
END