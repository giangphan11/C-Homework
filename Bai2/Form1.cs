using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Giải phương trình bậc 2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = double.Parse(txtC.Text);
            string nghiem = "";
            if (a == 0)
            {
                nghiem = "Đây không phải là phương trình bậc 2!";
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    nghiem = "Phương trình vô nghiệm !";
                }
                else if(delta == 0)
                {
                    double x = -b / 2 * a;
                    nghiem = "Phương trình có nghiệm kép= " + x.ToString();
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    nghiem = "x1= " + x1.ToString() + ", x2= " + x2.ToString();
                }
            }
            txtNghiem.Text = nghiem;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dlt = MessageBox.Show("Bạn chắc chắn thoát không?",
                "Thoát chương trình", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if(dlt== DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
