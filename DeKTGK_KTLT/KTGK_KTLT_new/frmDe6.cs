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
    public partial class frmDe6 : Form
    {
        public frmDe6()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDe6_Load(object sender, EventArgs e)
        {
            string studentInfo = "MSSV - Họ tên";

            this.Text += $"- {studentInfo}";

            string[] teachers = { "A", "B", "C" };
            cboTeacher.Items.AddRange(teachers);
            cboTeacher.SelectedIndex = 0;
        }
    }
}