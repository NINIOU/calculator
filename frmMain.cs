/*
'---------------------------------------
'Programmed by: Jomar I. Pabuaya
'Website: http://www.sourcecodester.com
'---------------------------------------
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int firstno = int.Parse(txtFirstNo.Text);
            int secondno = int.Parse(txtSecondNo.Text);
            int intTotal;

            intTotal = 0;

            switch (cboOperator.Text)
            {
                case "+":
                    intTotal = firstno + secondno;
                    break;
                case "-":
                    intTotal = firstno - secondno;
                    break;
                case "*":
                    intTotal = firstno * secondno;
                    break;
                case "/":
                    intTotal = firstno / secondno;
                    break;
            }

            txtTotal.Text = intTotal.ToString();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.sourcecodester.com");
        }
    }
}
