using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monthly_Payment_Calculator_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double purchasePrice = 0.0;
            double interestRate = 0.0;
            double downPayment = 0.0;
            int loanTerm = 0;
            double amounttoFinance;
            double monthlyPayments;

            purchasePrice = 0.0;
            {
                if (double.TryParse(txtPurchasePrice.Text, out purchasePrice))
                    Console.WriteLine();
                else
                    MessageBox.Show("error. enter a valid numeric value");
            };
            interestRate = 0.0;
            {
                if (double.TryParse(txtInterestRate.Text, out interestRate))
                    Console.WriteLine();
                else
                    MessageBox.Show("Error. Enter a valid numeric value");
            };
            downPayment = 0.0;
            {
                if (double.TryParse(txtDownPayment.Text, out downPayment))
                    Console.WriteLine();
                else
                    MessageBox.Show("Error. Enter a valid numeric value");
            };
            loanTerm = 0;
            {
                if (int.TryParse(txtLoanTerm.Text, out loanTerm))
                    Console.WriteLine();
                else
                    MessageBox.Show("Error. Enter a valid numeric value");
            };

            amounttoFinance = purchasePrice - downPayment;
            txtAmount.Text = amounttoFinance.ToString("C");

            double monthlyInterest = interestRate / 12;

            // formula
            monthlyPayments = (monthlyInterest * amounttoFinance * Math.Pow(1 + monthlyInterest, loanTerm)) / Math.Pow(1 + monthlyInterest, loanTerm - 1);
            monthlyPayments = Math.Round(monthlyPayments, 2);
            txtPayments.Text = monthlyPayments.ToString("C");

            Console.ReadLine();

        }
    }
}
    