using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project5_RMateo
{
    public partial class TravelExpenseForm : Form
    {
        public TravelExpenseForm()
        {
            InitializeComponent();
        }

        /*
         * Gives the user option to press "Enter"
         * instead of using the pointer to calculate.
         */
        private void TravelExpenseForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = CalculateButton;

        }


        /*
         * Calculate button is used to display 
         * each the miles per gallon of the car,
         * the total miles to work,
         * and calculates the total cost using
         * the user input of the gas price.
         * 
         * The following formula is used for this program.
         * 
         *  ** Total Price = (Distance/MPG) x Gas Price **
         *      
         *      
         */
        private void CalculateButton_Click(object sender, EventArgs e)
        {

            Double MPG = 0.0;
            Double Distance = 0.0;
            Double GasPrice = 0.0;
            Double TotalCost = 0.0;

            if (BuickRadioBtn.Checked && FreewayRadioBtn.Checked)
            {
                MPG = 23.7;
                Distance = 33;

                MileageValue.Text = MPG.ToString();
                TotalMilesValue.Text = Distance.ToString();

                GasPrice = Convert.ToDouble(GasPriceValue.Text);

                TotalCost = (Distance / MPG) * GasPrice;
                TotalCostValue.Text = TotalCost.ToString("N2");

            }

            else if (BuickRadioBtn.Checked && CityRadioBtn.Checked)
            {
                MPG = 15.5;
                Distance = 21;

                MileageValue.Text = MPG.ToString();
                TotalMilesValue.Text = Distance.ToString();

                GasPrice = Convert.ToDouble(GasPriceValue.Text);

                TotalCost = (Distance / MPG) * GasPrice;
                TotalCostValue.Text = TotalCost.ToString("N2");
            }
            
            else if (ChevyRadioBtn.Checked && FreewayRadioBtn.Checked)
            {
                MPG = 29.3;
                Distance = 33;

                MileageValue.Text = MPG.ToString();
                TotalMilesValue.Text = Distance.ToString();

                GasPrice = Convert.ToDouble(GasPriceValue.Text);

                TotalCost = (Distance / MPG) * GasPrice;
                TotalCostValue.Text = TotalCost.ToString("N2");
            }

            else if (ChevyRadioBtn.Checked && CityRadioBtn.Checked)
            {
                MPG = 19.8;
                Distance = 21;

                MileageValue.Text = MPG.ToString();
                TotalMilesValue.Text = Distance.ToString();

                GasPrice = Convert.ToDouble(GasPriceValue.Text);

                TotalCost = (Distance / MPG) * GasPrice;
                TotalCostValue.Text = TotalCost.ToString("N2");
            }
            else
            {
                MessageBox.Show("Please make sure all fields have been filled.");
            }
        }

        private void AutoGroupBox_Enter(object sender, EventArgs e)
        {

        }


        /*
         * Used for error trapping. Ensures multiple
         * decimal points are not used and ensures
         * that only numeric values are entered.
         */
        private void GasPriceValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            
            if (ch == 46 && GasPriceValue.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if(!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

        private void GasPriceValue_TextChanged(object sender, EventArgs e)
        {
            //Disables calculate button when blank
            if (string.IsNullOrWhiteSpace(GasPriceValue.Text))
                CalculateButton.Enabled = false;
            else
                CalculateButton.Enabled = true;
        }



        /*
         * "Quit" button ends program
         */

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
