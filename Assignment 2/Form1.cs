using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        double tip = 0;
        double total = 0;
        string order="";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // iced coffee
            if (cbxCofType.SelectedIndex == 0)
            {

                
                if (cbxCofSize.SelectedIndex == 0)

                {
                    order = order + "Iced Coffee\n";
                    total += 3;
                }
                else
                    total += 3.5;
            }



            // capp

            if (cbxCofType.SelectedIndex == 1)
            {

                
                if (cbxCofSize.SelectedIndex == 0)

                {
                    order = order + "Cappuccino Coffee\n";
                    total += 3.5;
                }
                else
                    total += 4;
            }


            // latte

            if (cbxCofType.SelectedIndex == 2)
            {

                
                if (cbxCofSize.SelectedIndex == 0)

                {
                    order = order + "Latte Coffee\n";
                    total += 3.5;
                }
                else
                    total += 4;
            }

            //mocha 

            if (cbxCofType.SelectedIndex == 3)
            {

                
                if (cbxCofSize.SelectedIndex == 0)

                {
                    order = order + "Mocha Coffee\n";
                    total += 3.5;
                }
                else
                    total += 4;
            }

            //cream for coffee
            if (cbxCoffee.SelectedIndex == 0)

            {
                order = order + "Cream\n";
                total += 0;
            }
            //sugar for coffee
            if (cbxCoffee.SelectedIndex == 1)

            {
                order = order + "Sugar\n";
                total += 0;
            }
            //cinnamon for coffee
            if (cbxCoffee.SelectedIndex == 2)

            {
                order = order + "Cinnamon\n";
                total += 3;
            }
            //Cocoa for coffee
            if (cbxCoffee.SelectedIndex == 3)

            {
                order = order + "Cocoa\n";
                total += 3;
            }
            //whipped cream for coffee
            if (cbxCoffee.SelectedIndex == 4)

            {
                order = order + "Whipped Cream\n";
                total += 2;
            }

            //Berry Black
            if (cbxTeaType.SelectedIndex == 0)
            {
                
                if (cbxTeaSize.SelectedIndex == 0)

                {
                    order = order + "Berry Black\n";
                    total += 3.5;
                }
                else
                {
                    total += 4;
                }
            }



            // Honey Bush
            if (cbxTeaType.SelectedIndex == 1)
            {
                
                if (cbxTeaSize.SelectedIndex == 0)

                {
                    order = order + "Honey Bush\n";
                    total += 3.5;
                }
                else
                {
                    total += 4;
                }
            }

            // Jasmine Green
            if (cbxTeaType.SelectedIndex == 2)
            {
                
                if (cbxTeaSize.SelectedIndex == 0)

                {
                    order = order + "Jasmine Green\n";
                    total += 3.5;
                }
                else
                {
                    order = order + "Jasmine Green\n";
                    total += 4;
                }
            }
            
            //cream for tea
            if (cbxTea.SelectedIndex == 0)
            {
                order = order + "Tea\n";
                total += 0;
            }
            //sugar for tea
            if (cbxTea.SelectedIndex == 1)
            {
                order = order + "sugar\n";
                total += 0;
            }
            //caramel for tea
            if (cbxTea.SelectedIndex == 2)
            {
                order = order + "Caramel\n";
                total += 1;
            }
            //vanilla for tea
            if (cbxTea.SelectedIndex == 3)
            {
                order = order + "Vanilla\n";
                total += 1;
                  
            }
            int numBrownie = (int)numericUpDown3.Value;
            int numCarrot = (int)numericUpDown2.Value;
            int numChip = (int)numericUpDown1.Value;

          
            //pastry
            double Brownies = numBrownie * 2.50;
            double Carrot = numCarrot * 2.50;
            double Chip = numChip * 2.50;

            total += Brownies + Carrot + Chip;
            if (numBrownie + numCarrot + numChip <= 1)
            {
                total += .5;
            }
            if (numBrownie + numCarrot + numChip <= 10)
            {
                total += 1;
            }
            else
            {
                total += 1.5;
            }

            //find tip

            tip = Convert.ToDouble(tbxTip.Text);



            //create a class

            calc calc1 = new calc(total, tip);
            total = calc1.math();




            // display

            MessageBox.Show(order + "\n" + total.ToString("C"));

            //stay above this line

            

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void btClear_Click(object sender, EventArgs e)
        {
           
        }

        private void btClear_Click_1(object sender, EventArgs e)
        {
            cbxCoffee.ClearSelected();
            foreach (int index in cbxCoffee.CheckedIndices)
            {
                cbxCoffee.SetItemChecked(index, false);
            }

            cbxTea.ClearSelected();
            foreach (int index in cbxTea.CheckedIndices)
            {
                cbxTea.SetItemChecked(index, false);
            }

            cbxCofType.ResetText();
            cbxCofSize.ResetText();
            cbxTeaSize.ResetText();
            cbxTeaType.ResetText();
            numericUpDown1.ResetText();
            numericUpDown2.ResetText();
            numericUpDown3.ResetText();


        }

        private void lbBrown_Click(object sender, EventArgs e)
        {

        }

        private void cbxTea_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
