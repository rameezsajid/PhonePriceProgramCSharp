using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RameezSajidUnit16
{
    public partial class Form1 : Form
    {
        List<string> mobileName;

        List<double> mobilePrice;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //we create two lists to hold the data

            mobileName = new List<string>();
            mobilePrice = new List<double>();

            // populate the lists with suitable data

            mobileName.Add("Nokia");
            mobilePrice.Add(50);

            mobileName.Add("Samsung");
            mobilePrice.Add(45);

            mobileName.Add("iPhone");
            mobilePrice.Add(100);

            mobileName.Add("Motorola");
            mobilePrice.Add(90);

            mobileName.Add("Sony");
            mobilePrice.Add(30);

            // copy the data to the listbox - this might be better as a function

            for (int i = 0; i < mobileName.Count; i++)
            {
                string listLine = mobileName[i] + " price is " + Convert.ToString(mobilePrice[i]);

                listBoxMobileData.Items.Add(listLine);
            }
        }

        private void buttonMostExpensive_Click(object sender, EventArgs e)
        {
            // set up variables to hold the earliest (lowest) year
            // put now so every company will be earlier than this

            double expensiveMobile = 0;     // for youngest (highest year) start with 0 say...

            // and the name of that company

            string expensiveName = "";

            // now we look through the list in turn
            for (int i = 0; i < mobileName.Count; i++)
            {
                // if the company is earler than the current best then
                // update the earliest year and name with this companies details

                if (mobilePrice[i] > expensiveMobile)
                {
                    expensiveMobile = mobilePrice[i];
                    expensiveName = mobileName[i];
                }
                
            }

            // build output text

            string expensive = "most expensive mobile is " + expensiveName + " at " +
                Convert.ToString(expensiveMobile);

            // write to the textbox

            textBoxMostExpensive.Text = expensive;
        }

        private void buttonCheapest_Click(object sender, EventArgs e)
        {
            

            double cheapestMobile = 35;     
            // and the name of that company

            string cheapestName = "";

            // now we look through the list in turn
            for (int i = 0; i < mobilePrice.Count; i++)
            {
                // if the company is earler than the current best then
                // update the earliest year and name with this companies details

                if (mobilePrice[i] < cheapestMobile)
                {
                    cheapestMobile = mobilePrice[i];
                }
                cheapestName = mobileName[i];
            }

            // build output text

            string cheapest = "cheapest mobile is " + cheapestName + " at " +
                Convert.ToString(cheapestMobile);

            // write to the textbox

            textBoxCheapest.Text = cheapest;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To find the most expensive phone click the most expensive button and to find the most cheapest button click on the button that reads cheapest to store mobile data type in the mobile name and price in the text box and select the store button");
        }

        private void buttonStore_Click(object sender, EventArgs e)
        {
            string newMobileName;

            double newMobilePrice;


            newMobileName = textBoxMobileName.Text;

            newMobilePrice = Convert.ToDouble(textBoxMobilePrice.Text);

            mobileName.Add(newMobileName);

            mobilePrice.Add(newMobilePrice);

            string listLine = newMobileName + " - " + Convert.ToDouble((newMobilePrice));

            listBoxMobileData.Items.Add(listLine);

        }


    }
}
