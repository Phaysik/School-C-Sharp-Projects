namespace Pizza_Delivery
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.listToppings = new System.Windows.Forms.ListBox();
            this.comboPizza = new System.Windows.Forms.ComboBox();
            this.comboSauce = new System.Windows.Forms.ComboBox();
            this.comboCrust = new System.Windows.Forms.ComboBox();
            this.comboSize = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtWater = new System.Windows.Forms.TextBox();
            this.txtSoda = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.comboOther = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtDelivery = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(499, 372);
            this.tabControl1.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(34, 387);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset Order";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(394, 387);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Pizza_Delivery.Properties.Resources.pizza_man_logo;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.listToppings);
            this.tabPage1.Controls.Add(this.comboPizza);
            this.tabPage1.Controls.Add(this.comboSauce);
            this.tabPage1.Controls.Add(this.comboCrust);
            this.tabPage1.Controls.Add(this.comboSize);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(491, 346);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pizza";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(286, 282);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(187, 25);
            this.label15.TabIndex = 11;
            this.label15.Text = "Pizza Selections";
            // 
            // listToppings
            // 
            this.listToppings.FormattingEnabled = true;
            this.listToppings.Items.AddRange(new object[] {
            "Pepperoni",
            "Extra Cheese",
            "Onions",
            "Garlic",
            "Green Peppers",
            "Green Olives",
            "Mushroom",
            "Black Olives",
            "Chicken",
            "Bacon",
            "Beef",
            "Ham",
            "Sausage"});
            this.listToppings.Location = new System.Drawing.Point(316, 65);
            this.listToppings.Name = "listToppings";
            this.listToppings.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listToppings.Size = new System.Drawing.Size(120, 108);
            this.listToppings.TabIndex = 10;
            // 
            // comboPizza
            // 
            this.comboPizza.FormattingEnabled = true;
            this.comboPizza.Items.AddRange(new object[] {
            "Meat Lovers",
            "Supreme",
            "Veggie Lovers",
            "Hawaiian",
            "BLT Pizza"});
            this.comboPizza.Location = new System.Drawing.Point(33, 282);
            this.comboPizza.Name = "comboPizza";
            this.comboPizza.Size = new System.Drawing.Size(164, 21);
            this.comboPizza.TabIndex = 9;
            // 
            // comboSauce
            // 
            this.comboSauce.FormattingEnabled = true;
            this.comboSauce.Items.AddRange(new object[] {
            "Tomato",
            "Pesto",
            "White",
            "Ranch"});
            this.comboSauce.Location = new System.Drawing.Point(33, 211);
            this.comboSauce.Name = "comboSauce";
            this.comboSauce.Size = new System.Drawing.Size(164, 21);
            this.comboSauce.TabIndex = 8;
            // 
            // comboCrust
            // 
            this.comboCrust.FormattingEnabled = true;
            this.comboCrust.Items.AddRange(new object[] {
            "Thin & Crispy Crust",
            "Pan Crust",
            "Regular Crust"});
            this.comboCrust.Location = new System.Drawing.Point(33, 139);
            this.comboCrust.Name = "comboCrust";
            this.comboCrust.Size = new System.Drawing.Size(164, 21);
            this.comboCrust.TabIndex = 7;
            // 
            // comboSize
            // 
            this.comboSize.FormattingEnabled = true;
            this.comboSize.Items.AddRange(new object[] {
            "Small (10\") - $9.95",
            "Medium (12\") - $12.95",
            "Large (16\") - $15.95"});
            this.comboSize.Location = new System.Drawing.Point(33, 78);
            this.comboSize.Name = "comboSize";
            this.comboSize.Size = new System.Drawing.Size(164, 21);
            this.comboSize.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(30, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Specialty Pizzas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(313, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Toppings - $1.50";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(30, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Crust";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(30, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Sauce";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(34, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizza Express\r\n";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Pizza_Delivery.Properties.Resources.pizza_man_logo;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txtWater);
            this.tabPage2.Controls.Add(this.txtSoda);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(491, 346);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Beverages";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(284, 272);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(184, 25);
            this.label14.TabIndex = 8;
            this.label14.Text = "Drink Selections";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Crimson;
            this.label13.Location = new System.Drawing.Point(149, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(204, 16);
            this.label13.TabIndex = 7;
            this.label13.Text = "Soda cost is $1.75 - Water is free!";
            // 
            // txtWater
            // 
            this.txtWater.Location = new System.Drawing.Point(204, 111);
            this.txtWater.Name = "txtWater";
            this.txtWater.Size = new System.Drawing.Size(100, 20);
            this.txtWater.TabIndex = 6;
            this.txtWater.Text = "0";
            this.txtWater.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSoda
            // 
            this.txtSoda.Location = new System.Drawing.Point(204, 66);
            this.txtSoda.Name = "txtSoda";
            this.txtSoda.Size = new System.Drawing.Size(100, 20);
            this.txtSoda.TabIndex = 5;
            this.txtSoda.Text = "0";
            this.txtSoda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(201, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Quantity";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Crimson;
            this.label11.Location = new System.Drawing.Point(59, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Soda(s)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(59, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Water(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pizza Express\r\n";
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::Pizza_Delivery.Properties.Resources.pizza_man_logo;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.comboOther);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(491, 346);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Other Items";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(291, 264);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(172, 25);
            this.label17.TabIndex = 8;
            this.label17.Text = "Specialty Items";
            // 
            // comboOther
            // 
            this.comboOther.FormattingEnabled = true;
            this.comboOther.Items.AddRange(new object[] {
            "Wings - $5.00",
            "Cheese Sticks - $4.00",
            "Garlic Bread - $3.00"});
            this.comboOther.Location = new System.Drawing.Point(147, 89);
            this.comboOther.Name = "comboOther";
            this.comboOther.Size = new System.Drawing.Size(164, 21);
            this.comboOther.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Crimson;
            this.label16.Location = new System.Drawing.Point(165, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 16);
            this.label16.TabIndex = 4;
            this.label16.Text = "Choose Other Items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pizza Express\r\n";
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::Pizza_Delivery.Properties.Resources.pizza_man_logo;
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.txtDelivery);
            this.tabPage4.Controls.Add(this.txtName);
            this.tabPage4.Controls.Add(this.label22);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(491, 346);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Customer Info";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtDelivery
            // 
            this.txtDelivery.Location = new System.Drawing.Point(145, 140);
            this.txtDelivery.Name = "txtDelivery";
            this.txtDelivery.Size = new System.Drawing.Size(227, 20);
            this.txtDelivery.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(145, 92);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 20);
            this.txtName.TabIndex = 10;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(259, 277);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(232, 25);
            this.label22.TabIndex = 9;
            this.label22.Text = "Delivery Contact Info";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Crimson;
            this.label19.Location = new System.Drawing.Point(14, 140);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(115, 16);
            this.label19.TabIndex = 6;
            this.label19.Text = "Delivery Address:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Crimson;
            this.label18.Location = new System.Drawing.Point(14, 92);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 16);
            this.label18.TabIndex = 5;
            this.label18.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Pizza Express\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 432);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ComboBox comboSize;
        private System.Windows.Forms.ComboBox comboPizza;
        private System.Windows.Forms.ComboBox comboSauce;
        private System.Windows.Forms.ComboBox comboCrust;
        private System.Windows.Forms.ListBox listToppings;
        private System.Windows.Forms.TextBox txtWater;
        private System.Windows.Forms.TextBox txtSoda;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboOther;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDelivery;
        private System.Windows.Forms.TextBox txtName;
    }
}

