USE [QLDSV_TC]
GO
/****** Object:  StoredProcedure [dbo].[GetAllHocKy]    Script Date: 10/4/2021 4:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAllHocKy] @NIENKHOA nchar(9)  as 
select HOCKY from LOPTINCHI where NIENKHOA= @NIENKHOA group by HOCKY


GO
/****** Object:  StoredProcedure [dbo].[GetAllNhom]    Script Date: 10/4/2021 4:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllNhom] @NIENKHOA varchar(9), @HOCKI int
as select NHOM FROM LOPTINCHI where @NIENKHOA = NIENKHOA AND HOCKY = @HOCKI group by NHOM


GO
/****** Object:  StoredProcedure [dbo].[GetAllNienKhoa]    Script Date: 10/4/2021 4:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllNienKhoa] as 
select NIENKHOA from LOPTINCHI group by NIENKHOA


GO
/****** Object:  StoredProcedure [dbo].[SP_BDMH]    Script Date: 10/4/2021 4:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_BDMH] @NienKhoa varchar(9), @HocKy int, @Nhom int,@MonHoc nvarchar(50)
as
declare @LOPTINCHI int
select @LOPTINCHI= MALTC from LOPTINCHI,MONHOC
where LOPTINCHI.NIENKHOA = @NienKhoa AND LOPTINCHI.HOCKY = @HocKy AND LOPTINCHI.NHOM = @Nhom
AND MONHOC.TENMH = @MonHoc AND LOPTINCHI.MAMH = MONHOC.MAMH
select MALC=@LOPTINCHI,SINHVIEN.MASV,HOTEN=HO+' '+TEN,DIEM_CC,DIEM_GK,DIEM_CK,DIEM_TK= DIEM_CC*0.1 + DIEM_GK*0.3 + DIEM_CK*0.6 from DANGKY,SINHVIEN
where  DANGKY.MASV = SINHVIEN.MASV AND DANGKY.MALTC = @LOPTINCHI AND HUYDANGKY = 0
order by TEN,HO
GO
/****** Object:  StoredProcedure [dbo].[SP_BDMH_Report]    Script Date: 10/4/2021 4:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_BDMH_Report] @NienKhoa varchar(9), @HocKy int, @Nhom int,@MonHoc nvarchar(50)
as
declare @LOPTINCHI int
select @LOPTINCHI= MALTC from LOPTINCHI,MONHOC
where LOPTINCHI.NIENKHOA = @NienKhoa AND LOPTINCHI.HOCKY = @HocKy AND LOPTINCHI.NHOM = @Nhom
AND MONHOC.TENMH = @MonHoc AND LOPTINCHI.MAMH = MONHOC.MAMH
select SINHVIEN.MASV,HO,TEN,DIEM_CC,DIEM_GK,DIEM_CK,DIEM_TK= DIEM_CC*0.1 + DIEM_GK*0.3 + DIEM_CK*0.6 from DANGKY,SINHVIEN
where  DANGKY.MASV = SINHVIEN.MASV AND DANGKY.MALTC = @LOPTINCHI AND HUYDANGKY = 0
order by TEN,HO

GO
/****** Object:  StoredProcedure [dbo].[SP_CHECKID]    Script Date: 10/4/2021 4:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CHECKID] @Code NVARCHAR(15),
@Type NVARCHAR(15)
AS
BEGIN
	-- LOP
	IF(@Type = 'MALOP')
	BEGIN
		
		IF EXISTS(SELECT * FROM dbo.LOP WHERE dbo.LOP.MALOP = @Code)
			RETURN 1; -- Mã tồn tại ở phân mãnh hiện tại
	
		ELSE IF EXISTS(SELECT * FROM LINK0.QLDSV_TC.dbo.LOP AS LOP WHERE LOP.MALOP = @Code)
			RETURN 2;	--Mã NV tồn tại ở phân mãnh  khác
	END

	--MON Hoc
	IF(@Type = 'MAMONHOC')
	BEGIN
		IF EXISTS(SELECT * FROM dbo.MONHOC WHERE MAMH = @Code)
		RETURN 1;
	END
	
	


		IF(@Type = 'MASV')
	BEGIN
		
		IF EXISTS(SELECT * FROM dbo.SINHVIEN WHERE dbo.SINHVIEN.MASV = @Code)
			RETURN 1; -- Mã tồn tại ở phân mãnh hiện tại
	
		ELSE IF EXISTS(SELECT * FROM LINK0.QLDSV_TC.dbo.SINHVIEN AS SV WHERE SV.MASV = @Code)
			RETURN 2;	--Mã NV tồn tại ở phân mãnh  khác
	END

	RETURN 0	--Không bị trùng được thêm
END




GO
/****** Object:  StoredProcedure [dbo].[SP_CHECKNAME]    Script Date: 10/4/2021 4:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CHECKNAME]
@Name NVARCHAR(50),
@Type NVARCHAR(15)
AS
BEGIN
	--Kiểm tra Table lop của server hiện tại
	IF(@Type = 'TENLOP')
	BEGIN
		IF EXISTS(SELECT * FROM dbo.LOP WHERE dbo.LOP.TENLOP = @Name)
			RETURN 1; -- @name bị trùng  ở phân mãnh hiện tại
	
		ELSE IF EXISTS(SELECT * FROM LINK0.QLDSV_TC.dbo.LOP AS LOP WHERE LOP.TENLOP = @Name)
			RETURN 2;	--@name bị trùng ở phân mãnh  khác
	END

	IF(@Type = 'TENMONHOC')
	BEGIN
		IF EXISTS(SELECT * FROM dbo.MONHOC WHERE TENMH = @Name)
		RETURN 1;
	END
	
	RETURN 0	--Không bị trùng ,được thêm
END



GO
/****** Object:  StoredProcedure [dbo].[SP_DangKiTC]    Script Date: 10/4/2021 4:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DangKiTC] @MALTC INT, @MASV NCHAR(10)
AS
BEGIN
	INSERT INTO dbo.DANGKY
	        ( MALTC ,
	          MASV,
			  HUYDANGKY 
	        )
	VALUES  ( @MALTC , -- MALTC - int
	          @MASV,  -- MASV - nchar(10)
	        0
	        )
END
GO
/****** Object:  StoredProcedure [dbo].[SP_FULLMARK]    Script Date: 10/4/2021 4:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_FULLMARK] @MSSV varchar(10) , @Type int
--0:PGV
--1:Khoa (Chỉ thực hiện trên đúng 1 sv hiện tại)
as
IF (@Type = 0)
BEGIN
	IF EXISTS (SELECT 1 FROM SINHVIEN WHERE MASV=@MSSV)  
				BEGIN
                    with GETDIEMMON (MAMH,DIEMTK) as
					(select LOPTINCHI.MAMH,DIEMTK= DIEM_CC * 0.1 + DIEM_GK * 0.3 + DIEM_CK * 0.6 
					from DANGKY,LOPTINCHI 
					where DANGKY.MASV = @MSSV AND DANGKY.MALTC = LOPTINCHI.MALTC AND HUYDANGKY=0)
					select TENMH,DIEMTK= MAX(DIEMTK) 
					from MONHOC,GETDIEMMON
					where GETDIEMMON.MAMH = MONHOC.MAMH
					group by TENMH
                END
	ELSE IF  EXISTS (SELECT 1 FROM LINK0.QLDSV_TC.dbo.SINHVIEN WHERE MASV=@MSSV) 
				BEGIN
                    with GETDIEMMON (MAMH,DIEMTK) as
					(select LOPTINCHI.MAMH,DIEMTK= DIEM_CC * 0.1 + DIEM_GK * 0.3 + DIEM_CK * 0.6 
					from DANGKY,LOPTINCHI 
					where DANGKY.MASV = @MSSV AND DANGKY.MALTC = LOPTINCHI.MALTC AND HUYDANGKY=0)
					select TENMH,DIEMTK= MAX(DIEMTK) 
					from MONHOC,GETDIEMMON
					where GETDIEMMON.MAMH = MONHOC.MAMH
					group by TENMH
                END
ELSE
	RAISERROR(N'SINH VIÊN NÀY KHÔNG TỒN TẠI',16,1)
END
ELSE
BEGIN
	IF EXISTS (SELECT 1 FROM SINHVIEN WHERE MASV=@MSSV)  
				BEGIN
                    with GETDIEMMON (MAMH,DIEMTK) as
					(select LOPTINCHI.MAMH,DIEMTK= DIEM_CC * 0.1 + DIEM_GK * 0.3 + DIEM_CK * 0.6 
					from DANGKY,LOPTINCHI 
					where DANGKY.MASV = @MSSV AND DANGKY.MALTC = LOPTINCHI.MALTC AND HUYDANGKY=0)
					select TENMH,DIEMTK= MAX(DIEMTK) 
					from MONHOC,GETDIEMMON
					where GETDIEMMON.MAMH = MONHOC.MAMH
					group by TENMH
                END
	ELSE
		RAISERROR(N'SINH VIÊN NÀY KHÔNG TỒN TẠI',16,1)
END

GO
/****** Object:  StoredProcedure [dbo].[SP_FULLMARK_BYCLASS_V2]    Script Date: 10/4/2021 4:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_FULLMARK_BYCLASS_V2] @MALOP varchar(10)
as
declare @columns NVARCHAR(MAX)
SET FMTONLY OFF
select INFO = SINHVIEN.MASV + '-' + HO + ' ' +TEN,TENMH,DIEM INTO #GetAllMark
from SINHVIEN left join 
(select MASV,A.TENMH,DIEM=COALESCE(DIEM_CC*0.1+DIEM_GK*0.3+DIEM_CK*0.6,0) 
from DANGKY, (select MALTC,TENMH from LOPTINCHI,MONHOC where LOPTINCHI.MAMH = MONHOC.MAMH) as A
where DANGKY.MALTC = A.MALTC) as B 
on SINHVIEN.MASV = B.MASV
where MALOP =  @MALOP  AND DANGHIHOC = 0
Select TOP(1) @columns = TENMH FROM #GetAllMark where TENMH IS NOT NULL
Select INFO,TENMH=COALESCE(TENMH,@columns),DIEM from #GetAllMark
SET FMTONLY ON
GO
/****** Object:  StoredProcedure [dbo].[SP_getInfoSVDKI]    Script Date: 10/4/2021 4:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_getInfoSVDKI]
@masv NCHAR(10)
AS
BEGIN
	SELECT MASV,HO,TEN,MALOP FROM dbo.SINHVIEN WHERE MASV = @masv
END

GO
/****** Object:  StoredProcedure [dbo].[SP_InDanhSachLopTinChi]    Script Date: 10/4/2021 4:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_InDanhSachLopTinChi] @NienKhoa varchar(9), @HocKy int
AS
with SOSVDK (MALTC,MAMH,MAGV,NHOM,SOSVTOITHIEU,AMOUNT) as
(select LOPTINCHI.MALTC,MAMH,MAGV,NHOM,SOSVTOITHIEU,count(DANGKY.MALTC) from LOPTINCHI 
left join DANGKY
on DANGKY.MALTC = LOPTINCHI.MALTC 
where HUYLOP=0 AND LOPTINCHI.NIENKHOA = @NienKhoa AND LOPTINCHI.HOCKY = @HocKy 
group by LOPTINCHI.MALTC,MAMH,MAGV,NHOM,SOSVTOITHIEU)
select A.MALTC,TENMH,NHOM,HOTEN,SOSVTOITHIEU,AMOUNT
from (select MALTC,TENMH from SOSVDK,MONHOC where SOSVDK.MAMH = MONHOC.MAMH) as A,
(select MALTC,NHOM,HOTEN=HO+' '+TEN,SOSVDK.SOSVTOITHIEU,AMOUNT from SOSVDK,GIANGVIEN where SOSVDK.MAGV=GIANGVIEN.MAGV) as B
where A.MALTC=B.MALTC



GO
/****** Object:  StoredProcedure [dbo].[SP_InDanhSachLopTinChi_Report]    Script Date: 10/4/2021 4:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_InDanhSachLopTinChi_Report] @NienKhoa varchar(9), @HocKy int
AS
with SOSVDK (MALTC,MAMH,MAGV,NHOM,SOSVTOITHIEU,AMOUNT) as
(select LOPTINCHI.MALTC,MAMH,MAGV,NHOM,SOSVTOITHIEU,count(DANGKY.MALTC) from LOPTINCHI 
left join DANGKY
on DANGKY.MALTC = LOPTINCHI.MALTC 
where HUYLOP=0 AND LOPTINCHI.NIENKHOA = @NienKhoa AND LOPTINCHI.HOCKY = @HocKy 
group by LOPTINCHI.MALTC,MAMH,MAGV,NHOM,SOSVTOITHIEU)
select TENMH,NHOM,HOTEN,SOSVTOITHIEU,AMOUNT
from (select MALTC,TENMH from SOSVDK,MONHOC where SOSVDK.MAMH = MONHOC.MAMH) as A,
(select MALTC,NHOM,HOTEN=HO+' '+TEN,SOSVDK.SOSVTOITHIEU,AMOUNT from SOSVDK,GIANGVIEN where SOSVDK.MAGV=GIANGVIEN.MAGV) as B
where A.MALTC=B.MALTC
GO
/****** Object:  StoredProcedure [dbo].[SP_Lay_Thong_Tin_GV_Tu_Login]    Script Date: 10/4/2021 4:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Lay_Thong_Tin_GV_Tu_Login]
 @TENLOGIN NVARCHAR(100)
 AS
 DECLARE @UID INT
 DECLARE @MAGV NVARCHAR(100)
 SELECT @UID = uid, @MAGV = name FROM SYS.sysusers
	WHERE sid = SUSER_SID(@TENLOGIN)
 SELECT MAGV = @MAGV,
		HOTEN = (SELECT HO+ ' '+TEN FROM dbo.GIANGVIEN WHERE MAGV=@MAGV),
		TENNHOM= name
		FROM SYS.sysusers
		WHERE uid = (SELECT groupuid FROM SYS.sysmembers WHERE memberuid = @UID)


GO
/****** Object:  StoredProcedure [dbo].[SP_LayDSGV]    Script Date: 10/4/2021 4:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_LayDSGV] AS
BEGIN
	SELECT MAGV,HOTEN = HO+' '+TEN FROM dbo.GIANGVIEN 
END

GO
/****** Object:  StoredProcedure [dbo].[SP_LayThongTinSV_DangNhap]    Script Date: 10/4/2021 4:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_LayThongTinSV_DangNhap]
@masv NCHAR(10),@password NVARCHAR(40)
AS
BEGIN
	SELECT MASV,HOTEN = HO+' '+TEN FROM dbo.SINHVIEN WHERE MASV = @masv AND PASSWORD = @password
END

GO
/****** Object:  StoredProcedure [dbo].[SP_LIST_SVHUYDANGKY]    Script Date: 10/4/2021 4:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_LIST_SVHUYDANGKY] @MASSV varchar(20)
as
with GETLIST_HUYDANGKY(MALTC,NIENKHOA,HOCKY,MAMH,MAGV,NHOM)
as
(select DANGKY.MALTC,NIENKHOA,HOCKY,MAMH,MAGV,NHOM 
from DANGKY,LOPTINCHI
where DANGKY.MASV=@MASSV AND DANGKY.MALTC = LOPTINCHI.MALTC AND DANGKY.HUYDANGKY = 0 
AND DANGKY.DIEM_CC IS NULL AND DANGKY.DIEM_CK IS NULL AND DANGKY.DIEM_GK IS NULL	
)
select A.MALTC,NIENKHOA,HOCKY,TENMH,HOTENGV=HO + ' '+ TEN,NHOM
from (select MALTC,NIENKHOA,HOCKY,HO,TEN,NHOM
from GETLIST_HUYDANGKY,GIANGVIEN
where GETLIST_HUYDANGKY.MAGV = GIANGVIEN.MAGV) as A,
(select MALTC,TENMH from GETLIST_HUYDANGKY,MONHOC 
where GETLIST_HUYDANGKY.MAMH = MONHOC.MAMH) as B
where A.MALTC = B.MALTC


GO
/****** Object:  StoredProcedure [dbo].[SP_SVDangKyLTC]    Script Date: 10/4/2021 4:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SVDangKyLTC] @NienKhoa VARCHAR(9),
@HocKy int , @Nhom int, @TenMh nvarchar(50)
as
declare @LOPTINCHI int
select @LOPTINCHI = MALTC  from LOPTINCHI,MONHOC
where LOPTINCHI.NIENKHOA=@NienKhoa AND LOPTINCHI.HOCKY = @HocKy
AND LOPTINCHI.NHOM = @Nhom AND MONHOC.TENMH = @TenMh AND LOPTINCHI.MAMH = MONHOC.MAMH
select SINHVIEN.MASV,HOTEN=HO+' '+TEN,PHAI = IIF(PHAI=1,N'Nữ',N'Nam'),MALOP from SINHVIEN,DANGKY
where DANGKY.MASV = SINHVIEN.MASV AND DANGKY.MALTC = @LOPTINCHI AND HUYDANGKY = 0
order by TEN,HO
GO
/****** Object:  StoredProcedure [dbo].[SP_TAOLOGIN]    Script Date: 10/4/2021 4:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TAOLOGIN]
  @LGNAME VARCHAR(50),
  @PASS VARCHAR(50),
  @USERNAME VARCHAR(50),
  @ROLE VARCHAR(50)
AS

	-- check login , user bị trùng 
	IF EXISTS(SELECT name FROM sys.server_principals 
				WHERE TYPE IN ('U', 'S', 'G')	--U: Windows Login Accounts
				AND name NOT LIKE '%##%'		--S: SQL Login Accounts
				AND name = @LGNAME)				--G: Windows Group Login Accounts
		RETURN 1	--Trùng Login
	ELSE IF EXISTS(SELECT name FROM sys.database_principals
					WHERE type_desc = 'SQL_USER'
					AND name = @USERNAME)
		RETURN 2	--Trùng User

	-- băt đầu tạo tài khoản
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'QLDSV_TC'
  IF (@RET =1) 
     RETURN 3 -- tạo tài khoản không thành công
 
  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1) 
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RETURN 3 -- tạo  tài khoảng không thành công
  END
  EXEC sp_addrolemember @ROLE, @USERNAME

  --THEM ROLE SECURITYADMIN DE CO QUYEN TAO TAI KHOAN
  EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'

  RETURN 0  -- THANH CONG

GO
/****** Object:  StoredProcedure [dbo].[SP_XULY_DIEM]    Script Date: 10/4/2021 4:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_XULY_DIEM]
@MSSV varchar(20),
@MALTC int,
@DIEMCC float,
@DIEMGK float,
@DIEMCK float
as 
BEGIN
	IF EXISTS (Select 1 From DANGKY where MASV = @MSSV AND MALTC = @MALTC)
	BEGIN
		UPDATE DANGKY
		SET DIEM_CC = @DIEMCC, DIEM_GK = @DIEMGK, DIEM_CK = @DIEMCK
		WHERE MASV = @MSSV AND MALTC = @MALTC
	END
	ELSE 
	RAISERROR(N'THÔNG TIN ĐĂNG KÝ KHÔNG TỒN TẠI',16,1)
	END

GO
/****** Object:  StoredProcedure [dbo].[SP_XULY_LTC]    Script Date: 10/4/2021 4:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_XULY_LTC] @MASV NVARCHAR(10),  
@MALTC INT,  
@type smallint
--type=1 : đăng ký
--type=0 : hủy
-- SP này để vừa cho sinh viên đăng ký hoặc hủy môn đăng ký
AS  
BEGIN  
	IF (@type=1)
	BEGIN
            IF EXISTS (SELECT 1 FROM DANGKY WHERE MASV=@MASV AND MALTC=@MALTC)  
				BEGIN
                    raiserror(N'SINH VIÊN ĐÃ ĐĂNG KÝ LỚP',16,1)
					RETURN
                END  
            ELSE  
                BEGIN  
                    INSERT INTO DBO.DANGKY(MALTC, MASV,HUYDANGKY)  
                    VALUES (@MALTC, @MASV,0)  
                END
	END
	ELSE IF(@type = 2)
	BEGIN
		IF EXISTS (SELECT 1 FROM DANGKY WHERE MASV=@MASV AND MALTC=@MALTC)  
				BEGIN
                    UPDATE DANGKY SET HUYDANGKY=1 WHERE MALTC = @MALTC AND MASV = @MASV
                END
		ELSE
			BEGIN
				raiserror(N'SINH VIÊN CHƯA ĐĂNG KÝ LỚP',16,1)
				
			END
	END
		
END


GO
