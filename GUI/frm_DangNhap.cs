using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frm_DangNhap : Form
    {
        NhanVienBLL nvBLL = new NhanVienBLL();
        frm_Main frm_Main;
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        public frm_DangNhap(frm_Main frm_Main)
        {
            InitializeComponent();
            this.frm_Main = frm_Main;
        }
        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            txt_TaiKhoan.Text = "Nhập Email hoặc SĐT";
            txt_TaiKhoan.ForeColor = Color.Gray;
        }

        
        private void txt_TaiKhoan_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TaiKhoan.Text))
            {
                txt_TaiKhoan.Text = "Nhập Email hoặc SĐT";
                txt_TaiKhoan.ForeColor = Color.Gray;
            }
        }

        private void txt_TaiKhoan_Enter(object sender, EventArgs e)
        {
            txt_TaiKhoan.Text = "";
            txt_TaiKhoan.ForeColor = Color.Black;
        }

        private void txt_MatKhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MatKhau.Text))
            {
                txt_MatKhau.UseSystemPasswordChar = false;
                txt_MatKhau.Text = "Nhập mật khẩu";
                txt_MatKhau.ForeColor = Color.Gray;
            }
        }

        private void txt_MatKhau_Enter(object sender, EventArgs e)
        {
            txt_MatKhau.UseSystemPasswordChar = true;
            txt_MatKhau.Text = "";
            txt_MatKhau.ForeColor = Color.Black;
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (nvBLL.Login(txt_TaiKhoan.Text, txt_MatKhau.Text))
            {
                frm_Main frm = new frm_Main();
                frm.role = nvBLL.getRoleNhanVien(txt_TaiKhoan.Text);
                string name = nvBLL.getTenNV(txt_TaiKhoan.Text);
                frm.setTenNV(name,txt_TaiKhoan.Text);
                frm.checkQuyen(frm.role);
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tài khoản");
            } 
                
        }

        private void toolStripButton_Restore_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Backup Files (*.bak)|*.bak";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string backupPath = openFileDialog.FileName;
                    RestoreBLL bll = new RestoreBLL();
                    if (bll.RestoreDatabase(backupPath))
                    {
                        MessageBox.Show("Restore successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton_BackUp_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Backup Files (*.bak)|*.bak";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string backupPath = saveFileDialog.FileName;
                    BackupBLL bll = new BackupBLL();
                    if (bll.BackupDatabase(backupPath))
                    {
                        MessageBox.Show("Backup successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void chk_HienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_HienThiMK.Checked == true)
            {
                txt_MatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txt_MatKhau.UseSystemPasswordChar = true;
            }
        }
    }
}
