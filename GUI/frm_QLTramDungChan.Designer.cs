
namespace GUI
{
    partial class frm_QLTramDungChan
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
            this.lst_DiemDi = new System.Windows.Forms.ListBox();
            this.cbb_DanhSachMaLichTrinh = new System.Windows.Forms.ComboBox();
            this.txt_DiemDi = new System.Windows.Forms.TextBox();
            this.txt_DiemDen = new System.Windows.Forms.TextBox();
            this.lst_DiemDen = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_DanhSachTramDungChanTheoMaLichTrinh = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.dgv_DanhSachTramDungChan = new System.Windows.Forms.DataGridView();
            this.btn_ThemTramDungChan = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_XoaTramDungChan = new System.Windows.Forms.Button();
            this.txt_MaTramDungChan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenTramDungChan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_DiaDiem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachTramDungChanTheoMaLichTrinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachTramDungChan)).BeginInit();
            this.SuspendLayout();
            // 
            // lst_DiemDi
            // 
            this.lst_DiemDi.FormattingEnabled = true;
            this.lst_DiemDi.ItemHeight = 16;
            this.lst_DiemDi.Location = new System.Drawing.Point(25, 139);
            this.lst_DiemDi.Name = "lst_DiemDi";
            this.lst_DiemDi.Size = new System.Drawing.Size(251, 212);
            this.lst_DiemDi.TabIndex = 0;
            // 
            // cbb_DanhSachMaLichTrinh
            // 
            this.cbb_DanhSachMaLichTrinh.FormattingEnabled = true;
            this.cbb_DanhSachMaLichTrinh.Location = new System.Drawing.Point(25, 48);
            this.cbb_DanhSachMaLichTrinh.Name = "cbb_DanhSachMaLichTrinh";
            this.cbb_DanhSachMaLichTrinh.Size = new System.Drawing.Size(315, 24);
            this.cbb_DanhSachMaLichTrinh.TabIndex = 1;
            // 
            // txt_DiemDi
            // 
            this.txt_DiemDi.Location = new System.Drawing.Point(122, 101);
            this.txt_DiemDi.Name = "txt_DiemDi";
            this.txt_DiemDi.Size = new System.Drawing.Size(154, 22);
            this.txt_DiemDi.TabIndex = 2;
            // 
            // txt_DiemDen
            // 
            this.txt_DiemDen.Location = new System.Drawing.Point(404, 101);
            this.txt_DiemDen.Name = "txt_DiemDen";
            this.txt_DiemDen.Size = new System.Drawing.Size(154, 22);
            this.txt_DiemDen.TabIndex = 2;
            // 
            // lst_DiemDen
            // 
            this.lst_DiemDen.FormattingEnabled = true;
            this.lst_DiemDen.ItemHeight = 16;
            this.lst_DiemDen.Location = new System.Drawing.Point(307, 139);
            this.lst_DiemDen.Name = "lst_DiemDen";
            this.lst_DiemDen.Size = new System.Drawing.Size(251, 212);
            this.lst_DiemDen.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh Sách Mã Lịch Trình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(21, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Điểm đi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(303, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Điểm đến";
            // 
            // dgv_DanhSachTramDungChanTheoMaLichTrinh
            // 
            this.dgv_DanhSachTramDungChanTheoMaLichTrinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachTramDungChanTheoMaLichTrinh.Location = new System.Drawing.Point(25, 428);
            this.dgv_DanhSachTramDungChanTheoMaLichTrinh.Name = "dgv_DanhSachTramDungChanTheoMaLichTrinh";
            this.dgv_DanhSachTramDungChanTheoMaLichTrinh.RowHeadersWidth = 51;
            this.dgv_DanhSachTramDungChanTheoMaLichTrinh.RowTemplate.Height = 24;
            this.dgv_DanhSachTramDungChanTheoMaLichTrinh.Size = new System.Drawing.Size(533, 155);
            this.dgv_DanhSachTramDungChanTheoMaLichTrinh.TabIndex = 6;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.White;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(150, 368);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(92, 43);
            this.btn_Them.TabIndex = 7;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.White;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(339, 368);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(89, 43);
            this.btn_Xoa.TabIndex = 9;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // dgv_DanhSachTramDungChan
            // 
            this.dgv_DanhSachTramDungChan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachTramDungChan.Location = new System.Drawing.Point(645, 63);
            this.dgv_DanhSachTramDungChan.Name = "dgv_DanhSachTramDungChan";
            this.dgv_DanhSachTramDungChan.RowHeadersWidth = 51;
            this.dgv_DanhSachTramDungChan.RowTemplate.Height = 24;
            this.dgv_DanhSachTramDungChan.Size = new System.Drawing.Size(396, 235);
            this.dgv_DanhSachTramDungChan.TabIndex = 10;
            // 
            // btn_ThemTramDungChan
            // 
            this.btn_ThemTramDungChan.BackColor = System.Drawing.Color.White;
            this.btn_ThemTramDungChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemTramDungChan.Location = new System.Drawing.Point(663, 320);
            this.btn_ThemTramDungChan.Name = "btn_ThemTramDungChan";
            this.btn_ThemTramDungChan.Size = new System.Drawing.Size(85, 50);
            this.btn_ThemTramDungChan.TabIndex = 7;
            this.btn_ThemTramDungChan.Text = "Thêm";
            this.btn_ThemTramDungChan.UseVisualStyleBackColor = false;
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.White;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(796, 320);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(85, 50);
            this.btn_Sua.TabIndex = 9;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            // 
            // btn_XoaTramDungChan
            // 
            this.btn_XoaTramDungChan.BackColor = System.Drawing.Color.White;
            this.btn_XoaTramDungChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaTramDungChan.Location = new System.Drawing.Point(929, 320);
            this.btn_XoaTramDungChan.Name = "btn_XoaTramDungChan";
            this.btn_XoaTramDungChan.Size = new System.Drawing.Size(85, 50);
            this.btn_XoaTramDungChan.TabIndex = 9;
            this.btn_XoaTramDungChan.Text = "Xóa";
            this.btn_XoaTramDungChan.UseVisualStyleBackColor = false;
            // 
            // txt_MaTramDungChan
            // 
            this.txt_MaTramDungChan.Location = new System.Drawing.Point(845, 459);
            this.txt_MaTramDungChan.Name = "txt_MaTramDungChan";
            this.txt_MaTramDungChan.Size = new System.Drawing.Size(196, 22);
            this.txt_MaTramDungChan.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(642, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã Trạm Dừng Chân";
            // 
            // txt_TenTramDungChan
            // 
            this.txt_TenTramDungChan.Location = new System.Drawing.Point(845, 503);
            this.txt_TenTramDungChan.Name = "txt_TenTramDungChan";
            this.txt_TenTramDungChan.Size = new System.Drawing.Size(196, 22);
            this.txt_TenTramDungChan.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(642, 503);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên Trạm Dừng Chân";
            // 
            // cbo_DiaDiem
            // 
            this.cbo_DiaDiem.FormattingEnabled = true;
            this.cbo_DiaDiem.Location = new System.Drawing.Point(845, 411);
            this.cbo_DiaDiem.Name = "cbo_DiaDiem";
            this.cbo_DiaDiem.Size = new System.Drawing.Size(196, 24);
            this.cbo_DiaDiem.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(642, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Địa điểm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(709, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(266, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Danh Sách Trạm Dừng Chân";
            // 
            // frm_QLTramDungChan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1075, 604);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbo_DiaDiem);
            this.Controls.Add(this.dgv_DanhSachTramDungChan);
            this.Controls.Add(this.btn_XoaTramDungChan);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_ThemTramDungChan);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dgv_DanhSachTramDungChanTheoMaLichTrinh);
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
            this.Controls.Add(this.cbb_DanhSachMaLichTrinh);
            this.Controls.Add(this.lst_DiemDen);
            this.Controls.Add(this.lst_DiemDi);
            this.Name = "frm_QLTramDungChan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Trạm Dừng Chân";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_QLTramDungChan_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachTramDungChanTheoMaLichTrinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachTramDungChan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_DiemDi;
        private System.Windows.Forms.ComboBox cbb_DanhSachMaLichTrinh;
        private System.Windows.Forms.TextBox txt_DiemDi;
        private System.Windows.Forms.TextBox txt_DiemDen;
        private System.Windows.Forms.ListBox lst_DiemDen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_DanhSachTramDungChanTheoMaLichTrinh;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView dgv_DanhSachTramDungChan;
        private System.Windows.Forms.Button btn_ThemTramDungChan;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_XoaTramDungChan;
        private System.Windows.Forms.TextBox txt_MaTramDungChan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TenTramDungChan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_DiaDiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}