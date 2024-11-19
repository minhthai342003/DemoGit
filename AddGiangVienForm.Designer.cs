namespace ql_diemrenluyen.GUI.ADMIN.Teacher
{
    partial class AddGiangVienForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox comboBoxChucVu;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.ComboBox comboBoxTrangThai;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelTenGV;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelChucVu;
        private System.Windows.Forms.Label labelKhoa;
        private System.Windows.Forms.Label labelTrangThai;
        private System.Windows.Forms.Label labelTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.comboBoxChucVu = new System.Windows.Forms.ComboBox();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.comboBoxTrangThai = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelTenGV = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelChucVu = new System.Windows.Forms.Label();
            this.labelKhoa = new System.Windows.Forms.Label();
            this.labelTrangThai = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();

            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(150, 80);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(250, 20);
            this.txtTenGV.TabIndex = 0;

            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(150, 120);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 20);
            this.txtEmail.TabIndex = 1;

            // 
            // comboBoxChucVu
            // 
            this.comboBoxChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChucVu.FormattingEnabled = true;
            this.comboBoxChucVu.Location = new System.Drawing.Point(150, 160);
            this.comboBoxChucVu.Name = "comboBoxChucVu";
            this.comboBoxChucVu.Size = new System.Drawing.Size(250, 21);
            this.comboBoxChucVu.TabIndex = 2;

            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(150, 200);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(250, 20);
            this.txtKhoa.TabIndex = 3;

            // 
            // comboBoxTrangThai
            // 
            this.comboBoxTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTrangThai.FormattingEnabled = true;
            this.comboBoxTrangThai.Items.AddRange(new object[] {
            "Hoạt động",
            "Không hoạt động"});
            this.comboBoxTrangThai.Location = new System.Drawing.Point(150, 240);
            this.comboBoxTrangThai.Name = "comboBoxTrangThai";
            this.comboBoxTrangThai.Size = new System.Drawing.Size(250, 21);
            this.comboBoxTrangThai.TabIndex = 4;

            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(150, 280);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(300, 280);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // 
            // labelTenGV
            // 
            this.labelTenGV.AutoSize = true;
            this.labelTenGV.Location = new System.Drawing.Point(50, 80);
            this.labelTenGV.Name = "labelTenGV";
            this.labelTenGV.Size = new System.Drawing.Size(59, 13);
            this.labelTenGV.TabIndex = 7;
            this.labelTenGV.Text = "Tên Giảng Viên";

            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(50, 120);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email";

            // 
            // labelChucVu
            // 
            this.labelChucVu.AutoSize = true;
            this.labelChucVu.Location = new System.Drawing.Point(50, 160);
            this.labelChucVu.Name = "labelChucVu";
            this.labelChucVu.Size = new System.Drawing.Size(49, 13);
            this.labelChucVu.TabIndex = 9;
            this.labelChucVu.Text = "Chức Vụ";

            // 
            // labelKhoa
            // 
            this.labelKhoa.AutoSize = true;
            this.labelKhoa.Location = new System.Drawing.Point(50, 200);
            this.labelKhoa.Name = "labelKhoa";
            this.labelKhoa.Size = new System.Drawing.Size(33, 13);
            this.labelKhoa.TabIndex = 10;
            this.labelKhoa.Text = "Khoa";

            // 
            // labelTrangThai
            // 
            this.labelTrangThai.AutoSize = true;
            this.labelTrangThai.Location = new System.Drawing.Point(50, 240);
            this.labelTrangThai.Name = "labelTrangThai";
            this.labelTrangThai.Size = new System.Drawing.Size(60, 13);
            this.labelTrangThai.TabIndex = 11;
            this.labelTrangThai.Text = "Trạng Thái";

            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(150, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(211, 30);
            this.labelTitle.TabIndex = 12;
            this.labelTitle.Text = "Thêm Giảng Viên Mới";

            // 
            // AddGiangVienForm
            // 
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelTrangThai);
            this.Controls.Add(this.labelKhoa);
            this.Controls.Add(this.labelChucVu);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelTenGV);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboBoxTrangThai);
            this.Controls.Add(this.txtKhoa);
            this.Controls.Add(this.comboBoxChucVu);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTenGV);
            this.Name = "AddGiangVienForm";
            this.Text = "Thêm Giảng Viên";
        }
    }
}
