namespace HotelManagement.GUI
{
    partial class HotelManagementGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelManagementGUI));
            this.iconTab = new System.Windows.Forms.ImageList(this.components);
            this.Notification = new System.Windows.Forms.TabPage();
            this.dsNotification = new System.Windows.Forms.DataGridView();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.QuanLyKhachHang = new System.Windows.Forms.TabPage();
            this.btnThemKhachHang = new MaterialSkin.Controls.MaterialButton();
            this.btnThayDoiKhachHang = new MaterialSkin.Controls.MaterialButton();
            this.txtGioiTinhKH = new System.Windows.Forms.ComboBox();
            this.txtDoanKH = new System.Windows.Forms.TextBox();
            this.txtCMNDKH = new System.Windows.Forms.TextBox();
            this.txtEmailKH = new System.Windows.Forms.TextBox();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHoTenKH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMaPhongDatPhong = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMaKHDatPhong = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnLocPhong = new MaterialSkin.Controls.MaterialButton();
            this.dgvFilterPhong = new System.Windows.Forms.DataGridView();
            this.dtpNgayTraPhong = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvKhachHang1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TabControlNV = new MaterialSkin.Controls.MaterialTabControl();
            this.QuanLyPhong = new System.Windows.Forms.TabPage();
            this.txtTinhTrang = new MaterialSkin.Controls.MaterialComboBox();
            this.txtLoaiPhong = new MaterialSkin.Controls.MaterialComboBox();
            this.txtMaPhong = new MaterialSkin.Controls.MaterialComboBox();
            this.btnUpdatePhong = new MaterialSkin.Controls.MaterialButton();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Notification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsNotification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.QuanLyKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilterPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang1)).BeginInit();
            this.TabControlNV.SuspendLayout();
            this.QuanLyPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconTab
            // 
            this.iconTab.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconTab.ImageStream")));
            this.iconTab.TransparentColor = System.Drawing.Color.Transparent;
            this.iconTab.Images.SetKeyName(0, "department.png");
            this.iconTab.Images.SetKeyName(1, "group.png");
            this.iconTab.Images.SetKeyName(2, "project.png");
            this.iconTab.Images.SetKeyName(3, "to-do-list.png");
            this.iconTab.Images.SetKeyName(4, "user.png");
            this.iconTab.Images.SetKeyName(5, "notification.png");
            // 
            // Notification
            // 
            this.Notification.Controls.Add(this.dsNotification);
            this.Notification.ImageKey = "notification.png";
            this.Notification.Location = new System.Drawing.Point(4, 39);
            this.Notification.Name = "Notification";
            this.Notification.Padding = new System.Windows.Forms.Padding(3);
            this.Notification.Size = new System.Drawing.Size(1266, 610);
            this.Notification.TabIndex = 3;
            this.Notification.Text = "Notification";
            this.Notification.UseVisualStyleBackColor = true;
            // 
            // dsNotification
            // 
            this.dsNotification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsNotification.Location = new System.Drawing.Point(45, 16);
            this.dsNotification.Name = "dsNotification";
            this.dsNotification.RowHeadersWidth = 51;
            this.dsNotification.RowTemplate.Height = 24;
            this.dsNotification.Size = new System.Drawing.Size(811, 416);
            this.dsNotification.TabIndex = 35;
            // 
            // dgvPhong
            // 
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(174, 74);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.RowTemplate.Height = 24;
            this.dgvPhong.Size = new System.Drawing.Size(907, 188);
            this.dgvPhong.TabIndex = 8;
            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(333, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tình trạng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(333, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại phòng";
            // 
            // QuanLyKhachHang
            // 
            this.QuanLyKhachHang.Controls.Add(this.btnThemKhachHang);
            this.QuanLyKhachHang.Controls.Add(this.btnThayDoiKhachHang);
            this.QuanLyKhachHang.Controls.Add(this.txtGioiTinhKH);
            this.QuanLyKhachHang.Controls.Add(this.txtDoanKH);
            this.QuanLyKhachHang.Controls.Add(this.txtCMNDKH);
            this.QuanLyKhachHang.Controls.Add(this.txtEmailKH);
            this.QuanLyKhachHang.Controls.Add(this.txtSDTKH);
            this.QuanLyKhachHang.Controls.Add(this.label11);
            this.QuanLyKhachHang.Controls.Add(this.label12);
            this.QuanLyKhachHang.Controls.Add(this.label13);
            this.QuanLyKhachHang.Controls.Add(this.label14);
            this.QuanLyKhachHang.Controls.Add(this.txtDiaChiKH);
            this.QuanLyKhachHang.Controls.Add(this.label9);
            this.QuanLyKhachHang.Controls.Add(this.label10);
            this.QuanLyKhachHang.Controls.Add(this.txtHoTenKH);
            this.QuanLyKhachHang.Controls.Add(this.label8);
            this.QuanLyKhachHang.Controls.Add(this.txtMaKH);
            this.QuanLyKhachHang.Controls.Add(this.label5);
            this.QuanLyKhachHang.Controls.Add(this.dgvKhachHang);
            this.QuanLyKhachHang.ImageKey = "to-do-list.png";
            this.QuanLyKhachHang.Location = new System.Drawing.Point(4, 39);
            this.QuanLyKhachHang.Name = "QuanLyKhachHang";
            this.QuanLyKhachHang.Size = new System.Drawing.Size(1266, 610);
            this.QuanLyKhachHang.TabIndex = 2;
            this.QuanLyKhachHang.Text = "Quản lý khách hàng";
            this.QuanLyKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnThemKhachHang
            // 
            this.btnThemKhachHang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemKhachHang.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThemKhachHang.Depth = 0;
            this.btnThemKhachHang.HighEmphasis = true;
            this.btnThemKhachHang.Icon = null;
            this.btnThemKhachHang.Location = new System.Drawing.Point(735, 534);
            this.btnThemKhachHang.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThemKhachHang.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemKhachHang.Name = "btnThemKhachHang";
            this.btnThemKhachHang.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemKhachHang.Size = new System.Drawing.Size(93, 36);
            this.btnThemKhachHang.TabIndex = 25;
            this.btnThemKhachHang.Text = "Thêm mới";
            this.btnThemKhachHang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemKhachHang.UseAccentColor = false;
            this.btnThemKhachHang.UseVisualStyleBackColor = true;
            this.btnThemKhachHang.Click += new System.EventHandler(this.btnThemKhachHang_Click);
            // 
            // btnThayDoiKhachHang
            // 
            this.btnThayDoiKhachHang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThayDoiKhachHang.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThayDoiKhachHang.Depth = 0;
            this.btnThayDoiKhachHang.HighEmphasis = true;
            this.btnThayDoiKhachHang.Icon = null;
            this.btnThayDoiKhachHang.Location = new System.Drawing.Point(378, 534);
            this.btnThayDoiKhachHang.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThayDoiKhachHang.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThayDoiKhachHang.Name = "btnThayDoiKhachHang";
            this.btnThayDoiKhachHang.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThayDoiKhachHang.Size = new System.Drawing.Size(119, 36);
            this.btnThayDoiKhachHang.TabIndex = 24;
            this.btnThayDoiKhachHang.Text = "Lưu thay đổi";
            this.btnThayDoiKhachHang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThayDoiKhachHang.UseAccentColor = false;
            this.btnThayDoiKhachHang.UseVisualStyleBackColor = true;
            this.btnThayDoiKhachHang.Click += new System.EventHandler(this.btnThayDoiKhachHang_Click);
            // 
            // txtGioiTinhKH
            // 
            this.txtGioiTinhKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtGioiTinhKH.FormattingEnabled = true;
            this.txtGioiTinhKH.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.txtGioiTinhKH.Location = new System.Drawing.Point(205, 390);
            this.txtGioiTinhKH.Name = "txtGioiTinhKH";
            this.txtGioiTinhKH.Size = new System.Drawing.Size(335, 28);
            this.txtGioiTinhKH.TabIndex = 23;
            // 
            // txtDoanKH
            // 
            this.txtDoanKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoanKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDoanKH.Location = new System.Drawing.Point(858, 464);
            this.txtDoanKH.Name = "txtDoanKH";
            this.txtDoanKH.Size = new System.Drawing.Size(335, 27);
            this.txtDoanKH.TabIndex = 22;
            // 
            // txtCMNDKH
            // 
            this.txtCMNDKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMNDKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtCMNDKH.Location = new System.Drawing.Point(205, 461);
            this.txtCMNDKH.Name = "txtCMNDKH";
            this.txtCMNDKH.Size = new System.Drawing.Size(335, 27);
            this.txtCMNDKH.TabIndex = 21;
            // 
            // txtEmailKH
            // 
            this.txtEmailKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtEmailKH.Location = new System.Drawing.Point(858, 323);
            this.txtEmailKH.Name = "txtEmailKH";
            this.txtEmailKH.Size = new System.Drawing.Size(335, 27);
            this.txtEmailKH.TabIndex = 20;
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtSDTKH.Location = new System.Drawing.Point(858, 259);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(335, 27);
            this.txtSDTKH.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MediumBlue;
            this.label11.Location = new System.Drawing.Point(730, 466);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "Đoàn";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MediumBlue;
            this.label12.Location = new System.Drawing.Point(62, 463);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 25);
            this.label12.TabIndex = 16;
            this.label12.Text = "CMND";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.MediumBlue;
            this.label13.Location = new System.Drawing.Point(730, 323);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 25);
            this.label13.TabIndex = 14;
            this.label13.Text = "Email";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.MediumBlue;
            this.label14.Location = new System.Drawing.Point(730, 259);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 25);
            this.label14.TabIndex = 12;
            this.label14.Text = "SĐT";
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDiaChiKH.Location = new System.Drawing.Point(858, 391);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(335, 27);
            this.txtDiaChiKH.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumBlue;
            this.label9.Location = new System.Drawing.Point(730, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Địa chỉ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MediumBlue;
            this.label10.Location = new System.Drawing.Point(62, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "Giới tính";
            // 
            // txtHoTenKH
            // 
            this.txtHoTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtHoTenKH.Location = new System.Drawing.Point(205, 320);
            this.txtHoTenKH.Name = "txtHoTenKH";
            this.txtHoTenKH.Size = new System.Drawing.Size(335, 27);
            this.txtHoTenKH.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumBlue;
            this.label8.Location = new System.Drawing.Point(62, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Họ tên";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMaKH.Location = new System.Drawing.Point(205, 256);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(335, 27);
            this.txtMaKH.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(62, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã KH";
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(67, 34);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(1126, 179);
            this.dgvKhachHang.TabIndex = 2;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(333, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phòng";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtTienCoc);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.materialButton1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.txtMaPhongDatPhong);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.txtMaKHDatPhong);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.btnLocPhong);
            this.tabPage2.Controls.Add(this.dgvFilterPhong);
            this.tabPage2.Controls.Add(this.dtpNgayTraPhong);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dtpNgayDen);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dgvKhachHang1);
            this.tabPage2.ImageKey = "department.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1266, 610);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lập phiếu đặt";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(545, 552);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(104, 36);
            this.materialButton1.TabIndex = 14;
            this.materialButton1.Text = "Đặt Phòng";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(109, 500);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 27);
            this.textBox1.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.MediumBlue;
            this.label17.Location = new System.Drawing.Point(104, 460);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(183, 25);
            this.label17.TabIndex = 12;
            this.label17.Text = "Yêu Cầu Đặc Biệt";
            // 
            // txtMaPhongDatPhong
            // 
            this.txtMaPhongDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhongDatPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMaPhongDatPhong.Location = new System.Drawing.Point(944, 336);
            this.txtMaPhongDatPhong.Name = "txtMaPhongDatPhong";
            this.txtMaPhongDatPhong.ReadOnly = true;
            this.txtMaPhongDatPhong.Size = new System.Drawing.Size(208, 27);
            this.txtMaPhongDatPhong.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.MediumBlue;
            this.label16.Location = new System.Drawing.Point(939, 298);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 25);
            this.label16.TabIndex = 10;
            this.label16.Text = "Mã Phòng";
            // 
            // txtMaKHDatPhong
            // 
            this.txtMaKHDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKHDatPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMaKHDatPhong.Location = new System.Drawing.Point(944, 64);
            this.txtMaKHDatPhong.Name = "txtMaKHDatPhong";
            this.txtMaKHDatPhong.ReadOnly = true;
            this.txtMaKHDatPhong.Size = new System.Drawing.Size(208, 27);
            this.txtMaKHDatPhong.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.MediumBlue;
            this.label15.Location = new System.Drawing.Point(939, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 25);
            this.label15.TabIndex = 8;
            this.label15.Text = "Mã KH";
            // 
            // btnLocPhong
            // 
            this.btnLocPhong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLocPhong.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLocPhong.Depth = 0;
            this.btnLocPhong.HighEmphasis = true;
            this.btnLocPhong.Icon = null;
            this.btnLocPhong.Location = new System.Drawing.Point(944, 222);
            this.btnLocPhong.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLocPhong.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLocPhong.Name = "btnLocPhong";
            this.btnLocPhong.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLocPhong.Size = new System.Drawing.Size(103, 36);
            this.btnLocPhong.TabIndex = 7;
            this.btnLocPhong.Text = "Lọc phòng";
            this.btnLocPhong.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLocPhong.UseAccentColor = false;
            this.btnLocPhong.UseVisualStyleBackColor = true;
            this.btnLocPhong.Click += new System.EventHandler(this.btnLocPhong_Click);
            // 
            // dgvFilterPhong
            // 
            this.dgvFilterPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilterPhong.Location = new System.Drawing.Point(109, 295);
            this.dgvFilterPhong.Name = "dgvFilterPhong";
            this.dgvFilterPhong.ReadOnly = true;
            this.dgvFilterPhong.RowHeadersWidth = 51;
            this.dgvFilterPhong.RowTemplate.Height = 24;
            this.dgvFilterPhong.Size = new System.Drawing.Size(778, 150);
            this.dgvFilterPhong.TabIndex = 6;
            this.dgvFilterPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilterPhong_CellClick);
            // 
            // dtpNgayTraPhong
            // 
            this.dtpNgayTraPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTraPhong.Location = new System.Drawing.Point(582, 236);
            this.dtpNgayTraPhong.Name = "dtpNgayTraPhong";
            this.dtpNgayTraPhong.Size = new System.Drawing.Size(305, 22);
            this.dtpNgayTraPhong.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.Location = new System.Drawing.Point(577, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ngày trả phòng";
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDen.Location = new System.Drawing.Point(109, 236);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(311, 22);
            this.dtpNgayDen.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(104, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày đến";
            // 
            // dgvKhachHang1
            // 
            this.dgvKhachHang1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang1.Location = new System.Drawing.Point(109, 26);
            this.dgvKhachHang1.Name = "dgvKhachHang1";
            this.dgvKhachHang1.ReadOnly = true;
            this.dgvKhachHang1.RowHeadersWidth = 51;
            this.dgvKhachHang1.RowTemplate.Height = 24;
            this.dgvKhachHang1.Size = new System.Drawing.Size(778, 150);
            this.dgvKhachHang1.TabIndex = 0;
            this.dgvKhachHang1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(490, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ PHÒNG";
            // 
            // TabControlNV
            // 
            this.TabControlNV.Controls.Add(this.QuanLyPhong);
            this.TabControlNV.Controls.Add(this.tabPage2);
            this.TabControlNV.Controls.Add(this.QuanLyKhachHang);
            this.TabControlNV.Controls.Add(this.Notification);
            this.TabControlNV.Depth = 0;
            this.TabControlNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlNV.ImageList = this.iconTab;
            this.TabControlNV.Location = new System.Drawing.Point(3, 64);
            this.TabControlNV.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControlNV.Multiline = true;
            this.TabControlNV.Name = "TabControlNV";
            this.TabControlNV.SelectedIndex = 0;
            this.TabControlNV.Size = new System.Drawing.Size(1274, 653);
            this.TabControlNV.TabIndex = 1;
            // 
            // QuanLyPhong
            // 
            this.QuanLyPhong.Controls.Add(this.txtTinhTrang);
            this.QuanLyPhong.Controls.Add(this.txtLoaiPhong);
            this.QuanLyPhong.Controls.Add(this.txtMaPhong);
            this.QuanLyPhong.Controls.Add(this.btnUpdatePhong);
            this.QuanLyPhong.Controls.Add(this.dgvPhong);
            this.QuanLyPhong.Controls.Add(this.label4);
            this.QuanLyPhong.Controls.Add(this.label3);
            this.QuanLyPhong.Controls.Add(this.label2);
            this.QuanLyPhong.Controls.Add(this.label1);
            this.QuanLyPhong.ImageKey = "user.png";
            this.QuanLyPhong.Location = new System.Drawing.Point(4, 39);
            this.QuanLyPhong.Name = "QuanLyPhong";
            this.QuanLyPhong.Padding = new System.Windows.Forms.Padding(3);
            this.QuanLyPhong.Size = new System.Drawing.Size(1266, 610);
            this.QuanLyPhong.TabIndex = 0;
            this.QuanLyPhong.Text = "Quản lý phòng";
            this.QuanLyPhong.UseVisualStyleBackColor = true;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.AutoResize = false;
            this.txtTinhTrang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTinhTrang.Depth = 0;
            this.txtTinhTrang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtTinhTrang.DropDownHeight = 174;
            this.txtTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTinhTrang.DropDownWidth = 121;
            this.txtTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtTinhTrang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTinhTrang.FormattingEnabled = true;
            this.txtTinhTrang.IntegralHeight = false;
            this.txtTinhTrang.ItemHeight = 43;
            this.txtTinhTrang.Items.AddRange(new object[] {
            "Còn trống",
            "Đã đặt",
            "Đang sử dụng"});
            this.txtTinhTrang.Location = new System.Drawing.Point(476, 372);
            this.txtTinhTrang.MaxDropDownItems = 4;
            this.txtTinhTrang.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(368, 49);
            this.txtTinhTrang.StartIndex = 0;
            this.txtTinhTrang.TabIndex = 13;
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.AutoResize = false;
            this.txtLoaiPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtLoaiPhong.Depth = 0;
            this.txtLoaiPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtLoaiPhong.DropDownHeight = 174;
            this.txtLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtLoaiPhong.DropDownWidth = 121;
            this.txtLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtLoaiPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtLoaiPhong.FormattingEnabled = true;
            this.txtLoaiPhong.IntegralHeight = false;
            this.txtLoaiPhong.ItemHeight = 43;
            this.txtLoaiPhong.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.txtLoaiPhong.Location = new System.Drawing.Point(476, 437);
            this.txtLoaiPhong.MaxDropDownItems = 4;
            this.txtLoaiPhong.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(368, 49);
            this.txtLoaiPhong.StartIndex = 0;
            this.txtLoaiPhong.TabIndex = 12;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.AutoResize = false;
            this.txtMaPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMaPhong.Depth = 0;
            this.txtMaPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtMaPhong.DropDownHeight = 174;
            this.txtMaPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMaPhong.DropDownWidth = 121;
            this.txtMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtMaPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMaPhong.FormattingEnabled = true;
            this.txtMaPhong.IntegralHeight = false;
            this.txtMaPhong.ItemHeight = 43;
            this.txtMaPhong.Location = new System.Drawing.Point(476, 298);
            this.txtMaPhong.MaxDropDownItems = 4;
            this.txtMaPhong.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(368, 49);
            this.txtMaPhong.StartIndex = 0;
            this.txtMaPhong.TabIndex = 11;
            // 
            // btnUpdatePhong
            // 
            this.btnUpdatePhong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdatePhong.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdatePhong.Depth = 0;
            this.btnUpdatePhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePhong.HighEmphasis = true;
            this.btnUpdatePhong.Icon = null;
            this.btnUpdatePhong.Location = new System.Drawing.Point(592, 526);
            this.btnUpdatePhong.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdatePhong.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdatePhong.Name = "btnUpdatePhong";
            this.btnUpdatePhong.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdatePhong.Size = new System.Drawing.Size(64, 36);
            this.btnUpdatePhong.TabIndex = 10;
            this.btnUpdatePhong.Text = "Lưu";
            this.btnUpdatePhong.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdatePhong.UseAccentColor = false;
            this.btnUpdatePhong.UseVisualStyleBackColor = true;
            this.btnUpdatePhong.Click += new System.EventHandler(this.btnUpdatePhong_Click);
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienCoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTienCoc.Location = new System.Drawing.Point(576, 500);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.ReadOnly = true;
            this.txtTienCoc.Size = new System.Drawing.Size(311, 27);
            this.txtTienCoc.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.MediumBlue;
            this.label18.Location = new System.Drawing.Point(571, 460);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 25);
            this.label18.TabIndex = 15;
            this.label18.Text = "Tiền Cọc";
            // 
            // HotelManagementGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.TabControlNV);
            this.DrawerTabControl = this.TabControlNV;
            this.Name = "HotelManagementGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hotel Management System";
            this.Notification.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsNotification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.QuanLyKhachHang.ResumeLayout(false);
            this.QuanLyKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilterPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang1)).EndInit();
            this.TabControlNV.ResumeLayout(false);
            this.QuanLyPhong.ResumeLayout(false);
            this.QuanLyPhong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList iconTab;
        private System.Windows.Forms.TabPage Notification;
        private System.Windows.Forms.DataGridView dsNotification;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage QuanLyKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTabControl TabControlNV;
        private System.Windows.Forms.TabPage QuanLyPhong;
        private MaterialSkin.Controls.MaterialButton btnUpdatePhong;
        private MaterialSkin.Controls.MaterialComboBox txtTinhTrang;
        private MaterialSkin.Controls.MaterialComboBox txtLoaiPhong;
        private MaterialSkin.Controls.MaterialComboBox txtMaPhong;
        private System.Windows.Forms.DataGridView dgvKhachHang1;
        private System.Windows.Forms.DateTimePicker dtpNgayTraPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpNgayDen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDoanKH;
        private System.Windows.Forms.TextBox txtCMNDKH;
        private System.Windows.Forms.TextBox txtEmailKH;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHoTenKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txtGioiTinhKH;
        private MaterialSkin.Controls.MaterialButton btnThemKhachHang;
        private MaterialSkin.Controls.MaterialButton btnThayDoiKhachHang;
        private System.Windows.Forms.DataGridView dgvFilterPhong;
        private MaterialSkin.Controls.MaterialButton btnLocPhong;
        private System.Windows.Forms.TextBox txtMaKHDatPhong;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMaPhongDatPhong;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label17;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.Label label18;
    }
}