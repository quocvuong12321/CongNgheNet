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
    public partial class UsCtrl_QLTramDungChan : UserControl
    {
        LichTrinhBLL lichTrinhBLL = new LichTrinhBLL();
        DiaDiemBLL ddBLL = new DiaDiemBLL();
        TramDungChanBLL tdcBLL = new TramDungChanBLL();
        public UsCtrl_QLTramDungChan()
        {
            InitializeComponent();
        }

        
        private void UsCtrl_QLTramDungChan_Load(object sender, EventArgs e)
        {
            cbo_DanhSachMaLichTrinh.DataSource = lichTrinhBLL.LayDanhSachMaLichTrinh();
            load_cboDiaDiem();
            //HienThiTatCaTramDungChan();
            HienThiTramDungChanTheoDiaDiem(Convert.ToInt32(cbo_DiaDiem.SelectedValue));
        }

        private void cbo_DanhSachMaLichTrinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maLichTrinh = cbo_DanhSachMaLichTrinh.SelectedValue.ToString();

            LichTrinh_DiemDau_DiemCuoi chiTietLichTrinh = lichTrinhBLL.LayThongTinLichTrinh(maLichTrinh);

            if (chiTietLichTrinh != null)
            {
                txt_DiemDi.Text = chiTietLichTrinh.DiemDau;
                txt_DiemDen.Text = chiTietLichTrinh.DiemCuoi;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin lịch trình.");
            }


            HienThi_DgvLichTrinhVaTramDungChan(maLichTrinh);
        }

        private void txt_DiemDi_TextChanged(object sender, EventArgs e)
        {
            string tenDiaDiem = txt_DiemDi.Text;

            int maDiaDiem = ddBLL.LayMaDiaDiemTheoTen(tenDiaDiem);

            TramDungChanBLL tramDungChanBLL = new TramDungChanBLL();
            List<string> danhSachTram = tramDungChanBLL.LayDanhSachTenTramDungChanTheoDiaDiem(maDiaDiem);

            lst_DiemDi.Items.Clear();
            lst_DiemDi.Items.AddRange(danhSachTram.ToArray());
        }

        private void txt_DiemDen_TextChanged(object sender, EventArgs e)
        {
            string tenDiaDiem = txt_DiemDen.Text;

            int maDiaDiem = ddBLL.LayMaDiaDiemTheoTen(tenDiaDiem);

            TramDungChanBLL tramDungChanBLL = new TramDungChanBLL();
            List<string> danhSachTram = tramDungChanBLL.LayDanhSachTenTramDungChanTheoDiaDiem(maDiaDiem);

            lst_DiemDen.Items.Clear();
            lst_DiemDen.Items.AddRange(danhSachTram.ToArray());
        }


        private void HienThi_DgvLichTrinhVaTramDungChan( string maLichTrinh)
        {
            var danhSachLichTrinh = tdcBLL.LayDanhSachLichTrinhVaTramDungChan( maLichTrinh);

            dgv_DanhSachTramDungChanTheoMaLichTrinh.DataSource = danhSachLichTrinh;

            dgv_DanhSachTramDungChanTheoMaLichTrinh.Columns["MaLichTrinh"].HeaderText = "Mã Lịch Trình";
            dgv_DanhSachTramDungChanTheoMaLichTrinh.Columns["DiemDi"].HeaderText = "Nơi Xuất Phát";
            dgv_DanhSachTramDungChanTheoMaLichTrinh.Columns["TramDiemDi"].HeaderText = "Điểm Đón";
            dgv_DanhSachTramDungChanTheoMaLichTrinh.Columns["DiemDen"].HeaderText = "Nơi Kết Thúc";
            dgv_DanhSachTramDungChanTheoMaLichTrinh.Columns["TramDiemDen"].HeaderText = "Điểm Trả";


        }

        private void HienThiTatCaTramDungChan()
        {
            var danhSachTram = tdcBLL.LayTatCaTramDungChan();

            dgv_DanhSachTramDungChan.DataSource = danhSachTram;

            dgv_DanhSachTramDungChan.Columns["ID_TramDungChan"].HeaderText = "Mã Trạm Dừng Chân";
            dgv_DanhSachTramDungChan.Columns["TEN_TramDungChan"].HeaderText = "Tên Trạm Dừng Chân";

            dgv_DanhSachTramDungChan.Columns["ID_DiaDiem"].Visible = false;
            dgv_DanhSachTramDungChan.Columns["DiaDiem"].Visible = false;
        }

        private void HienThiTramDungChanTheoDiaDiem(int maDiaDiem)
        {
            var danhSachTram = tdcBLL.LayDanhSachTramDungChanTheoDiaDiem(maDiaDiem);

            dgv_DanhSachTramDungChan.DataSource = danhSachTram;

            dgv_DanhSachTramDungChan.Columns["ID_TramDungChan"].HeaderText = "Mã Trạm Dừng Chân";
            dgv_DanhSachTramDungChan.Columns["TEN_TramDungChan"].HeaderText = "Tên Trạm Dừng Chân";

            dgv_DanhSachTramDungChan.Columns["ID_DiaDiem"].Visible = false;
            dgv_DanhSachTramDungChan.Columns["DiaDiem"].Visible = false;
        }



        private bool isLoading = true;
        private void load_cboDiaDiem()
        {
            isLoading = true;

            DiaDiemBLL diaDiemBLL = new DiaDiemBLL();
            var danhSachDiaDiem = diaDiemBLL.loadDiaDiem();

            cbo_DiaDiem.DataSource = danhSachDiaDiem;
            cbo_DiaDiem.DisplayMember = "TEN_TINH_THANH";
            cbo_DiaDiem.ValueMember = "ID_DIADIEM";

            isLoading = false;
        }

        private void cbo_DiaDiem_SelectedValueChanged(object sender, EventArgs e)
        {
            if (isLoading)
                return;

            if (cbo_DiaDiem.SelectedValue != null)
            {
                int maDiaDiem;
                if (int.TryParse(cbo_DiaDiem.SelectedValue.ToString(), out maDiaDiem))
                {
                    HienThiTramDungChanTheoDiaDiem(maDiaDiem);
                }
                else
                {
                    MessageBox.Show("ID địa điểm không hợp lệ.");
                }
            }
            else
            {
                MessageBox.Show("Chưa có địa điểm nào được chọn.");
            }

        }

        private void btn_ThemTramDungChan_Click(object sender, EventArgs e)
        {
            string maTramDungChan = txt_MaTramDungChan.Text;
            string tenTramDungChan = txt_TenTramDungChan.Text;
            int maDiaDiem;

            if (string.IsNullOrEmpty(maTramDungChan) || string.IsNullOrEmpty(tenTramDungChan))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trạm dừng chân.");
                return;
            }

            if (int.TryParse(cbo_DiaDiem.SelectedValue.ToString(), out maDiaDiem))
            {
                bool themTramDungChan = tdcBLL.ThemTramDungChan(maTramDungChan, tenTramDungChan, maDiaDiem);

                if (themTramDungChan)
                {
                    MessageBox.Show("Thêm trạm dừng chân thành công.");
                    HienThiTramDungChanTheoDiaDiem(maDiaDiem);
                }
                else
                {
                    MessageBox.Show("Mã trạm dừng chân đã tồn tại. Vui lòng nhập mã khác.");
                }
            }
            else
            {
                MessageBox.Show("Mã địa điểm không hợp lệ.");
            }
        }

        private void btn_XoaTramDungChan_Click(object sender, EventArgs e)
        {
            string maTramDungChan = txt_MaTramDungChan.Text;

            if (string.IsNullOrEmpty(maTramDungChan))
            {
                MessageBox.Show("Vui lòng chọn trạm dừng chân để xóa.");
                return;
            }

            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa trạm dừng chân này?",
                                                "Xác nhận xóa",
                                                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                bool isDeleted = tdcBLL.XoaTramDungChan(maTramDungChan);

                if (isDeleted)
                {
                    MessageBox.Show("Xóa trạm dừng chân thành công.");
                    HienThiTramDungChanTheoDiaDiem(Convert.ToInt32(cbo_DiaDiem.SelectedValue));
                }
                else
                {
                    MessageBox.Show("Mã trạm dừng chân không tồn tại hoặc lỗi khi xóa trạm dừng chân.");
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string maTramDungChan = txt_MaTramDungChan.Text;
            string tenTramDungChan = txt_TenTramDungChan.Text;
            int maDiaDiem;

            if (string.IsNullOrEmpty(maTramDungChan) || string.IsNullOrEmpty(tenTramDungChan))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để sửa trạm dừng chân.");
                return;
            }

            if (int.TryParse(cbo_DiaDiem.SelectedValue.ToString(), out maDiaDiem))
            {
                bool isUpdated = tdcBLL.SuaTramDungChan(maTramDungChan, tenTramDungChan, maDiaDiem);

                if (isUpdated)
                {
                    MessageBox.Show("Sửa trạm dừng chân thành công.");
                    HienThiTramDungChanTheoDiaDiem(maDiaDiem);
                }
                else
                {
                    MessageBox.Show("Mã trạm dừng chân không tồn tại hoặc lỗi khi sửa trạm dừng chân.");
                }
            }
            else
            {
                MessageBox.Show("Mã địa điểm không hợp lệ.");
            }
        }
    }
}
