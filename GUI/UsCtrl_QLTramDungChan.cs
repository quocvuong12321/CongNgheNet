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
            HienThiTramDungChanTheoDiaDiem(Convert.ToInt32(cbo_DiaDiem.SelectedValue));
            //databindding_DgvDsTramDungChan();
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


            HienThi_DgvTramDungChanDiemDi(maLichTrinh);
            HienThi_DgvTramDungChanDiemTra(maLichTrinh);
        }

        private void txt_DiemDi_TextChanged(object sender, EventArgs e)
        {
            string tenDiaDiem = txt_DiemDi.Text;

            int maDiaDiem = ddBLL.LayMaDiaDiemTheoTen(tenDiaDiem);

            List<TRAMDUNGCHAN> danhSachTram = tdcBLL.LayDanhSachTramDungChanTheoDiaDiem(maDiaDiem);

            lst_DiemDi.DisplayMember = "TEN_TramDungChan";
            lst_DiemDi.ValueMember = "ID_TramDungChan";
            lst_DiemDi.DataSource = danhSachTram;
        }

        private void txt_DiemDen_TextChanged(object sender, EventArgs e)
        {
            string tenDiaDiem = txt_DiemDen.Text;

            int maDiaDiem = ddBLL.LayMaDiaDiemTheoTen(tenDiaDiem);

            List<TRAMDUNGCHAN> danhSachTram = tdcBLL.LayDanhSachTramDungChanTheoDiaDiem(maDiaDiem);

            lst_DiemDen.DisplayMember = "TEN_TramDungChan";
            lst_DiemDen.ValueMember = "ID_TramDungChan";
            lst_DiemDen.DataSource = danhSachTram;
        }

        private void HienThi_DgvTramDungChanDiemDi( string maLichTrinh)
        {
            var danhSachLichTrinh = tdcBLL.LayDanhSachLichTrinhVaTramDungChanDiemDi(maLichTrinh);
            dgv_DanhSachTramDungChanDiemDi.DataSource = danhSachLichTrinh;
            dgv_DanhSachTramDungChanDiemDi.Columns["MaLichTrinh"].HeaderText = "Mã Lịch Trình";
            dgv_DanhSachTramDungChanDiemDi.Columns["TenTramDungChan"].HeaderText = "Điểm Đón";
            dgv_DanhSachTramDungChanDiemDi.Columns["IDTramDungChan"].Visible = false;
        }
        private void HienThi_DgvTramDungChanDiemTra( string maLichTrinh)
        {
            var danhSachLichTrinh = tdcBLL.LayDanhSachLichTrinhVaTramDungChanDiemTra(maLichTrinh);
            dgv_DanhSachTramDungChanDiemTra.DataSource = danhSachLichTrinh;
            dgv_DanhSachTramDungChanDiemTra.Columns["MaLichTrinh"].HeaderText = "Mã Lịch Trình";
            dgv_DanhSachTramDungChanDiemTra.Columns["TenTramDungChan"].HeaderText = "Điểm Trả";
            dgv_DanhSachTramDungChanDiemTra.Columns["IDTramDungChan"].Visible = false;

        }

        //private void HienThiTatCaTramDungChan()
        //{
        //    var danhSachTram = tdcBLL.LayTatCaTramDungChan();

        //    dgv_DanhSachTramDungChan.DataSource = danhSachTram;

        //    dgv_DanhSachTramDungChan.Columns["ID_TramDungChan"].HeaderText = "Mã Trạm Dừng Chân";
        //    dgv_DanhSachTramDungChan.Columns["TEN_TramDungChan"].HeaderText = "Tên Trạm Dừng Chân";

        //    dgv_DanhSachTramDungChan.Columns["ID_DiaDiem"].Visible = false;
        //    dgv_DanhSachTramDungChan.Columns["DiaDiem"].Visible = false;
        //}

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

        private void databindding_DgvDsTramDungChan()
        {
            txt_MaTramDungChan.DataBindings.Clear();
            txt_MaTramDungChan.DataBindings.Add("Text", dgv_DanhSachTramDungChan.DataSource, "ID_TramDungChan");
            txt_TenTramDungChan.DataBindings.Clear();
            txt_TenTramDungChan.DataBindings.Add("Text", dgv_DanhSachTramDungChan.DataSource, "TEN_TramDungChan");
        }

        private void HienThiTramDungChanTheoLichTrinh(string maLichTrinh)
        {
            var danhSachTramDiemDi = tdcBLL.LayDanhSachLichTrinhVaTramDungChanDiemDi(maLichTrinh);
            dgv_DanhSachTramDungChanDiemDi.DataSource = danhSachTramDiemDi;
            var danhSachTramDiemDen = tdcBLL.LayDanhSachLichTrinhVaTramDungChanDiemTra(maLichTrinh);
            dgv_DanhSachTramDungChanDiemTra.DataSource = danhSachTramDiemDen;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (lst_DiemDi.SelectedItem != null || lst_DiemDen.SelectedItem != null)
            {
                string maLichTrinh = cbo_DanhSachMaLichTrinh.SelectedValue.ToString();

                if (lst_DiemDi.SelectedItem != null)
                {
                    string maTramDi = lst_DiemDi.SelectedValue.ToString();
                    bool themThanhCongDi = tdcBLL.ThemTramDungChanTheoMaLichTrinh(maTramDi, maLichTrinh);
                    if (themThanhCongDi)
                        MessageBox.Show("Thêm trạm điểm đi thành công cho lịch trình!");
                    else
                        MessageBox.Show("Trạm điểm đi đã tồn tại cho lịch trình này.");
                }



                if (lst_DiemDen.SelectedItem != null)
                {
                    string maTramDen = lst_DiemDen.SelectedValue.ToString();
                    bool themThanhCongDen = tdcBLL.ThemTramDungChanTheoMaLichTrinh(maTramDen, maLichTrinh);
                    if (themThanhCongDen)
                        MessageBox.Show("Thêm trạm điểm đến thành công cho lịch trình!");
                    else
                        MessageBox.Show("Trạm điểm đến đã tồn tại cho lịch trình này.");
                }

                HienThiTramDungChanTheoLichTrinh(maLichTrinh);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một trạm dừng chân.");
            }
        }

        private void btn_BoChon_Click(object sender, EventArgs e)
        {
            lst_DiemDi.ClearSelected();
            lst_DiemDen.ClearSelected();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgv_DanhSachTramDungChanDiemDi.SelectedRows.Count > 0 || dgv_DanhSachTramDungChanDiemTra.SelectedRows.Count > 0)
            {
                string maLichTrinh = cbo_DanhSachMaLichTrinh.SelectedValue.ToString();

                if (dgv_DanhSachTramDungChanDiemDi.SelectedRows.Count > 0)
                {
                    string maTramDi = dgv_DanhSachTramDungChanDiemDi.SelectedRows[0].Cells[2].Value.ToString();
                    bool xoaThanhCongDi = tdcBLL.XoaTramDungChanTheoMaLichTrinh(maTramDi, maLichTrinh);

                    if (xoaThanhCongDi)
                    {
                        MessageBox.Show("Xóa trạm điểm đi thành công!");
                        HienThiTramDungChanTheoLichTrinh(maLichTrinh);
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa trạm điểm đi này.");
                    }
                }

                if (dgv_DanhSachTramDungChanDiemTra.SelectedRows.Count > 0)
                {
                    string maTramDen = dgv_DanhSachTramDungChanDiemTra.SelectedRows[0].Cells[2].Value.ToString();
                    bool xoaThanhCongDen = tdcBLL.XoaTramDungChanTheoMaLichTrinh(maTramDen, maLichTrinh);

                    if (xoaThanhCongDen)
                    {
                        MessageBox.Show("Xóa trạm điểm đến thành công!");
                        HienThiTramDungChanTheoLichTrinh(maLichTrinh);
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa trạm điểm đến này.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }

        private void btn_BoChon1_Click(object sender, EventArgs e)
        {
            dgv_DanhSachTramDungChanDiemDi.ClearSelection();
            dgv_DanhSachTramDungChanDiemTra.ClearSelection();
        }





    }
}
