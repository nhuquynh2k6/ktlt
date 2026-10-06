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
    public partial class frmDe0 : Form
    {
        public frmDe0()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDe0_Load(object sender, EventArgs e)
        {
            string studentInfo = "MSSV - Họ tên";

            this.Text += $"- {studentInfo}";

            string[] productCat = { "Đồ uống", "Thực phẩm", "Đồ dùng" };
            cboCategory.Items.AddRange(productCat);
            cboCategory.SelectedIndex = 0;
        }
    }
}