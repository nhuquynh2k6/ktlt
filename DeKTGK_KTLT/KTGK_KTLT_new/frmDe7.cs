using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTGK_KTLT_new
{
    public partial class frmDe7 : Form
    {
        public frmDe7()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDe7_Load(object sender, EventArgs e)
        {
            string studentInfo = "MSSV - Họ tên";

            this.Text += $"- {studentInfo}";

            string[] status = { "Đang thực hiện", "Hoàn thành", "Bị hủy" };
            cboStatus.Items.AddRange(status);
            cboStatus.SelectedIndex = 0;
        }
    }
}