namespace OrderCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double GetValue(string text)
        {
            if(string.IsNullOrEmpty(text))
                return 0;

            double value;

            if(double.TryParse(text, out value))
                return value;
            else
                return 0;
        }

        private readonly string[] prodCode =
            {"3115", "3116", "3117", "3118", "3119"};
        private readonly string[] prodDesc =
            {"USB Scanner", "Monitor 17'", "Mono Laser Printer", "LCD/TV Monitor 19'", "Colour Laser Printer"};
        private readonly string[] prodPrice = 
            {"49.99", "159.99", "129.99", "319.99", "349.99"};

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach(TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.Clear();
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //check textbox isn't empty
            string prodCode1 = txtCode1.Text;
            string prodCode2 = txtCode2.Text;
            string prodCode3 = txtCode3.Text;
            string prodCode4 = txtCode4.Text;
            string prodCode5 = txtCode5.Text;

            string prodQty1 = txtQty1.Text;
            string prodQty2 = txtQty2.Text;
            string prodQty3 = txtQty3.Text;
            string prodQty4 = txtQty4.Text;
            string prodQty5 = txtQty5.Text;

            double number = 0;
            bool isNumber = false;

            if(!prodCode1.Equals(""))
            { 
              bool isFound = false;
              int position = -1;

                for(int i = 0; i < prodCode.Length; i++)
                {
                     if(prodCode1.Equals(prodCode[i]))
                     {
                         isFound = true;
                         position = i;
                     }
                }
                
                if(isFound)
                {
                    isNumber = double.TryParse(txtQty1.Text, out number);
                    if(isNumber)
                    {
                        //set description
                        txtDesc1.Text = prodDesc[position];

                        //calculate price
                        if(!prodQty1.Equals(""))
                        { 
                            txtPrice1.Text = prodPrice[position];
                            double quantity1 = Double.Parse(txtQty1.Text);  
                            double price1 = Double.Parse(prodPrice[position]) * quantity1;
                            txtTotal1.Text = Math.Round(price1, 2).ToString();
                        }

                        else
                        {
                            txtDesc1.Text = "Please enter a quantity";
                        }
                    }

                    else
                    {
                        txtQty1.Text = "Enter a number";
                    }
                }

                else
                {
                    txtDesc1.Text = "Unit not found";
                }
            }

              if(!prodCode2.Equals(""))
              { 
              bool isFound = false;
              int position = -1;

                for(int i = 0; i < prodCode.Length; i++)
                {
                     if(prodCode2.Equals(prodCode[i]))
                     {
                         isFound = true;
                         position = i;
                     }
                }
                
                if(isFound)
                {
                    isNumber = double.TryParse(txtQty2.Text, out number);
                    if(isNumber)
                    {
                        //set description
                        txtDesc2.Text = prodDesc[position];

                        //calculate price
                        if(!prodQty2.Equals(""))
                        { 
                            txtPrice2.Text = prodPrice[position];
                            double quantity2 = Double.Parse(txtQty1.Text);  
                            double price2 = Double.Parse(prodPrice[position]) * quantity2;
                            txtTotal2.Text = Math.Round(price2, 2).ToString();
                        }

                        else
                        {
                            txtDesc2.Text = "Please enter a quantity";
                        }
                    }

                    else
                    {
                        txtQty2.Text = "Enter a number";
                    }
                }

                 else
                 {
                     txtDesc2.Text = "Unit not found";
                 }
              }

              if(!prodCode3.Equals(""))
              { 
                bool isFound = false;
                int position = -1;

                for(int i = 0; i < prodCode.Length; i++)
                {
                     if(prodCode3.Equals(prodCode[i]))
                     {
                         isFound = true;
                         position = i;
                     }
                }
                
                if(isFound)
                {
                    isNumber = double.TryParse(txtQty3.Text, out number);
                    if(isNumber)
                    {
                        //set description
                        txtDesc3.Text = prodDesc[position];

                        //calculate price
                        if(!prodQty3.Equals("") && isNumber)
                        { 
                            txtPrice3.Text = prodPrice[position];
                            double quantity3 = Double.Parse(txtQty3.Text);  
                            double price3 = Double.Parse(prodPrice[position]) * quantity3;
                            txtTotal3.Text = Math.Round(price3, 2).ToString();
                        }

                        else
                        {
                            txtDesc3.Text = "Please enter a quantity";
                        }
                    }

                    else
                    {
                        txtQty3.Text = "Enter a number";
                    }
                }

                else
                {
                    txtDesc3.Text = "Unit not found";
                }
              }

              if(!prodCode4.Equals(""))
              { 
                bool isFound = false;
                int position = -1;

                for(int i = 0; i < prodCode.Length; i++)
                {
                     if(prodCode4.Equals(prodCode[i]))
                     {
                         isFound = true;
                         position = i;
                     }
                }
                
                if(isFound)
                {
                    isNumber = double.TryParse(txtQty4.Text, out number);
                    if(isNumber)
                    {
                        //set description
                        txtDesc4.Text = prodDesc[position];

                        //calculate price
                        if(!prodQty4.Equals(""))
                        { 
                            txtPrice4.Text = prodPrice[position];
                            double quantity4 = Double.Parse(txtQty4.Text);  
                            double price4 = Double.Parse(prodPrice[position]) * quantity4;
                            txtTotal4.Text = Math.Round(price4, 2).ToString();
                        }

                        else
                        {
                            txtDesc4.Text = "Please enter a quantity";
                        }
                    }

                    else
                    {
                        txtQty4.Text = "Enter a number";
                    }
                }

                else
                {
                    txtDesc4.Text = "Unit not found";
                }
              }

              if(!prodCode5.Equals(""))
              { 
                bool isFound = false;
                int position = -1;

                for(int i = 0; i < prodCode.Length; i++)
                {
                     if(prodCode5.Equals(prodCode[i]))
                     {
                         isFound = true;
                         position = i;
                     }
                }
                
                if(isFound)
                {
                    isNumber = double.TryParse(txtQty5.Text, out number);
                    if(isNumber)
                    {
                        //set description
                        txtDesc5.Text = prodDesc[position];

                        //calculate price
                        if(!prodQty5.Equals(""))
                        { 
                            txtPrice5.Text = prodPrice[position];
                            double quantity5 = Double.Parse(txtQty4.Text);  
                            double price5 = Double.Parse(prodPrice[position]) * quantity5;
                            txtTotal5.Text = Math.Round(price5, 2).ToString();
                        }

                        else
                        {
                            txtDesc5.Text = "Please enter a quantity";
                        }
                    }

                    else
                    {
                        txtQty5.Text = "Enter a number";
                    }
                }

                else
                {
                    txtDesc5.Text = "Unit not found";
                }
              }

             double subTotal = 
                GetValue(txtTotal1.Text) +
                GetValue(txtTotal2.Text) +
                GetValue(txtTotal3.Text) +
                GetValue(txtTotal4.Text) +
                GetValue(txtTotal5.Text);
            txtSubtotal.Text = ($"£{Math.Round(subTotal, 2).ToString()}");

            if(subTotal > 5000)
            {
                double orderTotal = subTotal - (subTotal * 10 / 100);
                txtDiscount.Text = "10%";
                txtOrderTotal.Text = ($"£{Math.Round(orderTotal, 2).ToString()}");
            }

            else
            {
                txtDiscount.Text = "0%";
                txtOrderTotal.Text = ($"£{Math.Round(subTotal, 2).ToString()}");
            }
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string prodCode1 = txtCode1.Text;
            string prodCode2 = txtCode2.Text;
            string prodCode3 = txtCode3.Text;
            string prodCode4 = txtCode4.Text;
            string prodCode5 = txtCode5.Text;

            string prodQty1 = txtQty1.Text;
            string prodQty2 = txtQty2.Text;
            string prodQty3 = txtQty3.Text;
            string prodQty4 = txtQty4.Text;
            string prodQty5 = txtQty5.Text;

            double number = 0;
            bool isNumber = false;

            if(!prodCode1.Equals(""))
            { 
              bool isFound = false;
              int position = -1;

                for(int i = 0; i < prodCode.Length; i++)
                {
                     if(prodCode1.Equals(prodCode[i]))
                     {
                         isFound = true;
                         position = i;
                     }
                }
                
                if(isFound)
                {
                    isNumber = double.TryParse(txtQty1.Text, out number);
                    if(isNumber)
                    {
                        //set description
                        txtDesc1.Text = prodDesc[position];

                        //calculate price
                        if(!prodQty1.Equals(""))
                        { 
                            txtPrice1.Text = prodPrice[position];
                            double quantity1 = Double.Parse(txtQty1.Text);  
                            double price1 = Double.Parse(prodPrice[position]) * quantity1;
                            txtTotal1.Text = Math.Round(price1, 2).ToString();
                        }

                        else
                        {
                            txtDesc1.Text = "Please enter a quantity";
                        }
                    }

                    else
                    {
                        txtQty1.Text = "Enter a number";
                    }
                }

                else
                {
                    txtDesc1.Text = "Unit not found";
                }
            }

              if(!prodCode2.Equals(""))
              { 
              bool isFound = false;
              int position = -1;

                for(int i = 0; i < prodCode.Length; i++)
                {
                     if(prodCode2.Equals(prodCode[i]))
                     {
                         isFound = true;
                         position = i;
                     }
                }
                
                if(isFound)
                {
                    isNumber = double.TryParse(txtQty2.Text, out number);
                    if(isNumber)
                    {
                        //set description
                        txtDesc2.Text = prodDesc[position];

                        //calculate price
                        if(!prodQty2.Equals(""))
                        { 
                            txtPrice2.Text = prodPrice[position];
                            double quantity2 = Double.Parse(txtQty1.Text);  
                            double price2 = Double.Parse(prodPrice[position]) * quantity2;
                            txtTotal2.Text = Math.Round(price2, 2).ToString();
                        }

                        else
                        {
                            txtDesc2.Text = "Please enter a quantity";
                        }
                    }

                    else
                    {
                        txtQty2.Text = "Enter a number";
                    }
                }

                 else
                 {
                     txtDesc2.Text = "Unit not found";
                 }
              }

              if(!prodCode3.Equals(""))
              { 
                bool isFound = false;
                int position = -1;

                for(int i = 0; i < prodCode.Length; i++)
                {
                     if(prodCode3.Equals(prodCode[i]))
                     {
                         isFound = true;
                         position = i;
                     }
                }
                
                if(isFound)
                {
                    isNumber = double.TryParse(txtQty3.Text, out number);
                    if(isNumber)
                    {
                        //set description
                        txtDesc3.Text = prodDesc[position];

                        //calculate price
                        if(!prodQty3.Equals("") && isNumber)
                        { 
                            txtPrice3.Text = prodPrice[position];
                            double quantity3 = Double.Parse(txtQty3.Text);  
                            double price3 = Double.Parse(prodPrice[position]) * quantity3;
                            txtTotal3.Text = Math.Round(price3, 2).ToString();
                        }

                        else
                        {
                            txtDesc3.Text = "Please enter a quantity";
                        }
                    }

                    else
                    {
                        txtQty3.Text = "Enter a number";
                    }
                }

                else
                {
                    txtDesc3.Text = "Unit not found";
                }
              }

              if(!prodCode4.Equals(""))
              { 
                bool isFound = false;
                int position = -1;

                for(int i = 0; i < prodCode.Length; i++)
                {
                     if(prodCode4.Equals(prodCode[i]))
                     {
                         isFound = true;
                         position = i;
                     }
                }
                
                if(isFound)
                {
                    isNumber = double.TryParse(txtQty4.Text, out number);
                    if(isNumber)
                    {
                        //set description
                        txtDesc4.Text = prodDesc[position];

                        //calculate price
                        if(!prodQty4.Equals(""))
                        { 
                            txtPrice4.Text = prodPrice[position];
                            double quantity4 = Double.Parse(txtQty4.Text);  
                            double price4 = Double.Parse(prodPrice[position]) * quantity4;
                            txtTotal4.Text = Math.Round(price4, 2).ToString();
                        }

                        else
                        {
                            txtDesc4.Text = "Please enter a quantity";
                        }
                    }

                    else
                    {
                        txtQty4.Text = "Enter a number";
                    }
                }

                else
                {
                    txtDesc4.Text = "Unit not found";
                }
              }

              if(!prodCode5.Equals(""))
              { 
                bool isFound = false;
                int position = -1;

                for(int i = 0; i < prodCode.Length; i++)
                {
                     if(prodCode5.Equals(prodCode[i]))
                     {
                         isFound = true;
                         position = i;
                     }
                }
                
                if(isFound)
                {
                    isNumber = double.TryParse(txtQty5.Text, out number);
                    if(isNumber)
                    {
                        //set description
                        txtDesc5.Text = prodDesc[position];

                        //calculate price
                        if(!prodQty5.Equals(""))
                        { 
                            txtPrice5.Text = prodPrice[position];
                            double quantity5 = Double.Parse(txtQty4.Text);  
                            double price5 = Double.Parse(prodPrice[position]) * quantity5;
                            txtTotal5.Text = Math.Round(price5, 2).ToString();
                        }

                        else
                        {
                            txtDesc5.Text = "Please enter a quantity";
                        }
                    }

                    else
                    {
                        txtQty5.Text = "Enter a number";
                    }
                }

                else
                {
                    txtDesc5.Text = "Unit not found";
                }
              }

              double subTotal = 
                GetValue(txtTotal1.Text) +
                GetValue(txtTotal2.Text) +
                GetValue(txtTotal3.Text) +
                GetValue(txtTotal4.Text) +
                GetValue(txtTotal5.Text);
            txtSubtotal.Text = ($"£{Math.Round(subTotal, 2).ToString()}");

            if(subTotal > 5000)
            {
                double orderTotal = subTotal - (subTotal * 10 / 100);
                txtDiscount.Text = "10%";
                txtOrderTotal.Text = ($"£{Math.Round(orderTotal, 2).ToString()}");
            }

            else
            {
                txtDiscount.Text = "0%";
                txtOrderTotal.Text = ($"£{Math.Round(subTotal, 2).ToString()}");
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.Clear();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Your order total is: {txtOrderTotal.Text}");
            this.Close();
        }
    }
}