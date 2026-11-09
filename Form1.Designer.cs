namespace WinFormsApp2
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
            lblTitle = new Label();
            lblPumpNo = new Label();
            txtPumpNo = new TextBox();
            txtCustomer = new TextBox();
            lblCustomer = new Label();
            txtPlateNo = new TextBox();
            lblPlateNo = new Label();
            txtFuelType = new TextBox();
            lblFuelType = new Label();
            txtFuelLevel = new TextBox();
            lblFuelLevel = new Label();
            txtTankCapacity = new TextBox();
            lblTankCapacity = new Label();
            txtPricePerLiters = new TextBox();
            lblPricePerLiter = new Label();
            txtLiters = new TextBox();
            lblLiters = new Label();
            txtCashTendered = new TextBox();
            lblCashTendered = new Label();
            txtLoyaltyPoints = new TextBox();
            lblLoyaltyPoints = new Label();
            lblTankSpace = new Label();
            lblVolDiscount = new Label();
            lblChange = new Label();
            lblVatAmount = new Label();
            lblNetAmount = new Label();
            lblLoyaltyDiscount = new Label();
            lblPointsEarned = new Label();
            lblTankStatus = new Label();
            txtLoyaltyDiscount = new TextBox();
            txtNetAmount = new TextBox();
            txtVatAmount = new TextBox();
            txtChange = new TextBox();
            txtPointsEarned = new TextBox();
            txtTankStatus = new TextBox();
            txtTankSpace = new TextBox();
            txtGrossAmount = new TextBox();
            lblGrossAmount = new Label();
            txtVolDiscount = new TextBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(181, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Gas Station Billing System";
            // 
            // lblPumpNo
            // 
            lblPumpNo.AutoSize = true;
            lblPumpNo.Location = new Point(12, 35);
            lblPumpNo.Name = "lblPumpNo";
            lblPumpNo.Size = new Size(105, 20);
            lblPumpNo.TabIndex = 1;
            lblPumpNo.Text = "Pump Number";
            lblPumpNo.Click += label1_Click;
            // 
            // txtPumpNo
            // 
            txtPumpNo.Location = new Point(130, 35);
            txtPumpNo.Name = "txtPumpNo";
            txtPumpNo.Size = new Size(181, 27);
            txtPumpNo.TabIndex = 2;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(130, 73);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(181, 27);
            txtCustomer.TabIndex = 4;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(12, 77);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(116, 20);
            lblCustomer.TabIndex = 3;
            lblCustomer.Text = "Customer Name";
            lblCustomer.Click += label2_Click;
            // 
            // txtPlateNo
            // 
            txtPlateNo.Location = new Point(130, 125);
            txtPlateNo.Name = "txtPlateNo";
            txtPlateNo.Size = new Size(181, 27);
            txtPlateNo.TabIndex = 6;
            // 
            // lblPlateNo
            // 
            lblPlateNo.AutoSize = true;
            lblPlateNo.Location = new Point(12, 128);
            lblPlateNo.Name = "lblPlateNo";
            lblPlateNo.Size = new Size(100, 20);
            lblPlateNo.TabIndex = 5;
            lblPlateNo.Text = "Plate Number";
            lblPlateNo.Click += label3_Click;
            // 
            // txtFuelType
            // 
            txtFuelType.Location = new Point(130, 180);
            txtFuelType.Name = "txtFuelType";
            txtFuelType.Size = new Size(181, 27);
            txtFuelType.TabIndex = 8;
            // 
            // lblFuelType
            // 
            lblFuelType.AutoSize = true;
            lblFuelType.Location = new Point(12, 183);
            lblFuelType.Name = "lblFuelType";
            lblFuelType.Size = new Size(94, 20);
            lblFuelType.TabIndex = 7;
            lblFuelType.Text = "Fuel Number";
            // 
            // txtFuelLevel
            // 
            txtFuelLevel.Location = new Point(550, 176);
            txtFuelLevel.Name = "txtFuelLevel";
            txtFuelLevel.Size = new Size(181, 27);
            txtFuelLevel.TabIndex = 16;
            // 
            // lblFuelLevel
            // 
            lblFuelLevel.AutoSize = true;
            lblFuelLevel.Location = new Point(384, 183);
            lblFuelLevel.Name = "lblFuelLevel";
            lblFuelLevel.Size = new Size(147, 20);
            lblFuelLevel.TabIndex = 15;
            lblFuelLevel.Text = "Current Fuel Level (L)";
            // 
            // txtTankCapacity
            // 
            txtTankCapacity.Location = new Point(550, 125);
            txtTankCapacity.Name = "txtTankCapacity";
            txtTankCapacity.Size = new Size(181, 27);
            txtTankCapacity.TabIndex = 14;
            // 
            // lblTankCapacity
            // 
            lblTankCapacity.AutoSize = true;
            lblTankCapacity.Location = new Point(384, 128);
            lblTankCapacity.Name = "lblTankCapacity";
            lblTankCapacity.Size = new Size(120, 20);
            lblTankCapacity.TabIndex = 13;
            lblTankCapacity.Text = "Tank Capacity (L)";
            // 
            // txtPricePerLiters
            // 
            txtPricePerLiters.Location = new Point(550, 74);
            txtPricePerLiters.Name = "txtPricePerLiters";
            txtPricePerLiters.Size = new Size(181, 27);
            txtPricePerLiters.TabIndex = 12;
            // 
            // lblPricePerLiter
            // 
            lblPricePerLiter.AutoSize = true;
            lblPricePerLiter.Location = new Point(384, 77);
            lblPricePerLiter.Name = "lblPricePerLiter";
            lblPricePerLiter.Size = new Size(100, 20);
            lblPricePerLiter.TabIndex = 11;
            lblPricePerLiter.Text = "Price per Liter";
            lblPricePerLiter.Click += label3_Click_1;
            // 
            // txtLiters
            // 
            txtLiters.Location = new Point(550, 32);
            txtLiters.Name = "txtLiters";
            txtLiters.Size = new Size(181, 27);
            txtLiters.TabIndex = 10;
            txtLiters.TextChanged += textBox8_TextChanged;
            // 
            // lblLiters
            // 
            lblLiters.AutoSize = true;
            lblLiters.Location = new Point(384, 35);
            lblLiters.Name = "lblLiters";
            lblLiters.Size = new Size(118, 20);
            lblLiters.TabIndex = 9;
            lblLiters.Text = "Liters Requested";
            // 
            // txtCashTendered
            // 
            txtCashTendered.Location = new Point(550, 273);
            txtCashTendered.Name = "txtCashTendered";
            txtCashTendered.Size = new Size(181, 27);
            txtCashTendered.TabIndex = 24;
            // 
            // lblCashTendered
            // 
            lblCashTendered.AutoSize = true;
            lblCashTendered.Location = new Point(384, 276);
            lblCashTendered.Name = "lblCashTendered";
            lblCashTendered.Size = new Size(106, 20);
            lblCashTendered.TabIndex = 23;
            lblCashTendered.Text = "Cash Tendered";
            // 
            // txtLoyaltyPoints
            // 
            txtLoyaltyPoints.Location = new Point(550, 218);
            txtLoyaltyPoints.Name = "txtLoyaltyPoints";
            txtLoyaltyPoints.Size = new Size(181, 27);
            txtLoyaltyPoints.TabIndex = 22;
            // 
            // lblLoyaltyPoints
            // 
            lblLoyaltyPoints.AutoSize = true;
            lblLoyaltyPoints.Location = new Point(382, 221);
            lblLoyaltyPoints.Name = "lblLoyaltyPoints";
            lblLoyaltyPoints.Size = new Size(99, 20);
            lblLoyaltyPoints.TabIndex = 21;
            lblLoyaltyPoints.Text = "Loyalty Points";
            // 
            // lblTankSpace
            // 
            lblTankSpace.AutoSize = true;
            lblTankSpace.Location = new Point(759, 35);
            lblTankSpace.Name = "lblTankSpace";
            lblTankSpace.Size = new Size(148, 20);
            lblTankSpace.TabIndex = 27;
            lblTankSpace.Text = "Available Tank Space";
            lblTankSpace.Click += label1_Click_1;
            // 
            // lblVolDiscount
            // 
            lblVolDiscount.AutoSize = true;
            lblVolDiscount.Location = new Point(772, 128);
            lblVolDiscount.Name = "lblVolDiscount";
            lblVolDiscount.Size = new Size(121, 20);
            lblVolDiscount.TabIndex = 28;
            lblVolDiscount.Text = "Volume Discount";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Location = new Point(834, 358);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(59, 20);
            lblChange.TabIndex = 29;
            lblChange.Text = "Change";
            lblChange.Click += label3_Click_2;
            // 
            // lblVatAmount
            // 
            lblVatAmount.AutoSize = true;
            lblVatAmount.Location = new Point(798, 290);
            lblVatAmount.Name = "lblVatAmount";
            lblVatAmount.Size = new Size(95, 20);
            lblVatAmount.TabIndex = 30;
            lblVatAmount.Text = "VAT Included";
            // 
            // lblNetAmount
            // 
            lblNetAmount.AutoSize = true;
            lblNetAmount.Location = new Point(772, 238);
            lblNetAmount.Name = "lblNetAmount";
            lblNetAmount.Size = new Size(121, 20);
            lblNetAmount.TabIndex = 31;
            lblNetAmount.Text = "Net Amount Due";
            // 
            // lblLoyaltyDiscount
            // 
            lblLoyaltyDiscount.AutoSize = true;
            lblLoyaltyDiscount.Location = new Point(775, 183);
            lblLoyaltyDiscount.Name = "lblLoyaltyDiscount";
            lblLoyaltyDiscount.Size = new Size(118, 20);
            lblLoyaltyDiscount.TabIndex = 32;
            lblLoyaltyDiscount.Text = "Loyalty Discount";
            // 
            // lblPointsEarned
            // 
            lblPointsEarned.AutoSize = true;
            lblPointsEarned.Location = new Point(795, 417);
            lblPointsEarned.Name = "lblPointsEarned";
            lblPointsEarned.Size = new Size(98, 20);
            lblPointsEarned.TabIndex = 33;
            lblPointsEarned.Text = "Points Earned";
            lblPointsEarned.Click += label7_Click;
            // 
            // lblTankStatus
            // 
            lblTankStatus.AutoSize = true;
            lblTankStatus.Location = new Point(728, 470);
            lblTankStatus.Name = "lblTankStatus";
            lblTankStatus.Size = new Size(165, 20);
            lblTankStatus.TabIndex = 34;
            lblTankStatus.Text = "Tank Status After Refuel";
            // 
            // txtLoyaltyDiscount
            // 
            txtLoyaltyDiscount.Location = new Point(913, 176);
            txtLoyaltyDiscount.Name = "txtLoyaltyDiscount";
            txtLoyaltyDiscount.Size = new Size(181, 27);
            txtLoyaltyDiscount.TabIndex = 35;
            // 
            // txtNetAmount
            // 
            txtNetAmount.Location = new Point(913, 231);
            txtNetAmount.Name = "txtNetAmount";
            txtNetAmount.Size = new Size(181, 27);
            txtNetAmount.TabIndex = 36;
            // 
            // txtVatAmount
            // 
            txtVatAmount.Location = new Point(913, 287);
            txtVatAmount.Name = "txtVatAmount";
            txtVatAmount.Size = new Size(181, 27);
            txtVatAmount.TabIndex = 37;
            // 
            // txtChange
            // 
            txtChange.Location = new Point(913, 351);
            txtChange.Name = "txtChange";
            txtChange.Size = new Size(181, 27);
            txtChange.TabIndex = 38;
            // 
            // txtPointsEarned
            // 
            txtPointsEarned.Location = new Point(913, 410);
            txtPointsEarned.Name = "txtPointsEarned";
            txtPointsEarned.Size = new Size(181, 27);
            txtPointsEarned.TabIndex = 39;
            // 
            // txtTankStatus
            // 
            txtTankStatus.Location = new Point(913, 470);
            txtTankStatus.Name = "txtTankStatus";
            txtTankStatus.Size = new Size(181, 27);
            txtTankStatus.TabIndex = 40;
            // 
            // txtTankSpace
            // 
            txtTankSpace.Location = new Point(913, 32);
            txtTankSpace.Name = "txtTankSpace";
            txtTankSpace.Size = new Size(181, 27);
            txtTankSpace.TabIndex = 43;
            // 
            // txtGrossAmount
            // 
            txtGrossAmount.Location = new Point(913, 74);
            txtGrossAmount.Name = "txtGrossAmount";
            txtGrossAmount.Size = new Size(181, 27);
            txtGrossAmount.TabIndex = 44;
            // 
            // lblGrossAmount
            // 
            lblGrossAmount.AutoSize = true;
            lblGrossAmount.Location = new Point(799, 77);
            lblGrossAmount.Name = "lblGrossAmount";
            lblGrossAmount.Size = new Size(102, 20);
            lblGrossAmount.TabIndex = 45;
            lblGrossAmount.Text = "Gross Amount";
            // 
            // txtVolDiscount
            // 
            txtVolDiscount.Location = new Point(913, 125);
            txtVolDiscount.Name = "txtVolDiscount";
            txtVolDiscount.Size = new Size(181, 27);
            txtVolDiscount.TabIndex = 46;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1712, 757);
            Controls.Add(txtVolDiscount);
            Controls.Add(lblGrossAmount);
            Controls.Add(txtGrossAmount);
            Controls.Add(txtTankSpace);
            Controls.Add(txtTankStatus);
            Controls.Add(txtPointsEarned);
            Controls.Add(txtChange);
            Controls.Add(txtVatAmount);
            Controls.Add(txtNetAmount);
            Controls.Add(txtLoyaltyDiscount);
            Controls.Add(lblTankStatus);
            Controls.Add(lblPointsEarned);
            Controls.Add(lblLoyaltyDiscount);
            Controls.Add(lblNetAmount);
            Controls.Add(lblVatAmount);
            Controls.Add(lblChange);
            Controls.Add(lblVolDiscount);
            Controls.Add(lblTankSpace);
            Controls.Add(txtCashTendered);
            Controls.Add(lblCashTendered);
            Controls.Add(txtLoyaltyPoints);
            Controls.Add(lblLoyaltyPoints);
            Controls.Add(txtFuelLevel);
            Controls.Add(lblFuelLevel);
            Controls.Add(txtTankCapacity);
            Controls.Add(lblTankCapacity);
            Controls.Add(txtPricePerLiters);
            Controls.Add(lblPricePerLiter);
            Controls.Add(txtLiters);
            Controls.Add(lblLiters);
            Controls.Add(txtFuelType);
            Controls.Add(lblFuelType);
            Controls.Add(txtPlateNo);
            Controls.Add(lblPlateNo);
            Controls.Add(txtCustomer);
            Controls.Add(lblCustomer);
            Controls.Add(txtPumpNo);
            Controls.Add(lblPumpNo);
            Controls.Add(lblTitle);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblPumpNo;
        private TextBox txtPumpNo;
        private TextBox txtCustomer;
        private Label lblCustomer;
        private TextBox txtPlateNo;
        private Label lblPlateNo;
        private TextBox txtFuelType;
        private Label lblFuelType;
        private TextBox txtFuelLevel;
        private Label lblFuelLevel;
        private TextBox txtTankCapacity;
        private Label lblTankCapacity;
        private TextBox txtPricePerLiters;
        private Label lblPricePerLiter;
        private TextBox txtLiters;
        private Label lblLiters;
        private TextBox txtCashTendered;
        private Label lblCashTendered;
        private TextBox txtLoyaltyPoints;
        private Label lblLoyaltyPoints;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblTankSpace;
        private Label lblVolDiscount;
 
        private TextBox txtLoyaltyDiscount;
        private TextBox txtNetAmount;
        private TextBox txtVatAmount;
        private TextBox txtChange;
        private TextBox txtPointsEarned;
        private TextBox txtTankStatus;
    
        private TextBox txtTankSpace;
        private TextBox txtGrossAmount;
        private Label lblGrossAmount;

        private TextBox txtVolDiscount;

        private Label lblLoyaltyDiscount;

        private Label lblNetAmount;

        private Label lblVatAmount;

        private Label lblChange;

        private Label lblPointsEarned;

        private Label lblTankStatus;
    }
}
