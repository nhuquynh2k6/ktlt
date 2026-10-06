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
    public partial class frmDe1 : Form
    {
        public frmDe1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDe1_Load(object sender, EventArgs e)
        {
            string studentInfo = "MSSV - Họ tên";

            this.Text += $"- {studentInfo}";

            string[] classes = { "CNTT2411", "HTTT2411", "KHDL2411" };
            cboClass.Items.AddRange(classes);
            cboClass.SelectedIndex = 0;
        }
    }
}