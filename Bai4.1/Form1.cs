using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4._1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
            txtA.Text= "";
            txtB.Text = "";
            txtC.Text = "";
            this.ActiveControl = txtA;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?",
                "Xác nhận thoát",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            double kq = Double.Parse(txtA.Text) + Double.Parse(txtB.Text);
            txtC.Text = kq + "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            double kq = Double.Parse(txtA.Text) - Double.Parse(txtB.Text);
            txtC.Text = kq + "";
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            double kq = Double.Parse(txtA.Text) * Double.Parse(txtB.Text);
            txtC.Text = kq + "";
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(txtA.Text);
            double b = Double.Parse(txtB.Text);
            if (b == 0)
            {
                txtC.Text = "không thể chia cho số 0";
            }
            else
            {
                double kq =  Math.Round(a/b,2) ;
                txtC.Text = kq + "";
            }
            
        }
    }
}
