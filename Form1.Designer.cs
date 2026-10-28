namespace BaIKiemTraGiuaKyLTTQ
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            grpDanhSach = new GroupBox();
            dgvThietBi = new DataGridView();
            colMaTB = new DataGridViewTextBoxColumn();
            colTenTB = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            grpThongTin = new GroupBox();
            lblMaTB = new Label();
            txtMaTB = new TextBox();
            lblTenTB = new Label();
            txtTenTB = new TextBox();
            lblDonGia = new Label();
            txtDonGia = new TextBox();
            grpThaoTac = new GroupBox();
            btnThem = new Button();
            btnThoat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThietBi).BeginInit();
            grpThongTin.SuspendLayout();
            grpThaoTac.SuspendLayout();
            SuspendLayout();
           
            grpDanhSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpDanhSach.Controls.Add(dgvThietBi);
            grpDanhSach.Location = new Point(12, 12);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Size = new Size(540, 426);
            grpDanhSach.TabIndex = 0;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "Danh sách thiết bị";
           
            dgvThietBi.AllowUserToAddRows = false;
            dgvThietBi.AllowUserToDeleteRows = false;
            dgvThietBi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThietBi.BackgroundColor = SystemColors.Window;
            dgvThietBi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThietBi.Columns.AddRange(new DataGridViewColumn[] { colMaTB, colTenTB, colDonGia });
            dgvThietBi.Dock = DockStyle.Fill;
            dgvThietBi.Location = new Point(3, 23);
            dgvThietBi.MultiSelect = false;
            dgvThietBi.Name = "dgvThietBi";
            dgvThietBi.ReadOnly = true;
            dgvThietBi.RowHeadersWidth = 51;
            dgvThietBi.RowTemplate.Height = 25;
            dgvThietBi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThietBi.Size = new Size(534, 400);
            dgvThietBi.TabIndex = 0;
            dgvThietBi.CellClick += dgvThietBi_CellClick;
          
            colMaTB.DataPropertyName = "MaThietBi";
            colMaTB.FillWeight = 85F;
            colMaTB.HeaderText = "Mã Thiết Bị";
            colMaTB.MinimumWidth = 6;
            colMaTB.Name = "colMaTB";
            colMaTB.ReadOnly = true;
            
            colTenTB.DataPropertyName = "TenThietBi";
            colTenTB.FillWeight = 140F;
            colTenTB.HeaderText = "Tên Thiết Bị";
            colTenTB.MinimumWidth = 6;
            colTenTB.Name = "colTenTB";
            colTenTB.ReadOnly = true;
            
            colDonGia.DataPropertyName = "DonGia";
            colDonGia.FillWeight = 95F;
            colDonGia.HeaderText = "Đơn Giá (VNĐ)";
            colDonGia.MinimumWidth = 6;
            colDonGia.Name = "colDonGia";
            colDonGia.ReadOnly = true;
           
            grpThongTin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            grpThongTin.Controls.Add(lblMaTB);
            grpThongTin.Controls.Add(txtMaTB);
            grpThongTin.Controls.Add(lblTenTB);
            grpThongTin.Controls.Add(txtTenTB);
            grpThongTin.Controls.Add(lblDonGia);
            grpThongTin.Controls.Add(txtDonGia);
            grpThongTin.Location = new Point(565, 12);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(270, 180);
            grpThongTin.TabIndex = 1;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin thiết bị";
            
            lblMaTB.AutoSize = true;
            lblMaTB.Location = new Point(15, 35);
            lblMaTB.Name = "lblMaTB";
            lblMaTB.Size = new Size(84, 20);
            lblMaTB.TabIndex = 0;
            lblMaTB.Text = "Mã thiết bị:";
           
            txtMaTB.Location = new Point(107, 32);
            txtMaTB.MaxLength = 10;
            txtMaTB.Name = "txtMaTB";
            txtMaTB.Size = new Size(157, 27);
            txtMaTB.TabIndex = 1;
            
            lblTenTB.AutoSize = true;
            lblTenTB.Location = new Point(15, 78);
            lblTenTB.Name = "lblTenTB";
            lblTenTB.Size = new Size(86, 20);
            lblTenTB.TabIndex = 2;
            lblTenTB.Text = "Tên thiết bị:";
           
            txtTenTB.Location = new Point(107, 75);
            txtTenTB.Name = "txtTenTB";
            txtTenTB.Size = new Size(157, 27);
            txtTenTB.TabIndex = 3;
            
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(15, 122);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(110, 20);
            lblDonGia.TabIndex = 4;
            lblDonGia.Text = "Đơn giá (VNĐ):";
          
            txtDonGia.Location = new Point(131, 119);
            txtDonGia.MaxLength = 12;
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(133, 27);
            txtDonGia.TabIndex = 5;
            txtDonGia.KeyPress += txtDonGia_KeyPress;
            
            grpThaoTac.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            grpThaoTac.Controls.Add(btnThem);
            grpThaoTac.Controls.Add(btnThoat);
            grpThaoTac.Controls.Add(btnSua);
            grpThaoTac.Controls.Add(btnXoa);
            grpThaoTac.Location = new Point(565, 205);
            grpThaoTac.Name = "grpThaoTac";
            grpThaoTac.Size = new Size(270, 233);
            grpThaoTac.TabIndex = 2;
            grpThaoTac.TabStop = false;
            grpThaoTac.Text = "Thao tác";
            
            btnThem.Location = new Point(20, 35);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(105, 40);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
             
            btnThoat.Location = new Point(145, 35);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(105, 40);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
             
            btnSua.Location = new Point(20, 105);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(105, 40);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            
            btnXoa.Location = new Point(145, 105);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(105, 40);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
           
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 450);
            Controls.Add(grpThaoTac);
            Controls.Add(grpThongTin);
            Controls.Add(grpDanhSach);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Thiết bị / Vật tư - VP105";
            Load += Form1_Load;
            grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvThietBi).EndInit();
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            grpThaoTac.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDanhSach;
        private DataGridView dgvThietBi;
        private DataGridViewTextBoxColumn colMaTB;
        private DataGridViewTextBoxColumn colTenTB;
        private DataGridViewTextBoxColumn colDonGia;
        private GroupBox grpThongTin;
        private Label lblMaTB;
        private TextBox txtMaTB;
        private Label lblTenTB;
        private TextBox txtTenTB;
        private Label lblDonGia;
        private TextBox txtDonGia;
        private GroupBox grpThaoTac;
        private Button btnThem;
        private Button btnThoat;
        private Button btnSua;
        private Button btnXoa;
    }
}
