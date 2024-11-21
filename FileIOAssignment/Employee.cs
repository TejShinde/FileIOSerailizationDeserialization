using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileIOAssignment
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the basic salary
                double basic = double.Parse(txtBasic.Text);

                // Calculation
                double hra = 0.40 * basic; 
                double da = 0.30 * basic;  
                double ta = 0.20 * basic;  
                double pf = 0.12 * basic;  
                double pt = 200;          // Fixed Professional Tax

                // Calculate Gross Salary
                double gross = basic + hra + da + ta - pf - pt;

                // Display the results
                txtHRA.Text = hra.ToString("F2");
                txtDA.Text = da.ToString("F2");
                txtTA.Text = ta.ToString("F2");
                txtPF.Text = pf.ToString("F2");
                txtPT.Text = pt.ToString("F2");
                txtGross.Text = gross.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
    
}
