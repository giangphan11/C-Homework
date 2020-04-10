using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaiPTBac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.ActiveControl = yourtextboxname;
            //this.ActiveControl = txtC;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            if (txtA.Text == "" && txtB.Text == "" && txtC.Text == "")
            {
                this.ActiveControl = txtA;

            }
            else if(txtB.Text == "")
                this.ActiveControl = txtB;
            else if (txtC.Text == "")
                this.ActiveControl = txtC;
            else
            {
                double a = Double.Parse(txtA.Text);
                double b = Double.Parse(txtB.Text);
                double c = Double.Parse(txtC.Text);
                XuLy xuLy = new XuLy();
                txtKQ.Text = xuLy.GiaiPT(ref a, ref b, ref c);
            }
        }
    }
}
