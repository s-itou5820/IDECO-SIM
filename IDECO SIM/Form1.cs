using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDECO_SIM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double Return_Per = 0.0;
        double Add_Invest = 0.0;
        int Period = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Invest = double.Parse(textBox1.Text);
            Return_Per = double.Parse(textBox2.Text);
            Period = int.Parse(textBox3.Text);
            Form2 form2 = new Form2(Return_Per, Add_Invest, Period);
            form2.Show();
        }

    }
}
