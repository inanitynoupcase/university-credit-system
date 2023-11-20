## **QUẢN LÝ ĐIỂM SINH VIÊN THEO HỆ TÍN CHỈ**

**Nội dung: Quản lý điểm sinh viên hệ đại học theo hệ tín chỉ trên từng Khoa**
- Trường có nhiều khoa, mỗi khoa 2 để phân biệt các khoa với nhau và tên khoa. Trong mỗi khoa còn có 1 số thông tin như trưởng khoa.
- Mỗi khoa quản lý nhiều lớp, mỗi lớp chỉ thuộc một khoa. Trong một khoa có nhiều chuyên ngành. Mỗi sinh viên chỉ thuộc 1 chuyên ngành, trong 1 chuyên ngành có nhiều sinh viên.
- Mỗi chuyên ngành có kế hoạch giảng xác định, học kỳ nào sẽ được học các  môn nào đã được lên kế hoạch trước.
- Mỗi lớp có mã lớp dùng để phân biệt các lớp và tên lớp, năm nhập học. Một sinh viên chỉ thuộc 1 lớp - Thông tin về sinh viên gồm có mã sinh viên để phân biệt các sinh viên, họ tên sinh viên, phái, địa chỉ, ngày sinh, khóa học.
- Lớp tín chỉ là lớp do trường đã lên kế hoạch mở trong 1 học kỳ thuộc 1 năm, và do 1 Khoa quản lý. Lớp này có các thông tin học buổi nào, thứ mấy, môn gì, giảng viên nào giảng để cho sinh viên có thể đăng ký học. Số sv đăng ký phải từ số sv tối thiểu trở lên thì mới tổ chức dạy, ngược lại nhà trường sẽ hủy.  Thông tin về lớp tín chỉ: mă lớp tín chỉ, số sv tối thiểu. Một lớp tín chỉ khi mở chỉ cho phép các sinh viên cùng Khoa đăng ký. Trong 1 học kỳ thuộc 1 niên khóa, 1 môn học có thể được tổ chức thành nhiều lớp tín chỉ cho sinh viên đăng ký, các lớp này phân biệt với nhau qua số nhóm.
- Các lớp tín chỉ thuộc 1 học kỳ năm học sẽ được mở cho sinh viên đăng ký trong 1 khoảng thời gian; Qua thời gian đăng ký, sinh viên sẽ không được đăng ký, hoặc hủy đăng ký.
- Thông tin về giảng viên gồm mã giảng viên dùng để phân biệt các giảng viên, họ tên giảng viên, học vị, học hàm, chuyên môn. Một giảng viên chỉ thuộc duy nhất 1 khoa.
- Thông tin về nhân viên : chứa các thông tin về các nhân viên thuộc phòng giáo vụ.
- Thông tin về môn học gồm mã môn học dùng để phân biệt các môn học, tên môn học, số tiết lý thuyết, số tiết thực hành. Một giảng viên có thể giảng được nhiều môn, và 1 môn có thể được giảng dạy bởi nhiều giảng viên. Giảng viên có thể giảng cho lớp thuộc Khoa khác.
- Sinh viên thi môn học nào thì có 1 kết quả.  
- Nếu sinh viên thi không đạt, thì sinh viên đăng ký học lại với lớp khóa sau, và thi cùng với lớp đó.
- Sau khi thi và có điểm của các môn thi. Điểm của các môn thi được Giảng viên dạy nhập trực tiếp vào cơ sở dữ liệu.  Điểm 1 môn thi có thể có các cột điểm : điểm chuyên cần (10%), điểm giữa kỳ (30%), điểm cuối kỳ (60%).
 	
Giả sử  trường có 2 khoa chính : công nghệ thông tin (CNTT),  và viễn thông (VT)

**1.	Phân tán cơ sở dữ liệu QLDSV ra làm 2 mảnh với điều kiện sau:**
-	QLDSV được đặt trên server1: chứa thông tin điểm của các sinh viên thuộc khoa công nghệ thông tin
-	QLDSV được đặt trên server2:  chứa thông tin điểm của các sinh viên thuộc khoa viễn thông.
 
**2.	Viết chương trình thực hiện các công việc sau trên từng khoa:**

**2.1 Đăng nhập:**
- Form mẫu: 
```
Khoa: 
Login:
Password:
```
- Trước khi sinh viên/ giáo viên sử dụng chương trình thì phải đăng ký trước. Đối với sinh viên thì masv xem như là login name. Sau khi đăng nhập, chương trình sẽ thông báo họ tên user đăng nhập, nhóm quyền của user, bật/tắt các chức năng trên menu chính dựa theo nhóm quyền.
 
**2.2. Nhập liệu:**
gồm các công việc sau:

*- Nhập danh mục lớp:* Form có các chức năng sau Thêm, Xóa, Ghi, Phục hồi, Thoát; Lớp thuộc khoa nào thì khoa đó nhập. Trên từng khoa ta chỉ thấy được danh sách lớp thuộc khoa đó. (PGV)

*- Nhập danh sách sinh viên:* Dưới dạng SubForm. Trong phần này, có chức năng cho phép chuyển sinh viên từ lớp này qua lớp khác, với điều kiện chưa thi bất cứ môn nào. (PGV)

*- Nhập Giảng viên* (PGV)

*- Nhập môn học:* Trên form Nhập môn học có các nút lệnh : Thêm, Xóa,  Ghi, Phục hồi, Thoát (PGV)

*- Mở Lớp tín chỉ:* Có các chức năng Thêm, Xóa, Ghi, Phục hồi thông tin của lớp tín chỉ

*- Đăng ký lớp tín chỉ:* User nhập vào mã sinh viên của mình, chương trình tự động in ra các thông tin của sinh viên (họ, tên, mã lớp). Kế tiếp, user nhập vào Niên khóa, Học kỳ, chương trình sẽ tự động lọc ra các lớp tín chỉ đã mở trong niên khóa, học kỳ đó để sinh viên đăng ký (chưa hủy). Dữ liệu in ra gồm: 
```MAMH | TENMH | nhóm | Hoten GV giảng | số sv đã đăng ký```

*- Nhập điểm:* Điểm thuộc khoa nào thì khoa đó nhập. User nhập vào Niên khóa, Học kỳ, môn học, nhóm; click nút lệnh Bắt đầu thì chương trình tự động lọc ra các sinh viên có đăng ký trên lớp tín chỉ đó theo dạng sau, sau đó user chỉ nhập điểm vào. 
Điểm hết môn = Điểm CC * 0.1 + Điểm GK * 0.3 + ĐCK * 0.6

| Mã SV | Họ tên SV | Điểm chuyên cần |Điểm giữa kỳ| Điểm cuối kỳ | Điểm hết môn  |
|:-------|:------:|-------:|-------:|:-------|:------:|
|  (read only)  |  (read only)  |    |    |    |   	(tự động tính, read only)   |


*Sau khi nhập điểm thi xong, click nút lệnh ‘Ghi điểm’ thì mới ghi hết điểm về CSDL.* 

**2. Phân quyền:** Chương trình có các nhóm quyền sau: PGV, Khoa, Sinh vien.
-  Nếu login thuộc nhóm PGV thì login đó có thể đăng nhập vào bất kỳ khoa nào để cập nhật bằng cách chọn tên khoa, tên lớp và tìm dữ liệu trên phân mảnh tương ứng. Nhóm quyền này có thể theo dõi được số liệu lớp tín chỉ, thông tin sinh viên đăng ký,… tuy nhiên, không được cập nhật điểm.
-  Nếu login thuộc nhóm Khoa thì ta chỉ cho phép làm việc trên khoa đó   và tìm dữ liệu trên phân mảnh tương ứng để in. Nhóm quyền này được phép nhập điểm lớp tín chỉ
- Nếu login thuộc nhóm Sinhvien thì chỉ được quyền đăng ký lớp tín chỉ,  xem điểm thi của mình.
Chương trình cho phép ta tạo các login, password và cho login này làm việc với quyền hạn gì.  Nhóm PGV chỉ được quyền tạo tài khoản cho  PGV, Nhóm Khoa chỉ được quyền tạo tài khoản cho  Khoa.

**3. Báo cáo :** gồm các mục sau:

*-	Danh sách sinh viên:* Tùy thuộc vào quyền hạn của login mà ta cho phép chọn khoa – lớp để in.  

*-	Danh sách lớp tín chỉ:* User nhập vào Niên khóa, học kỳ, chương trình in ra các lớp tín chỉ đã mở (chưa hủy) trong Niên khóa, học kỳ thuộc khoa mà user đang chọn. Mẫu in: (in theo thứ tự tên môn học, nhóm)

							KHOA XXXXXXXXXXXX
						Niên khóa: ####-####   Học kỳ: #

| STT | Tên môn học| Nhóm | Họ tên GV giảng | Số SV tối thiểu | Số SV đã đăng ký  |
|:-------:|:------:|:-------:|:-------:|:-------:|:------:|
|  1 |  Cơ sở dữ liệu phân tán | 1   | Lưu Nguyễn Kỳ Thư - Nguyễn Trung Trụ  |  15 |  30 |	

Số lượng lớp đã mở: 1

*-	Danh sách sinh viên đăng ký lớp tín chỉ:*  User nhập vào Niên khóa, học kỳ, môn học, nhóm, chương trình in ra danh sách theo thứ tự tăng dần tên + họ sinh viên với mẫu sau:

			DANH SÁCH SINH VIÊN ĐĂNG KÝ LỚP TÍN CHỈ
				KHOA XXXXXXXXXXXX
			Niên khóa: ####-####   Học kỳ: #
			Môn học: XXXXXXXXXXX – Nhóm: #


| STT | Mã SV | Họ | Tên |	Phái | Mã lớp |
|:-------:|:------:|:-------:|:-------:|:-------:|:-------:|
|  1 |  N19DCCN017 | Trần Nguyễn   | Gia Bảo  | Nam | D19CQCHT01-N |

Số sinh viên đã đăng ký: 1

*- Bảng điểm môn học của 1 lớp tín chỉ:* User nhập vào Niên khóa, học kỳ, môn học, nhóm, chương trình in ra bảng điểm theo thứ tự tăng dần tên + họ với mẫu sau:
		
							BẢNG ĐIỂM HẾT MÔN
							KHOA XXXXXXXXXXXX
						Niên khóa: ####-####   Học kỳ: #
						Môn học: XXXXXXXXXXX – Nhóm: #


| STT | Mã SV | Họ | Tên | Điểm chuyên cần |Điểm giữa kỳ| Điểm cuối kỳ | Điểm hết môn  |
|:-------:|:------:|:-------:|:-------:|:-------:|:-------:|:-------:|:-------:|
|  1 |  N19DCCN017 | Trần Nguyễn   | Gia Bảo  | 10 | 10|	10 |	10 |						

Số sinh viên: 1

*- Phiếu Điểm:*  để in phiếu điểm cho một sinh viên dựa vào mã sinh viên do ta nhập hay chọn từ trong một danh sách.
Phiếu điểm gồm có các cột: ```STT | TÊN MÔN HỌC | ĐIỂM```
- Thứ tự in điểm là theo tên môn học
- Điểm là điểm Max của các lần thi (nếu có).

*- Bảng điểm tổng kết:* Bảng điểm tổng kết của 1 lớp dựa vào mã lớp nhập vào. Điểm thi là điểm lớn nhất của các lần thi. (Cross-Tab) 
		
						BẢNG ĐIỂM TỔNG KẾT CUỐI KHÓA
						LỚP: XXXXXXXXXXXXX – KHÓA HỌC: 
							KHOA: XXXXXXXXXXX
MASV-Họ tên	Môn học 1	Môn học 2	Môn học 3	Môn học 4	Môn học n



| MASV - Họ tên | Môn học 1 | Môn học 2 | Môn học 3 | Môn học 4 |Môn học n|
|:-------:|:------:|:-------:|:-------:|:-------:|:-------:|
|  N19DCCN017 - Trần Nguyễn Gia Bảo|  10 | 10   | 10  | 10 | 10|					


***Ghi chú: Sinh viên tự kiểm tra các ràng buộc có thể có khi viết chương trình
 Lưu ý: Thực hiện việc truy vấn trên SQL Server.***

***- Chỉ làm việc với các sinh viên còn đang học.***


***
# university-credit-system
MSSQL (SSMS 19.1) + Devexpress (C# - 19.2.5)
*note*: Phần Chuyển lớp chưa xong và còn bugfix UI 
