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
            this.cbo_SoGhe = new System.Windows.Forms.ComboBox();
            this.txtBienSoXe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_DanhSachXe = new System.Windows.Forms.DataGridView();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_XoaXe = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_ThemXe = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachXe)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_SoGhe
            // 
            this.cbo_SoGhe.FormattingEnabled = true;
            this.cbo_SoGhe.Location = new System.Drawing.Point(980, 157);
            this.cbo_SoGhe.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_SoGhe.Name = "cbo_SoGhe";
            this.cbo_SoGhe.Size = new System.Drawing.Size(124, 29);
            this.cbo_SoGhe.TabIndex = 3;
            // 
            // txtBienSoXe
            // 
            this.txtBienSoXe.Location = new System.Drawing.Point(647, 157);
            this.txtBienSoXe.Margin = new System.Windows.Forms.Padding(4);
            this.txtBienSoXe.Name = "txtBienSoXe";
            this.txtBienSoXe.Size = new System.Drawing.Size(148, 28);
            this.txtBienSoXe.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(527, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Biển số xe";
            // 
            // dgv_DanhSachXe
            // 
            this.dgv_DanhSachXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachXe.Location = new System.Drawing.Point(346, 337);
            this.dgv_DanhSachXe.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_DanhSachXe.Name = "dgv_DanhSachXe";
            this.dgv_DanhSachXe.RowHeadersWidth = 51;
            this.dgv_DanhSachXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachXe.Size = new System.Drawing.Size(1198, 352);
            this.dgv_DanhSachXe.TabIndex = 28;
            this.dgv_DanhSachXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachXe_CellClick);
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.Red;
            this.btn_Huy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.ForeColor = System.Drawing.Color.Snow;
            this.btn_Huy.Location = new System.Drawing.Point(1293, 249);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(210, 61);
            this.btn_Huy.TabIndex = 8;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_XoaXe
            // 
            this.btn_XoaXe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_XoaXe.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaXe.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaXe.Image")));
            this.btn_XoaXe.Location = new System.Drawing.Point(994, 249);
            this.btn_XoaXe.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XoaXe.Name = "btn_XoaXe";
            this.btn_XoaXe.Size = new System.Drawing.Size(210, 61);
            this.btn_XoaXe.TabIndex = 6;
            this.btn_XoaXe.Text = "Xóa xe";
            this.btn_XoaXe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XoaXe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_XoaXe.UseVisualStyleBackColor = false;
            this.btn_XoaXe.Click += new System.EventHandler(this.btn_XoaXe_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CapNhat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.ForeColor = System.Drawing.Color.Goldenrod;
            this.btn_CapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btn_CapNhat.Image")));
            this.btn_CapNhat.Location = new System.Drawing.Point(695, 249);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(210, 61);
            this.btn_CapNhat.TabIndex = 5;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_ThemXe
            // 
            this.btn_ThemXe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ThemXe.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemXe.ForeColor = System.Drawing.Color.Green;
            this.btn_ThemXe.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemXe.Image")));
            this.btn_ThemXe.Location = new System.Drawing.Point(396, 249);
            this.btn_ThemXe.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThemXe.Name = "btn_ThemXe";
            this.btn_ThemXe.Size = new System.Drawing.Size(210, 61);
            this.btn_ThemXe.TabIndex = 4;
            this.btn_ThemXe.Text = "Thêm xe";
            this.btn_ThemXe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ThemXe.UseVisualStyleBackColor = false;
            this.btn_ThemXe.Click += new System.EventHandler(this.btn_ThemXe_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(859, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số ghế";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(796, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ XE";
            // 
            // UsCtrl_QLXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.txtBienSoXe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_DanhSachXe);
            this.Controls.Add(this.cbo_SoGhe);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_XoaXe);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.btn_ThemXe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UsCtrl_QLXe";
            this.Size = new System.Drawing.Size(1661, 760);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_SoGhe;
        private System.Windows.Forms.TextBox txtBienSoXe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_DanhSachXe;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_XoaXe;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_ThemXe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}
