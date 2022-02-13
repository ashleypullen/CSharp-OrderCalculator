namespace OrderCalc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCode1 = new System.Windows.Forms.TextBox();
            this.txtCode2 = new System.Windows.Forms.TextBox();
            this.txtCode3 = new System.Windows.Forms.TextBox();
            this.txtCode4 = new System.Windows.Forms.TextBox();
            this.txtDesc1 = new System.Windows.Forms.TextBox();
            this.txtDesc2 = new System.Windows.Forms.TextBox();
            this.txtDesc3 = new System.Windows.Forms.TextBox();
            this.txtDesc4 = new System.Windows.Forms.TextBox();
            this.txtQty1 = new System.Windows.Forms.TextBox();
            this.txtQty2 = new System.Windows.Forms.TextBox();
            this.txtQty3 = new System.Windows.Forms.TextBox();
            this.txtQty4 = new System.Windows.Forms.TextBox();
            this.txtPrice1 = new System.Windows.Forms.TextBox();
            this.txtPrice2 = new System.Windows.Forms.TextBox();
            this.txtPrice3 = new System.Windows.Forms.TextBox();
            this.txtPrice4 = new System.Windows.Forms.TextBox();
            this.txtTotal1 = new System.Windows.Forms.TextBox();
            this.txtTotal2 = new System.Windows.Forms.TextBox();
            this.txtTotal3 = new System.Windows.Forms.TextBox();
            this.txtTotal4 = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCode5 = new System.Windows.Forms.TextBox();
            this.txtDesc5 = new System.Windows.Forms.TextBox();
            this.txtQty5 = new System.Windows.Forms.TextBox();
            this.txtPrice5 = new System.Windows.Forms.TextBox();
            this.txtTotal5 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(261, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(130, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(442, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(567, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(675, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(516, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Subtotal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(516, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Discount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(516, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Order Total";
            // 
            // txtCode1
            // 
            this.txtCode1.Location = new System.Drawing.Point(21, 89);
            this.txtCode1.Name = "txtCode1";
            this.txtCode1.Size = new System.Drawing.Size(100, 23);
            this.txtCode1.TabIndex = 9;
            // 
            // txtCode2
            // 
            this.txtCode2.Location = new System.Drawing.Point(21, 118);
            this.txtCode2.Name = "txtCode2";
            this.txtCode2.Size = new System.Drawing.Size(100, 23);
            this.txtCode2.TabIndex = 10;
            // 
            // txtCode3
            // 
            this.txtCode3.Location = new System.Drawing.Point(21, 147);
            this.txtCode3.Name = "txtCode3";
            this.txtCode3.Size = new System.Drawing.Size(100, 23);
            this.txtCode3.TabIndex = 11;
            // 
            // txtCode4
            // 
            this.txtCode4.Location = new System.Drawing.Point(21, 176);
            this.txtCode4.Name = "txtCode4";
            this.txtCode4.Size = new System.Drawing.Size(100, 23);
            this.txtCode4.TabIndex = 12;
            // 
            // txtDesc1
            // 
            this.txtDesc1.Enabled = false;
            this.txtDesc1.Location = new System.Drawing.Point(127, 89);
            this.txtDesc1.Name = "txtDesc1";
            this.txtDesc1.Size = new System.Drawing.Size(276, 23);
            this.txtDesc1.TabIndex = 13;
            // 
            // txtDesc2
            // 
            this.txtDesc2.Enabled = false;
            this.txtDesc2.Location = new System.Drawing.Point(127, 118);
            this.txtDesc2.Name = "txtDesc2";
            this.txtDesc2.Size = new System.Drawing.Size(276, 23);
            this.txtDesc2.TabIndex = 14;
            // 
            // txtDesc3
            // 
            this.txtDesc3.Enabled = false;
            this.txtDesc3.Location = new System.Drawing.Point(127, 147);
            this.txtDesc3.Name = "txtDesc3";
            this.txtDesc3.Size = new System.Drawing.Size(276, 23);
            this.txtDesc3.TabIndex = 15;
            // 
            // txtDesc4
            // 
            this.txtDesc4.Enabled = false;
            this.txtDesc4.Location = new System.Drawing.Point(127, 176);
            this.txtDesc4.Name = "txtDesc4";
            this.txtDesc4.Size = new System.Drawing.Size(276, 23);
            this.txtDesc4.TabIndex = 16;
            // 
            // txtQty1
            // 
            this.txtQty1.Location = new System.Drawing.Point(409, 89);
            this.txtQty1.Name = "txtQty1";
            this.txtQty1.Size = new System.Drawing.Size(100, 23);
            this.txtQty1.TabIndex = 17;
            // 
            // txtQty2
            // 
            this.txtQty2.Location = new System.Drawing.Point(409, 118);
            this.txtQty2.Name = "txtQty2";
            this.txtQty2.Size = new System.Drawing.Size(100, 23);
            this.txtQty2.TabIndex = 18;
            // 
            // txtQty3
            // 
            this.txtQty3.Location = new System.Drawing.Point(409, 147);
            this.txtQty3.Name = "txtQty3";
            this.txtQty3.Size = new System.Drawing.Size(100, 23);
            this.txtQty3.TabIndex = 19;
            // 
            // txtQty4
            // 
            this.txtQty4.Location = new System.Drawing.Point(409, 176);
            this.txtQty4.Name = "txtQty4";
            this.txtQty4.Size = new System.Drawing.Size(100, 23);
            this.txtQty4.TabIndex = 20;
            // 
            // txtPrice1
            // 
            this.txtPrice1.Enabled = false;
            this.txtPrice1.Location = new System.Drawing.Point(512, 89);
            this.txtPrice1.Name = "txtPrice1";
            this.txtPrice1.Size = new System.Drawing.Size(100, 23);
            this.txtPrice1.TabIndex = 21;
            // 
            // txtPrice2
            // 
            this.txtPrice2.Enabled = false;
            this.txtPrice2.Location = new System.Drawing.Point(512, 118);
            this.txtPrice2.Name = "txtPrice2";
            this.txtPrice2.Size = new System.Drawing.Size(100, 23);
            this.txtPrice2.TabIndex = 22;
            // 
            // txtPrice3
            // 
            this.txtPrice3.Enabled = false;
            this.txtPrice3.Location = new System.Drawing.Point(512, 147);
            this.txtPrice3.Name = "txtPrice3";
            this.txtPrice3.Size = new System.Drawing.Size(100, 23);
            this.txtPrice3.TabIndex = 23;
            // 
            // txtPrice4
            // 
            this.txtPrice4.Enabled = false;
            this.txtPrice4.Location = new System.Drawing.Point(512, 176);
            this.txtPrice4.Name = "txtPrice4";
            this.txtPrice4.Size = new System.Drawing.Size(100, 23);
            this.txtPrice4.TabIndex = 24;
            // 
            // txtTotal1
            // 
            this.txtTotal1.Enabled = false;
            this.txtTotal1.Location = new System.Drawing.Point(618, 89);
            this.txtTotal1.Name = "txtTotal1";
            this.txtTotal1.Size = new System.Drawing.Size(100, 23);
            this.txtTotal1.TabIndex = 25;
            // 
            // txtTotal2
            // 
            this.txtTotal2.Enabled = false;
            this.txtTotal2.Location = new System.Drawing.Point(618, 118);
            this.txtTotal2.Name = "txtTotal2";
            this.txtTotal2.Size = new System.Drawing.Size(100, 23);
            this.txtTotal2.TabIndex = 26;
            // 
            // txtTotal3
            // 
            this.txtTotal3.Enabled = false;
            this.txtTotal3.Location = new System.Drawing.Point(618, 147);
            this.txtTotal3.Name = "txtTotal3";
            this.txtTotal3.Size = new System.Drawing.Size(100, 23);
            this.txtTotal3.TabIndex = 27;
            // 
            // txtTotal4
            // 
            this.txtTotal4.Enabled = false;
            this.txtTotal4.Location = new System.Drawing.Point(618, 176);
            this.txtTotal4.Name = "txtTotal4";
            this.txtTotal4.Size = new System.Drawing.Size(100, 23);
            this.txtTotal4.TabIndex = 28;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(618, 263);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 23);
            this.txtSubtotal.TabIndex = 29;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Enabled = false;
            this.txtDiscount.Location = new System.Drawing.Point(618, 292);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 23);
            this.txtDiscount.TabIndex = 30;
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Enabled = false;
            this.txtOrderTotal.Location = new System.Drawing.Point(618, 321);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.Size = new System.Drawing.Size(100, 23);
            this.txtOrderTotal.TabIndex = 31;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(18, 281);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(122, 56);
            this.btnCalculate.TabIndex = 32;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(146, 282);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 55);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calculateToolStripMenuItem.Text = "Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // txtCode5
            // 
            this.txtCode5.Location = new System.Drawing.Point(21, 205);
            this.txtCode5.Name = "txtCode5";
            this.txtCode5.Size = new System.Drawing.Size(100, 23);
            this.txtCode5.TabIndex = 35;
            // 
            // txtDesc5
            // 
            this.txtDesc5.Enabled = false;
            this.txtDesc5.Location = new System.Drawing.Point(127, 205);
            this.txtDesc5.Name = "txtDesc5";
            this.txtDesc5.Size = new System.Drawing.Size(276, 23);
            this.txtDesc5.TabIndex = 36;
            // 
            // txtQty5
            // 
            this.txtQty5.Location = new System.Drawing.Point(409, 205);
            this.txtQty5.Name = "txtQty5";
            this.txtQty5.Size = new System.Drawing.Size(100, 23);
            this.txtQty5.TabIndex = 37;
            // 
            // txtPrice5
            // 
            this.txtPrice5.Enabled = false;
            this.txtPrice5.Location = new System.Drawing.Point(512, 205);
            this.txtPrice5.Name = "txtPrice5";
            this.txtPrice5.Size = new System.Drawing.Size(100, 23);
            this.txtPrice5.TabIndex = 38;
            // 
            // txtTotal5
            // 
            this.txtTotal5.Enabled = false;
            this.txtTotal5.Location = new System.Drawing.Point(618, 205);
            this.txtTotal5.Name = "txtTotal5";
            this.txtTotal5.Size = new System.Drawing.Size(100, 23);
            this.txtTotal5.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(759, 382);
            this.Controls.Add(this.txtTotal5);
            this.Controls.Add(this.txtPrice5);
            this.Controls.Add(this.txtQty5);
            this.Controls.Add(this.txtDesc5);
            this.Controls.Add(this.txtCode5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtOrderTotal);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtTotal4);
            this.Controls.Add(this.txtTotal3);
            this.Controls.Add(this.txtTotal2);
            this.Controls.Add(this.txtTotal1);
            this.Controls.Add(this.txtPrice4);
            this.Controls.Add(this.txtPrice3);
            this.Controls.Add(this.txtPrice2);
            this.Controls.Add(this.txtPrice1);
            this.Controls.Add(this.txtQty4);
            this.Controls.Add(this.txtQty3);
            this.Controls.Add(this.txtQty2);
            this.Controls.Add(this.txtQty1);
            this.Controls.Add(this.txtDesc4);
            this.Controls.Add(this.txtDesc3);
            this.Controls.Add(this.txtDesc2);
            this.Controls.Add(this.txtDesc1);
            this.Controls.Add(this.txtCode4);
            this.Controls.Add(this.txtCode3);
            this.Controls.Add(this.txtCode2);
            this.Controls.Add(this.txtCode1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtCode1;
        private TextBox txtCode2;
        private TextBox txtCode3;
        private TextBox txtCode4;
        private TextBox txtDesc1;
        private TextBox txtDesc2;
        private TextBox txtDesc3;
        private TextBox txtDesc4;
        private TextBox txtQty1;
        private TextBox txtQty2;
        private TextBox txtQty3;
        private TextBox txtQty4;
        private TextBox txtPrice1;
        private TextBox txtPrice2;
        private TextBox txtPrice3;
        private TextBox txtPrice4;
        private TextBox txtTotal1;
        private TextBox txtTotal2;
        private TextBox txtTotal3;
        private TextBox txtTotal4;
        private TextBox txtSubtotal;
        private TextBox txtDiscount;
        private TextBox txtOrderTotal;
        private Button btnCalculate;
        private Button btnClear;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem calculateToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TextBox txtCode5;
        private TextBox txtDesc5;
        private TextBox txtQty5;
        private TextBox txtPrice5;
        private TextBox txtTotal5;
    }
}