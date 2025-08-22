namespace fastFood
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            datelb1.Text = DateTime.Now.ToLongTimeString();
        }

        private void label32_Click_1(object sender, EventArgs e)
        {
            datelb1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true) {
                textBox1.Enabled = true;
            }
            if(checkBox1.Checked==false)
            {
                textBox1.Enabled=false;
                textBox1.Text = "0";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox2.Enabled = true;
            }
            if (checkBox2.Checked == false)
            {
                textBox2.Enabled = false;
                textBox2.Text = "0";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox3.Enabled = true;
            }
            if (checkBox3.Checked == false)
            {
                textBox3.Enabled = false;
                textBox3.Text = "0";
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox4.Enabled = true;
            }
            if (checkBox4.Checked == false)
            {
                textBox4.Enabled = false;
                textBox4.Text = "0";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                textBox5.Enabled = true;
            }
            if (checkBox5.Checked == false)
            {
                textBox5.Enabled = false;
                textBox5.Text = "0";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                textBox6.Enabled = true;
            }
            if (checkBox6.Checked == false)
            {
                textBox6.Enabled = false;
                textBox6.Text = "0";
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                textBox7.Enabled = true;
            }
            if (checkBox7.Checked == false)
            {
                textBox7.Enabled = false;
                textBox7.Text = "0";
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                textBox8.Enabled = true;
            }
            if (checkBox8.Checked == false)
            {
                textBox8.Enabled = false;
                textBox8.Text = "0";
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                textBox9.Enabled = true;
            }
            if (checkBox9.Checked == false)
            {
                textBox9.Enabled = false;
                textBox9.Text = "0";
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                textBox10.Enabled = true;
            }
            if (checkBox10.Checked == false)
            {
                textBox10.Enabled = false;
                textBox10.Text = "0";
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                textBox11.Enabled = true;
            }
            if (checkBox11.Checked == false)
            {
                textBox11.Enabled = false;
                textBox11.Text = "0";
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                textBox12.Enabled = true;
            }
            if (checkBox12.Checked == false)
            {
                textBox12.Enabled = false;
                textBox12.Text = "0";
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                textBox13.Enabled = true;
            }
            if (checkBox13.Checked == false)
            {
                textBox13.Enabled = false;
                textBox13.Text = "0";
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                textBox14.Enabled = true;
            }
            if (checkBox14.Checked == false)
            {
                textBox14.Enabled = false;
                textBox14.Text = "0";
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //DECIDE PRICE OF MENU
        double burgerup = 90, chese_burgerup = 135, friesup = 50, hot_dogup = 150, sandwichup = 60, pizzaup = 220, rollup = 120;
        double hot_coffeeup = 25, cold_coffeeup = 80, cocoup = 40, shakeup = 75, ice_creamup = 30, juiceup = 60, cakeup = 55;

        private void printPreviewDialog1_Load_1(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text + "Subtotal" + Subtotal1.Text + "Tax: " + tax.Text + "Grand Total" + Grand_total.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Blue, new Point(130, 100));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()== DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void tax_Click(object sender, EventArgs e)
        {

        }

        //private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e){
        //}
        //private void printPreviewDialog1_Load(object sender, EventArgs e){}

        //Declare variable to hold total price for each drink and meals
        double burgertp, chese_burgertp, friestp, hot_dogtp, sandwichtp, pizzatp, rolltp, hot_coffeetp, cold_coffeetp, cocotp, shaketp, ice_creamtp, juicetp, caketp;
        double subtotal = 0, Tax, grand_total;

        private void button2_Click(object sender, EventArgs e)
        {
            burgertp = burgerup * Convert.ToDouble(textBox1.Text);
            chese_burgertp = chese_burgerup * Convert.ToDouble(textBox2.Text);
            friestp = friesup * Convert.ToDouble(textBox3.Text);
            hot_dogtp = hot_dogup * Convert.ToDouble(textBox4.Text);
            sandwichtp = sandwichup * Convert.ToDouble(textBox5.Text);
            pizzatp = pizzaup * Convert.ToDouble(textBox6.Text);
            rolltp = rollup * Convert.ToDouble(textBox7.Text);
            hot_coffeetp = hot_coffeeup * Convert.ToDouble(textBox8.Text);
            cold_coffeetp = cold_coffeeup * Convert.ToDouble(textBox9.Text);
            cocotp = cocoup * Convert.ToDouble(textBox10.Text);
            shaketp = shakeup * Convert.ToDouble(textBox11.Text);
            juicetp = juiceup * Convert.ToDouble(textBox12.Text);
            caketp = cakeup * Convert.ToDouble(textBox13.Text);
            ice_creamtp = ice_creamup * Convert.ToDouble(textBox14.Text);
            //Now let's add product on the receipt
            richTextBox1.Clear();
            Tax = 0;
            grand_total = 0;
            subtotal = 0;
            richTextBox1 .AppendText(Environment.NewLine);
            richTextBox1.AppendText("\t\t\tCODESPACE RESTAURENT\t\t\t" +datelb1.Text+ Environment.NewLine);
            richTextBox1.AppendText("\t\t\t*************************************"+Environment.NewLine);
            if (checkBox1.Checked == true)
            {
                richTextBox1.AppendText("\tBurger\t" + burgertp+"Rs" + Environment.NewLine);
                subtotal = subtotal + burgertp;
                Subtotal1.Text = "" + subtotal;
            }
            if (checkBox2.Checked == true)
            {
                richTextBox1.AppendText("\tChese_Burger\t" + chese_burgertp + "Rs" + Environment.NewLine);
                subtotal = subtotal + chese_burgertp;
                Subtotal1.Text = "" + subtotal;
            }
            if (checkBox3.Checked == true)
            {
                richTextBox1.AppendText("\tFries\t" + friestp + "Rs" + Environment.NewLine);
                subtotal = subtotal + friestp;
                Subtotal1.Text = "" + subtotal;
            }
            if (checkBox4.Checked == true)
            {
                richTextBox1.AppendText("\tHot_Dog\t" + hot_dogtp + "Rs" + Environment.NewLine);
                subtotal = subtotal + hot_dogtp;
                Subtotal1.Text = "" + subtotal;
            }
            if (checkBox5.Checked == true)
            {

                richTextBox1.AppendText("\tSandwich\t" + sandwichtp + "Rs" + Environment.NewLine);
                subtotal = subtotal + sandwichtp;
                Subtotal1.Text = "" + subtotal;
            }
            if (checkBox6.Checked == true)
            {
                richTextBox1.AppendText("\tPizza\t" + pizzatp + "Rs" + Environment.NewLine);
                subtotal = subtotal + pizzatp;
                Subtotal1.Text = "" + subtotal;
            }
            if (checkBox7.Checked == true)
            {
                richTextBox1.AppendText("\tRoll\t" + rolltp + "Rs" + Environment.NewLine);
                subtotal = subtotal + rolltp;
                Subtotal1.Text = "" + subtotal;
            }
            if (checkBox8.Checked == true)
            {
                richTextBox1.AppendText("\tHot coffee\t" + hot_coffeetp + "Rs" + Environment.NewLine);
                subtotal = subtotal + hot_coffeetp;
                Subtotal1.Text = "" + subtotal;
            }
            if (checkBox9.Checked == true)
            {
                richTextBox1.AppendText("\tCold Coffee\t" + cold_coffeetp + "Rs" + Environment.NewLine);
                subtotal = subtotal + cold_coffeetp;
                Subtotal1.Text = "" + subtotal;
            }
            if (checkBox10.Checked == true)
            {
                richTextBox1.AppendText("\tCoco Cola\t" + cocotp + "Rs" + Environment.NewLine);
                subtotal = subtotal + cocotp;
                Subtotal1.Text = "" + subtotal;
            }
            if (checkBox11.Checked == true)
            {
                richTextBox1.AppendText("\tShake\t" + shaketp + "Rs" + Environment.NewLine);
                subtotal = subtotal + shaketp;
                Subtotal1.Text = "" + subtotal;
            }
            if (checkBox12.Checked == true)
            {
                richTextBox1.AppendText("\tJuice\t" + juicetp + "Rs" + Environment.NewLine);
                subtotal = subtotal + juicetp;
                Subtotal1.Text = "" + subtotal;
            }
            if (checkBox13.Checked == true)
            {
                richTextBox1.AppendText("\tCake\t" + caketp + "Rs" + Environment.NewLine);
                subtotal = subtotal + caketp;
                Subtotal1.Text = "" + subtotal;
            }
            if (checkBox14.Checked == true)
            {
                richTextBox1.AppendText("\tIce Cream\t" + ice_creamtp + "Rs" + Environment.NewLine);
                subtotal = subtotal + ice_creamtp;
                Subtotal1.Text = "" + subtotal;
            }
            Tax = subtotal * 0.16;
            grand_total = subtotal + Tax;
            tax.Text = "Rs" + Tax;
            Grand_total.Text = "Rs" + grand_total;
        }

  
        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox1.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            // Action for clicking label16 (if needed)
        }

        private void Subtotal1_Click(object sender, EventArgs e)
        {
            // Action for clicking Subtotal1 (maybe calculating subtotal)
        }

    }
}