using System;
using System.Windows.Forms;
using ql_diemrenluyen.BUS;
using ql_diemrenluyen.DTO;

namespace ql_diemrenluyen.GUI.ADMIN.Teacher
{
    public partial class AddGiangVienForm : Form
    {
        private DataGridView table;
        private QLGiangVien mainForm;

        public AddGiangVienForm(DataGridView dataGridView, QLGiangVien gvform)
        {
            InitializeComponent();
            table = dataGridView;
            mainForm = gvform;

            // Thêm các chức vụ vào ComboBox
            comboBoxChucVu.Items.Add("Giảng viên bộ môn");
            comboBoxChucVu.Items.Add("cố vấn học tập");
            comboBoxChucVu.Items.Add("quản lý khoa");
            comboBoxChucVu.Items.Add("quản lý trường");

            // Set default value cho ComboBox nếu cần
            comboBoxChucVu.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường nhập liệu có rỗng không
            if (string.IsNullOrWhiteSpace(txtTenGV.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtKhoa.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra email hợp lệ
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trạng thái giảng viên
            if (comboBoxTrangThai.SelectedItem == null || comboBoxChucVu.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn trạng thái và chức vụ giảng viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận thêm giảng viên
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thêm giảng viên không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                // Thêm giảng viên mới
                AddNewGiangVien();
            }
        }

        private void AddNewGiangVien()
        {
            // Tạo đối tượng GiangVienDTO để lưu trữ thông tin giảng viên
            GiangVienDTO giangVien = new GiangVienDTO
            {
                Name = txtTenGV.Text,
                Email = txtEmail.Text,
                ChucVu = comboBoxChucVu.SelectedItem?.ToString(), // Lấy chức vụ từ ComboBox
                KhoaId = txtKhoa.Text,
                TrangThai = (comboBoxTrangThai.SelectedItem?.ToString() == "Hoạt động")
            };

            // Gọi hàm thêm giảng viên từ lớp GiangVienBUS
            bool result = GiangVienBUS.AddGiangVien(giangVien);

            if (result)
            {
                // Cập nhật bảng giảng viên sau khi thêm thành công
                MessageBox.Show("Thêm giảng viên thành công!");
                QLGiangVien.LoadGiangVienList(table); // Load lại danh sách
                this.Close(); // Đóng form
            }
            else
            {
                // Thông báo nếu thêm giảng viên không thành công
                MessageBox.Show("Thêm giảng viên không thành công. Vui lòng kiểm tra lại!");
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                // Kiểm tra email hợp lệ bằng cách tạo đối tượng MailAddress
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Đóng form khi người dùng bấm nút "Đóng"
            this.Close();
        }
    }
}
