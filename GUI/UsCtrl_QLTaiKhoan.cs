using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class UsCtrl_QLTaiKhoan : UserControl
    {
        NhanVienBLL nvBLL = new NhanVienBLL();
        public UsCtrl_QLTaiKhoan()
        {
            InitializeComponent();
        }

        private void UsCtrl_QLTaiKhoan_Load(object sender, EventArgs e)
        {
            loadGioiTinh();
            loadLoaiTK();
        }

        private void loadLoaiTK()
        {
            string[] loainv = { "Quản lý", "Nhân viên"};
            foreach (string item in loainv)
            {
                cbo_LoaiTaiKhoan.Items.Add(item);
            }

            dgv_DanhSachTaiKhoan.DataSource = nvBLL.LoadNhanVien();
        }

        private void loadGioiTinh()
        {
            string[] gioitinh = { "Nam", "Nữ" };
            foreach(string item in gioitinh)
            {
                cbo_GioiTinh.Items.Add(item);
            }
        }
        //private bool isCreate = false;
        private void btn_ThemNhanVien_Click(object sender, EventArgs e)
        {
            isEditing = false;
            txt_TaiKhoan.Clear();
            txt_SoDienThoai.Clear();
            txt_HoTen.Clear();
            txt_DiaChi.Clear();
            cbo_LoaiTaiKhoan.SelectedItem = null;
            cbo_GioiTinh.SelectedItem = null;
            btn_Luu.Enabled = true;
        }

        private bool isEditing = false;
        private void dgv_DanhSachTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgv_DanhSachTaiKhoan.SelectedRows[0];
            txt_TaiKhoan.Text = dr.Cells[0].Value.ToString();
            txt_HoTen.Text = dr.Cells[1].Value.ToString();
            txt_SoDienThoai.Text = dr.Cells[2].Value.ToString();
            cbo_GioiTinh.SelectedItem = dr.Cells[3].Value.ToString();
            txt_DiaChi.Text = dr.Cells[4].Value.ToString();
            cbo_LoaiTaiKhoan.SelectedItem = dr.Cells[5].Value.ToString();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            isEditing = true;
            txt_TaiKhoan.Enabled = false;
            btn_Luu.Enabled = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường bắt buộc không được để trống
            if (string.IsNullOrWhiteSpace(txt_TaiKhoan.Text))
            {
                MessageBox.Show("Vui lòng nhập username.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TaiKhoan.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_HoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_HoTen.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_SoDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SoDienThoai.Focus();
                return;
            }
            if (cbo_GioiTinh.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn giới tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbo_GioiTinh.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_DiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_DiaChi.Focus();
                return;
            }
            if (cbo_LoaiTaiKhoan.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbo_LoaiTaiKhoan.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_SoDienThoai.Text) || txt_SoDienThoai.Text.Length != 10 || !txt_SoDienThoai.Text.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại phải là 10 ký tự và chỉ chứa số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (isEditing)
            {
                string username = txt_TaiKhoan.Text; 
                NHANVIEN nvSua = new NHANVIEN
                {
                    HOTEN = txt_HoTen.Text,
                    SO_DT = txt_SoDienThoai.Text,
                    GIOITINH = cbo_GioiTinh.SelectedItem.ToString(),
                    LOAINV = cbo_LoaiTaiKhoan.SelectedItem.ToString(),
                    DIACHI = txt_DiaChi.Text
                };
                if (nvBLL.update(username, nvSua))
                {
                    MessageBox.Show("Lưu thành công");
                }
                else
                {
                    MessageBox.Show("Lưu Thất bại");
                }
            }
            else
            {
                NHANVIEN nv = new NHANVIEN
                {
                    USERNAME = txt_TaiKhoan.Text,
                    MAT_KHAU = "1",
                    HOTEN = txt_HoTen.Text,
                    SO_DT = txt_SoDienThoai.Text,
                    GIOITINH = cbo_GioiTinh.SelectedItem.ToString(),
                    DIACHI = txt_DiaChi.Text,
                    LOAINV = cbo_LoaiTaiKhoan.SelectedItem.ToString()
                };
                MessageBox.Show(nvBLL.Insert(nv) ? "Thêm thành công" : "Thêm thất bại");
            }

            dgv_DanhSachTaiKhoan.DataSource = null;
            dgv_DanhSachTaiKhoan.DataSource = nvBLL.LoadNhanVien();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            btn_Luu.Enabled = false;
            txt_TaiKhoan.Enabled = true;
            txt_TaiKhoan.Clear();
            txt_SoDienThoai.Clear();
            txt_HoTen.Clear();
            txt_DiaChi.Clear();
            cbo_LoaiTaiKhoan.SelectedItem = null;
            cbo_GioiTinh.SelectedItem = null;
        }

        private void btn_XuatBaoCaoNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                //int thang = int.Parse(cbo_Thang.SelectedItem.ToString());
                //int nam = int.Parse(cbo_Nam.SelectedItem.ToString());

                // Mở form báo cáo
                frm_BaoCaoNhanVienTheoThang frmBaoCao = new frm_BaoCaoNhanVienTheoThang();
                frmBaoCao.LoadReportNhanVienTheoThang();
                frmBaoCao.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
