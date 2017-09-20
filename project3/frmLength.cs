//frmLength.cs
// CS-1181
// Sagar Gaire
// 9/19/2017
// Anil Mandal
// From this assingnment we now how to convert one type of length into another and also it work as simple length converter calculator
//wow:when we enter value in the text box and the output label will get color change
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project3
{
    public partial class frmLength : Form
    {
        int metriclength;
        double notCorrect;
        char notCorrect2;
        int imperiallength;
        public frmLength()

        {
            InitializeComponent();

        }

        private void frmLength_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(txtMilliMeters.Text, out metriclength);
        }

        private void btnMetricLength_Click(object sender, EventArgs e)
        {
            //coding to enter length in millimiters and convert into its length

            if ( metriclength != notCorrect && metriclength != notCorrect2)
            {
                if (metriclength >= 0 && metriclength < 10)
                {
                    lblMetricOutput.Text = metriclength.ToString("n3") + " mm";
                    //wow factor for changing the color of output value in a label
                    lblMetricOutput.ForeColor = Color.Green;

                }
                else if (metriclength < 100)
                {
                    lblMetricOutput.Text = (metriclength / 10.0).ToString("n3") + " cm";
                    lblMetricOutput.ForeColor = Color.Green;
                    //wow
                }
                else if ( metriclength < 1000)
                {
                    lblMetricOutput.Text = (metriclength / 100.0).ToString("n3") + " dm";
                    //wow
                    lblMetricOutput.ForeColor = Color.Green;
                }
                else if ( metriclength < 10000)
                {
                    lblMetricOutput.Text = (metriclength / 1000.0).ToString("n3") + " m";
                    //wow
                    lblMetricOutput.ForeColor = Color.Green;
                }
                else if ( metriclength < 100000)
                {
                    lblMetricOutput.Text = (metriclength / 10000.0).ToString("n3") + " dam";
                    //wow
                    lblMetricOutput.ForeColor = Color.Green;
                  
                }
                else if ( metriclength < 1000000)
                {
                    lblMetricOutput.Text = (metriclength / 100000.0).ToString("n3") + " hm";
                    //wow
                    lblMetricOutput.ForeColor = Color.Green;
                }
                else if (metriclength >= 1000000)
                {
                    lblMetricOutput.Text = (metriclength / 1000000.0).ToString("n3") + " km";
                    //wow
                    lblMetricOutput.ForeColor = Color.Green;

                }
                //c
                 if (metriclength < 0)

                MessageBox.Show("This number can not be negative because it is less then zero");
            }
            //coding to display if a input number is not a integer number
            else { MessageBox.Show("enter value is not a integer number");
                //wow
                lblMetricOutput.ForeColor = Color.Green;
            }
           


           
            //coding to find the assigned value of length in inches

        }

        private void btnImperialLength_Click(object sender, EventArgs e)
        {
            if (imperiallength != notCorrect && imperiallength != notCorrect2)


            {
                //coding to display if a input number is not a integer number
                if (imperiallength < 0)

                    MessageBox.Show("This number can not be negative because it is less then zero");
                {
                    if (imperiallength < 12.0)
                    {
                        lblOutput.Text = imperiallength.ToString("n3") + " in";
                        //wow factor
                        lblOutput.ForeColor = Color.Red;

                    }
                    else if (imperiallength < 36)
                    {
                        lblOutput.Text = (imperiallength / 12.0).ToString("n3") + " ft";
                        //wow factor
                        lblOutput.ForeColor = Color.Red;
                    }
                    else if (imperiallength < 198)
                    {
                        lblOutput.Text = (imperiallength / 36.0).ToString("n3") + " yd";
                        //wow factor
                        lblOutput.ForeColor = Color.Red;
                    }
                    else if (imperiallength < 7920)
                    {
                        lblOutput.Text = (imperiallength / 198.0).ToString("n3") + " rd";
                        //wow factor
                        lblOutput.ForeColor = Color.Red;
                    }
                    else if (imperiallength < 63360)
                    {
                        lblOutput.Text = (imperiallength / 7920.0).ToString("n3") + " fur";
                        //wow factor
                        lblOutput.ForeColor = Color.Red;
                    }
                    else if (imperiallength >= 63360)
                    {
                        lblOutput.Text = (imperiallength / 63360.0).ToString("n3") + " mi";
                        //wow factor
                        lblOutput.ForeColor = Color.Red;

                    }
                }
            }
            //coding to display if a input number is not a integer number
            else { MessageBox.Show("the entered value is not a integer number"); }


            
        }
        private void txtInches_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(txtInches.Text, out imperiallength);
           

        }

        private void lblMillimeters_Click(object sender, EventArgs e)
        {
           
        }
    }
}