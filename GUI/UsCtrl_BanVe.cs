﻿using System;
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
    public partial class UsCtrl_BanVe : UserControl
    {
        DiaDiemBLL ddBLL = new DiaDiemBLL();
        LichTrinhBLL ltBLL = new LichTrinhBLL();
        DatVeBLL dvBLL = new DatVeBLL();
        GheBLL gBLL = new GheBLL();
        private List<string> gheDaChon;
        private double giaVe;
        private string maVe;
        private string MaNhanVien;
        public UsCtrl_BanVe()
        {
            InitializeComponent();
            gheDaChon = new List<string>();

        }

        public void getMaNV(string manv)
        {
            MaNhanVien = manv;
        }

        private void loadCboDiaDiem()
        {
            cbo_DiemDi.DataSource = ddBLL.loadDiaDiem();
            cbo_DiemDi.DisplayMember = "TEN_TINH_THANH";
            cbo_DiemDi.ValueMember = "ID_DIADIEM";
            cbo_DiemDen.DataSource = ddBLL.loadDiaDiem();
            cbo_DiemDen.DisplayMember = "TEN_TINH_THANH";
            cbo_DiemDen.ValueMember = "ID_DIADIEM";
        }

        private void loadCboThanhToan()
        {
            string[] ThanhToan = { "Tiền mặt", "Chuyển khoản" };

            cboThanhToan.Items.AddRange(ThanhToan);
        }

        private void loadTTLicTrinh()
        {
            dgv_ThongTinLichTrinh.DataSource = ltBLL.TTLichTrinh(int.Parse(cbo_DiemDi.SelectedValue.ToString()), int.Parse(cbo_DiemDen.SelectedValue.ToString()), DateTime.Parse(dtp_NgayDi.Value.ToShortDateString()));
            dgv_ThongTinLichTrinh.Columns["GioDi"].DefaultCellStyle.Format = "HH:mm";
            dgv_ThongTinLichTrinh.Columns["GioDen"].DefaultCellStyle.Format = "HH:mm";
            dgv_ThongTinLichTrinh.Columns["GiaVe"].DefaultCellStyle.Format = "0,00" + " đ";
                dgv_ThongTinLichTrinh.Columns["MaLichTrinh"].HeaderText = "Mã lịch trình";
                dgv_ThongTinLichTrinh.Columns["DiemDon"].HeaderText = "Điểm khởi hành";
                dgv_ThongTinLichTrinh.Columns["DiemTra"].HeaderText = "Điểm kết thúc";
                dgv_ThongTinLichTrinh.Columns["GioDi"].HeaderText = "Giờ khởi hành";
                dgv_ThongTinLichTrinh.Columns["GioDen"].HeaderText = "Giờ kết thúc";
                dgv_ThongTinLichTrinh.Columns["BienSoXe"].HeaderText = "Biển số xe";
                dgv_ThongTinLichTrinh.Columns["GiaVe"].HeaderText = "Giá vé";
            


        }
        private void UsCtrl_BanVe_Load(object sender, EventArgs e)
        {
            gb_Xe20.Visible = false;
            gb_Xe34.Visible = false;
            loadCboDiaDiem();

            loadCboThanhToan();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            loadTTLicTrinh();
        }

        private void dgv_ThongTinLichTrinh_SelectionChanged(object sender, EventArgs e)
        {
            
        }
        private void dgv_ThongTinLichTrinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_ThongTinLichTrinh.SelectedRows.Count > 0)
            {
                string mlt = dgv_ThongTinLichTrinh.SelectedRows[0].Cells[0].Value.ToString();
                int diemden = int.Parse(cbo_DiemDen.SelectedValue.ToString());
                int diemdi = int.Parse(cbo_DiemDi.SelectedValue.ToString());

                cbo_DiemDon.DataSource = dvBLL.layDiemDon(mlt, diemdi);
                cbo_DiemDon.DisplayMember = "TEN_TramDungChan";
                cbo_DiemDon.ValueMember = "ID_TramDungChan";
                cbo_DiemTra.DataSource = dvBLL.layDiemTra(mlt, diemden);
                cbo_DiemTra.DisplayMember = "TEN_TramDungChan";
                cbo_DiemTra.ValueMember = "ID_TramDungChan";
                if (dvBLL.layLoaiXe(mlt))
                {
                    gb_Xe34.Visible = false;
                    gb_Xe20.Visible = true;
                }
                else
                {
                    gb_Xe34.Visible = true;
                    gb_Xe20.Visible = false;
                }
                txt_TongTien.Clear();
                txt_MaVe.Clear();
                txt_ViTriGhe.Clear();
                LoadTinhTrangGhe(mlt);
            }
        }

        private Control FindControlRecursive(Control parent, string name)
        {
            // Kiểm tra nếu control hiện tại là control cần tìm
            if (parent.Name == name)
            {
                return parent;
            }

            // Tìm kiếm trong các control con
            foreach (Control child in parent.Controls)
            {
                Control result = FindControlRecursive(child, name);
                if (result != null)
                {
                    return result;
                }
            }

            return null;
        }

        private void LoadTinhTrangGhe(string malichtrinh)
        {
            List<GHE> lst = new List<GHE>();
            lst = gBLL.LoadGhe(malichtrinh);
            int SoGhe = gBLL.LaySoGhe(malichtrinh);
            giaVe = ltBLL.LayGiaLichTrinh(malichtrinh);
            foreach (var item in lst)
            {
                string viTriNgoi = item.VI_TRI_NGOI;
                string trangThai = item.TRANG_THAI;
                string buttonName = "xe" + SoGhe + "_" + viTriNgoi;

                Button seatButton = FindControlRecursive(this, buttonName) as Button;

                if (seatButton != null)
                {
                    seatButton.Click -= ChucNangChonGhe;

                    seatButton.BackColor = trangThai.Equals("Đã đặt") ? Color.Gray : Color.White;
                    if (trangThai.Equals("Đã đặt"))
                    {
                        seatButton.Click -= ChucNangChonGhe;
                    }
                    else
                    {
                        seatButton.Click += ChucNangChonGhe;
                    }
                }
            }
        }


        private void ChucNangChonGhe(object sender, EventArgs e)
        {
            Button seatButton = sender as Button;
            if (seatButton != null)
            {
                if (seatButton.BackColor == Color.White)
                {
                    seatButton.BackColor = Color.ForestGreen;
                    gheDaChon.Add(seatButton.Text);
                }
                else if (seatButton.BackColor == Color.ForestGreen)
                {
                    seatButton.BackColor = Color.White;
                    gheDaChon.Remove(seatButton.Text);
                }
            }
            UpdateTongTien();
            txt_ViTriGhe.Clear();
            txt_ViTriGhe.Text = String.Join(", ", gheDaChon);
        }

        private void UpdateTongTien()
        {
            double totalPrice = giaVe * gheDaChon.Count;
            txt_TongTien.Text = string.Format("{0:0,00} VNĐ", totalPrice);
            txt_TongTien.Tag = totalPrice;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (dgv_ThongTinLichTrinh.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chưa chọn lịch trình!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            txt_TenKH.Clear();
            txt_SDT.Clear();
            txt_TongTien.Clear();
            txt_ViTriGhe.Clear();
            string maLichTrinhSelected = dgv_ThongTinLichTrinh.SelectedRows[0].Cells[0].Value.ToString();
            maVe = maLichTrinhSelected + "VE" + dvBLL.LaySoVe(maLichTrinhSelected).ToString("D3");
            txt_MaVe.Text = maVe;

        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            txt_TenKH.Clear();
            txt_SDT.Clear();
            //txt_TongTien.Clear();
            txt_ViTriGhe.Clear();

            int SoGhe = gBLL.LaySoGhe(dgv_ThongTinLichTrinh.SelectedRows[0].Cells[0].Value.ToString());

            List<string> dsGheDaChon = new List<string>(gheDaChon);

            foreach (var item in dsGheDaChon)
            {
                string viTriNgoi = item;
                string buttonName = "xe" + SoGhe + "_" + viTriNgoi;

                Button seatButtonName = FindControlRecursive(this, buttonName) as Button;

                if (seatButtonName != null && seatButtonName.BackColor == Color.ForestGreen)
                {
                    seatButtonName.BackColor = Color.White;
                    gheDaChon.Remove(item);
                }
            }
            UpdateTongTien();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaVe.Text))
            {
                MessageBox.Show("Mã vé không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_MaVe.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_TenKH.Text))
            {
                MessageBox.Show("Tên khách hàng không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_TenKH.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_SDT.Text) || txt_SDT.Text.Length != 10 || !txt_SDT.Text.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại phải là 10 ký tự và chỉ chứa số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbo_DiemDon.SelectedValue == null)
            {
                MessageBox.Show("Điểm đón không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo_DiemDon.Focus();
                return;
            }
            if (cbo_DiemTra.SelectedValue == null)
            {
                MessageBox.Show("Điểm trả không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo_DiemTra.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_ViTriGhe.Text.Trim())){
                MessageBox.Show("Vui lòng chọn ít nhất một ghế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string maLichTrinhSelected = dgv_ThongTinLichTrinh.SelectedRows[0].Cells[0].Value.ToString();
            Ve newVe = new Ve()
            {
                ID_VE = txt_MaVe.Text,
                TENKHACHHANG = txt_TenKH.Text,
                SDT = txt_SDT.Text,
                TONG_TIEN = double.Parse(txt_TongTien.Tag.ToString()),
                SOLUONG = gheDaChon.Count(),
                ID_LICH_TRINH = maLichTrinhSelected,
                TRANG_THAI = "Hiện tại",
                NGAY_DAT_VE = DateTime.Now,
                NHAN_VIEN_TAO = MaNhanVien,
                DIEMDON = cbo_DiemDon.SelectedValue.ToString(),
                DIEMTRA = cbo_DiemTra.SelectedValue.ToString(),
                HINHTHUCTHANHTOAN = cboThanhToan.SelectedItem.ToString()
            };
            if (dvBLL.LuuVe(newVe))
            {
                foreach (var item in gheDaChon)
                {
                    int idGhe = dvBLL.LayIDGhe(item, maLichTrinhSelected);
                    ChiTietVe ctVe = new ChiTietVe()
                    {
                        ID_GHE = idGhe,
                        ID_VE = newVe.ID_VE
                    };
                    dvBLL.LuuChiTietVe(ctVe);
                }
                MessageBox.Show("Đặt vé thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_TenKH.Clear();
                txt_SDT.Clear();
                txt_TongTien.Clear();
                txt_ViTriGhe.Clear();
                txt_MaVe.Clear();
                gheDaChon.Clear();
            }
            else
            {
                MessageBox.Show("Đặt vé không thành công","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_KiemTra_Click(object sender, EventArgs e)
        {
            var currentControl = this;
            UsCtrl_BanVe Nus = new UsCtrl_BanVe();
            var panel = currentControl.Parent;
            Parent.Controls.Remove(currentControl);
            Nus.getMaNV(MaNhanVien);
            panel.Controls.Add(Nus);
            Nus.Dock = DockStyle.Fill;

        }

        private void btn_InVe_Click(object sender, EventArgs e)
        {
            try
            {
                // Mở form in vé
                frm_InVe frmVe = new frm_InVe();
                frmVe.LoadReportInVe(maVe);
                frmVe.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Giới hạn độ dài tối đa là 10 số
            TextBox txt = sender as TextBox;
            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 10)
            {
                e.Handled = true;
            }
        }
    }
}
