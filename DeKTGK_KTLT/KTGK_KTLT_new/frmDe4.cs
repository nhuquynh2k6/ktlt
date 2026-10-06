using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTGK_KTLT_new
{
    public partial class frmDe4 : Form
    {
        public frmDe4()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDe4_Load(object sender, EventArgs e)
        {
            string studentInfo = "CNTT2411024 - Dương Như Quỳnh";

            this.Text += $"- {studentInfo}";

            string[] status = { "Chờ thanh toán", "Đã thanh toán", "Hủy" };
            cboStatus.Items.AddRange(status);
            cboStatus.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInvoiceNumber.Text))
            { 
                if (int.Parse(txtTotal.Text) <= 0)
                {
                    MessageBox.Show("Tổng tiền phải là số >0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }     
                if(int.Parse(txtProductCount.Text) <= 0)
                {
                    MessageBox.Show("Số lượng mặt hàng phải là số >0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            string khanCap = "";
            if (chkUrgent.Checked)
            {
                khanCap = "Có";
            }
            lstInvoices.Items.Add($"{txtInvoiceNumber.Text}|{txtTotal.Text}|{txtProductCount.Text}|{cboStatus.SelectedItem}|{khanCap}");
            txtInvoiceNumber.Clear();
            txtTotal.Clear();
            txtProductCount.Clear();
            chkUrgent.Checked = false;
            cboStatus.SelectedItem = -1;
        }
            else
            {
                MessageBox.Show("Tên khách hàng không được rỗng ", "Lỗi nhập dữ liệu ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            lblResult.Text = GetStatistics();
        }
        public string GetStatistics()
        {
            string kequa = "";
            int b = 0; int c = 0; int d = 0; int e = 0;
            foreach (string sokhachhan in lstInvoices.Items)
            {

                if (sokhachhan.Trim().Split('|')[3] == cboStatus.Items[0].ToString().Trim())
                {
                    b++;
                }
                if (sokhachhan.Trim().Split('|')[3] == cboStatus.Items[1].ToString().Trim())
                {
                    c++;
                }
                if (sokhachhan.Trim().Split('|')[3] == cboStatus.Items[2].ToString().Trim())
                {
                    d++;
                }
                if (sokhachhan.Trim().Split('|')[4] == "Có")
                {
                    e++;
                }
            }
            return kequa = $"Thống kê:\n Chờ thanh toán: {b}\n Đã thanh toán: {c} \n Huỷ: {d} \n Khẩn cấp: {e}";

        }
        public List<string> FindInvoices(string keyword)
        {
            List<string> dsHoaDon = new List<string>();
            foreach (char ten in lstInvoices.Items.ToString())
            {
                if (keyword.Trim().ToLower() == ten.ToString().Trim().Split('|')[0])
                {
                    dsHoaDon.Add(ten.ToString());
                }
            }
            return dsHoaDon;

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string dsHoaDon = "";
            dsHoaDon = $"{FindInvoices(txtInvoiceNumber.Text)}";
            MessageBox.Show(dsHoaDon);
    }
    }
}