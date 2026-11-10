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
            txtPricePerLiter = new TextBox();
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
            btnCompute = new Button();
            btnClear = new Button();
            btnReport = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(461, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(181, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Gas Station Billing System";
            // 
            // lblPumpNo
            // 
            lblPumpNo.AutoSize = true;
            lblPumpNo.Location = new Point(12, 38);
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
            txtPumpNo.TextChanged += txtPumpNo_TextChanged;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(130, 68);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(181, 27);
            txtCustomer.TabIndex = 4;
            txtCustomer.TextChanged += txtCustomer_TextChanged;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(12, 71);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(116, 20);
            lblCustomer.TabIndex = 3;
            lblCustomer.Text = "Customer Name";
            lblCustomer.Click += label2_Click;
            // 
            // txtPlateNo
            // 
            txtPlateNo.Location = new Point(130, 101);
            txtPlateNo.Name = "txtPlateNo";
            txtPlateNo.Size = new Size(181, 27);
            txtPlateNo.TabIndex = 6;
            txtPlateNo.TextChanged += txtPlateNo_TextChanged;
            // 
            // lblPlateNo
            // 
            lblPlateNo.AutoSize = true;
            lblPlateNo.Location = new Point(12, 104);
            lblPlateNo.Name = "lblPlateNo";
            lblPlateNo.Size = new Size(100, 20);
            lblPlateNo.TabIndex = 5;
            lblPlateNo.Text = "Plate Number";
            lblPlateNo.Click += label3_Click;
            // 
            // txtFuelType
            // 
            txtFuelType.Location = new Point(130, 134);
            txtFuelType.Name = "txtFuelType";
            txtFuelType.Size = new Size(181, 27);
            txtFuelType.TabIndex = 8;
            txtFuelType.TextChanged += txtFuelType_TextChanged;
            // 
            // lblFuelType
            // 
            lblFuelType.AutoSize = true;
            lblFuelType.Location = new Point(12, 138);
            lblFuelType.Name = "lblFuelType";
            lblFuelType.Size = new Size(71, 20);
            lblFuelType.TabIndex = 7;
            lblFuelType.Text = "Fuel Type";
            lblFuelType.Click += lblFuelType_Click;
            // 
            // txtFuelLevel
            // 
            txtFuelLevel.Location = new Point(509, 131);
            txtFuelLevel.Name = "txtFuelLevel";
            txtFuelLevel.Size = new Size(181, 27);
            txtFuelLevel.TabIndex = 16;
            txtFuelLevel.TextChanged += txtFuelLevel_TextChanged;
            // 
            // lblFuelLevel
            // 
            lblFuelLevel.AutoSize = true;
            lblFuelLevel.Location = new Point(343, 131);
            lblFuelLevel.Name = "lblFuelLevel";
            lblFuelLevel.Size = new Size(147, 20);
            lblFuelLevel.TabIndex = 15;
            lblFuelLevel.Text = "Current Fuel Level (L)";
            // 
            // txtTankCapacity
            // 
            txtTankCapacity.Location = new Point(509, 98);
            txtTankCapacity.Name = "txtTankCapacity";
            txtTankCapacity.Size = new Size(181, 27);
            txtTankCapacity.TabIndex = 14;
            txtTankCapacity.TextChanged += txtTankCapacity_TextChanged;
            // 
            // lblTankCapacity
            // 
            lblTankCapacity.AutoSize = true;
            lblTankCapacity.Location = new Point(345, 98);
            lblTankCapacity.Name = "lblTankCapacity";
            lblTankCapacity.Size = new Size(120, 20);
            lblTankCapacity.TabIndex = 13;
            lblTankCapacity.Text = "Tank Capacity (L)";
            // 
            // txtPricePerLiter
            // 
            txtPricePerLiter.Location = new Point(509, 65);
            txtPricePerLiter.Name = "txtPricePerLiter";
            txtPricePerLiter.Size = new Size(181, 27);
            txtPricePerLiter.TabIndex = 12;
            txtPricePerLiter.TextChanged += txtPricePerLiters_TextChanged;
            // 
            // lblPricePerLiter
            // 
            lblPricePerLiter.AutoSize = true;
            lblPricePerLiter.Location = new Point(345, 65);
            lblPricePerLiter.Name = "lblPricePerLiter";
            lblPricePerLiter.Size = new Size(100, 20);
            lblPricePerLiter.TabIndex = 11;
            lblPricePerLiter.Text = "Price per Liter";
            lblPricePerLiter.Click += label3_Click_1;
            // 
            // txtLiters
            // 
            txtLiters.Location = new Point(509, 32);
            txtLiters.Name = "txtLiters";
            txtLiters.Size = new Size(181, 27);
            txtLiters.TabIndex = 10;
            txtLiters.TextChanged += textBox8_TextChanged;
            // 
            // lblLiters
            // 
            lblLiters.AutoSize = true;
            lblLiters.Location = new Point(345, 35);
            lblLiters.Name = "lblLiters";
            lblLiters.Size = new Size(118, 20);
            lblLiters.TabIndex = 9;
            lblLiters.Text = "Liters Requested";
            // 
            // txtCashTendered
            // 
            txtCashTendered.Location = new Point(509, 197);
            txtCashTendered.Name = "txtCashTendered";
            txtCashTendered.Size = new Size(181, 27);
            txtCashTendered.TabIndex = 24;
            txtCashTendered.TextChanged += txtCashTendered_TextChanged;
            // 
            // lblCashTendered
            // 
            lblCashTendered.AutoSize = true;
            lblCashTendered.Location = new Point(345, 200);
            lblCashTendered.Name = "lblCashTendered";
            lblCashTendered.Size = new Size(106, 20);
            lblCashTendered.TabIndex = 23;
            lblCashTendered.Text = "Cash Tendered";
            // 
            // txtLoyaltyPoints
            // 
            txtLoyaltyPoints.Location = new Point(509, 164);
            txtLoyaltyPoints.Name = "txtLoyaltyPoints";
            txtLoyaltyPoints.Size = new Size(181, 27);
            txtLoyaltyPoints.TabIndex = 22;
            txtLoyaltyPoints.TextChanged += txtLoyaltyPoints_TextChanged;
            // 
            // lblLoyaltyPoints
            // 
            lblLoyaltyPoints.AutoSize = true;
            lblLoyaltyPoints.Location = new Point(345, 167);
            lblLoyaltyPoints.Name = "lblLoyaltyPoints";
            lblLoyaltyPoints.Size = new Size(99, 20);
            lblLoyaltyPoints.TabIndex = 21;
            lblLoyaltyPoints.Text = "Loyalty Points";
            // 
            // lblTankSpace
            // 
            lblTankSpace.AutoSize = true;
            lblTankSpace.Location = new Point(728, 38);
            lblTankSpace.Name = "lblTankSpace";
            lblTankSpace.Size = new Size(148, 20);
            lblTankSpace.TabIndex = 27;
            lblTankSpace.Text = "Available Tank Space";
            lblTankSpace.Click += label1_Click_1;
            // 
            // lblVolDiscount
            // 
            lblVolDiscount.AutoSize = true;
            lblVolDiscount.Location = new Point(728, 101);
            lblVolDiscount.Name = "lblVolDiscount";
            lblVolDiscount.Size = new Size(121, 20);
            lblVolDiscount.TabIndex = 28;
            lblVolDiscount.Text = "Volume Discount";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Location = new Point(728, 236);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(59, 20);
            lblChange.TabIndex = 29;
            lblChange.Text = "Change";
            lblChange.Click += label3_Click_2;
            // 
            // lblVatAmount
            // 
            lblVatAmount.AutoSize = true;
            lblVatAmount.Location = new Point(728, 203);
            lblVatAmount.Name = "lblVatAmount";
            lblVatAmount.Size = new Size(95, 20);
            lblVatAmount.TabIndex = 30;
            lblVatAmount.Text = "VAT Included";
            // 
            // lblNetAmount
            // 
            lblNetAmount.AutoSize = true;
            lblNetAmount.Location = new Point(725, 170);
            lblNetAmount.Name = "lblNetAmount";
            lblNetAmount.Size = new Size(121, 20);
            lblNetAmount.TabIndex = 31;
            lblNetAmount.Text = "Net Amount Due";
            // 
            // lblLoyaltyDiscount
            // 
            lblLoyaltyDiscount.AutoSize = true;
            lblLoyaltyDiscount.Location = new Point(728, 137);
            lblLoyaltyDiscount.Name = "lblLoyaltyDiscount";
            lblLoyaltyDiscount.Size = new Size(118, 20);
            lblLoyaltyDiscount.TabIndex = 32;
            lblLoyaltyDiscount.Text = "Loyalty Discount";
            // 
            // lblPointsEarned
            // 
            lblPointsEarned.AutoSize = true;
            lblPointsEarned.Location = new Point(725, 269);
            lblPointsEarned.Name = "lblPointsEarned";
            lblPointsEarned.Size = new Size(98, 20);
            lblPointsEarned.TabIndex = 33;
            lblPointsEarned.Text = "Points Earned";
            lblPointsEarned.Click += label7_Click;
            // 
            // lblTankStatus
            // 
            lblTankStatus.AutoSize = true;
            lblTankStatus.Location = new Point(725, 303);
            lblTankStatus.Name = "lblTankStatus";
            lblTankStatus.Size = new Size(165, 20);
            lblTankStatus.TabIndex = 34;
            lblTankStatus.Text = "Tank Status After Refuel";
            // 
            // txtLoyaltyDiscount
            // 
            txtLoyaltyDiscount.Location = new Point(913, 131);
            txtLoyaltyDiscount.Name = "txtLoyaltyDiscount";
            txtLoyaltyDiscount.ReadOnly = true;
            txtLoyaltyDiscount.Size = new Size(181, 27);
            txtLoyaltyDiscount.TabIndex = 35;
            txtLoyaltyDiscount.TextChanged += txtLoyaltyDiscount_TextChanged;
            // 
            // txtNetAmount
            // 
            txtNetAmount.Location = new Point(913, 164);
            txtNetAmount.Name = "txtNetAmount";
            txtNetAmount.ReadOnly = true;
            txtNetAmount.Size = new Size(181, 27);
            txtNetAmount.TabIndex = 36;
            txtNetAmount.TextChanged += txtNetAmount_TextChanged;
            // 
            // txtVatAmount
            // 
            txtVatAmount.Location = new Point(913, 197);
            txtVatAmount.Name = "txtVatAmount";
            txtVatAmount.ReadOnly = true;
            txtVatAmount.Size = new Size(181, 27);
            txtVatAmount.TabIndex = 37;
            txtVatAmount.TextChanged += txtVatAmount_TextChanged;
            // 
            // txtChange
            // 
            txtChange.Location = new Point(913, 230);
            txtChange.Name = "txtChange";
            txtChange.ReadOnly = true;
            txtChange.Size = new Size(181, 27);
            txtChange.TabIndex = 38;
            txtChange.TextChanged += txtChange_TextChanged;
            // 
            // txtPointsEarned
            // 
            txtPointsEarned.Location = new Point(913, 263);
            txtPointsEarned.Name = "txtPointsEarned";
            txtPointsEarned.ReadOnly = true;
            txtPointsEarned.Size = new Size(181, 27);
            txtPointsEarned.TabIndex = 39;
            txtPointsEarned.TextChanged += txtPointsEarned_TextChanged;
            // 
            // txtTankStatus
            // 
            txtTankStatus.Location = new Point(913, 296);
            txtTankStatus.Name = "txtTankStatus";
            txtTankStatus.ReadOnly = true;
            txtTankStatus.Size = new Size(181, 27);
            txtTankStatus.TabIndex = 40;
            txtTankStatus.TextChanged += txtTankStatus_TextChanged;
            // 
            // txtTankSpace
            // 
            txtTankSpace.Location = new Point(913, 32);
            txtTankSpace.Name = "txtTankSpace";
            txtTankSpace.ReadOnly = true;
            txtTankSpace.Size = new Size(181, 27);
            txtTankSpace.TabIndex = 43;
            txtTankSpace.TextChanged += txtTankSpace_TextChanged;
            // 
            // txtGrossAmount
            // 
            txtGrossAmount.Location = new Point(913, 65);
            txtGrossAmount.Name = "txtGrossAmount";
            txtGrossAmount.ReadOnly = true;
            txtGrossAmount.Size = new Size(181, 27);
            txtGrossAmount.TabIndex = 44;
            txtGrossAmount.TextChanged += txtGrossAmount_TextChanged;
            // 
            // lblGrossAmount
            // 
            lblGrossAmount.AutoSize = true;
            lblGrossAmount.Location = new Point(728, 71);
            lblGrossAmount.Name = "lblGrossAmount";
            lblGrossAmount.Size = new Size(102, 20);
            lblGrossAmount.TabIndex = 45;
            lblGrossAmount.Text = "Gross Amount";
            // 
            // txtVolDiscount
            // 
            txtVolDiscount.Location = new Point(913, 98);
            txtVolDiscount.Name = "txtVolDiscount";
            txtVolDiscount.ReadOnly = true;
            txtVolDiscount.Size = new Size(181, 27);
            txtVolDiscount.TabIndex = 46;
            txtVolDiscount.TextChanged += txtVolDiscount_TextChanged;
            // 
            // btnCompute
            // 
            btnCompute.Location = new Point(423, 411);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(287, 29);
            btnCompute.TabIndex = 47;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(423, 446);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(287, 29);
            btnClear.TabIndex = 48;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(423, 481);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(287, 29);
            btnReport.TabIndex = 49;
            btnReport.Text = "View Receipt";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(423, 516);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(287, 29);
            btnExit.TabIndex = 50;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 576);
            Controls.Add(btnExit);
            Controls.Add(btnReport);
            Controls.Add(btnClear);
            Controls.Add(btnCompute);
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
            Controls.Add(txtPricePerLiter);
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
        private TextBox txtPricePerLiter;
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
        private Button btnCompute;
        private Button btnClear;
        private Button btnReport;
        private Button btnExit;
    }
}
