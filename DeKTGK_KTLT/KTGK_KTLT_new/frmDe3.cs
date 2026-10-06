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
    public partial class frmDe3 : Form
    {
        public frmDe3()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDe3_Load(object sender, EventArgs e)
        {
            string studentInfo = "CNTT2411003 - Lê Tuấn Huy";

            this.Text += $"- {studentInfo}";

            string[] customerTypes = { "Cá nhân", "Doanh nghiệp", "VIP" };
            cboType.Items.AddRange(customerTypes);
            cboType.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCustomerName.Text))
            {

                if (int.Parse(txtOrderValue.Text) < 0 || int.Parse(txtVisits.Text) < 0)
                {
                    MessageBox.Show(" Giá trị đơn hàng và số lần ghé thăm phải là số > 0 ", "Lỗi nhập dữ liệu ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string ThuongXuyen = "";
                if (chkRegular.Checked)
                {
                    ThuongXuyen = "co";
                }
                lstCustomers.Items.Add($"{txtCustomerName.Text}|{txtOrderValue.Text}|{txtVisits.Text}|{cboType.SelectedItem}|{ThuongXuyen}");
                txtCustomerName.Clear();
                txtOrderValue.Clear();
                txtVisits.Clear();
                cboType.SelectedIndex = -1;
                chkRegular.Checked = false;

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
            foreach (string sokhachhan in lstCustomers.Items)
            {

                if (sokhachhan.Trim().Split('|')[3] == cboType.Items[0].ToString().Trim())
                {
                    b++;
                }
                if (sokhachhan.Trim().Split('|')[3] == cboType.Items[1].ToString().Trim())
                {
                    c++;
                }
                if (sokhachhan.Trim().Split('|')[3] == cboType.Items[2].ToString().Trim())
                {
                    d++;
                }
                if (sokhachhan.Trim().Split('|')[4] == "co")
                {
                    e++;
                }
            }
            return kequa = $"Thong ke:\n Ca nhan: {b}\n Doanh Nghiep : {c} \n Vip : {d} \n Thuong Xuyen : {e}";

        }
        public List<string> FindCustomers(string keyword)
        {
            List<string> dskhachhang = new List<string>();
            foreach (char ten in lstCustomers.Items.ToString())
            {
                if (keyword.Trim().ToLower() == ten.ToString().Trim().Split('|')[0])
                {
                    dskhachhang.Add(ten.ToString());
                }
            }
            return dskhachhang;

        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            string dskhachhang = "";
            dskhachhang = $"{FindCustomers(txtCustomerName.Text)}";
            MessageBox.Show(dskhachhang);
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
