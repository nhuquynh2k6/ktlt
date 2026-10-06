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
    public partial class frmDe2 : Form
    {
        public frmDe2()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDe2_Load(object sender, EventArgs e)
        {
            string studentInfo = "MSSV - Họ tên";

            this.Text += $"- {studentInfo}";

            string[] departments = {"Kế toán", "Nhân sự", "Kinh doanh" };
            cboDepartment.Items.AddRange(departments);
            cboDepartment.SelectedIndex = 0;
        }
    }
}