### Thông Tin Cá Nhân ###
#### Họ tên: ####
 Nguyễn Đăng Quang
#### MSSV: ####
 1512432 
#### Mail: ####
 nguyendangquangkt@gmail.com

### Các Chức năng Đã Làm Được ###

- Khi người dùng chạy ứng dụng thì một icon quick note sẽ được thêm vào notification area
- Người dùng nhấn Shortcut key (Ctrl + Space) thì form nhập dữ liệu Notes sẽ hiện lên, gồm 1 textbox phía trên để nhập tag và textbox phía dưới để nhập nội dung
- Người dùng nhập vào nội dung và một hoặc nhiều tag được ngăn cách bởi dấu ",". Ví dụ: "“test, study, info, todo"
- Người dùng có thể duyệt qua tất cả các Nội dung bằng các tag tương ứng
- Người dùng có thể chọn view statistics để xem biểu đồ thể hiện tần số được sử dụng của từng tag

### Các Luồng Sự kiện chính ( Main Flow) ### 
- Exit menu: thoát ứng dụng
- View notes: sẽ có một list box ngoài cùng bên trái thể hiện các tag và số lượng note tương ứng với mỗi tag
    + Khi click vào một tag tương ứng thì listbox ở cột tiếp theo sẽ hiển thị các các chữ cái đầu (khoảng 40 ký tự )của các notes đã được lưu với tag đó.
    + Khi click vào dòng tương ứng trên listbox thứ 2 thì toàn bộ nội dung note đó sẽ được biểu diễn ra ô textbox lớn ngoài cùng bên phải
- View statistics: Thể hiện biểu đồ tròn theo tần số được sử dụng của mỗi tag
- Tạo Global hotkey (Ctrl + Space): cho phép người dùng gọi lại màn hình nhập dữ liệu Notes sau khi ứng dụng hạ xuống notification Area.
- Đồng thời click đúp chuột vào icon Quick note trên notification area thì ứng dụng cũng sẽ được mở lên
### Các Luồng Sự Kiện Phụ (add flow) ###
- Chưa nhập nội dung tag hoặc nội dung notes thì chương trình báo lỗi (sử dụng error provider) 

### Link Youtube ###
https://goo.gl/EA1BR3

### Link tới RePo trên Github ###
https://github.com/DangQuangITus/Quick-Note
