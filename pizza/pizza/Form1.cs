using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Small");
            comboBox1.Items.Add("Mediam");
            comboBox1.Items.Add("Large");
            comboBox1.Text = "Select Pizza Size";

            checkBox1.Text = "Extra Cheese";
            checkBox2.Text = "Pepperoni";
            checkBox3.Text = "Mushrooms";

            radioButton1.Text = "Thin Crust";
            radioButton2.Text = "Thick Crust";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSize = comboBox1.SelectedItem.ToString();
            MessageBox.Show($"You selected: {selectedSize}");

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string size = comboBox1.SelectedItem?.ToString() ?? "No size selected";
            string toppings = "";
            string crust = "";

            if (checkBox1.Checked)
            {
                toppings += "Extra Cheese, ";
            }

            if (checkBox2.Checked)
            {
                toppings += "Pepperoni, ";
            }

            if (checkBox3.Checked)
            {
                toppings += "Mushrooms, ";
            }

            if (radioButton1.Checked)
            {
                crust = "Thin Crust";
            }
            else if (radioButton2.Checked)
            {
                crust = "Thick Crust";
            }

          
            if (toppings.EndsWith(", "))
            {
                toppings = toppings.Substring(0, toppings.Length - 2);
            }

            string orderSummary = $"Pizza Size: {size}\nToppings: {toppings}\nCrust: {crust}";
            textBox1.Text = orderSummary;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
          
           
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }

   
    
}
