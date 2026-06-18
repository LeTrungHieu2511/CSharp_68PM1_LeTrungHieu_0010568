using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlysinhvien
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void QLSV_menu_Click(object sender, EventArgs e)
        {
            UCQLSV ucqlsv = new UCQLSV();
            pn_main.Controls.Clear();
            pn_main.Controls.Add(ucqlsv);
        }

        private void QLLH_menu_Click(object sender, EventArgs e)
        {
            UCQLLH ucqllh = new UCQLLH();
            pn_main.Controls.Clear();
            pn_main.Controls.Add(ucqllh);
        }
    }
}
