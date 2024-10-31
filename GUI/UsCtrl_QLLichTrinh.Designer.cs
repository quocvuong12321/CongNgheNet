
namespace GUI
{
    partial class UsCtrl_QLLichTrinh
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsCtrl_QLLichTrinh));
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_NgayKhoiHanh = new System.Windows.Forms.DateTimePicker();
            this.cbo_Xe = new System.Windows.Forms.ComboBox();
            this.btn_ThemLichTrinh = new System.Windows.Forms.Button();
            this.btn_CapNhatLichTrinh = new System.Windows.Forms.Button();
            this.txt_GiaVe = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_TuyenDuong = new System.Windows.Forms.ComboBox();
            this.dtp_GioKhoiHanh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_QLTramDungChan = new System.Windows.Forms.Button();
            this.txt_MaLichTrinh = new System.Windows.Forms.TextBox();
            this.dgv_DanhSachLichTrinh = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachLichTrinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(528, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 40);
            this.label1.TabIndex = 70;
            this.label1.Text = "QUẢN LÝ LỊCH TRÌNH";
            // 
            // dtp_NgayKhoiHanh
            // 
            this.dtp_NgayKhoiHanh.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayKhoiHanh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayKhoiHanh.Location = new System.Drawing.Point(332, 160);
            this.dtp_NgayKhoiHanh.Name = "dtp_NgayKhoiHanh";
            this.dtp_NgayKhoiHanh.Size = new System.Drawing.Size(255, 29);
            this.dtp_NgayKhoiHanh.TabIndex = 124;
            // 
            // cbo_Xe
            // 
            this.cbo_Xe.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Xe.FormattingEnabled = true;
            this.cbo_Xe.Location = new System.Drawing.Point(940, 67);
            this.cbo_Xe.Name = "cbo_Xe";
            this.cbo_Xe.Size = new System.Drawing.Size(255, 30);
            this.cbo_Xe.TabIndex = 122;
            // 
            // btn_ThemLichTrinh
            // 
            this.btn_ThemLichTrinh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ThemLichTrinh.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemLichTrinh.ForeColor = System.Drawing.Color.Green;
            this.btn_ThemLichTrinh.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemLichTrinh.Image")));
            this.btn_ThemLichTrinh.Location = new System.Drawing.Point(416, 270);
            this.btn_ThemLichTrinh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThemLichTrinh.Name = "btn_ThemLichTrinh";
            this.btn_ThemLichTrinh.Size = new System.Drawing.Size(202, 43);
            this.btn_ThemLichTrinh.TabIndex = 119;
            this.btn_ThemLichTrinh.Text = "Thêm lịch trình";
            this.btn_ThemLichTrinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ThemLichTrinh.UseVisualStyleBackColor = false;
            this.btn_ThemLichTrinh.Click += new System.EventHandler(this.btn_ThemLichTrinh_Click);
            // 
            // btn_CapNhatLichTrinh
            // 
            this.btn_CapNhatLichTrinh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CapNhatLichTrinh.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhatLichTrinh.ForeColor = System.Drawing.Color.Orange;
            this.btn_CapNhatLichTrinh.Image = ((System.Drawing.Image)(resources.GetObject("btn_CapNhatLichTrinh.Image")));
            this.btn_CapNhatLichTrinh.Location = new System.Drawing.Point(789, 270);
            this.btn_CapNhatLichTrinh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CapNhatLichTrinh.Name = "btn_CapNhatLichTrinh";
            this.btn_CapNhatLichTrinh.Size = new System.Drawing.Size(202, 43);
            this.btn_CapNhatLichTrinh.TabIndex = 120;
            this.btn_CapNhatLichTrinh.Text = "Cập nhật lịch trình";
            this.btn_CapNhatLichTrinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CapNhatLichTrinh.UseVisualStyleBackColor = false;
            this.btn_CapNhatLichTrinh.Click += new System.EventHandler(this.btn_CapNhatLichTrinh_Click);
            // 
            // txt_GiaVe
            // 
            this.txt_GiaVe.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaVe.Location = new System.Drawing.Point(940, 117);
            this.txt_GiaVe.Margin = new System.Windows.Forms.Padding(4);
            this.txt_GiaVe.Multiline = true;
            this.txt_GiaVe.Name = "txt_GiaVe";
            this.txt_GiaVe.Size = new System.Drawing.Size(255, 29);
            this.txt_GiaVe.TabIndex = 107;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(844, 71);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 23);
            this.label13.TabIndex = 117;
            this.label13.Text = "Xe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(170, 118);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 23);
            this.label9.TabIndex = 114;
            this.label9.Text = "Mã lịch trình";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(170, 208);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 23);
            this.label11.TabIndex = 111;
            this.label11.Text = "Giờ khởi hành";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(844, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 112;
            this.label5.Text = "Giá vé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(170, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 126;
            this.label2.Text = "Tuyến đường";
            // 
            // cbo_TuyenDuong
            // 
            this.cbo_TuyenDuong.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_TuyenDuong.FormattingEnabled = true;
            this.cbo_TuyenDuong.Location = new System.Drawing.Point(332, 67);
            this.cbo_TuyenDuong.Name = "cbo_TuyenDuong";
            this.cbo_TuyenDuong.Size = new System.Drawing.Size(255, 30);
            this.cbo_TuyenDuong.TabIndex = 121;
            this.cbo_TuyenDuong.SelectedIndexChanged += new System.EventHandler(this.cbo_TuyenDuong_SelectedIndexChanged);
            // 
            // dtp_GioKhoiHanh
            // 
            this.dtp_GioKhoiHanh.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_GioKhoiHanh.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_GioKhoiHanh.Location = new System.Drawing.Point(332, 206);
            this.dtp_GioKhoiHanh.Name = "dtp_GioKhoiHanh";
            this.dtp_GioKhoiHanh.Size = new System.Drawing.Size(255, 29);
            this.dtp_GioKhoiHanh.TabIndex = 124;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(170, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 111;
            this.label3.Text = "Ngày khởi hành";
            // 
            // btn_QLTramDungChan
            // 
            this.btn_QLTramDungChan.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLTramDungChan.Location = new System.Drawing.Point(997, 193);
            this.btn_QLTramDungChan.Name = "btn_QLTramDungChan";
            this.btn_QLTramDungChan.Size = new System.Drawing.Size(198, 62);
            this.btn_QLTramDungChan.TabIndex = 127;
            this.btn_QLTramDungChan.Text = "QL Trạm Dừng Chân";
            this.btn_QLTramDungChan.UseVisualStyleBackColor = true;
            this.btn_QLTramDungChan.Click += new System.EventHandler(this.btn_QLTramDungChan_Click);
            // 
            // txt_MaLichTrinh
            // 
            this.txt_MaLichTrinh.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaLichTrinh.Location = new System.Drawing.Point(332, 115);
            this.txt_MaLichTrinh.Name = "txt_MaLichTrinh";
            this.txt_MaLichTrinh.Size = new System.Drawing.Size(255, 29);
            this.txt_MaLichTrinh.TabIndex = 128;
            // 
            // dgv_DanhSachLichTrinh
            // 
            this.dgv_DanhSachLichTrinh.AllowUserToAddRows = false;
            this.dgv_DanhSachLichTrinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_DanhSachLichTrinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachLichTrinh.Location = new System.Drawing.Point(233, 320);
            this.dgv_DanhSachLichTrinh.Name = "dgv_DanhSachLichTrinh";
            this.dgv_DanhSachLichTrinh.RowHeadersWidth = 51;
            this.dgv_DanhSachLichTrinh.RowTemplate.Height = 24;
            this.dgv_DanhSachLichTrinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachLichTrinh.Size = new System.Drawing.Size(941, 223);
            this.dgv_DanhSachLichTrinh.TabIndex = 129;
            this.dgv_DanhSachLichTrinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachLichTrinh_CellClick);
            // 
            // UsCtrl_QLLichTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.dgv_DanhSachLichTrinh);
            this.Controls.Add(this.txt_MaLichTrinh);
            this.Controls.Add(this.btn_QLTramDungChan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_GioKhoiHanh);
            this.Controls.Add(this.dtp_NgayKhoiHanh);
            this.Controls.Add(this.cbo_Xe);
            this.Controls.Add(this.cbo_TuyenDuong);
            this.Controls.Add(this.btn_ThemLichTrinh);
            this.Controls.Add(this.btn_CapNhatLichTrinh);
            this.Controls.Add(this.txt_GiaVe);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "UsCtrl_QLLichTrinh";
            this.Size = new System.Drawing.Size(1471, 577);
            this.Load += new System.EventHandler(this.UsCtrl_QLLichTrinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachLichTrinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_NgayKhoiHanh;
        private System.Windows.Forms.ComboBox cbo_Xe;
        private System.Windows.Forms.Button btn_ThemLichTrinh;
        private System.Windows.Forms.Button btn_CapNhatLichTrinh;
        private System.Windows.Forms.TextBox txt_GiaVe;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_TuyenDuong;
        private System.Windows.Forms.DateTimePicker dtp_GioKhoiHanh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_QLTramDungChan;
        private System.Windows.Forms.TextBox txt_MaLichTrinh;
        private System.Windows.Forms.DataGridView dgv_DanhSachLichTrinh;
    }
}
