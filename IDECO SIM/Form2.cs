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
    public partial class Form2 : Form
    {
        double Return_Per;
        double Add_Invest;
        int Period;
        double[] asset;
        double[] time;

        public Form2(double RP, double AI, int Pd)
        {
            InitializeComponent();

            Return_Per = Math.Pow((RP*0.01+1.0),1.0/12.0);
            Add_Invest = AI;
            Period = Pd;
            asset = new double[Period * 12];
            time = new double[Period * 12];

            for (int i = 0; i < Period * 12; i++)
            {
                double val = (double)(i+1);
                asset[i] = Add_Invest * (1.0 - Math.Pow(Return_Per,val)) / (1.0 - Return_Per);
                time[i] = val / 12;

                // データをシリーズにセットします
                chart1.Series["積立総額"].Points.AddXY(time[i], Add_Invest * (i + 1));
                chart1.Series["資産総額"].Points.AddXY(time[i], asset[i]);

            }

            textBox1.Text = (Add_Invest * Period * 12).ToString();
            textBox2.Text = ((int)asset[Period * 12-1]).ToString();

            
        }

        

    }
}
