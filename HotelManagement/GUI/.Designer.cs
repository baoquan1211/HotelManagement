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
            this.CheckIn = new System.Windows.Forms.TabPage();
            this.dgvDichVuPhong = new System.Windows.Forms.DataGridView();
            this.btnCheckIn = new MaterialSkin.Controls.MaterialButton();
            this.btnUpdateYeuCauDacBiet = new MaterialSkin.Controls.MaterialButton();
            this.txtYeuCauDBCheckIn = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtMaPhongCheckIn = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnTimPhieu = new MaterialSkin.Controls.MaterialButton();
            this.txtSDTKHCheckin = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTenKHCheckin = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dgvPhieuDatPhong = new System.Windows.Forms.DataGridView();
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
            this.LapPhieuDatPhong = new System.Windows.Forms.TabPage();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnDatPhong = new MaterialSkin.Controls.MaterialButton();
            this.txtYeuCauDacBiet = new System.Windows.Forms.TextBox();
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
            this.TabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.QuanLyPhong = new System.Windows.Forms.TabPage();
            this.txtLoaiPhong = new System.Windows.Forms.ComboBox();
            this.txtTinhTrang = new System.Windows.Forms.ComboBox();
            this.txtMaPhong = new System.Windows.Forms.ComboBox();
            this.btnUpdatePhong = new MaterialSkin.Controls.MaterialButton();
            this.CheckIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVuPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDatPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.QuanLyKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.LapPhieuDatPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilterPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang1)).BeginInit();
            this.TabControl.SuspendLayout();
            this.QuanLyPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconTab
            // 
            this.iconTab.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconTab.ImageStream")));
            this.iconTab.TransparentColor = System.Drawing.Color.Transparent;
            this.iconTab.Images.SetKeyName(0, "group.png");
            this.iconTab.Images.SetKeyName(1, "checkin.png");
            this.iconTab.Images.SetKeyName(2, "report.png");
            this.iconTab.Images.SetKeyName(3, "room.png");
            // 
            // CheckIn
            // 
            this.CheckIn.Controls.Add(this.dgvDichVuPhong);
            this.CheckIn.Controls.Add(this.btnCheckIn);
            this.CheckIn.Controls.Add(this.btnUpdateYeuCauDacBiet);
            this.CheckIn.Controls.Add(this.txtYeuCauDBCheckIn);
            this.CheckIn.Controls.Add(this.label23);
            this.CheckIn.Controls.Add(this.txtMaPhongCheckIn);
            this.CheckIn.Controls.Add(this.label21);
            this.CheckIn.Controls.Add(this.txtMaPhieu);
            this.CheckIn.Controls.Add(this.label22);
            this.CheckIn.Controls.Add(this.btnTimPhieu);
            this.CheckIn.Controls.Add(this.txtSDTKHCheckin);
            this.CheckIn.Controls.Add(this.label20);
            this.CheckIn.Controls.Add(this.txtTenKHCheckin);
            this.CheckIn.Controls.Add(this.label19);
            this.CheckIn.Controls.Add(this.dgvPhieuDatPhong);
            this.CheckIn.ImageKey = "checkin.png";
            this.CheckIn.Location = new System.Drawing.Point(4, 39);
            this.CheckIn.Name = "CheckIn";
            this.CheckIn.Padding = new System.Windows.Forms.Padding(3);
            this.CheckIn.Size = new System.Drawing.Size(1266, 610);
            this.CheckIn.TabIndex = 3;
            this.CheckIn.Text = "Check In";
            this.CheckIn.UseVisualStyleBackColor = true;
            // 
            // dgvDichVuPhong
            // 
            this.dgvDichVuPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVuPhong.Location = new System.Drawing.Point(822, 305);
            this.dgvDichVuPhong.Name = "dgvDichVuPhong";
            this.dgvDichVuPhong.ReadOnly = true;
            this.dgvDichVuPhong.RowHeadersWidth = 51;
            this.dgvDichVuPhong.RowTemplate.Height = 24;
            this.dgvDichVuPhong.Size = new System.Drawing.Size(366, 201);
            this.dgvDichVuPhong.TabIndex = 49;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCheckIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCheckIn.Depth = 0;
            this.btnCheckIn.HighEmphasis = true;
            this.btnCheckIn.Icon = null;
            this.btnCheckIn.Location = new System.Drawing.Point(527, 525);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCheckIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCheckIn.Size = new System.Drawing.Size(186, 36);
            this.btnCheckIn.TabIndex = 48;
            this.btnCheckIn.Text = "Hoàn Thành Check in";
            this.btnCheckIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCheckIn.UseAccentColor = false;
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnUpdateYeuCauDacBiet
            // 
            this.btnUpdateYeuCauDacBiet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateYeuCauDacBiet.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdateYeuCauDacBiet.Depth = 0;
            this.btnUpdateYeuCauDacBiet.HighEmphasis = true;
            this.btnUpdateYeuCauDacBiet.Icon = null;
            this.btnUpdateYeuCauDacBiet.Location = new System.Drawing.Point(527, 416);
            this.btnUpdateYeuCauDacBiet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdateYeuCauDacBiet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdateYeuCauDacBiet.Name = "btnUpdateYeuCauDacBiet";
            this.btnUpdateYeuCauDacBiet.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdateYeuCauDacBiet.Size = new System.Drawing.Size(156, 36);
            this.btnUpdateYeuCauDacBiet.TabIndex = 47;
            this.btnUpdateYeuCauDacBiet.Text = "Cập nhật Yêu Cầu";
            this.btnUpdateYeuCauDacBiet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdateYeuCauDacBiet.UseAccentColor = false;
            this.btnUpdateYeuCauDacBiet.UseVisualStyleBackColor = true;
            this.btnUpdateYeuCauDacBiet.Click += new System.EventHandler(this.btnUpdateYeuCauDacBiet_Click);
            // 
            // txtYeuCauDBCheckIn
            // 
            this.txtYeuCauDBCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYeuCauDBCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtYeuCauDBCheckIn.Location = new System.Drawing.Point(72, 416);
            this.txtYeuCauDBCheckIn.Name = "txtYeuCauDBCheckIn";
            this.txtYeuCauDBCheckIn.Size = new System.Drawing.Size(319, 27);
            this.txtYeuCauDBCheckIn.TabIndex = 46;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.MediumBlue;
            this.label23.Location = new System.Drawing.Point(67, 388);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(173, 25);
            this.label23.TabIndex = 45;
            this.label23.Text = "Yêu cầu đặc biệt";
            // 
            // txtMaPhongCheckIn
            // 
            this.txtMaPhongCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhongCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMaPhongCheckIn.Location = new System.Drawing.Point(449, 333);
            this.txtMaPhongCheckIn.Name = "txtMaPhongCheckIn";
            this.txtMaPhongCheckIn.Size = new System.Drawing.Size(311, 27);
            this.txtMaPhongCheckIn.TabIndex = 44;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.MediumBlue;
            this.label21.Location = new System.Drawing.Point(444, 305);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(110, 25);
            this.label21.TabIndex = 43;
            this.label21.Text = "Mã Phòng";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMaPhieu.Location = new System.Drawing.Point(72, 333);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(311, 27);
            this.txtMaPhieu.TabIndex = 42;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.MediumBlue;
            this.label22.Location = new System.Drawing.Point(67, 305);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(103, 25);
            this.label22.TabIndex = 41;
            this.label22.Text = "Mã Phiếu";
            // 
            // btnTimPhieu
            // 
            this.btnTimPhieu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTimPhieu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTimPhieu.Depth = 0;
            this.btnTimPhieu.HighEmphasis = true;
            this.btnTimPhieu.Icon = null;
            this.btnTimPhieu.Location = new System.Drawing.Point(943, 45);
            this.btnTimPhieu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTimPhieu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTimPhieu.Name = "btnTimPhieu";
            this.btnTimPhieu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTimPhieu.Size = new System.Drawing.Size(93, 36);
            this.btnTimPhieu.TabIndex = 40;
            this.btnTimPhieu.Text = "Tìm phiếu";
            this.btnTimPhieu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTimPhieu.UseAccentColor = false;
            this.btnTimPhieu.UseVisualStyleBackColor = true;
            this.btnTimPhieu.Click += new System.EventHandler(this.btnTimPhieu_Click);
            // 
            // txtSDTKHCheckin
            // 
            this.txtSDTKHCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTKHCheckin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtSDTKHCheckin.Location = new System.Drawing.Point(520, 54);
            this.txtSDTKHCheckin.Name = "txtSDTKHCheckin";
            this.txtSDTKHCheckin.Size = new System.Drawing.Size(311, 27);
            this.txtSDTKHCheckin.TabIndex = 39;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.MediumBlue;
            this.label20.Location = new System.Drawing.Point(515, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(150, 25);
            this.label20.TabIndex = 38;
            this.label20.Text = "Số Điện Thoại";
            // 
            // txtTenKHCheckin
            // 
            this.txtTenKHCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKHCheckin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTenKHCheckin.Location = new System.Drawing.Point(99, 54);
            this.txtTenKHCheckin.Name = "txtTenKHCheckin";
            this.txtTenKHCheckin.Size = new System.Drawing.Size(311, 27);
            this.txtTenKHCheckin.TabIndex = 37;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.MediumBlue;
            this.label19.Location = new System.Drawing.Point(94, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(175, 25);
            this.label19.TabIndex = 36;
            this.label19.Text = "Tên Khách Hàng";
            // 
            // dgvPhieuDatPhong
            // 
            this.dgvPhieuDatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuDatPhong.Location = new System.Drawing.Point(69, 104);
            this.dgvPhieuDatPhong.Name = "dgvPhieuDatPhong";
            this.dgvPhieuDatPhong.ReadOnly = true;
            this.dgvPhieuDatPhong.RowHeadersWidth = 51;
            this.dgvPhieuDatPhong.RowTemplate.Height = 24;
            this.dgvPhieuDatPhong.Size = new System.Drawing.Size(1119, 181);
            this.dgvPhieuDatPhong.TabIndex = 35;
            this.dgvPhieuDatPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuDatPhong_CellClick);
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
            this.QuanLyKhachHang.ImageKey = "group.png";
            this.QuanLyKhachHang.Location = new System.Drawing.Point(4, 39);
            this.QuanLyKhachHang.Name = "QuanLyKhachHang";
            this.QuanLyKhachHang.Size = new System.Drawing.Size(1266, 610);
            this.QuanLyKhachHang.TabIndex = 2;
            this.QuanLyKhachHang.Text = "QL Khách Hàng";
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
            // LapPhieuDatPhong
            // 
            this.LapPhieuDatPhong.Controls.Add(this.txtTienCoc);
            this.LapPhieuDatPhong.Controls.Add(this.label18);
            this.LapPhieuDatPhong.Controls.Add(this.btnDatPhong);
            this.LapPhieuDatPhong.Controls.Add(this.txtYeuCauDacBiet);
            this.LapPhieuDatPhong.Controls.Add(this.label17);
            this.LapPhieuDatPhong.Controls.Add(this.txtMaPhongDatPhong);
            this.LapPhieuDatPhong.Controls.Add(this.label16);
            this.LapPhieuDatPhong.Controls.Add(this.txtMaKHDatPhong);
            this.LapPhieuDatPhong.Controls.Add(this.label15);
            this.LapPhieuDatPhong.Controls.Add(this.btnLocPhong);
            this.LapPhieuDatPhong.Controls.Add(this.dgvFilterPhong);
            this.LapPhieuDatPhong.Controls.Add(this.dtpNgayTraPhong);
            this.LapPhieuDatPhong.Controls.Add(this.label7);
            this.LapPhieuDatPhong.Controls.Add(this.dtpNgayDen);
            this.LapPhieuDatPhong.Controls.Add(this.label6);
            this.LapPhieuDatPhong.Controls.Add(this.dgvKhachHang1);
            this.LapPhieuDatPhong.ImageKey = "report.png";
            this.LapPhieuDatPhong.Location = new System.Drawing.Point(4, 39);
            this.LapPhieuDatPhong.Name = "LapPhieuDatPhong";
            this.LapPhieuDatPhong.Padding = new System.Windows.Forms.Padding(3);
            this.LapPhieuDatPhong.Size = new System.Drawing.Size(1266, 610);
            this.LapPhieuDatPhong.TabIndex = 1;
            this.LapPhieuDatPhong.Text = "Đặt phòng";
            this.LapPhieuDatPhong.UseVisualStyleBackColor = true;
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
            // btnDatPhong
            // 
            this.btnDatPhong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDatPhong.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDatPhong.Depth = 0;
            this.btnDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.HighEmphasis = true;
            this.btnDatPhong.Icon = null;
            this.btnDatPhong.Location = new System.Drawing.Point(444, 551);
            this.btnDatPhong.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDatPhong.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDatPhong.Size = new System.Drawing.Size(104, 36);
            this.btnDatPhong.TabIndex = 14;
            this.btnDatPhong.Text = "Đặt Phòng";
            this.btnDatPhong.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDatPhong.UseAccentColor = false;
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // txtYeuCauDacBiet
            // 
            this.txtYeuCauDacBiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYeuCauDacBiet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtYeuCauDacBiet.Location = new System.Drawing.Point(109, 500);
            this.txtYeuCauDacBiet.Name = "txtYeuCauDacBiet";
            this.txtYeuCauDacBiet.Size = new System.Drawing.Size(311, 27);
            this.txtYeuCauDacBiet.TabIndex = 13;
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
            // TabControl
            // 
            this.TabControl.Controls.Add(this.QuanLyPhong);
            this.TabControl.Controls.Add(this.LapPhieuDatPhong);
            this.TabControl.Controls.Add(this.QuanLyKhachHang);
            this.TabControl.Controls.Add(this.CheckIn);
            this.TabControl.Depth = 0;
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.ImageList = this.iconTab;
            this.TabControl.Location = new System.Drawing.Point(3, 64);
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1274, 653);
            this.TabControl.TabIndex = 1;
            // 
            // QuanLyPhong
            // 
            this.QuanLyPhong.Controls.Add(this.txtLoaiPhong);
            this.QuanLyPhong.Controls.Add(this.txtTinhTrang);
            this.QuanLyPhong.Controls.Add(this.txtMaPhong);
            this.QuanLyPhong.Controls.Add(this.btnUpdatePhong);
            this.QuanLyPhong.Controls.Add(this.dgvPhong);
            this.QuanLyPhong.Controls.Add(this.label4);
            this.QuanLyPhong.Controls.Add(this.label3);
            this.QuanLyPhong.Controls.Add(this.label2);
            this.QuanLyPhong.ImageKey = "room.png";
            this.QuanLyPhong.Location = new System.Drawing.Point(4, 39);
            this.QuanLyPhong.Name = "QuanLyPhong";
            this.QuanLyPhong.Padding = new System.Windows.Forms.Padding(3);
            this.QuanLyPhong.Size = new System.Drawing.Size(1266, 610);
            this.QuanLyPhong.TabIndex = 0;
            this.QuanLyPhong.Text = "QL Phòng";
            this.QuanLyPhong.UseVisualStyleBackColor = true;
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtLoaiPhong.FormattingEnabled = true;
            this.txtLoaiPhong.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.txtLoaiPhong.Location = new System.Drawing.Point(476, 447);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(368, 28);
            this.txtLoaiPhong.TabIndex = 26;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtTinhTrang.FormattingEnabled = true;
            this.txtTinhTrang.Items.AddRange(new object[] {
            "Còn trống",
            "Đã đặt",
            "Đang sử dụng"});
            this.txtTinhTrang.Location = new System.Drawing.Point(476, 383);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(368, 28);
            this.txtTinhTrang.TabIndex = 25;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtMaPhong.FormattingEnabled = true;
            this.txtMaPhong.Location = new System.Drawing.Point(476, 312);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(368, 28);
            this.txtMaPhong.TabIndex = 24;
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
            // HotelManagementGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.TabControl);
            this.DrawerTabControl = this.TabControl;
            this.Name = "HotelManagementGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hotel Management System";
            this.CheckIn.ResumeLayout(false);
            this.CheckIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVuPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDatPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.QuanLyKhachHang.ResumeLayout(false);
            this.QuanLyKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.LapPhieuDatPhong.ResumeLayout(false);
            this.LapPhieuDatPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilterPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang1)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.QuanLyPhong.ResumeLayout(false);
            this.QuanLyPhong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList iconTab;
        private System.Windows.Forms.TabPage CheckIn;
        private System.Windows.Forms.DataGridView dgvPhieuDatPhong;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage QuanLyKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage LapPhieuDatPhong;
        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private System.Windows.Forms.TabPage QuanLyPhong;
        private MaterialSkin.Controls.MaterialButton btnUpdatePhong;
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
        private System.Windows.Forms.TextBox txtYeuCauDacBiet;
        private System.Windows.Forms.Label label17;
        private MaterialSkin.Controls.MaterialButton btnDatPhong;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSDTKHCheckin;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtTenKHCheckin;
        private System.Windows.Forms.Label label19;
        private MaterialSkin.Controls.MaterialButton btnTimPhieu;
        private System.Windows.Forms.TextBox txtMaPhongCheckIn;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtYeuCauDBCheckIn;
        private System.Windows.Forms.Label label23;
        private MaterialSkin.Controls.MaterialButton btnUpdateYeuCauDacBiet;
        private MaterialSkin.Controls.MaterialButton btnCheckIn;
        private System.Windows.Forms.DataGridView dgvDichVuPhong;
        private System.Windows.Forms.ComboBox txtLoaiPhong;
        private System.Windows.Forms.ComboBox txtTinhTrang;
        private System.Windows.Forms.ComboBox txtMaPhong;
    }
}