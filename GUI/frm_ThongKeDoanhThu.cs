using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace GUI
{
    public partial class frm_ThongKeDoanhThu : Form
    {
        frm_Main frm;
        public frm_ThongKeDoanhThu()
        {
            InitializeComponent();
        }
        public frm_ThongKeDoanhThu(frm_Main frm)
        {
            this.frm = frm;
        }


     
    }
}
