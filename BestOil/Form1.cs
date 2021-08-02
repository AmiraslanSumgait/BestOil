using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BestOil
{
    public partial class Form1 : Form
    {
        private double fuelAmount;
        private double foodAmount;
        List<Fuel> fuels = new List<Fuel>
        {
            new Fuel("A-92",0.70),
            new Fuel("A-90",1.50),
            new Fuel("A-95",0.80),
            new Fuel("Premium",0.90)

        };
        List<Food> foods = new List<Food>
        {
            new Food("Hot Dog",4),
            new Food("Hamburger",5.40),
            new Food("Fri Potato",7.20),
            new Food("Coco-Cola",4.40)
        };
        
        public Form1()
        {
            InitializeComponent();
            foreach (var fuel in fuels)
            {
                cb_FuelType.Items.Add(fuel.Type);
            }
            
            rb_PerLiter.Enabled = false;
            rb_Price.Enabled = false;
            txtBox_Perliter.Enabled = false;
            txtBox_Price.Enabled = false;
            txtBox_Perliter.BorderColor = Color.Black;
            txtBox_Price.BorderColor = Color.Black;
            tbx_HotDog_Count.Text = "0";
            tbx_CocoCola_Count.Text = "0";
            tbx_Hamburger_Count.Text = "0";
            tbx_PotatoFri_Count.Text = "0";
            tbx_HotDog_Price.Text = foods[0].Price.ToString();
            tbx_Hamburger_Price.Text = foods[1].Price.ToString();
            tbx_PotatoFri_Price.Text = foods[2].Price.ToString();
            tbx_CocoCola_Price.Text = foods[3].Price.ToString();
        }
        private void AutoSizeTextBox(TextBox txt)
        {
            const int x_margin = 0;
            const int y_margin = 2;
            Size size = TextRenderer.MeasureText(txt.Text, txt.Font);
            txt.ClientSize =
                new Size(size.Width + x_margin, size.Height + y_margin);
        }
        private void cb_FuelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_FuelType.SelectedIndex;
            rb_PerLiter.Enabled = true;
            rb_Price.Enabled = true;
            txtBox_FuelPrice.Text = fuels[index].Price.ToString();
        }

        private void rb_PerLiter_CheckedChanged(object sender, EventArgs e)
        {
            txtBox_Price.Text = string.Empty;
            txtBox_Perliter.BorderColor = Color.DarkTurquoise;
            txtBox_Price.Enabled = false;
            txtBox_Perliter.Enabled = true;
            txtBox_Price.BorderColor = Color.Black;
        }

        private void rb_Price_CheckedChanged(object sender, EventArgs e)
        {
            txtBox_Perliter.Text = string.Empty;
            txtBox_Price.BorderColor = Color.DarkTurquoise;
            txtBox_Perliter.Enabled = false;
            txtBox_Price.Enabled = true;
            txtBox_Perliter.BorderColor = Color.Black;
        }

        private void txtBox_Perliter_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtBox_Perliter.Text, @"^*[0-9\.]+$"))
            {
                txtBox_Perliter.Text = "";
            }
            else
            {
                fuelAmount = double.Parse(txtBox_Perliter.Text) * fuels[cb_FuelType.SelectedIndex].Price;
                txtbox_GasStation_Amount.Text = fuelAmount.ToString();
            }
        }

        private void txtBox_Price_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtBox_Price.Text, @"^*[0-9\.]+$"))
            {
                txtBox_Price.Text = "";
            }
            else
            {
                txtbox_GasStation_Amount.Text = txtBox_Price.Text;
                fuelAmount = double.Parse(txtBox_Price.Text);
            }
        }

        private void cbx_HotDog_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_HotDog.Checked == true) tbx_HotDog_Count.Enabled = true;
            else
            {
                tbx_HotDog_Count.Enabled = false;
                foodAmount -= (double.Parse(tbx_HotDog_Count.Text) * foods[0].Price);
                txtbox_Minicafe_Amount.Text = foodAmount.ToString();
                tbx_HotDog_Count.Text = "0";
            }
        }
        private void cbx_Hamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Hamburger.Checked == true) tbx_Hamburger_Count.Enabled = true;
            else
            {
                tbx_Hamburger_Count.Enabled = false;
                foodAmount -= (double.Parse(tbx_Hamburger_Count.Text) * foods[1].Price);
                txtbox_Minicafe_Amount.Text = foodAmount.ToString();
                tbx_Hamburger_Count.Text = "0";
            }
        }
        private void cbx_PotatoFri_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_PotatoFri.Checked == true) tbx_PotatoFri_Count.Enabled = true;
            else
            {
                tbx_PotatoFri_Count.Enabled = false;
                foodAmount -= (double.Parse(tbx_PotatoFri_Count.Text) * foods[2].Price);
                txtbox_Minicafe_Amount.Text = foodAmount.ToString();
                tbx_PotatoFri_Count.Text = "0";
            }
        }
        private void cbx_CocoCola_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_CocoCola.Checked == true) tbx_CocoCola_Count.Enabled = true;
            else
            {
                tbx_CocoCola_Count.Enabled = false;
                foodAmount -= (double.Parse(tbx_CocoCola_Count.Text) * foods[3].Price);
                txtbox_Minicafe_Amount.Text = foodAmount.ToString();
                tbx_CocoCola_Count.Text = "0";
            }
        }
        private void tbx_HotDog_Count_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tbx_HotDog_Count.Text, @"^*[0-9\.]+$"))
            {
                tbx_HotDog_Count.Text = "";
            }
            else
            {
                foodAmount+= double.Parse(tbx_HotDog_Count.Text) * foods[0].Price;
                txtbox_Minicafe_Amount.Text = foodAmount.ToString();
            }
          
        }

        private void tbx_Hamburger_Count_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tbx_Hamburger_Count.Text, @"^*[0-9\.]+$"))
            {
                tbx_Hamburger_Count.Text = "";
            }
            else
            {
                foodAmount += double.Parse(tbx_Hamburger_Count.Text) * foods[1].Price;
                txtbox_Minicafe_Amount.Text = foodAmount.ToString();
            }
        }

        private void tbx_PotatoFri_Count_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tbx_PotatoFri_Count.Text, @"^*[0-9\.]+$"))
            {
                tbx_PotatoFri_Count.Text = "";
            }
            else
            {
                foodAmount += double.Parse(tbx_PotatoFri_Count.Text) * foods[2].Price;
                txtbox_Minicafe_Amount.Text = foodAmount.ToString();
            }
        }

        private void tbx_CocoCola_Count_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tbx_CocoCola_Count.Text, @"^*[0-9\.]+$"))
            {
                tbx_CocoCola_Count.Text = "";
            }
            else
            {
                foodAmount += double.Parse(tbx_CocoCola_Count.Text) * foods[3].Price;
                txtbox_Minicafe_Amount.Text = foodAmount.ToString();
            }
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            tbx_AllAmount.Text = (foodAmount + fuelAmount).ToString();
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for choosing us");
            Environment.Exit(0);
        }
    }
}
