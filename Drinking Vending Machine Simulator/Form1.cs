using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drinking_Vending_Machine_Simulator
{
    struct Drink
    {
        public String name;
        public double cost;
        public int numInMachine;
    }
    public partial class Form1 : Form
    {
        // Create an array of five Drink objects
        private Drink[] drink = new Drink[5];
        // Total sales, this will be used when clicked event handler is called
        private static double totalSales = 0.0;
        public Form1()
        {            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create new object for every drink, and put them into the array.
            Drink cola = new Drink();
            cola.name = "Cola";
            cola.cost = 1.0;
            cola.numInMachine = 20;
            drink[0] = cola;

            Drink beer = new Drink();
            beer.name = "Root Beer";
            beer.cost = 1.0;
            beer.numInMachine = 20;
            drink[1] = beer;

            Drink lemonLime = new Drink();
            lemonLime.name = "Lemon Lime";
            lemonLime.cost = 1.0;
            lemonLime.numInMachine = 20;
            drink[2] = lemonLime;

            Drink grapeSoda = new Drink();
            grapeSoda.name = "Grape Soda";
            grapeSoda.cost = 1.5;
            grapeSoda.numInMachine = 20;
            drink[3] = grapeSoda;

            Drink creamSoda = new Drink();
            creamSoda.name = "Cream Soda";
            creamSoda.cost = 1.5;
            creamSoda.numInMachine = 20;
            drink[4] = creamSoda;

            // When loaded, the text box of each drink should be 20,
            // the totalSales will be $0.00 by default.
            tbxCola.Text = cola.numInMachine.ToString();
            tbxBeer.Text = beer.numInMachine.ToString();
            tbxLemonLime.Text = lemonLime.numInMachine.ToString();
            tbxGrapeSoda.Text = grapeSoda.numInMachine.ToString();
            tbxCreamSoda.Text = creamSoda.numInMachine.ToString();
            tbxTotalSales.Text = totalSales.ToString("C");
        }
        
        private void pbxCola_Click(object sender, EventArgs e)
        {

            if (drink[0].numInMachine > 0)
            {
                drink[0].numInMachine--;
                totalSales = totalSales + drink[0].cost;
                refresh();
            }
            else
                MessageBox.Show("   SOLD OUT!", "COLA", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);       
        }
        private void pbxBeer_Click(object sender, EventArgs e)
        {
            if (drink[1].numInMachine > 0)
            {
                drink[1].numInMachine--;
                totalSales = totalSales + drink[1].cost;
                refresh();
            }
            else
                MessageBox.Show("   SOLD OUT!", "ROOT BEER",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void pbxLemonLime_Click(object sender, EventArgs e)
        {
            if (drink[2].numInMachine > 0)
            {
                drink[2].numInMachine--;
                totalSales = totalSales + drink[2].cost;
                refresh();
            }
            else
                MessageBox.Show("   SOLD OUT!", "LEMON LIME",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void pbxGrapeSoda_Click(object sender, EventArgs e)
        {
            if (drink[3].numInMachine > 0)
            {
                drink[3].numInMachine--;
                totalSales = totalSales + drink[3].cost;
                refresh();
            }
            else
                MessageBox.Show("   SOLD OUT!", "GRAPE SODA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void pbxCreamSoda_Click(object sender, EventArgs e)
        {
            if (drink[4].numInMachine > 0)
            {
                drink[4].numInMachine--;
                totalSales = totalSales + drink[4].cost;
                refresh();
            }
            else
                MessageBox.Show("   SOLD OUT!", "CREAM SODA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        // This method will update the drink left for each drink, 
        // and the total sales.
        public void refresh()
        {            
            tbxCola.Text = drink[0].numInMachine.ToString();
            tbxBeer.Text = drink[1].numInMachine.ToString();
            tbxLemonLime.Text = drink[2].numInMachine.ToString();
            tbxGrapeSoda.Text = drink[3].numInMachine.ToString();
            tbxCreamSoda.Text = drink[4].numInMachine.ToString();                         
            tbxTotalSales.Text = totalSales.ToString("C");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

