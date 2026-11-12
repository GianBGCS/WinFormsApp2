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
            lblPumpAndCustomer = new Label();
            lblFuelInputs = new Label();
            lblResults = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Cambria", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(243, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(309, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Gas Station Billing System";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblPumpNo
            // 
            lblPumpNo.AutoSize = true;
            lblPumpNo.Font = new Font("Cambria", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPumpNo.Location = new Point(36, 98);
            lblPumpNo.Name = "lblPumpNo";
            lblPumpNo.Size = new Size(98, 17);
            lblPumpNo.TabIndex = 1;
            lblPumpNo.Text = "Pump Number";
            lblPumpNo.Click += label1_Click;
            // 
            // txtPumpNo
            // 
            txtPumpNo.BorderStyle = BorderStyle.FixedSingle;
            txtPumpNo.Location = new Point(147, 93);
            txtPumpNo.Name = "txtPumpNo";
            txtPumpNo.Size = new Size(181, 27);
            txtPumpNo.TabIndex = 2;
            txtPumpNo.TextChanged += txtPumpNo_TextChanged;
            // 
            // txtCustomer
            // 
            txtCustomer.BorderStyle = BorderStyle.FixedSingle;
            txtCustomer.Location = new Point(147, 147);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(181, 27);
            txtCustomer.TabIndex = 4;
            txtCustomer.TextChanged += txtCustomer_TextChanged;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Cambria", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCustomer.Location = new Point(33, 152);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(108, 17);
            lblCustomer.TabIndex = 3;
            lblCustomer.Text = "Customer Name";
            lblCustomer.Click += label2_Click;
            // 
            // txtPlateNo
            // 
            txtPlateNo.BorderStyle = BorderStyle.FixedSingle;
            txtPlateNo.Location = new Point(576, 94);
            txtPlateNo.Name = "txtPlateNo";
            txtPlateNo.Size = new Size(181, 27);
            txtPlateNo.TabIndex = 6;
            txtPlateNo.TextChanged += txtPlateNo_TextChanged;
            // 
            // lblPlateNo
            // 
            lblPlateNo.AutoSize = true;
            lblPlateNo.Font = new Font("Cambria", 9F, FontStyle.Italic);
            lblPlateNo.Location = new Point(476, 99);
            lblPlateNo.Name = "lblPlateNo";
            lblPlateNo.Size = new Size(94, 17);
            lblPlateNo.TabIndex = 5;
            lblPlateNo.Text = "Plate Number";
            lblPlateNo.Click += label3_Click;
            // 
            // txtFuelType
            // 
            txtFuelType.BorderStyle = BorderStyle.FixedSingle;
            txtFuelType.Location = new Point(576, 149);
            txtFuelType.Name = "txtFuelType";
            txtFuelType.Size = new Size(181, 27);
            txtFuelType.TabIndex = 8;
            txtFuelType.TextChanged += txtFuelType_TextChanged;
            // 
            // lblFuelType
            // 
            lblFuelType.AutoSize = true;
            lblFuelType.Font = new Font("Cambria", 9F, FontStyle.Italic);
            lblFuelType.Location = new Point(485, 152);
            lblFuelType.Name = "lblFuelType";
            lblFuelType.Size = new Size(69, 17);
            lblFuelType.TabIndex = 7;
            lblFuelType.Text = "Fuel Type";
            lblFuelType.Click += lblFuelType_Click;
            // 
            // txtFuelLevel
            // 
            txtFuelLevel.BorderStyle = BorderStyle.FixedSingle;
            txtFuelLevel.Location = new Point(576, 237);
            txtFuelLevel.Name = "txtFuelLevel";
            txtFuelLevel.Size = new Size(181, 27);
            txtFuelLevel.TabIndex = 16;
            txtFuelLevel.TextChanged += txtFuelLevel_TextChanged;
            // 
            // lblFuelLevel
            // 
            lblFuelLevel.AutoSize = true;
            lblFuelLevel.Font = new Font("Cambria", 7.20000029F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFuelLevel.Location = new Point(445, 243);
            lblFuelLevel.Name = "lblFuelLevel";
            lblFuelLevel.Size = new Size(125, 15);
            lblFuelLevel.TabIndex = 15;
            lblFuelLevel.Text = "Current Fuel Level (L)";
            lblFuelLevel.Click += lblFuelLevel_Click;
            // 
            // txtTankCapacity
            // 
            txtTankCapacity.BorderStyle = BorderStyle.FixedSingle;
            txtTankCapacity.Location = new Point(147, 348);
            txtTankCapacity.Name = "txtTankCapacity";
            txtTankCapacity.Size = new Size(181, 27);
            txtTankCapacity.TabIndex = 14;
            txtTankCapacity.TextChanged += txtTankCapacity_TextChanged;
            // 
            // lblTankCapacity
            // 
            lblTankCapacity.AutoSize = true;
            lblTankCapacity.Font = new Font("Cambria", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTankCapacity.Location = new Point(33, 354);
            lblTankCapacity.Name = "lblTankCapacity";
            lblTankCapacity.Size = new Size(104, 15);
            lblTankCapacity.TabIndex = 13;
            lblTankCapacity.Text = "Tank Capacity (L)";
            lblTankCapacity.Click += lblTankCapacity_Click;
            // 
            // txtPricePerLiter
            // 
            txtPricePerLiter.BorderStyle = BorderStyle.FixedSingle;
            txtPricePerLiter.Location = new Point(147, 291);
            txtPricePerLiter.Name = "txtPricePerLiter";
            txtPricePerLiter.Size = new Size(181, 27);
            txtPricePerLiter.TabIndex = 12;
            txtPricePerLiter.TextChanged += txtPricePerLiters_TextChanged;
            // 
            // lblPricePerLiter
            // 
            lblPricePerLiter.AutoSize = true;
            lblPricePerLiter.Font = new Font("Cambria", 9F, FontStyle.Italic);
            lblPricePerLiter.Location = new Point(36, 295);
            lblPricePerLiter.Name = "lblPricePerLiter";
            lblPricePerLiter.Size = new Size(96, 17);
            lblPricePerLiter.TabIndex = 11;
            lblPricePerLiter.Text = "Price per Liter";
            lblPricePerLiter.Click += label3_Click_1;
            // 
            // txtLiters
            // 
            txtLiters.BorderStyle = BorderStyle.FixedSingle;
            txtLiters.Location = new Point(147, 237);
            txtLiters.Name = "txtLiters";
            txtLiters.Size = new Size(181, 27);
            txtLiters.TabIndex = 10;
            txtLiters.TextChanged += textBox8_TextChanged;
            // 
            // lblLiters
            // 
            lblLiters.AutoSize = true;
            lblLiters.Font = new Font("Cambria", 9F, FontStyle.Italic);
            lblLiters.Location = new Point(33, 241);
            lblLiters.Name = "lblLiters";
            lblLiters.Size = new Size(112, 17);
            lblLiters.TabIndex = 9;
            lblLiters.Text = "Liters Requested";
            // 
            // txtCashTendered
            // 
            txtCashTendered.BorderStyle = BorderStyle.FixedSingle;
            txtCashTendered.Location = new Point(576, 348);
            txtCashTendered.Name = "txtCashTendered";
            txtCashTendered.Size = new Size(181, 27);
            txtCashTendered.TabIndex = 24;
            txtCashTendered.TextChanged += txtCashTendered_TextChanged;
            // 
            // lblCashTendered
            // 
            lblCashTendered.AutoSize = true;
            lblCashTendered.Font = new Font("Cambria", 9F, FontStyle.Italic);
            lblCashTendered.Location = new Point(459, 352);
            lblCashTendered.Name = "lblCashTendered";
            lblCashTendered.Size = new Size(100, 17);
            lblCashTendered.TabIndex = 23;
            lblCashTendered.Text = "Cash Tendered";
            // 
            // txtLoyaltyPoints
            // 
            txtLoyaltyPoints.BorderStyle = BorderStyle.FixedSingle;
            txtLoyaltyPoints.Location = new Point(576, 291);
            txtLoyaltyPoints.Name = "txtLoyaltyPoints";
            txtLoyaltyPoints.Size = new Size(181, 27);
            txtLoyaltyPoints.TabIndex = 22;
            txtLoyaltyPoints.TextChanged += txtLoyaltyPoints_TextChanged;
            // 
            // lblLoyaltyPoints
            // 
            lblLoyaltyPoints.AutoSize = true;
            lblLoyaltyPoints.Font = new Font("Cambria", 9F, FontStyle.Italic);
            lblLoyaltyPoints.Location = new Point(462, 295);
            lblLoyaltyPoints.Name = "lblLoyaltyPoints";
            lblLoyaltyPoints.Size = new Size(97, 17);
            lblLoyaltyPoints.TabIndex = 21;
            lblLoyaltyPoints.Text = "Loyalty Points";
            lblLoyaltyPoints.Click += lblLoyaltyPoints_Click;
            // 
            // lblTankSpace
            // 
            lblTankSpace.AutoSize = true;
            lblTankSpace.Font = new Font("Cambria", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTankSpace.Location = new Point(20, 444);
            lblTankSpace.Name = "lblTankSpace";
            lblTankSpace.Size = new Size(121, 15);
            lblTankSpace.TabIndex = 27;
            lblTankSpace.Text = "Available Tank Space";
            lblTankSpace.Click += label1_Click_1;
            // 
            // lblVolDiscount
            // 
            lblVolDiscount.AutoSize = true;
            lblVolDiscount.Font = new Font("Cambria", 9F, FontStyle.Italic);
            lblVolDiscount.Location = new Point(24, 545);
            lblVolDiscount.Name = "lblVolDiscount";
            lblVolDiscount.Size = new Size(113, 17);
            lblVolDiscount.TabIndex = 28;
            lblVolDiscount.Text = "Volume Discount";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Cambria", 9F, FontStyle.Italic);
            lblChange.Location = new Point(485, 493);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(55, 17);
            lblChange.TabIndex = 29;
            lblChange.Text = "Change";
            lblChange.Click += label3_Click_2;
            // 
            // lblVatAmount
            // 
            lblVatAmount.AutoSize = true;
            lblVatAmount.Font = new Font("Cambria", 9F, FontStyle.Italic);
            lblVatAmount.Location = new Point(462, 442);
            lblVatAmount.Name = "lblVatAmount";
            lblVatAmount.Size = new Size(90, 17);
            lblVatAmount.TabIndex = 30;
            lblVatAmount.Text = "VAT Included";
            lblVatAmount.Click += lblVatAmount_Click;
            // 
            // lblNetAmount
            // 
            lblNetAmount.AutoSize = true;
            lblNetAmount.Font = new Font("Cambria", 9F, FontStyle.Italic);
            lblNetAmount.Location = new Point(19, 651);
            lblNetAmount.Name = "lblNetAmount";
            lblNetAmount.Size = new Size(111, 17);
            lblNetAmount.TabIndex = 31;
            lblNetAmount.Text = "Net Amount Due";
            lblNetAmount.Click += lblNetAmount_Click;
            // 
            // lblLoyaltyDiscount
            // 
            lblLoyaltyDiscount.AutoSize = true;
            lblLoyaltyDiscount.Font = new Font("Cambria", 9F, FontStyle.Italic);
            lblLoyaltyDiscount.Location = new Point(17, 600);
            lblLoyaltyDiscount.Name = "lblLoyaltyDiscount";
            lblLoyaltyDiscount.Size = new Size(113, 17);
            lblLoyaltyDiscount.TabIndex = 32;
            lblLoyaltyDiscount.Text = "Loyalty Discount";
            // 
            // lblPointsEarned
            // 
            lblPointsEarned.AutoSize = true;
            lblPointsEarned.Font = new Font("Cambria", 9F, FontStyle.Italic);
            lblPointsEarned.Location = new Point(458, 545);
            lblPointsEarned.Name = "lblPointsEarned";
            lblPointsEarned.Size = new Size(96, 17);
            lblPointsEarned.TabIndex = 33;
            lblPointsEarned.Text = "Points Earned";
            lblPointsEarned.Click += label7_Click;
            // 
            // lblTankStatus
            // 
            lblTankStatus.AutoSize = true;
            lblTankStatus.Font = new Font("Cambria", 9F, FontStyle.Italic);
            lblTankStatus.Location = new Point(402, 598);
            lblTankStatus.Name = "lblTankStatus";
            lblTankStatus.Size = new Size(157, 17);
            lblTankStatus.TabIndex = 34;
            lblTankStatus.Text = "Tank Status After Refuel";
            lblTankStatus.Click += lblTankStatus_Click;
            // 
            // txtLoyaltyDiscount
            // 
            txtLoyaltyDiscount.BackColor = SystemColors.Window;
            txtLoyaltyDiscount.BorderStyle = BorderStyle.FixedSingle;
            txtLoyaltyDiscount.Location = new Point(147, 594);
            txtLoyaltyDiscount.Name = "txtLoyaltyDiscount";
            txtLoyaltyDiscount.ReadOnly = true;
            txtLoyaltyDiscount.Size = new Size(181, 27);
            txtLoyaltyDiscount.TabIndex = 35;
            txtLoyaltyDiscount.TextChanged += txtLoyaltyDiscount_TextChanged;
            // 
            // txtNetAmount
            // 
            txtNetAmount.BackColor = SystemColors.Window;
            txtNetAmount.BorderStyle = BorderStyle.FixedSingle;
            txtNetAmount.Location = new Point(147, 645);
            txtNetAmount.Name = "txtNetAmount";
            txtNetAmount.ReadOnly = true;
            txtNetAmount.Size = new Size(181, 27);
            txtNetAmount.TabIndex = 36;
            txtNetAmount.TextChanged += txtNetAmount_TextChanged;
            // 
            // txtVatAmount
            // 
            txtVatAmount.BackColor = SystemColors.Window;
            txtVatAmount.BorderStyle = BorderStyle.FixedSingle;
            txtVatAmount.Location = new Point(576, 438);
            txtVatAmount.Name = "txtVatAmount";
            txtVatAmount.ReadOnly = true;
            txtVatAmount.Size = new Size(181, 27);
            txtVatAmount.TabIndex = 37;
            txtVatAmount.TextChanged += txtVatAmount_TextChanged;
            // 
            // txtChange
            // 
            txtChange.BackColor = SystemColors.Window;
            txtChange.BorderStyle = BorderStyle.FixedSingle;
            txtChange.Location = new Point(576, 489);
            txtChange.Name = "txtChange";
            txtChange.ReadOnly = true;
            txtChange.Size = new Size(181, 27);
            txtChange.TabIndex = 38;
            txtChange.TextChanged += txtChange_TextChanged;
            // 
            // txtPointsEarned
            // 
            txtPointsEarned.BackColor = SystemColors.Window;
            txtPointsEarned.BorderStyle = BorderStyle.FixedSingle;
            txtPointsEarned.Location = new Point(576, 541);
            txtPointsEarned.Name = "txtPointsEarned";
            txtPointsEarned.ReadOnly = true;
            txtPointsEarned.Size = new Size(181, 27);
            txtPointsEarned.TabIndex = 39;
            txtPointsEarned.TextChanged += txtPointsEarned_TextChanged;
            // 
            // txtTankStatus
            // 
            txtTankStatus.BackColor = SystemColors.Window;
            txtTankStatus.BorderStyle = BorderStyle.FixedSingle;
            txtTankStatus.Location = new Point(576, 594);
            txtTankStatus.Name = "txtTankStatus";
            txtTankStatus.ReadOnly = true;
            txtTankStatus.Size = new Size(181, 27);
            txtTankStatus.TabIndex = 40;
            txtTankStatus.TextChanged += txtTankStatus_TextChanged;
            // 
            // txtTankSpace
            // 
            txtTankSpace.BackColor = SystemColors.Window;
            txtTankSpace.BorderStyle = BorderStyle.FixedSingle;
            txtTankSpace.Location = new Point(147, 438);
            txtTankSpace.Name = "txtTankSpace";
            txtTankSpace.ReadOnly = true;
            txtTankSpace.Size = new Size(181, 27);
            txtTankSpace.TabIndex = 43;
            txtTankSpace.TextChanged += txtTankSpace_TextChanged;
            // 
            // txtGrossAmount
            // 
            txtGrossAmount.BackColor = SystemColors.Window;
            txtGrossAmount.BorderStyle = BorderStyle.FixedSingle;
            txtGrossAmount.Location = new Point(147, 489);
            txtGrossAmount.Name = "txtGrossAmount";
            txtGrossAmount.ReadOnly = true;
            txtGrossAmount.Size = new Size(181, 27);
            txtGrossAmount.TabIndex = 44;
            txtGrossAmount.TextChanged += txtGrossAmount_TextChanged;
            // 
            // lblGrossAmount
            // 
            lblGrossAmount.AutoSize = true;
            lblGrossAmount.Font = new Font("Cambria", 9F, FontStyle.Italic);
            lblGrossAmount.Location = new Point(33, 493);
            lblGrossAmount.Name = "lblGrossAmount";
            lblGrossAmount.Size = new Size(96, 17);
            lblGrossAmount.TabIndex = 45;
            lblGrossAmount.Text = "Gross Amount";
            lblGrossAmount.Click += lblGrossAmount_Click;
            // 
            // txtVolDiscount
            // 
            txtVolDiscount.BackColor = SystemColors.Window;
            txtVolDiscount.BorderStyle = BorderStyle.FixedSingle;
            txtVolDiscount.Location = new Point(147, 541);
            txtVolDiscount.Name = "txtVolDiscount";
            txtVolDiscount.ReadOnly = true;
            txtVolDiscount.Size = new Size(181, 27);
            txtVolDiscount.TabIndex = 46;
            txtVolDiscount.TextChanged += txtVolDiscount_TextChanged;
            // 
            // btnCompute
            // 
            btnCompute.Font = new Font("Cambria", 10.2F, FontStyle.Bold);
            btnCompute.Location = new Point(832, 121);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(219, 49);
            btnCompute.TabIndex = 47;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Cambria", 10.2F, FontStyle.Bold);
            btnClear.Location = new Point(832, 529);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(219, 49);
            btnClear.TabIndex = 48;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnReport
            // 
            btnReport.Font = new Font("Cambria", 10.2F, FontStyle.Bold);
            btnReport.Location = new Point(832, 247);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(219, 49);
            btnReport.TabIndex = 49;
            btnReport.Text = "View Receipt";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Cambria", 10.2F, FontStyle.Bold);
            btnExit.Location = new Point(832, 383);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(219, 49);
            btnExit.TabIndex = 50;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblPumpAndCustomer
            // 
            lblPumpAndCustomer.AutoSize = true;
            lblPumpAndCustomer.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPumpAndCustomer.Location = new Point(16, 50);
            lblPumpAndCustomer.Name = "lblPumpAndCustomer";
            lblPumpAndCustomer.Size = new Size(310, 23);
            lblPumpAndCustomer.TabIndex = 52;
            lblPumpAndCustomer.Text = "Pump and Customer Information";
            lblPumpAndCustomer.Click += txtPumpAndCustomer_Click;
            // 
            // lblFuelInputs
            // 
            lblFuelInputs.AutoSize = true;
            lblFuelInputs.Font = new Font("Cambria", 12F, FontStyle.Bold);
            lblFuelInputs.Location = new Point(16, 191);
            lblFuelInputs.Name = "lblFuelInputs";
            lblFuelInputs.Size = new Size(113, 23);
            lblFuelInputs.TabIndex = 53;
            lblFuelInputs.Text = "Fuel Inputs";
            lblFuelInputs.Click += lblFuelInputs_Click;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Cambria", 12F, FontStyle.Bold);
            lblResults.Location = new Point(20, 399);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(77, 23);
            lblResults.TabIndex = 54;
            lblResults.Text = "Results";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 677);
            Controls.Add(lblResults);
            Controls.Add(lblFuelInputs);
            Controls.Add(lblPumpAndCustomer);
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
            DoubleBuffered = true;
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
        private Label lblPumpAndCustomer;
        private Label lblFuelInputs;
        private Label lblResults;

        
    }
}
