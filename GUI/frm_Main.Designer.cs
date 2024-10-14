
namespace GUI
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_HeThong = new System.Windows.Forms.TabPage();
            this.panel = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_QLTaiKhoan = new System.Windows.Forms.ToolStripButton();
            this.tsb_DangXuat = new System.Windows.Forms.ToolStripButton();
            this.tsb_Thoat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_QLVe = new System.Windows.Forms.ToolStripButton();
            this.tsb_QLTuyenDuong = new System.Windows.Forms.ToolStripButton();
            this.tsb_QLXe = new System.Windows.Forms.ToolStripButton();
            this.tsb_BanVe = new System.Windows.Forms.ToolStripButton();
            this.tsb_DoanhThu = new System.Windows.Forms.ToolStripButton();
            this.tsp_TenNV = new System.Windows.Forms.ToolStripButton();
            this.tab_TroGiup = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tab_HeThong.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_HeThong);
            this.tabControl1.Controls.Add(this.tab_TroGiup);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1368, 760);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Tag = "";
            // 
            // tab_HeThong
            // 
            this.tab_HeThong.Controls.Add(this.panel);
            this.tab_HeThong.Controls.Add(this.toolStrip1);
            this.tab_HeThong.Location = new System.Drawing.Point(4, 33);
            this.tab_HeThong.Name = "tab_HeThong";
            this.tab_HeThong.Padding = new System.Windows.Forms.Padding(3);
            this.tab_HeThong.Size = new System.Drawing.Size(1360, 723);
            this.tab_HeThong.TabIndex = 0;
            this.tab_HeThong.Text = "Hệ thống";
            this.tab_HeThong.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(8, 82);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1339, 635);
            this.panel.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_QLTaiKhoan,
            this.tsb_DangXuat,
            this.tsb_Thoat,
            this.toolStripSeparator1,
            this.tsb_QLVe,
            this.tsb_QLTuyenDuong,
            this.tsb_QLXe,
            this.tsb_BanVe,
            this.tsb_DoanhThu,
            this.tsp_TenNV});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1354, 75);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_QLTaiKhoan
            // 
            this.tsb_QLTaiKhoan.AutoSize = false;
            this.tsb_QLTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("tsb_QLTaiKhoan.Image")));
            this.tsb_QLTaiKhoan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_QLTaiKhoan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_QLTaiKhoan.Name = "tsb_QLTaiKhoan";
            this.tsb_QLTaiKhoan.Size = new System.Drawing.Size(128, 72);
            this.tsb_QLTaiKhoan.Text = "Quản lý tài khoản";
            this.tsb_QLTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_QLTaiKhoan.Click += new System.EventHandler(this.tsb_QLTaiKhoan_Click);
            // 
            // tsb_DangXuat
            // 
            this.tsb_DangXuat.Image = ((System.Drawing.Image)(resources.GetObject("tsb_DangXuat.Image")));
            this.tsb_DangXuat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_DangXuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_DangXuat.Name = "tsb_DangXuat";
            this.tsb_DangXuat.Size = new System.Drawing.Size(81, 72);
            this.tsb_DangXuat.Text = "Đăng xuất";
            this.tsb_DangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_DangXuat.ToolTipText = "Đăng xuất\r\n";
            this.tsb_DangXuat.Click += new System.EventHandler(this.tsb_DangXuat_Click);
            // 
            // tsb_Thoat
            // 
            this.tsb_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Thoat.Image")));
            this.tsb_Thoat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_Thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Thoat.Name = "tsb_Thoat";
            this.tsb_Thoat.Size = new System.Drawing.Size(52, 72);
            this.tsb_Thoat.Text = "Thoát";
            this.tsb_Thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_Thoat.Click += new System.EventHandler(this.tsb_Thoat_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 75);
            // 
            // tsb_QLVe
            // 
            this.tsb_QLVe.Image = ((System.Drawing.Image)(resources.GetObject("tsb_QLVe.Image")));
            this.tsb_QLVe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_QLVe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_QLVe.Name = "tsb_QLVe";
            this.tsb_QLVe.Size = new System.Drawing.Size(82, 72);
            this.tsb_QLVe.Text = "Quản lý vé";
            this.tsb_QLVe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_QLVe.Click += new System.EventHandler(this.tsb_QLVe_Click);
            // 
            // tsb_QLTuyenDuong
            // 
            this.tsb_QLTuyenDuong.Image = ((System.Drawing.Image)(resources.GetObject("tsb_QLTuyenDuong.Image")));
            this.tsb_QLTuyenDuong.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_QLTuyenDuong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_QLTuyenDuong.Name = "tsb_QLTuyenDuong";
            this.tsb_QLTuyenDuong.Size = new System.Drawing.Size(122, 72);
            this.tsb_QLTuyenDuong.Text = "QL Tuyến đường";
            this.tsb_QLTuyenDuong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_QLTuyenDuong.Click += new System.EventHandler(this.tsb_QLTuyenDuong_Click);
            // 
            // tsb_QLXe
            // 
            this.tsb_QLXe.Image = ((System.Drawing.Image)(resources.GetObject("tsb_QLXe.Image")));
            this.tsb_QLXe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_QLXe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_QLXe.Name = "tsb_QLXe";
            this.tsb_QLXe.Size = new System.Drawing.Size(82, 72);
            this.tsb_QLXe.Text = "Quản lý xe";
            this.tsb_QLXe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_QLXe.Click += new System.EventHandler(this.tsb_QLXe_Click);
            // 
            // tsb_BanVe
            // 
            this.tsb_BanVe.Image = ((System.Drawing.Image)(resources.GetObject("tsb_BanVe.Image")));
            this.tsb_BanVe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_BanVe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_BanVe.Name = "tsb_BanVe";
            this.tsb_BanVe.Size = new System.Drawing.Size(57, 72);
            this.tsb_BanVe.Text = "Bán vé";
            this.tsb_BanVe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_BanVe.Click += new System.EventHandler(this.tsb_BanVe_Click);
            // 
            // tsb_DoanhThu
            // 
            this.tsb_DoanhThu.Image = ((System.Drawing.Image)(resources.GetObject("tsb_DoanhThu.Image")));
            this.tsb_DoanhThu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_DoanhThu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_DoanhThu.Name = "tsb_DoanhThu";
            this.tsb_DoanhThu.Size = new System.Drawing.Size(82, 72);
            this.tsb_DoanhThu.Text = "Doanh thu";
            this.tsb_DoanhThu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_DoanhThu.Click += new System.EventHandler(this.tsb_DoanhThu_Click);
            // 
            // tsp_TenNV
            // 
            this.tsp_TenNV.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsp_TenNV.Image = ((System.Drawing.Image)(resources.GetObject("tsp_TenNV.Image")));
            this.tsp_TenNV.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsp_TenNV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsp_TenNV.Name = "tsp_TenNV";
            this.tsp_TenNV.Size = new System.Drawing.Size(52, 72);
            this.tsp_TenNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tab_TroGiup
            // 
            this.tab_TroGiup.Location = new System.Drawing.Point(4, 33);
            this.tab_TroGiup.Name = "tab_TroGiup";
            this.tab_TroGiup.Padding = new System.Windows.Forms.Padding(3);
            this.tab_TroGiup.Size = new System.Drawing.Size(1360, 723);
            this.tab_TroGiup.TabIndex = 1;
            this.tab_TroGiup.Text = "Trợ giúp";
            this.tab_TroGiup.UseVisualStyleBackColor = true;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 774);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tab_HeThong.ResumeLayout(false);
            this.tab_HeThong.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_HeThong;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_QLTaiKhoan;
        private System.Windows.Forms.ToolStripButton tsb_DangXuat;
        private System.Windows.Forms.ToolStripButton tsb_Thoat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsb_QLVe;
        private System.Windows.Forms.ToolStripButton tsb_QLTuyenDuong;
        private System.Windows.Forms.ToolStripButton tsb_QLXe;
        private System.Windows.Forms.ToolStripButton tsb_BanVe;
        private System.Windows.Forms.ToolStripButton tsb_DoanhThu;
        private System.Windows.Forms.ToolStripButton tsp_TenNV;
        private System.Windows.Forms.TabPage tab_TroGiup;
        private System.Windows.Forms.Panel panel;
    }
}

