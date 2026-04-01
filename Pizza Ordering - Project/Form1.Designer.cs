namespace Pizza_Project
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
            this.label1 = new System.Windows.Forms.Label();
            this.GpPizzaSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbSamll = new System.Windows.Forms.RadioButton();
            this.GpCrustType = new System.Windows.Forms.GroupBox();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.GpTopping = new System.Windows.Forms.GroupBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkTomatos = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkChees = new System.Windows.Forms.CheckBox();
            this.GpWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.GpSummaryOrder = new System.Windows.Forms.GroupBox();
            this.lblTotal_Price = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCrust = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GpPizzaSize.SuspendLayout();
            this.GpCrustType.SuspendLayout();
            this.GpTopping.SuspendLayout();
            this.GpWhereToEat.SuspendLayout();
            this.GpSummaryOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(270, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(748, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAKE YOUR PIZZA";
            // 
            // GpPizzaSize
            // 
            this.GpPizzaSize.Controls.Add(this.rbLarge);
            this.GpPizzaSize.Controls.Add(this.rbMeduim);
            this.GpPizzaSize.Controls.Add(this.rbSamll);
            this.GpPizzaSize.Location = new System.Drawing.Point(69, 166);
            this.GpPizzaSize.Name = "GpPizzaSize";
            this.GpPizzaSize.Size = new System.Drawing.Size(229, 138);
            this.GpPizzaSize.TabIndex = 1;
            this.GpPizzaSize.TabStop = false;
            this.GpPizzaSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(35, 100);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(63, 20);
            this.rbLarge.TabIndex = 7;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "40";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Location = new System.Drawing.Point(35, 61);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(76, 20);
            this.rbMeduim.TabIndex = 6;
            this.rbMeduim.TabStop = true;
            this.rbMeduim.Tag = "30";
            this.rbMeduim.Text = "Meduim";
            this.rbMeduim.UseVisualStyleBackColor = true;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.rbMeduim_CheckedChanged);
            // 
            // rbSamll
            // 
            this.rbSamll.AutoSize = true;
            this.rbSamll.Location = new System.Drawing.Point(35, 23);
            this.rbSamll.Name = "rbSamll";
            this.rbSamll.Size = new System.Drawing.Size(62, 20);
            this.rbSamll.TabIndex = 5;
            this.rbSamll.TabStop = true;
            this.rbSamll.Tag = "20";
            this.rbSamll.Text = "Samll";
            this.rbSamll.UseVisualStyleBackColor = true;
            this.rbSamll.CheckedChanged += new System.EventHandler(this.rbSamll_CheckedChanged);
            // 
            // GpCrustType
            // 
            this.GpCrustType.Controls.Add(this.rbThick);
            this.GpCrustType.Controls.Add(this.rbThin);
            this.GpCrustType.Location = new System.Drawing.Point(69, 333);
            this.GpCrustType.Name = "GpCrustType";
            this.GpCrustType.Size = new System.Drawing.Size(229, 107);
            this.GpCrustType.TabIndex = 8;
            this.GpCrustType.TabStop = false;
            this.GpCrustType.Text = "Crust Type";
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Location = new System.Drawing.Point(35, 61);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(92, 20);
            this.rbThick.TabIndex = 6;
            this.rbThick.TabStop = true;
            this.rbThick.Tag = "10";
            this.rbThick.Text = "Think crust";
            this.rbThick.UseVisualStyleBackColor = true;
            this.rbThick.CheckedChanged += new System.EventHandler(this.rbThick_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Location = new System.Drawing.Point(35, 23);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(85, 20);
            this.rbThin.TabIndex = 5;
            this.rbThin.TabStop = true;
            this.rbThin.Text = "Thin crust";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // GpTopping
            // 
            this.GpTopping.Controls.Add(this.chkOlives);
            this.GpTopping.Controls.Add(this.chkGreenPeppers);
            this.GpTopping.Controls.Add(this.chkTomatos);
            this.GpTopping.Controls.Add(this.chkOnion);
            this.GpTopping.Controls.Add(this.chkMushrooms);
            this.GpTopping.Controls.Add(this.chkChees);
            this.GpTopping.Location = new System.Drawing.Point(505, 166);
            this.GpTopping.Name = "GpTopping";
            this.GpTopping.Size = new System.Drawing.Size(345, 145);
            this.GpTopping.TabIndex = 9;
            this.GpTopping.TabStop = false;
            this.GpTopping.Text = "Topping";
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(185, 62);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(67, 20);
            this.chkOlives.TabIndex = 5;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(185, 97);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(121, 20);
            this.chkGreenPeppers.TabIndex = 4;
            this.chkGreenPeppers.Tag = "5";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkTomatos
            // 
            this.chkTomatos.AutoSize = true;
            this.chkTomatos.Location = new System.Drawing.Point(27, 97);
            this.chkTomatos.Name = "chkTomatos";
            this.chkTomatos.Size = new System.Drawing.Size(83, 20);
            this.chkTomatos.TabIndex = 3;
            this.chkTomatos.Tag = "5";
            this.chkTomatos.Text = "Tomatos";
            this.chkTomatos.UseVisualStyleBackColor = true;
            this.chkTomatos.CheckedChanged += new System.EventHandler(this.chkTomatos_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(185, 24);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(64, 20);
            this.chkOnion.TabIndex = 2;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(27, 61);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(99, 20);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkChees
            // 
            this.chkChees.AutoSize = true;
            this.chkChees.Location = new System.Drawing.Point(27, 24);
            this.chkChees.Name = "chkChees";
            this.chkChees.Size = new System.Drawing.Size(99, 20);
            this.chkChees.TabIndex = 0;
            this.chkChees.Tag = "5";
            this.chkChees.Text = "Extra chees";
            this.chkChees.UseVisualStyleBackColor = true;
            this.chkChees.CheckedChanged += new System.EventHandler(this.chkChees_CheckedChanged);
            // 
            // GpWhereToEat
            // 
            this.GpWhereToEat.Controls.Add(this.rbTakeOut);
            this.GpWhereToEat.Controls.Add(this.rbEatIn);
            this.GpWhereToEat.Location = new System.Drawing.Point(505, 333);
            this.GpWhereToEat.Name = "GpWhereToEat";
            this.GpWhereToEat.Size = new System.Drawing.Size(345, 82);
            this.GpWhereToEat.TabIndex = 9;
            this.GpWhereToEat.TabStop = false;
            this.GpWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(168, 23);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(83, 20);
            this.rbTakeOut.TabIndex = 6;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Location = new System.Drawing.Point(35, 23);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(61, 20);
            this.rbEatIn.TabIndex = 5;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(793, 455);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(158, 42);
            this.btnResetForm.TabIndex = 10;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Location = new System.Drawing.Point(457, 455);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(158, 42);
            this.btnOrderPizza.TabIndex = 11;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // GpSummaryOrder
            // 
            this.GpSummaryOrder.Controls.Add(this.lblTotal_Price);
            this.GpSummaryOrder.Controls.Add(this.label10);
            this.GpSummaryOrder.Controls.Add(this.lblWhereToEat);
            this.GpSummaryOrder.Controls.Add(this.label8);
            this.GpSummaryOrder.Controls.Add(this.lblCrust);
            this.GpSummaryOrder.Controls.Add(this.label6);
            this.GpSummaryOrder.Controls.Add(this.lblToppings);
            this.GpSummaryOrder.Controls.Add(this.label4);
            this.GpSummaryOrder.Controls.Add(this.lblSize);
            this.GpSummaryOrder.Controls.Add(this.label2);
            this.GpSummaryOrder.Location = new System.Drawing.Point(1105, 151);
            this.GpSummaryOrder.Name = "GpSummaryOrder";
            this.GpSummaryOrder.Size = new System.Drawing.Size(298, 346);
            this.GpSummaryOrder.TabIndex = 12;
            this.GpSummaryOrder.TabStop = false;
            this.GpSummaryOrder.Text = "Summary Order";
            // 
            // lblTotal_Price
            // 
            this.lblTotal_Price.AutoSize = true;
            this.lblTotal_Price.Font = new System.Drawing.Font("Verdana", 27F, System.Drawing.FontStyle.Bold);
            this.lblTotal_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotal_Price.Location = new System.Drawing.Point(122, 258);
            this.lblTotal_Price.Name = "lblTotal_Price";
            this.lblTotal_Price.Size = new System.Drawing.Size(87, 54);
            this.lblTotal_Price.TabIndex = 9;
            this.lblTotal_Price.Text = "0$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(19, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "Total Price:";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Location = new System.Drawing.Point(155, 204);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(0, 16);
            this.lblWhereToEat.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(19, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Where to Eat: ";
            // 
            // lblCrust
            // 
            this.lblCrust.AutoSize = true;
            this.lblCrust.Location = new System.Drawing.Point(144, 160);
            this.lblCrust.Name = "lblCrust";
            this.lblCrust.Size = new System.Drawing.Size(0, 16);
            this.lblCrust.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(19, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Crust type:";
            // 
            // lblToppings
            // 
            this.lblToppings.Location = new System.Drawing.Point(23, 104);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(269, 41);
            this.lblToppings.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(19, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Toppings: ";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(94, 40);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(55, 16);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Medium";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(19, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Size: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1427, 526);
            this.Controls.Add(this.GpSummaryOrder);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.GpWhereToEat);
            this.Controls.Add(this.GpTopping);
            this.Controls.Add(this.GpCrustType);
            this.Controls.Add(this.GpPizzaSize);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GpPizzaSize.ResumeLayout(false);
            this.GpPizzaSize.PerformLayout();
            this.GpCrustType.ResumeLayout(false);
            this.GpCrustType.PerformLayout();
            this.GpTopping.ResumeLayout(false);
            this.GpTopping.PerformLayout();
            this.GpWhereToEat.ResumeLayout(false);
            this.GpWhereToEat.PerformLayout();
            this.GpSummaryOrder.ResumeLayout(false);
            this.GpSummaryOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GpPizzaSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbSamll;
        private System.Windows.Forms.GroupBox GpCrustType;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.GroupBox GpTopping;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkTomatos;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkChees;
        private System.Windows.Forms.GroupBox GpWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.GroupBox GpSummaryOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal_Price;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCrust;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblToppings;
    }
}

