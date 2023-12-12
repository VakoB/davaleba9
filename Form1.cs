using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace davaleba4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int side_1, side_2, side_3;
            side_1 = int.Parse(textBox1.Text);
            side_2 = int.Parse(textBox2.Text);
            side_3 = int.Parse(textBox3.Text);
            BaseClass obj_1 = new BaseClass(side_1,side_2,side_3);
            label1.Text = "ფართობი: " + obj_1.Fartobi().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int side_1, side_2, side_3;
            side_1 = int.Parse(textBox1.Text);
            side_2 = int.Parse(textBox2.Text);
            side_3 = int.Parse(textBox3.Text);
            ChildClass obj_2 = new ChildClass(side_1, side_2, side_3);
            label1.Text = "პერიმეტრი: " + obj_2.Perimeter().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            double[] arr;
            arr = new double[] { 2.3, 4.6, 3.2, -3.4, 2.62, 2.12, 6.32, -9.5 };
            BaseClass2 obj_3 = new BaseClass2(arr);

            foreach (var item in arr)
            {
                label1.Text += " " + item.ToString();
            }
            label2.Text = obj_3.Maximum().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";

            double[] arr;
            arr = new double[] { 2.3, 4.6, 3.2, -3.4, 2.62, 2.12, 6.32, -9.5 };
            ChildClass2 obj_4 = new ChildClass2(arr);
            foreach (var item in arr)
            {
                label1.Text += " " + item.ToString();
            }
            
            label2.Text = obj_4.Minimum().ToString();

        }
    }
}
