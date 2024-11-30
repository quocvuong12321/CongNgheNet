
namespace GUI
{
    partial class UsCtrl_ThongKeDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsCtrl_ThongKeDoanhThu));
            this.panel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_timTheoThang = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_XuatBaoCaoTheoThang = new System.Windows.Forms.Button();
            this.cbo_Nam = new System.Windows.Forms.ComboBox();
            this.cbo_Thang = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_timTheoNgay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_Ngay = new System.Windows.Forms.DateTimePicker();
            this.btn_XuatBaoCaoTheoNgay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Ve = new System.Windows.Forms.DataGridView();
            this.panel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ve)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.LightBlue;
            this.panel.Controls.Add(this.groupBox2);
            this.panel.Controls.Add(this.groupBox1);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.dgv_Ve);
            this.panel.Location = new System.Drawing.Point(-4, -40);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1479, 853);
            this.panel.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_timTheoThang);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_XuatBaoCaoTheoThang);
            this.groupBox2.Controls.Add(this.cbo_Nam);
            this.groupBox2.Controls.Add(this.cbo_Thang);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(226, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(901, 75);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc dữ liệu theo tháng";
            // 
            // btn_timTheoThang
            // 
            this.btn_timTheoThang.Location = new System.Drawing.Point(537, 20);
            this.btn_timTheoThang.Name = "btn_timTheoThang";
            this.btn_timTheoThang.Size = new System.Drawing.Size(112, 43);
            this.btn_timTheoThang.TabIndex = 20;
            this.btn_timTheoThang.Text = "Tìm";
            this.btn_timTheoThang.UseVisualStyleBackColor = true;
            this.btn_timTheoThang.Click += new System.EventHandler(this.btn_timTheoThang_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tháng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Năm";
            // 
            // btn_XuatBaoCaoTheoThang
            // 
            this.btn_XuatBaoCaoTheoThang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatBaoCaoTheoThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_XuatBaoCaoTheoThang.Image = ((System.Drawing.Image)(resources.GetObject("btn_XuatBaoCaoTheoThang.Image")));
            this.btn_XuatBaoCaoTheoThang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XuatBaoCaoTheoThang.Location = new System.Drawing.Point(727, 16);
            this.btn_XuatBaoCaoTheoThang.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XuatBaoCaoTheoThang.Name = "btn_XuatBaoCaoTheoThang";
            this.btn_XuatBaoCaoTheoThang.Size = new System.Drawing.Size(167, 52);
            this.btn_XuatBaoCaoTheoThang.TabIndex = 7;
            this.btn_XuatBaoCaoTheoThang.Text = "Xuất báo cáo";
            this.btn_XuatBaoCaoTheoThang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_XuatBaoCaoTheoThang.UseVisualStyleBackColor = true;
            this.btn_XuatBaoCaoTheoThang.Click += new System.EventHandler(this.btn_XuatBaoCaoTheoThang_Click);
            // 
            // cbo_Nam
            // 
            this.cbo_Nam.FormattingEnabled = true;
            this.cbo_Nam.Location = new System.Drawing.Point(373, 27);
            this.cbo_Nam.Name = "cbo_Nam";
            this.cbo_Nam.Size = new System.Drawing.Size(100, 28);
            this.cbo_Nam.TabIndex = 19;
            // 
            // cbo_Thang
            // 
            this.cbo_Thang.FormattingEnabled = true;
            this.cbo_Thang.Location = new System.Drawing.Point(168, 27);
            this.cbo_Thang.Name = "cbo_Thang";
            this.cbo_Thang.Size = new System.Drawing.Size(100, 28);
            this.cbo_Thang.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_timTheoNgay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtp_Ngay);
            this.groupBox1.Controls.Add(this.btn_XuatBaoCaoTheoNgay);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(226, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 82);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc dữ liệu theo ngày";
            // 
            // btn_timTheoNgay
            // 
            this.btn_timTheoNgay.Location = new System.Drawing.Point(537, 21);
            this.btn_timTheoNgay.Name = "btn_timTheoNgay";
            this.btn_timTheoNgay.Size = new System.Drawing.Size(112, 43);
            this.btn_timTheoNgay.TabIndex = 15;
            this.btn_timTheoNgay.Text = "Tìm";
            this.btn_timTheoNgay.UseVisualStyleBackColor = true;
            this.btn_timTheoNgay.Click += new System.EventHandler(this.btn_timTheoNgay_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(58, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chọn ngày";
            // 
            // dtp_Ngay
            // 
            this.dtp_Ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Ngay.Location = new System.Drawing.Point(168, 29);
            this.dtp_Ngay.Name = "dtp_Ngay";
            this.dtp_Ngay.Size = new System.Drawing.Size(305, 26);
            this.dtp_Ngay.TabIndex = 14;
            this.dtp_Ngay.Value = new System.DateTime(2024, 11, 1, 0, 0, 0, 0);
            // 
            // btn_XuatBaoCaoTheoNgay
            // 
            this.btn_XuatBaoCaoTheoNgay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatBaoCaoTheoNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_XuatBaoCaoTheoNgay.Image = ((System.Drawing.Image)(resources.GetObject("btn_XuatBaoCaoTheoNgay.Image")));
            this.btn_XuatBaoCaoTheoNgay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XuatBaoCaoTheoNgay.Location = new System.Drawing.Point(727, 16);
            this.btn_XuatBaoCaoTheoNgay.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XuatBaoCaoTheoNgay.Name = "btn_XuatBaoCaoTheoNgay";
            this.btn_XuatBaoCaoTheoNgay.Size = new System.Drawing.Size(167, 52);
            this.btn_XuatBaoCaoTheoNgay.TabIndex = 7;
            this.btn_XuatBaoCaoTheoNgay.Text = "Xuất báo cáo";
            this.btn_XuatBaoCaoTheoNgay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_XuatBaoCaoTheoNgay.UseVisualStyleBackColor = true;
            this.btn_XuatBaoCaoTheoNgay.Click += new System.EventHandler(this.btn_XuatBaoCaoTheoNgay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(546, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "THỐNG KÊ DOANH THU";
            // 
            // dgv_Ve
            // 
            this.dgv_Ve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Ve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ve.Location = new System.Drawing.Point(198, 321);
            this.dgv_Ve.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Ve.Name = "dgv_Ve";
            this.dgv_Ve.RowHeadersWidth = 51;
            this.dgv_Ve.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Ve.Size = new System.Drawing.Size(993, 253);
            this.dgv_Ve.TabIndex = 9;
            // 
            // UsCtrl_ThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "UsCtrl_ThongKeDoanhThu";
            this.Size = new System.Drawing.Size(1471, 773);
            this.Load += new System.EventHandler(this.UsCtrl_ThongKeDoanhThu_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ve)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView dgv_Ve;
        private System.Windows.Forms.Button btn_XuatBaoCaoTheoNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_Ngay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_timTheoThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_Nam;
        private System.Windows.Forms.ComboBox cbo_Thang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_timTheoNgay;
        private System.Windows.Forms.Button btn_XuatBaoCaoTheoThang;
    }
}
