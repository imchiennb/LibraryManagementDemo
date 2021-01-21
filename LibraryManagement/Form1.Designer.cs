
namespace LibraryManagement
{
    partial class Form1
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabQuanLySach = new System.Windows.Forms.TabPage();
            this.dtGridViewQLS = new System.Windows.Forms.DataGridView();
            this.clMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabMuonTraSach = new System.Windows.Forms.TabPage();
            this.dtGridViewMuonTraSach = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HTSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTenSach = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTenSinhVien = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabQuanLySach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewQLS)).BeginInit();
            this.tabMuonTraSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewMuonTraSach)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabQuanLySach);
            this.tabControl.Controls.Add(this.tabMuonTraSach);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 426);
            this.tabControl.TabIndex = 0;
            // 
            // tabQuanLySach
            // 
            this.tabQuanLySach.Controls.Add(this.dtGridViewQLS);
            this.tabQuanLySach.Controls.Add(this.btnThemSach);
            this.tabQuanLySach.Controls.Add(this.txtTenSach);
            this.tabQuanLySach.Controls.Add(this.label2);
            this.tabQuanLySach.Controls.Add(this.txtMaSach);
            this.tabQuanLySach.Controls.Add(this.label1);
            this.tabQuanLySach.Location = new System.Drawing.Point(4, 22);
            this.tabQuanLySach.Name = "tabQuanLySach";
            this.tabQuanLySach.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuanLySach.Size = new System.Drawing.Size(768, 400);
            this.tabQuanLySach.TabIndex = 0;
            this.tabQuanLySach.Text = "Quản Lý Sách";
            this.tabQuanLySach.UseVisualStyleBackColor = true;
            // 
            // dtGridViewQLS
            // 
            this.dtGridViewQLS.AllowUserToAddRows = false;
            this.dtGridViewQLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewQLS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaSach,
            this.clTenSach});
            this.dtGridViewQLS.Location = new System.Drawing.Point(54, 117);
            this.dtGridViewQLS.Name = "dtGridViewQLS";
            this.dtGridViewQLS.Size = new System.Drawing.Size(643, 241);
            this.dtGridViewQLS.TabIndex = 5;
            // 
            // clMaSach
            // 
            this.clMaSach.HeaderText = "Mã Sách";
            this.clMaSach.Name = "clMaSach";
            this.clMaSach.Width = 300;
            // 
            // clTenSach
            // 
            this.clTenSach.HeaderText = "Tên Sách";
            this.clTenSach.Name = "clTenSach";
            this.clTenSach.Width = 300;
            // 
            // btnThemSach
            // 
            this.btnThemSach.Location = new System.Drawing.Point(424, 26);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(159, 67);
            this.btnThemSach.TabIndex = 4;
            this.btnThemSach.Text = "Thêm Sách";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(107, 73);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(262, 20);
            this.txtTenSach.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Sách";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(107, 27);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(262, 20);
            this.txtMaSach.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sách";
            // 
            // tabMuonTraSach
            // 
            this.tabMuonTraSach.Controls.Add(this.dtGridViewMuonTraSach);
            this.tabMuonTraSach.Controls.Add(this.btnTraSach);
            this.tabMuonTraSach.Controls.Add(this.button1);
            this.tabMuonTraSach.Controls.Add(this.dtNgayTra);
            this.tabMuonTraSach.Controls.Add(this.label6);
            this.tabMuonTraSach.Controls.Add(this.dtNgayMuon);
            this.tabMuonTraSach.Controls.Add(this.label5);
            this.tabMuonTraSach.Controls.Add(this.cbTenSach);
            this.tabMuonTraSach.Controls.Add(this.label4);
            this.tabMuonTraSach.Controls.Add(this.cbTenSinhVien);
            this.tabMuonTraSach.Controls.Add(this.label3);
            this.tabMuonTraSach.Location = new System.Drawing.Point(4, 22);
            this.tabMuonTraSach.Name = "tabMuonTraSach";
            this.tabMuonTraSach.Padding = new System.Windows.Forms.Padding(3);
            this.tabMuonTraSach.Size = new System.Drawing.Size(768, 400);
            this.tabMuonTraSach.TabIndex = 1;
            this.tabMuonTraSach.Text = "Mượn/Trả Sách";
            this.tabMuonTraSach.UseVisualStyleBackColor = true;
            // 
            // dtGridViewMuonTraSach
            // 
            this.dtGridViewMuonTraSach.AllowUserToAddRows = false;
            this.dtGridViewMuonTraSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewMuonTraSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.HTSV,
            this.TenSach,
            this.NgayMuon,
            this.NgayTra,
            this.ThanhTien});
            this.dtGridViewMuonTraSach.Location = new System.Drawing.Point(23, 98);
            this.dtGridViewMuonTraSach.Name = "dtGridViewMuonTraSach";
            this.dtGridViewMuonTraSach.Size = new System.Drawing.Size(693, 282);
            this.dtGridViewMuonTraSach.TabIndex = 10;
            this.dtGridViewMuonTraSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViewMuonTraSach_CellClick);
            // 
            // STT
            // 
            this.STT.FillWeight = 50F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // HTSV
            // 
            this.HTSV.HeaderText = "Họ Tên Sinh Viên";
            this.HTSV.Name = "HTSV";
            this.HTSV.Width = 120;
            // 
            // TenSach
            // 
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.Name = "TenSach";
            this.TenSach.Width = 120;
            // 
            // NgayMuon
            // 
            this.NgayMuon.HeaderText = "Ngày Mượn";
            this.NgayMuon.Name = "NgayMuon";
            // 
            // NgayTra
            // 
            this.NgayTra.HeaderText = "Ngày Trả";
            this.NgayTra.Name = "NgayTra";
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 110;
            // 
            // btnTraSach
            // 
            this.btnTraSach.Location = new System.Drawing.Point(615, 51);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(101, 23);
            this.btnTraSach.TabIndex = 9;
            this.btnTraSach.Text = "Trả Sách";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Mượn Sách";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtNgayTra
            // 
            this.dtNgayTra.Location = new System.Drawing.Point(392, 54);
            this.dtNgayTra.Name = "dtNgayTra";
            this.dtNgayTra.Size = new System.Drawing.Size(200, 20);
            this.dtNgayTra.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ngày Trả";
            // 
            // dtNgayMuon
            // 
            this.dtNgayMuon.Location = new System.Drawing.Point(392, 17);
            this.dtNgayMuon.Name = "dtNgayMuon";
            this.dtNgayMuon.Size = new System.Drawing.Size(200, 20);
            this.dtNgayMuon.TabIndex = 5;
            this.dtNgayMuon.ValueChanged += new System.EventHandler(this.dtNgayMuon_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Mượn";
            // 
            // cbTenSach
            // 
            this.cbTenSach.FormattingEnabled = true;
            this.cbTenSach.Location = new System.Drawing.Point(100, 54);
            this.cbTenSach.Name = "cbTenSach";
            this.cbTenSach.Size = new System.Drawing.Size(192, 21);
            this.cbTenSach.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên Sách";
            // 
            // cbTenSinhVien
            // 
            this.cbTenSinhVien.FormattingEnabled = true;
            this.cbTenSinhVien.Location = new System.Drawing.Point(100, 17);
            this.cbTenSinhVien.Name = "cbTenSinhVien";
            this.cbTenSinhVien.Size = new System.Drawing.Size(192, 21);
            this.cbTenSinhVien.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Sinh Viên";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Library Management";
            this.tabControl.ResumeLayout(false);
            this.tabQuanLySach.ResumeLayout(false);
            this.tabQuanLySach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewQLS)).EndInit();
            this.tabMuonTraSach.ResumeLayout(false);
            this.tabMuonTraSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewMuonTraSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabQuanLySach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabMuonTraSach;
        private System.Windows.Forms.DataGridView dtGridViewQLS;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSach;
        private System.Windows.Forms.DataGridView dtGridViewMuonTraSach;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtNgayTra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtNgayMuon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTenSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTenSinhVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn HTSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}

