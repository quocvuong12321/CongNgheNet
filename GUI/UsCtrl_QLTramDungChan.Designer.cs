
namespace GUI
{
    partial class UsCtrl_QLTramDungChan
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
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_DiaDiem = new System.Windows.Forms.ComboBox();
            this.dgv_DanhSachTramDungChan = new System.Windows.Forms.DataGridView();
            this.btn_XoaTramDungChan = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_ThemTramDungChan = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dgv_DanhSachTramDungChanDiemDi = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TenTramDungChan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaTramDungChan = new System.Windows.Forms.TextBox();
            this.txt_DiemDen = new System.Windows.Forms.TextBox();
            this.txt_DiemDi = new System.Windows.Forms.TextBox();
            this.cbo_DanhSachMaLichTrinh = new System.Windows.Forms.ComboBox();
            this.lst_DiemDen = new System.Windows.Forms.ListBox();
            this.lst_DiemDi = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_DanhSachTramDungChanDiemTra = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachTramDungChan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachTramDungChanDiemDi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachTramDungChanDiemTra)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(950, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(266, 25);
            this.label7.TabIndex = 34;
            this.label7.Text = "Danh Sách Trạm Dừng Chân";
            // 
            // cbo_DiaDiem
            // 
            this.cbo_DiaDiem.FormattingEnabled = true;
            this.cbo_DiaDiem.Location = new System.Drawing.Point(1012, 89);
            this.cbo_DiaDiem.Name = "cbo_DiaDiem";
            this.cbo_DiaDiem.Size = new System.Drawing.Size(245, 24);
            this.cbo_DiaDiem.TabIndex = 33;
            this.cbo_DiaDiem.SelectedValueChanged += new System.EventHandler(this.cbo_DiaDiem_SelectedValueChanged);
            // 
            // dgv_DanhSachTramDungChan
            // 
            this.dgv_DanhSachTramDungChan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachTramDungChan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachTramDungChan.Location = new System.Drawing.Point(861, 180);
            this.dgv_DanhSachTramDungChan.Name = "dgv_DanhSachTramDungChan";
            this.dgv_DanhSachTramDungChan.RowHeadersWidth = 51;
            this.dgv_DanhSachTramDungChan.RowTemplate.Height = 24;
            this.dgv_DanhSachTramDungChan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachTramDungChan.Size = new System.Drawing.Size(396, 188);
            this.dgv_DanhSachTramDungChan.TabIndex = 32;
            // 
            // btn_XoaTramDungChan
            // 
            this.btn_XoaTramDungChan.BackColor = System.Drawing.Color.White;
            this.btn_XoaTramDungChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaTramDungChan.Location = new System.Drawing.Point(1148, 486);
            this.btn_XoaTramDungChan.Name = "btn_XoaTramDungChan";
            this.btn_XoaTramDungChan.Size = new System.Drawing.Size(85, 50);
            this.btn_XoaTramDungChan.TabIndex = 31;
            this.btn_XoaTramDungChan.Text = "Xóa";
            this.btn_XoaTramDungChan.UseVisualStyleBackColor = false;
            this.btn_XoaTramDungChan.Click += new System.EventHandler(this.btn_XoaTramDungChan_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.White;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(1015, 486);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(85, 50);
            this.btn_Sua.TabIndex = 30;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.White;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(445, 325);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(89, 43);
            this.btn_Xoa.TabIndex = 29;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btn_ThemTramDungChan
            // 
            this.btn_ThemTramDungChan.BackColor = System.Drawing.Color.White;
            this.btn_ThemTramDungChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemTramDungChan.Location = new System.Drawing.Point(882, 486);
            this.btn_ThemTramDungChan.Name = "btn_ThemTramDungChan";
            this.btn_ThemTramDungChan.Size = new System.Drawing.Size(85, 50);
            this.btn_ThemTramDungChan.TabIndex = 28;
            this.btn_ThemTramDungChan.Text = "Thêm";
            this.btn_ThemTramDungChan.UseVisualStyleBackColor = false;
            this.btn_ThemTramDungChan.Click += new System.EventHandler(this.btn_ThemTramDungChan_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.White;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(256, 325);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(92, 43);
            this.btn_Them.TabIndex = 27;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            // 
            // dgv_DanhSachTramDungChanDiemDi
            // 
            this.dgv_DanhSachTramDungChanDiemDi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachTramDungChanDiemDi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachTramDungChanDiemDi.Location = new System.Drawing.Point(83, 384);
            this.dgv_DanhSachTramDungChanDiemDi.Name = "dgv_DanhSachTramDungChanDiemDi";
            this.dgv_DanhSachTramDungChanDiemDi.RowHeadersWidth = 51;
            this.dgv_DanhSachTramDungChanDiemDi.RowTemplate.Height = 24;
            this.dgv_DanhSachTramDungChanDiemDi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachTramDungChanDiemDi.Size = new System.Drawing.Size(299, 181);
            this.dgv_DanhSachTramDungChanDiemDi.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(409, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Điểm đến";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(859, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tên Trạm Dừng Chân";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(858, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Địa điểm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(859, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Mã Trạm Dừng Chân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(127, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Điểm đi";
            // 
            // txt_TenTramDungChan
            // 
            this.txt_TenTramDungChan.Location = new System.Drawing.Point(1062, 443);
            this.txt_TenTramDungChan.Name = "txt_TenTramDungChan";
            this.txt_TenTramDungChan.Size = new System.Drawing.Size(196, 22);
            this.txt_TenTramDungChan.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(128, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Danh Sách Mã Lịch Trình";
            // 
            // txt_MaTramDungChan
            // 
            this.txt_MaTramDungChan.Location = new System.Drawing.Point(1062, 399);
            this.txt_MaTramDungChan.Name = "txt_MaTramDungChan";
            this.txt_MaTramDungChan.Size = new System.Drawing.Size(196, 22);
            this.txt_MaTramDungChan.TabIndex = 18;
            // 
            // txt_DiemDen
            // 
            this.txt_DiemDen.Location = new System.Drawing.Point(510, 142);
            this.txt_DiemDen.Name = "txt_DiemDen";
            this.txt_DiemDen.ReadOnly = true;
            this.txt_DiemDen.Size = new System.Drawing.Size(154, 22);
            this.txt_DiemDen.TabIndex = 17;
            this.txt_DiemDen.TextChanged += new System.EventHandler(this.txt_DiemDen_TextChanged);
            // 
            // txt_DiemDi
            // 
            this.txt_DiemDi.Location = new System.Drawing.Point(228, 142);
            this.txt_DiemDi.Name = "txt_DiemDi";
            this.txt_DiemDi.ReadOnly = true;
            this.txt_DiemDi.Size = new System.Drawing.Size(154, 22);
            this.txt_DiemDi.TabIndex = 16;
            this.txt_DiemDi.TextChanged += new System.EventHandler(this.txt_DiemDi_TextChanged);
            // 
            // cbo_DanhSachMaLichTrinh
            // 
            this.cbo_DanhSachMaLichTrinh.FormattingEnabled = true;
            this.cbo_DanhSachMaLichTrinh.Location = new System.Drawing.Point(131, 89);
            this.cbo_DanhSachMaLichTrinh.Name = "cbo_DanhSachMaLichTrinh";
            this.cbo_DanhSachMaLichTrinh.Size = new System.Drawing.Size(315, 24);
            this.cbo_DanhSachMaLichTrinh.TabIndex = 15;
            this.cbo_DanhSachMaLichTrinh.SelectedIndexChanged += new System.EventHandler(this.cbo_DanhSachMaLichTrinh_SelectedIndexChanged);
            // 
            // lst_DiemDen
            // 
            this.lst_DiemDen.FormattingEnabled = true;
            this.lst_DiemDen.ItemHeight = 16;
            this.lst_DiemDen.Location = new System.Drawing.Point(413, 180);
            this.lst_DiemDen.Name = "lst_DiemDen";
            this.lst_DiemDen.Size = new System.Drawing.Size(251, 132);
            this.lst_DiemDen.TabIndex = 14;
            // 
            // lst_DiemDi
            // 
            this.lst_DiemDi.FormattingEnabled = true;
            this.lst_DiemDi.ItemHeight = 16;
            this.lst_DiemDi.Location = new System.Drawing.Point(131, 180);
            this.lst_DiemDi.Name = "lst_DiemDi";
            this.lst_DiemDi.Size = new System.Drawing.Size(251, 132);
            this.lst_DiemDi.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(504, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(487, 40);
            this.label8.TabIndex = 71;
            this.label8.Text = "QUẢN LÝ TRẠM DỪNG CHÂN";
            // 
            // dgv_DanhSachTramDungChanDiemTra
            // 
            this.dgv_DanhSachTramDungChanDiemTra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachTramDungChanDiemTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachTramDungChanDiemTra.Location = new System.Drawing.Point(413, 384);
            this.dgv_DanhSachTramDungChanDiemTra.Name = "dgv_DanhSachTramDungChanDiemTra";
            this.dgv_DanhSachTramDungChanDiemTra.RowHeadersWidth = 51;
            this.dgv_DanhSachTramDungChanDiemTra.RowTemplate.Height = 24;
            this.dgv_DanhSachTramDungChanDiemTra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachTramDungChanDiemTra.Size = new System.Drawing.Size(299, 181);
            this.dgv_DanhSachTramDungChanDiemTra.TabIndex = 26;
            // 
            // UsCtrl_QLTramDungChan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbo_DiaDiem);
            this.Controls.Add(this.dgv_DanhSachTramDungChan);
            this.Controls.Add(this.btn_XoaTramDungChan);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_ThemTramDungChan);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dgv_DanhSachTramDungChanDiemTra);
            this.Controls.Add(this.dgv_DanhSachTramDungChanDiemDi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TenTramDungChan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MaTramDungChan);
            this.Controls.Add(this.txt_DiemDen);
            this.Controls.Add(this.txt_DiemDi);
            this.Controls.Add(this.cbo_DanhSachMaLichTrinh);
            this.Controls.Add(this.lst_DiemDen);
            this.Controls.Add(this.lst_DiemDi);
            this.Name = "UsCtrl_QLTramDungChan";
            this.Size = new System.Drawing.Size(1471, 700);
            this.Load += new System.EventHandler(this.UsCtrl_QLTramDungChan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachTramDungChan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachTramDungChanDiemDi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachTramDungChanDiemTra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_DiaDiem;
        private System.Windows.Forms.DataGridView dgv_DanhSachTramDungChan;
        private System.Windows.Forms.Button btn_XoaTramDungChan;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_ThemTramDungChan;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dgv_DanhSachTramDungChanDiemDi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TenTramDungChan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaTramDungChan;
        private System.Windows.Forms.TextBox txt_DiemDen;
        private System.Windows.Forms.TextBox txt_DiemDi;
        private System.Windows.Forms.ComboBox cbo_DanhSachMaLichTrinh;
        private System.Windows.Forms.ListBox lst_DiemDen;
        private System.Windows.Forms.ListBox lst_DiemDi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_DanhSachTramDungChanDiemTra;
    }
}
