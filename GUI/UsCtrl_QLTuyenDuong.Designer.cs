
namespace GUI
{
    partial class UsCtrl_QLTuyenDuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsCtrl_QLTuyenDuong));
            this.cbbDiemDen = new System.Windows.Forms.ComboBox();
            this.cbbDiemDi = new System.Windows.Forms.ComboBox();
            this.dgvDanhSachTuyenDuong = new System.Windows.Forms.DataGridView();
            this.btnXoaTuyenDuong = new System.Windows.Forms.Button();
            this.btnThemTuyenDuong = new System.Windows.Forms.Button();
            this.btnCapNhatTuyenDuong = new System.Windows.Forms.Button();
            this.txtKhoangCach = new System.Windows.Forms.TextBox();
            this.txtTenTuyenDuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ThoiGianDuKien = new System.Windows.Forms.TextBox();
            this.btn_Huy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTuyenDuong)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbDiemDen
            // 
            this.cbbDiemDen.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDiemDen.FormattingEnabled = true;
            this.cbbDiemDen.Location = new System.Drawing.Point(912, 160);
            this.cbbDiemDen.Name = "cbbDiemDen";
            this.cbbDiemDen.Size = new System.Drawing.Size(229, 29);
            this.cbbDiemDen.TabIndex = 102;
            // 
            // cbbDiemDi
            // 
            this.cbbDiemDi.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDiemDi.FormattingEnabled = true;
            this.cbbDiemDi.Location = new System.Drawing.Point(912, 112);
            this.cbbDiemDi.Name = "cbbDiemDi";
            this.cbbDiemDi.Size = new System.Drawing.Size(229, 29);
            this.cbbDiemDi.TabIndex = 101;
            // 
            // dgvDanhSachTuyenDuong
            // 
            this.dgvDanhSachTuyenDuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachTuyenDuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachTuyenDuong.Location = new System.Drawing.Point(271, 345);
            this.dgvDanhSachTuyenDuong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDanhSachTuyenDuong.Name = "dgvDanhSachTuyenDuong";
            this.dgvDanhSachTuyenDuong.RowHeadersWidth = 51;
            this.dgvDanhSachTuyenDuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachTuyenDuong.Size = new System.Drawing.Size(862, 193);
            this.dgvDanhSachTuyenDuong.TabIndex = 98;
            this.dgvDanhSachTuyenDuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachTuyenDuong_CellClick);
            // 
            // btnXoaTuyenDuong
            // 
            this.btnXoaTuyenDuong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoaTuyenDuong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTuyenDuong.ForeColor = System.Drawing.Color.Red;
            this.btnXoaTuyenDuong.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaTuyenDuong.Image")));
            this.btnXoaTuyenDuong.Location = new System.Drawing.Point(911, 271);
            this.btnXoaTuyenDuong.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaTuyenDuong.Name = "btnXoaTuyenDuong";
            this.btnXoaTuyenDuong.Size = new System.Drawing.Size(221, 57);
            this.btnXoaTuyenDuong.TabIndex = 94;
            this.btnXoaTuyenDuong.Text = "Xóa tuyến đường";
            this.btnXoaTuyenDuong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaTuyenDuong.UseVisualStyleBackColor = false;
            this.btnXoaTuyenDuong.Click += new System.EventHandler(this.btnXoaTuyenDuong_Click);
            // 
            // btnThemTuyenDuong
            // 
            this.btnThemTuyenDuong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThemTuyenDuong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTuyenDuong.ForeColor = System.Drawing.Color.Green;
            this.btnThemTuyenDuong.Image = ((System.Drawing.Image)(resources.GetObject("btnThemTuyenDuong.Image")));
            this.btnThemTuyenDuong.Location = new System.Drawing.Point(271, 271);
            this.btnThemTuyenDuong.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemTuyenDuong.Name = "btnThemTuyenDuong";
            this.btnThemTuyenDuong.Size = new System.Drawing.Size(221, 57);
            this.btnThemTuyenDuong.TabIndex = 90;
            this.btnThemTuyenDuong.Text = "Thêm tuyến đường";
            this.btnThemTuyenDuong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemTuyenDuong.UseVisualStyleBackColor = false;
            this.btnThemTuyenDuong.Click += new System.EventHandler(this.btnThemTuyenDuong_Click);
            // 
            // btnCapNhatTuyenDuong
            // 
            this.btnCapNhatTuyenDuong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCapNhatTuyenDuong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatTuyenDuong.ForeColor = System.Drawing.Color.Orange;
            this.btnCapNhatTuyenDuong.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatTuyenDuong.Image")));
            this.btnCapNhatTuyenDuong.Location = new System.Drawing.Point(591, 271);
            this.btnCapNhatTuyenDuong.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhatTuyenDuong.Name = "btnCapNhatTuyenDuong";
            this.btnCapNhatTuyenDuong.Size = new System.Drawing.Size(237, 57);
            this.btnCapNhatTuyenDuong.TabIndex = 91;
            this.btnCapNhatTuyenDuong.Text = "Cập nhật tuyến đường";
            this.btnCapNhatTuyenDuong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapNhatTuyenDuong.UseVisualStyleBackColor = false;
            this.btnCapNhatTuyenDuong.Click += new System.EventHandler(this.btnCapNhatTuyenDuong_Click);
            // 
            // txtKhoangCach
            // 
            this.txtKhoangCach.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhoangCach.Location = new System.Drawing.Point(405, 159);
            this.txtKhoangCach.Margin = new System.Windows.Forms.Padding(4);
            this.txtKhoangCach.Multiline = true;
            this.txtKhoangCach.Name = "txtKhoangCach";
            this.txtKhoangCach.Size = new System.Drawing.Size(229, 26);
            this.txtKhoangCach.TabIndex = 74;
            this.txtKhoangCach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKhoangCach_KeyPress);
            // 
            // txtTenTuyenDuong
            // 
            this.txtTenTuyenDuong.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTuyenDuong.Location = new System.Drawing.Point(405, 109);
            this.txtTenTuyenDuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenTuyenDuong.Multiline = true;
            this.txtTenTuyenDuong.Name = "txtTenTuyenDuong";
            this.txtTenTuyenDuong.Size = new System.Drawing.Size(229, 26);
            this.txtTenTuyenDuong.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(225, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 88;
            this.label4.Text = "Khoảng cách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(780, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 87;
            this.label6.Text = "Điểm đến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(225, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 21);
            this.label3.TabIndex = 83;
            this.label3.Text = "Tên tuyến đường";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(780, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 21);
            this.label8.TabIndex = 80;
            this.label8.Text = "Điểm đi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(482, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 40);
            this.label1.TabIndex = 69;
            this.label1.Text = "QUẢN LÝ TUYẾN ĐƯỜNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(225, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 88;
            this.label2.Text = "Thời gian dự kiến";
            // 
            // txt_ThoiGianDuKien
            // 
            this.txt_ThoiGianDuKien.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThoiGianDuKien.Location = new System.Drawing.Point(405, 206);
            this.txt_ThoiGianDuKien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ThoiGianDuKien.Multiline = true;
            this.txt_ThoiGianDuKien.Name = "txt_ThoiGianDuKien";
            this.txt_ThoiGianDuKien.Size = new System.Drawing.Size(229, 26);
            this.txt_ThoiGianDuKien.TabIndex = 74;
            this.txt_ThoiGianDuKien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ThoiGianDuKien_KeyPress);
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.Red;
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.ForeColor = System.Drawing.Color.Snow;
            this.btn_Huy.Location = new System.Drawing.Point(911, 212);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(112, 33);
            this.btn_Huy.TabIndex = 104;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // UsCtrl_QLTuyenDuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.cbbDiemDen);
            this.Controls.Add(this.cbbDiemDi);
            this.Controls.Add(this.dgvDanhSachTuyenDuong);
            this.Controls.Add(this.btnXoaTuyenDuong);
            this.Controls.Add(this.btnThemTuyenDuong);
            this.Controls.Add(this.btnCapNhatTuyenDuong);
            this.Controls.Add(this.txt_ThoiGianDuKien);
            this.Controls.Add(this.txtKhoangCach);
            this.Controls.Add(this.txtTenTuyenDuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "UsCtrl_QLTuyenDuong";
            this.Size = new System.Drawing.Size(1471, 559);
            this.Load += new System.EventHandler(this.UsCtrl_QLTuyenDuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTuyenDuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbDiemDen;
        private System.Windows.Forms.ComboBox cbbDiemDi;
        private System.Windows.Forms.DataGridView dgvDanhSachTuyenDuong;
        private System.Windows.Forms.Button btnXoaTuyenDuong;
        private System.Windows.Forms.Button btnThemTuyenDuong;
        private System.Windows.Forms.Button btnCapNhatTuyenDuong;
        private System.Windows.Forms.TextBox txtKhoangCach;
        private System.Windows.Forms.TextBox txtTenTuyenDuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ThoiGianDuKien;
        private System.Windows.Forms.Button btn_Huy;
    }
}
