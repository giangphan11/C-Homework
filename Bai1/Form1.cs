using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Xin chào !";
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xảy ra sự kiện click !");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            string height = "Chiều cao của form là: " + this.Height.ToString();
            string width = "Chiều rộng của form là: " + this.Width.ToString();
            MessageBox.Show(height +"\n"+ width);
        }
    }
}
