﻿using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_Main : Form
    {
        
        public string MaNV;
        public UsCtrl_BanVe usBV;

        public string role;

        LichTrinhBLL ltBll = new LichTrinhBLL();
        public frm_Main()
        {
            InitializeComponent();

            ltBll.CapNhatTrangThaiLichTrinh();
        }

        public void checkQuyen(string Role)
        {
            if(Role.Equals("Nhân viên"))
            {
                tsb_QLLichTrinh.Enabled = false;
                tsb_QLTuyenDuong.Enabled = false;
                //tsb_QLLichTrinh.Enabled = false;
                tsb_QLXe.Enabled = false;
                tsb_QLTaiKhoan.Enabled = false;
            }
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            panel.Dock = DockStyle.Fill;
        }
        public void setTenNV(string name,string manv)
        {
            MaNV = manv;
            tsb_TenNV.Text = "Chào, "+name;
        }

        public void MoUsCtrl(UserControl us)
        {
            panel.Controls.Clear();
            us.Dock = DockStyle.Fill;//fill cho vừa với panel
            panel.Controls.Add(us);
        }

        private void tsb_QLXe_Click(object sender, EventArgs e)
        {
            UsCtrl_QLXe us = new UsCtrl_QLXe();
            panel.Controls.Clear();
            us.Dock = DockStyle.Fill;//fill cho vừa với panel
            panel.Controls.Add(us);
        }

        private void tsb_QLTaiKhoan_Click(object sender, EventArgs e)
        {
            UsCtrl_QLTaiKhoan us = new UsCtrl_QLTaiKhoan();
            panel.Controls.Clear();
            us.Dock = DockStyle.Fill;
            panel.Controls.Add(us);
        }

        private void tsb_QLTuyenDuong_Click(object sender, EventArgs e)
        {
            UsCtrl_QLTuyenDuong us = new UsCtrl_QLTuyenDuong();
            panel.Controls.Clear();
            us.Dock = DockStyle.Fill;
            panel.Controls.Add(us);
        }

       
        private void tsb_QLVe_Click(object sender, EventArgs e)
        {
            UsCtrl_QLVe us = new UsCtrl_QLVe();
            panel.Controls.Clear();
            us.Dock = DockStyle.Fill;
            panel.Controls.Add(us);
        }

        

        private void tsb_BanVe_Click(object sender, EventArgs e)
        {
            UsCtrl_BanVe usBV = new UsCtrl_BanVe();
            panel.Controls.Clear();
            usBV.getMaNV(MaNV);
            usBV.Dock = DockStyle.Fill;
            panel.Controls.Add(usBV);
        }

        private void tsb_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void tsb_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r == DialogResult.Yes)
            {
                this.Hide();
                frm_DangNhap frm = new frm_DangNhap();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Sau khi đăng nhập thành công, hiển thị lại form chính
                    this.Show();
                }
                else
                {
                    // Thoát ứng dụng nếu người dùng đóng form đăng nhập mà không đăng nhập lại
                    this.Close();
                }
            }
           
        }

        private void tsb_DoanhThu_Click(object sender, EventArgs e)
        {
            UsCtrl_ThongKeDoanhThu us = new UsCtrl_ThongKeDoanhThu();
            panel.Controls.Clear();
            us.Dock = DockStyle.Fill;
            panel.Controls.Add(us);

        }

        private void tsb_QLLichTrinh_Click(object sender, EventArgs e)
        {
            UsCtrl_QLLichTrinh us = new UsCtrl_QLLichTrinh(this);
            panel.Controls.Clear();
            us.Dock = DockStyle.Fill;
            panel.Controls.Add(us);
        }

        private void tsb_TenNV_Click(object sender, EventArgs e)
        {
            UsCtrl_ThongTinNhanVien us = new UsCtrl_ThongTinNhanVien(this);
            panel.Controls.Clear();
            us.Dock = DockStyle.Fill;
            panel.Controls.Add(us);
        }
    }
}
