
namespace GUI
{
    partial class UsCtrl_QLVe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsCtrl_QLVe));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_XoaVe = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.dgv_DSVe = new System.Windows.Forms.DataGridView();
            this.cbo_LichTrinh = new System.Windows.Forms.ComboBox();
            this.cbo_TrangThai = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_Loc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSVe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(521, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH VÉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lọc vé";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(593, 139);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(414, 29);
            this.txt_TimKiem.TabIndex = 3;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.Color.White;
            this.btn_CapNhat.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btn_CapNhat.Image")));
            this.btn_CapNhat.Location = new System.Drawing.Point(255, 221);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(135, 46);
            this.btn_CapNhat.TabIndex = 27;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            // 
            // btn_XoaVe
            // 
            this.btn_XoaVe.BackColor = System.Drawing.Color.White;
            this.btn_XoaVe.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaVe.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaVe.Image")));
            this.btn_XoaVe.Location = new System.Drawing.Point(483, 221);
            this.btn_XoaVe.Name = "btn_XoaVe";
            this.btn_XoaVe.Size = new System.Drawing.Size(135, 46);
            this.btn_XoaVe.TabIndex = 28;
            this.btn_XoaVe.Text = "Xóa vé";
            this.btn_XoaVe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_XoaVe.UseVisualStyleBackColor = false;
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.Green;
            this.btn_Luu.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Luu.Location = new System.Drawing.Point(711, 221);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(135, 46);
            this.btn_Luu.TabIndex = 30;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Huy.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Huy.Location = new System.Drawing.Point(939, 221);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(135, 46);
            this.btn_Huy.TabIndex = 31;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = false;
            // 
            // dgv_DSVe
            // 
            this.dgv_DSVe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSVe.ColumnHeadersHeight = 29;
            this.dgv_DSVe.Location = new System.Drawing.Point(95, 273);
            this.dgv_DSVe.Name = "dgv_DSVe";
            this.dgv_DSVe.RowHeadersWidth = 51;
            this.dgv_DSVe.RowTemplate.Height = 24;
            this.dgv_DSVe.Size = new System.Drawing.Size(1127, 251);
            this.dgv_DSVe.TabIndex = 32;
            // 
            // cbo_LichTrinh
            // 
            this.cbo_LichTrinh.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_LichTrinh.FormattingEnabled = true;
            this.cbo_LichTrinh.Location = new System.Drawing.Point(337, 71);
            this.cbo_LichTrinh.Name = "cbo_LichTrinh";
            this.cbo_LichTrinh.Size = new System.Drawing.Size(257, 30);
            this.cbo_LichTrinh.TabIndex = 36;
            // 
            // cbo_TrangThai
            // 
            this.cbo_TrangThai.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_TrangThai.FormattingEnabled = true;
            this.cbo_TrangThai.Location = new System.Drawing.Point(758, 71);
            this.cbo_TrangThai.Name = "cbo_TrangThai";
            this.cbo_TrangThai.Size = new System.Drawing.Size(249, 30);
            this.cbo_TrangThai.TabIndex = 37;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(642, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 23);
            this.label15.TabIndex = 38;
            this.label15.Text = "Trạng thái";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(246, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 23);
            this.label16.TabIndex = 39;
            this.label16.Text = "Lịch trình";
            // 
            // btn_Loc
            // 
            this.btn_Loc.BackColor = System.Drawing.Color.White;
            this.btn_Loc.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Loc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Loc.Location = new System.Drawing.Point(1052, 69);
            this.btn_Loc.Name = "btn_Loc";
            this.btn_Loc.Size = new System.Drawing.Size(125, 35);
            this.btn_Loc.TabIndex = 40;
            this.btn_Loc.Text = "Lọc";
            this.btn_Loc.UseVisualStyleBackColor = false;
            this.btn_Loc.Click += new System.EventHandler(this.btn_Loc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(425, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 41;
            this.label3.Text = "Tìm kiếm";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.White;
            this.btn_TimKiem.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(1052, 136);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(125, 35);
            this.btn_TimKiem.TabIndex = 42;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // UsCtrl_QLVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Loc);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbo_TrangThai);
            this.Controls.Add(this.cbo_LichTrinh);
            this.Controls.Add(this.dgv_DSVe);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_XoaVe);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UsCtrl_QLVe";
            this.Size = new System.Drawing.Size(1278, 563);
            this.Load += new System.EventHandler(this.UsCtrl_QLVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_XoaVe;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.DataGridView dgv_DSVe;
        private System.Windows.Forms.ComboBox cbo_LichTrinh;
        private System.Windows.Forms.ComboBox cbo_TrangThai;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_Loc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_TimKiem;
    }
}
