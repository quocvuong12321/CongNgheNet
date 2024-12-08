
namespace GUI
{
    partial class UsCtrl_QLTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsCtrl_QLTaiKhoan));
            this.dgv_DanhSachTaiKhoan = new System.Windows.Forms.DataGridView();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_ThemNhanVien = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_SoDienThoai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_LoaiTaiKhoan = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbo_GioiTinh = new System.Windows.Forms.ComboBox();
            this.lable_12 = new System.Windows.Forms.Label();
            this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
            this.btn_XuatBaoCaoNhanVien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DanhSachTaiKhoan
            // 
            this.dgv_DanhSachTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachTaiKhoan.Location = new System.Drawing.Point(77, 267);
            this.dgv_DanhSachTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_DanhSachTaiKhoan.Name = "dgv_DanhSachTaiKhoan";
            this.dgv_DanhSachTaiKhoan.RowHeadersWidth = 51;
            this.dgv_DanhSachTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachTaiKhoan.Size = new System.Drawing.Size(1189, 256);
            this.dgv_DanhSachTaiKhoan.TabIndex = 42;
            this.dgv_DanhSachTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachTaiKhoan_CellClick);
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.Red;
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.ForeColor = System.Drawing.Color.Snow;
            this.btn_Huy.Location = new System.Drawing.Point(834, 202);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(174, 57);
            this.btn_Huy.TabIndex = 40;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.Color.Snow;
            this.btn_Luu.Location = new System.Drawing.Point(598, 202);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(174, 57);
            this.btn_Luu.TabIndex = 39;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.ForeColor = System.Drawing.Color.Goldenrod;
            this.btn_CapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btn_CapNhat.Image")));
            this.btn_CapNhat.Location = new System.Drawing.Point(362, 202);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(174, 57);
            this.btn_CapNhat.TabIndex = 37;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_ThemNhanVien
            // 
            this.btn_ThemNhanVien.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ThemNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemNhanVien.ForeColor = System.Drawing.Color.Green;
            this.btn_ThemNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemNhanVien.Image")));
            this.btn_ThemNhanVien.Location = new System.Drawing.Point(126, 202);
            this.btn_ThemNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThemNhanVien.Name = "btn_ThemNhanVien";
            this.btn_ThemNhanVien.Size = new System.Drawing.Size(174, 57);
            this.btn_ThemNhanVien.TabIndex = 36;
            this.btn_ThemNhanVien.Text = "Thêm nhân viên";
            this.btn_ThemNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ThemNhanVien.UseVisualStyleBackColor = false;
            this.btn_ThemNhanVien.Click += new System.EventHandler(this.btn_ThemNhanVien_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(109, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(109, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Họ và tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(516, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 40);
            this.label1.TabIndex = 29;
            this.label1.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(245, 105);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_HoTen.Multiline = true;
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(190, 26);
            this.txt_HoTen.TabIndex = 30;
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.Location = new System.Drawing.Point(245, 145);
            this.txt_SoDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoDienThoai.Multiline = true;
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(190, 26);
            this.txt_SoDienThoai.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(476, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 24);
            this.label7.TabIndex = 35;
            this.label7.Text = "Loại tài khoản";
            // 
            // cbo_LoaiTaiKhoan
            // 
            this.cbo_LoaiTaiKhoan.FormattingEnabled = true;
            this.cbo_LoaiTaiKhoan.Location = new System.Drawing.Point(619, 146);
            this.cbo_LoaiTaiKhoan.Name = "cbo_LoaiTaiKhoan";
            this.cbo_LoaiTaiKhoan.Size = new System.Drawing.Size(190, 24);
            this.cbo_LoaiTaiKhoan.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(837, 99);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 24);
            this.label8.TabIndex = 31;
            this.label8.Text = "Địa chỉ";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(929, 99);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(283, 69);
            this.txt_DiaChi.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(476, 101);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 24);
            this.label9.TabIndex = 31;
            this.label9.Text = "Giới tính";
            // 
            // cbo_GioiTinh
            // 
            this.cbo_GioiTinh.FormattingEnabled = true;
            this.cbo_GioiTinh.Location = new System.Drawing.Point(619, 99);
            this.cbo_GioiTinh.Name = "cbo_GioiTinh";
            this.cbo_GioiTinh.Size = new System.Drawing.Size(190, 24);
            this.cbo_GioiTinh.TabIndex = 43;
            // 
            // lable_12
            // 
            this.lable_12.AutoSize = true;
            this.lable_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lable_12.ForeColor = System.Drawing.Color.Red;
            this.lable_12.Location = new System.Drawing.Point(109, 68);
            this.lable_12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lable_12.Name = "lable_12";
            this.lable_12.Size = new System.Drawing.Size(97, 24);
            this.lable_12.TabIndex = 33;
            this.lable_12.Text = "Username";
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.Location = new System.Drawing.Point(245, 65);
            this.txt_TaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TaiKhoan.Multiline = true;
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(190, 26);
            this.txt_TaiKhoan.TabIndex = 30;
            // 
            // btn_XuatBaoCaoNhanVien
            // 
            this.btn_XuatBaoCaoNhanVien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatBaoCaoNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_XuatBaoCaoNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btn_XuatBaoCaoNhanVien.Image")));
            this.btn_XuatBaoCaoNhanVien.Location = new System.Drawing.Point(1070, 202);
            this.btn_XuatBaoCaoNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XuatBaoCaoNhanVien.Name = "btn_XuatBaoCaoNhanVien";
            this.btn_XuatBaoCaoNhanVien.Size = new System.Drawing.Size(174, 57);
            this.btn_XuatBaoCaoNhanVien.TabIndex = 45;
            this.btn_XuatBaoCaoNhanVien.Text = "Xuất báo cáo";
            this.btn_XuatBaoCaoNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_XuatBaoCaoNhanVien.UseVisualStyleBackColor = true;
            this.btn_XuatBaoCaoNhanVien.Click += new System.EventHandler(this.btn_XuatBaoCaoNhanVien_Click);
            // 
            // UsCtrl_QLTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.btn_XuatBaoCaoNhanVien);
            this.Controls.Add(this.cbo_GioiTinh);
            this.Controls.Add(this.cbo_LoaiTaiKhoan);
            this.Controls.Add(this.dgv_DanhSachTaiKhoan);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.btn_ThemNhanVien);
            this.Controls.Add(this.txt_SoDienThoai);
            this.Controls.Add(this.txt_TaiKhoan);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lable_12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "UsCtrl_QLTaiKhoan";
            this.Size = new System.Drawing.Size(1337, 652);
            this.Load += new System.EventHandler(this.UsCtrl_QLTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DanhSachTaiKhoan;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_ThemNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_SoDienThoai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_LoaiTaiKhoan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbo_GioiTinh;
        private System.Windows.Forms.Label lable_12;
        private System.Windows.Forms.TextBox txt_TaiKhoan;
        private System.Windows.Forms.Button btn_XuatBaoCaoNhanVien;
    }
}
