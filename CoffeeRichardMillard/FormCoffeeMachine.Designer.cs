namespace CoffeeRichardMillard
{
    partial class FormCoffeeMachine
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
            this.listBoxCoffees = new System.Windows.Forms.ListBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxSize = new System.Windows.Forms.GroupBox();
            this.buttonLarge = new System.Windows.Forms.Button();
            this.buttonMedium = new System.Windows.Forms.Button();
            this.buttonSmall = new System.Windows.Forms.Button();
            this.groupBoxCream = new System.Windows.Forms.GroupBox();
            this.buttonRemoveCream = new System.Windows.Forms.Button();
            this.buttonAddCream = new System.Windows.Forms.Button();
            this.groupBoxSugar = new System.Windows.Forms.GroupBox();
            this.buttonRemoveSugar = new System.Windows.Forms.Button();
            this.buttonAddSugar = new System.Windows.Forms.Button();
            this.groupBoxCoffee = new System.Windows.Forms.GroupBox();
            this.buttonRemoveCoffee = new System.Windows.Forms.Button();
            this.buttonAddCoffee = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelPaid = new System.Windows.Forms.Label();
            this.groupBoxPaymentAmounts = new System.Windows.Forms.GroupBox();
            this.buttonPay2000 = new System.Windows.Forms.Button();
            this.buttonPay1000 = new System.Windows.Forms.Button();
            this.buttonPay500 = new System.Windows.Forms.Button();
            this.buttonPay100 = new System.Windows.Forms.Button();
            this.buttonPay25 = new System.Windows.Forms.Button();
            this.buttonPay10 = new System.Windows.Forms.Button();
            this.buttonPay5 = new System.Windows.Forms.Button();
            this.buttonCompleteOrder = new System.Windows.Forms.Button();
            this.labelCoffees = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxSize.SuspendLayout();
            this.groupBoxCream.SuspendLayout();
            this.groupBoxSugar.SuspendLayout();
            this.groupBoxCoffee.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxPaymentAmounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxCoffees
            // 
            this.listBoxCoffees.FormattingEnabled = true;
            this.listBoxCoffees.Location = new System.Drawing.Point(12, 38);
            this.listBoxCoffees.Name = "listBoxCoffees";
            this.listBoxCoffees.Size = new System.Drawing.Size(241, 264);
            this.listBoxCoffees.TabIndex = 0;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(12, 311);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(31, 13);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "Total";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(259, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(235, 316);
            this.tabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxSize);
            this.tabPage1.Controls.Add(this.groupBoxCream);
            this.tabPage1.Controls.Add(this.groupBoxSugar);
            this.tabPage1.Controls.Add(this.groupBoxCoffee);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(227, 290);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Order";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxSize
            // 
            this.groupBoxSize.Controls.Add(this.buttonLarge);
            this.groupBoxSize.Controls.Add(this.buttonMedium);
            this.groupBoxSize.Controls.Add(this.buttonSmall);
            this.groupBoxSize.Location = new System.Drawing.Point(7, 85);
            this.groupBoxSize.Name = "groupBoxSize";
            this.groupBoxSize.Size = new System.Drawing.Size(200, 51);
            this.groupBoxSize.TabIndex = 3;
            this.groupBoxSize.TabStop = false;
            this.groupBoxSize.Text = "Size";
            // 
            // buttonLarge
            // 
            this.buttonLarge.Location = new System.Drawing.Point(135, 19);
            this.buttonLarge.Name = "buttonLarge";
            this.buttonLarge.Size = new System.Drawing.Size(49, 23);
            this.buttonLarge.TabIndex = 2;
            this.buttonLarge.Tag = "2";
            this.buttonLarge.Text = "Large";
            this.buttonLarge.UseVisualStyleBackColor = true;
            this.buttonLarge.Click += new System.EventHandler(this.buttonCoffeeSize_Click);
            // 
            // buttonMedium
            // 
            this.buttonMedium.Location = new System.Drawing.Point(74, 19);
            this.buttonMedium.Name = "buttonMedium";
            this.buttonMedium.Size = new System.Drawing.Size(55, 23);
            this.buttonMedium.TabIndex = 1;
            this.buttonMedium.Tag = "1";
            this.buttonMedium.Text = "Medium";
            this.buttonMedium.UseVisualStyleBackColor = true;
            this.buttonMedium.Click += new System.EventHandler(this.buttonCoffeeSize_Click);
            // 
            // buttonSmall
            // 
            this.buttonSmall.Location = new System.Drawing.Point(19, 19);
            this.buttonSmall.Name = "buttonSmall";
            this.buttonSmall.Size = new System.Drawing.Size(49, 23);
            this.buttonSmall.TabIndex = 0;
            this.buttonSmall.Tag = "0";
            this.buttonSmall.Text = "Small";
            this.buttonSmall.UseVisualStyleBackColor = true;
            this.buttonSmall.Click += new System.EventHandler(this.buttonCoffeeSize_Click);
            // 
            // groupBoxCream
            // 
            this.groupBoxCream.Controls.Add(this.buttonRemoveCream);
            this.groupBoxCream.Controls.Add(this.buttonAddCream);
            this.groupBoxCream.Location = new System.Drawing.Point(7, 218);
            this.groupBoxCream.Name = "groupBoxCream";
            this.groupBoxCream.Size = new System.Drawing.Size(200, 50);
            this.groupBoxCream.TabIndex = 2;
            this.groupBoxCream.TabStop = false;
            this.groupBoxCream.Text = "Cream";
            // 
            // buttonRemoveCream
            // 
            this.buttonRemoveCream.Location = new System.Drawing.Point(108, 14);
            this.buttonRemoveCream.Name = "buttonRemoveCream";
            this.buttonRemoveCream.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveCream.TabIndex = 3;
            this.buttonRemoveCream.Text = "Remove";
            this.buttonRemoveCream.UseVisualStyleBackColor = true;
            this.buttonRemoveCream.Click += new System.EventHandler(this.buttonRemoveCream_Click);
            // 
            // buttonAddCream
            // 
            this.buttonAddCream.Location = new System.Drawing.Point(18, 14);
            this.buttonAddCream.Name = "buttonAddCream";
            this.buttonAddCream.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCream.TabIndex = 2;
            this.buttonAddCream.Text = "Add";
            this.buttonAddCream.UseVisualStyleBackColor = true;
            this.buttonAddCream.Click += new System.EventHandler(this.buttonAddCream_Click);
            // 
            // groupBoxSugar
            // 
            this.groupBoxSugar.Controls.Add(this.buttonRemoveSugar);
            this.groupBoxSugar.Controls.Add(this.buttonAddSugar);
            this.groupBoxSugar.Location = new System.Drawing.Point(7, 155);
            this.groupBoxSugar.Name = "groupBoxSugar";
            this.groupBoxSugar.Size = new System.Drawing.Size(200, 50);
            this.groupBoxSugar.TabIndex = 1;
            this.groupBoxSugar.TabStop = false;
            this.groupBoxSugar.Text = "Sugar";
            // 
            // buttonRemoveSugar
            // 
            this.buttonRemoveSugar.Location = new System.Drawing.Point(108, 14);
            this.buttonRemoveSugar.Name = "buttonRemoveSugar";
            this.buttonRemoveSugar.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveSugar.TabIndex = 3;
            this.buttonRemoveSugar.Text = "Remove";
            this.buttonRemoveSugar.UseVisualStyleBackColor = true;
            this.buttonRemoveSugar.Click += new System.EventHandler(this.buttonRemoveSugar_Click);
            // 
            // buttonAddSugar
            // 
            this.buttonAddSugar.Location = new System.Drawing.Point(18, 14);
            this.buttonAddSugar.Name = "buttonAddSugar";
            this.buttonAddSugar.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSugar.TabIndex = 2;
            this.buttonAddSugar.Text = "Add";
            this.buttonAddSugar.UseVisualStyleBackColor = true;
            this.buttonAddSugar.Click += new System.EventHandler(this.buttonAddSugar_Click);
            // 
            // groupBoxCoffee
            // 
            this.groupBoxCoffee.Controls.Add(this.buttonRemoveCoffee);
            this.groupBoxCoffee.Controls.Add(this.buttonAddCoffee);
            this.groupBoxCoffee.Location = new System.Drawing.Point(7, 18);
            this.groupBoxCoffee.Name = "groupBoxCoffee";
            this.groupBoxCoffee.Size = new System.Drawing.Size(200, 50);
            this.groupBoxCoffee.TabIndex = 0;
            this.groupBoxCoffee.TabStop = false;
            this.groupBoxCoffee.Text = "Coffee";
            // 
            // buttonRemoveCoffee
            // 
            this.buttonRemoveCoffee.Location = new System.Drawing.Point(109, 19);
            this.buttonRemoveCoffee.Name = "buttonRemoveCoffee";
            this.buttonRemoveCoffee.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveCoffee.TabIndex = 1;
            this.buttonRemoveCoffee.Text = "Remove";
            this.buttonRemoveCoffee.UseVisualStyleBackColor = true;
            this.buttonRemoveCoffee.Click += new System.EventHandler(this.buttonRemoveCoffee_Click);
            // 
            // buttonAddCoffee
            // 
            this.buttonAddCoffee.Location = new System.Drawing.Point(19, 19);
            this.buttonAddCoffee.Name = "buttonAddCoffee";
            this.buttonAddCoffee.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCoffee.TabIndex = 0;
            this.buttonAddCoffee.Text = "Add";
            this.buttonAddCoffee.UseVisualStyleBackColor = true;
            this.buttonAddCoffee.Click += new System.EventHandler(this.buttonAddCoffee_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelPaid);
            this.tabPage2.Controls.Add(this.groupBoxPaymentAmounts);
            this.tabPage2.Controls.Add(this.buttonCompleteOrder);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(227, 290);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pay";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelPaid
            // 
            this.labelPaid.AutoSize = true;
            this.labelPaid.Location = new System.Drawing.Point(48, 200);
            this.labelPaid.Name = "labelPaid";
            this.labelPaid.Size = new System.Drawing.Size(28, 13);
            this.labelPaid.TabIndex = 7;
            this.labelPaid.Text = "Paid";
            // 
            // groupBoxPaymentAmounts
            // 
            this.groupBoxPaymentAmounts.Controls.Add(this.buttonPay2000);
            this.groupBoxPaymentAmounts.Controls.Add(this.buttonPay1000);
            this.groupBoxPaymentAmounts.Controls.Add(this.buttonPay500);
            this.groupBoxPaymentAmounts.Controls.Add(this.buttonPay100);
            this.groupBoxPaymentAmounts.Controls.Add(this.buttonPay25);
            this.groupBoxPaymentAmounts.Controls.Add(this.buttonPay10);
            this.groupBoxPaymentAmounts.Controls.Add(this.buttonPay5);
            this.groupBoxPaymentAmounts.Location = new System.Drawing.Point(6, 6);
            this.groupBoxPaymentAmounts.Name = "groupBoxPaymentAmounts";
            this.groupBoxPaymentAmounts.Size = new System.Drawing.Size(200, 100);
            this.groupBoxPaymentAmounts.TabIndex = 6;
            this.groupBoxPaymentAmounts.TabStop = false;
            this.groupBoxPaymentAmounts.Text = "Payment Amounts";
            // 
            // buttonPay2000
            // 
            this.buttonPay2000.Location = new System.Drawing.Point(150, 48);
            this.buttonPay2000.Name = "buttonPay2000";
            this.buttonPay2000.Size = new System.Drawing.Size(42, 23);
            this.buttonPay2000.TabIndex = 12;
            this.buttonPay2000.Tag = "20.00";
            this.buttonPay2000.Text = "20.00";
            this.buttonPay2000.UseVisualStyleBackColor = true;
            this.buttonPay2000.Click += new System.EventHandler(this.buttonPay);
            // 
            // buttonPay1000
            // 
            this.buttonPay1000.Location = new System.Drawing.Point(102, 48);
            this.buttonPay1000.Name = "buttonPay1000";
            this.buttonPay1000.Size = new System.Drawing.Size(42, 23);
            this.buttonPay1000.TabIndex = 11;
            this.buttonPay1000.Tag = "10.00";
            this.buttonPay1000.Text = "10.00";
            this.buttonPay1000.UseVisualStyleBackColor = true;
            this.buttonPay1000.Click += new System.EventHandler(this.buttonPay);
            // 
            // buttonPay500
            // 
            this.buttonPay500.Location = new System.Drawing.Point(54, 48);
            this.buttonPay500.Name = "buttonPay500";
            this.buttonPay500.Size = new System.Drawing.Size(42, 23);
            this.buttonPay500.TabIndex = 10;
            this.buttonPay500.Tag = "5.00";
            this.buttonPay500.Text = "5.00";
            this.buttonPay500.UseVisualStyleBackColor = true;
            this.buttonPay500.Click += new System.EventHandler(this.buttonPay);
            // 
            // buttonPay100
            // 
            this.buttonPay100.Location = new System.Drawing.Point(6, 48);
            this.buttonPay100.Name = "buttonPay100";
            this.buttonPay100.Size = new System.Drawing.Size(42, 23);
            this.buttonPay100.TabIndex = 9;
            this.buttonPay100.Tag = "1.00";
            this.buttonPay100.Text = "1.00";
            this.buttonPay100.UseVisualStyleBackColor = true;
            this.buttonPay100.Click += new System.EventHandler(this.buttonPay);
            // 
            // buttonPay25
            // 
            this.buttonPay25.Location = new System.Drawing.Point(102, 19);
            this.buttonPay25.Name = "buttonPay25";
            this.buttonPay25.Size = new System.Drawing.Size(42, 23);
            this.buttonPay25.TabIndex = 8;
            this.buttonPay25.Tag = "0.25";
            this.buttonPay25.Text = "0.25";
            this.buttonPay25.UseVisualStyleBackColor = true;
            this.buttonPay25.Click += new System.EventHandler(this.buttonPay);
            // 
            // buttonPay10
            // 
            this.buttonPay10.Location = new System.Drawing.Point(54, 19);
            this.buttonPay10.Name = "buttonPay10";
            this.buttonPay10.Size = new System.Drawing.Size(42, 23);
            this.buttonPay10.TabIndex = 7;
            this.buttonPay10.Tag = "0.10";
            this.buttonPay10.Text = "0.10";
            this.buttonPay10.UseVisualStyleBackColor = true;
            this.buttonPay10.Click += new System.EventHandler(this.buttonPay);
            // 
            // buttonPay5
            // 
            this.buttonPay5.Location = new System.Drawing.Point(6, 19);
            this.buttonPay5.Name = "buttonPay5";
            this.buttonPay5.Size = new System.Drawing.Size(42, 23);
            this.buttonPay5.TabIndex = 6;
            this.buttonPay5.Tag = "0.05";
            this.buttonPay5.Text = "0.05";
            this.buttonPay5.UseVisualStyleBackColor = true;
            this.buttonPay5.Click += new System.EventHandler(this.buttonPay);
            // 
            // buttonCompleteOrder
            // 
            this.buttonCompleteOrder.Location = new System.Drawing.Point(51, 227);
            this.buttonCompleteOrder.Name = "buttonCompleteOrder";
            this.buttonCompleteOrder.Size = new System.Drawing.Size(124, 23);
            this.buttonCompleteOrder.TabIndex = 0;
            this.buttonCompleteOrder.Text = "Complete Order";
            this.buttonCompleteOrder.UseVisualStyleBackColor = true;
            this.buttonCompleteOrder.Click += new System.EventHandler(this.buttonCompleteOrder_Click);
            // 
            // labelCoffees
            // 
            this.labelCoffees.AutoSize = true;
            this.labelCoffees.Location = new System.Drawing.Point(12, 22);
            this.labelCoffees.Name = "labelCoffees";
            this.labelCoffees.Size = new System.Drawing.Size(43, 13);
            this.labelCoffees.TabIndex = 4;
            this.labelCoffees.Text = "Coffees";
            // 
            // FormCoffeeMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 328);
            this.Controls.Add(this.labelCoffees);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.listBoxCoffees);
            this.Name = "FormCoffeeMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Machine";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxSize.ResumeLayout(false);
            this.groupBoxCream.ResumeLayout(false);
            this.groupBoxSugar.ResumeLayout(false);
            this.groupBoxCoffee.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBoxPaymentAmounts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCoffees;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBoxCream;
        private System.Windows.Forms.GroupBox groupBoxSugar;
        private System.Windows.Forms.GroupBox groupBoxCoffee;
        private System.Windows.Forms.Button buttonRemoveCoffee;
        private System.Windows.Forms.Button buttonAddCoffee;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonCompleteOrder;
        private System.Windows.Forms.Button buttonRemoveCream;
        private System.Windows.Forms.Button buttonAddCream;
        private System.Windows.Forms.Button buttonRemoveSugar;
        private System.Windows.Forms.Button buttonAddSugar;
        private System.Windows.Forms.Label labelCoffees;
        private System.Windows.Forms.GroupBox groupBoxPaymentAmounts;
        private System.Windows.Forms.Button buttonPay2000;
        private System.Windows.Forms.Button buttonPay1000;
        private System.Windows.Forms.Button buttonPay500;
        private System.Windows.Forms.Button buttonPay100;
        private System.Windows.Forms.Button buttonPay25;
        private System.Windows.Forms.Button buttonPay10;
        private System.Windows.Forms.Button buttonPay5;
        private System.Windows.Forms.Label labelPaid;
        private System.Windows.Forms.GroupBox groupBoxSize;
        private System.Windows.Forms.Button buttonLarge;
        private System.Windows.Forms.Button buttonMedium;
        private System.Windows.Forms.Button buttonSmall;
    }
}

