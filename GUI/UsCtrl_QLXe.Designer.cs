﻿
namespace GUI
{
    partial class UsCtrl_QLXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsCtrl_QLXe));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ThemXe = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_XoaXe = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.txt_MaXe = new System.Windows.Forms.TextBox();
            this.btn_HienThi = new System.Windows.Forms.Button();
            this.dgv_DanhSachXe = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBienSoXe = new System.Windows.Forms.TextBox();
            this.dtp_NgayThem = new System.Windows.Forms.DateTimePicker();
            this.cbo_SoGhe = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachXe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(602, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ XE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(323, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(323, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày thêm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(323, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số ghế";
            // 
            // btn_ThemXe
            // 
            this.btn_ThemXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemXe.ForeColor = System.Drawing.Color.Green;
            this.btn_ThemXe.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemXe.Image")));
            this.btn_ThemXe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemXe.Location = new System.Drawing.Point(311, 231);
            this.btn_ThemXe.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThemXe.Name = "btn_ThemXe";
            this.btn_ThemXe.Size = new System.Drawing.Size(137, 50);
            this.btn_ThemXe.TabIndex = 4;
            this.btn_ThemXe.Text = "Thêm xe";
            this.btn_ThemXe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ThemXe.UseVisualStyleBackColor = true;
            this.btn_ThemXe.Click += new System.EventHandler(this.btn_ThemXe_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.ForeColor = System.Drawing.Color.Goldenrod;
            this.btn_CapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btn_CapNhat.Image")));
            this.btn_CapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CapNhat.Location = new System.Drawing.Point(486, 231);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(137, 50);
            this.btn_CapNhat.TabIndex = 5;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CapNhat.UseVisualStyleBackColor = true;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_XoaXe
            // 
            this.btn_XoaXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaXe.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaXe.Image")));
            this.btn_XoaXe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaXe.Location = new System.Drawing.Point(660, 231);
            this.btn_XoaXe.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XoaXe.Name = "btn_XoaXe";
            this.btn_XoaXe.Size = new System.Drawing.Size(137, 50);
            this.btn_XoaXe.TabIndex = 6;
            this.btn_XoaXe.Text = "Xóa xe";
            this.btn_XoaXe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XoaXe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_XoaXe.UseVisualStyleBackColor = true;
            this.btn_XoaXe.Click += new System.EventHandler(this.btn_XoaXe_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.Red;
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.ForeColor = System.Drawing.Color.Snow;
            this.btn_Huy.Location = new System.Drawing.Point(918, 96);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(168, 51);
            this.btn_Huy.TabIndex = 8;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // txt_MaXe
            // 
            this.txt_MaXe.Location = new System.Drawing.Point(444, 90);
            this.txt_MaXe.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaXe.Name = "txt_MaXe";
            this.txt_MaXe.Size = new System.Drawing.Size(148, 24);
            this.txt_MaXe.TabIndex = 1;
            // 
            // btn_HienThi
            // 
            this.btn_HienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HienThi.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_HienThi.Image = ((System.Drawing.Image)(resources.GetObject("btn_HienThi.Image")));
            this.btn_HienThi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_HienThi.Location = new System.Drawing.Point(835, 231);
            this.btn_HienThi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_HienThi.Name = "btn_HienThi";
            this.btn_HienThi.Size = new System.Drawing.Size(283, 50);
            this.btn_HienThi.TabIndex = 9;
            this.btn_HienThi.Text = "Hiển thị danh sách xe";
            this.btn_HienThi.UseVisualStyleBackColor = true;
            this.btn_HienThi.Click += new System.EventHandler(this.btn_HienThi_Click);
            // 
            // dgv_DanhSachXe
            // 
            this.dgv_DanhSachXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachXe.Location = new System.Drawing.Point(219, 299);
            this.dgv_DanhSachXe.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_DanhSachXe.Name = "dgv_DanhSachXe";
            this.dgv_DanhSachXe.RowHeadersWidth = 51;
            this.dgv_DanhSachXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachXe.Size = new System.Drawing.Size(948, 312);
            this.dgv_DanhSachXe.TabIndex = 28;
            this.dgv_DanhSachXe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachXe_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(631, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "Biển số xe";
            // 
            // txtBienSoXe
            // 
            this.txtBienSoXe.Location = new System.Drawing.Point(727, 90);
            this.txtBienSoXe.Margin = new System.Windows.Forms.Padding(4);
            this.txtBienSoXe.Name = "txtBienSoXe";
            this.txtBienSoXe.Size = new System.Drawing.Size(148, 24);
            this.txtBienSoXe.TabIndex = 30;
            // 
            // dtp_NgayThem
            // 
            this.dtp_NgayThem.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayThem.Location = new System.Drawing.Point(444, 130);
            this.dtp_NgayThem.Name = "dtp_NgayThem";
            this.dtp_NgayThem.Size = new System.Drawing.Size(431, 24);
            this.dtp_NgayThem.TabIndex = 31;
            // 
            // cbo_SoGhe
            // 
            this.cbo_SoGhe.FormattingEnabled = true;
            this.cbo_SoGhe.Location = new System.Drawing.Point(444, 175);
            this.cbo_SoGhe.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_SoGhe.Name = "cbo_SoGhe";
            this.cbo_SoGhe.Size = new System.Drawing.Size(124, 25);
            this.cbo_SoGhe.TabIndex = 3;
            // 
            // UsCtrl_QLXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.dtp_NgayThem);
            this.Controls.Add(this.txtBienSoXe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_DanhSachXe);
            this.Controls.Add(this.btn_HienThi);
            this.Controls.Add(this.cbo_SoGhe);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_XoaXe);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.btn_ThemXe);
            this.Controls.Add(this.txt_MaXe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UsCtrl_QLXe";
            this.Size = new System.Drawing.Size(1463, 637);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ThemXe;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_XoaXe;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.TextBox txt_MaXe;
        private System.Windows.Forms.Button btn_HienThi;
        private System.Windows.Forms.DataGridView dgv_DanhSachXe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBienSoXe;
        private System.Windows.Forms.DateTimePicker dtp_NgayThem;
        private System.Windows.Forms.ComboBox cbo_SoGhe;
    }
}
