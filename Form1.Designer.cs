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
            btnCompute = new Button();
            btnClear = new Button();
            btnReport = new Button();
            btnExi = new Button();
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
            lblPumpNo.Location = new Point(12, 62);
            lblPumpNo.Name = "lblPumpNo";
            lblPumpNo.Size = new Size(105, 20);
            lblPumpNo.TabIndex = 1;
            lblPumpNo.Text = "Pump Number";
            lblPumpNo.Click += label1_Click;
            // 
            // txtPumpNo
            // 
            txtPumpNo.Location = new Point(148, 59);
            txtPumpNo.Name = "txtPumpNo";
            txtPumpNo.Size = new Size(181, 27);
            txtPumpNo.TabIndex = 2;
            txtPumpNo.TextChanged += txtPumpNo_TextChanged;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(148, 92);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(181, 27);
            txtCustomer.TabIndex = 4;
            txtCustomer.TextChanged += txtCustomer_TextChanged;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(12, 95);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(116, 20);
            lblCustomer.TabIndex = 3;
            lblCustomer.Text = "Customer Name";
            lblCustomer.Click += label2_Click;
            // 
            // txtPlateNo
            // 
            txtPlateNo.Location = new Point(148, 125);
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
            txtFuelType.Location = new Point(148, 158);
            txtFuelType.Name = "txtFuelType";
            txtFuelType.Size = new Size(181, 27);
            txtFuelType.TabIndex = 8;
            // 
            // lblFuelType
            // 
            lblFuelType.AutoSize = true;
            lblFuelType.Location = new Point(12, 161);
            lblFuelType.Name = "lblFuelType";
            lblFuelType.Size = new Size(94, 20);
            lblFuelType.TabIndex = 7;
            lblFuelType.Text = "Fuel Number";
            // 
            // txtFuelLevel
            // 
            txtFuelLevel.Location = new Point(532, 158);
            txtFuelLevel.Name = "txtFuelLevel";
            txtFuelLevel.Size = new Size(181, 27);
            txtFuelLevel.TabIndex = 16;
            // 
            // lblFuelLevel
            // 
            lblFuelLevel.AutoSize = true;
            lblFuelLevel.Location = new Point(364, 161);
            lblFuelLevel.Name = "lblFuelLevel";
            lblFuelLevel.Size = new Size(147, 20);
            lblFuelLevel.TabIndex = 15;
            lblFuelLevel.Text = "Current Fuel Level (L)";
            // 
            // txtTankCapacity
            // 
            txtTankCapacity.Location = new Point(532, 125);
            txtTankCapacity.Name = "txtTankCapacity";
            txtTankCapacity.Size = new Size(181, 27);
            txtTankCapacity.TabIndex = 14;
            // 
            // lblTankCapacity
            // 
            lblTankCapacity.AutoSize = true;
            lblTankCapacity.Location = new Point(366, 128);
            lblTankCapacity.Name = "lblTankCapacity";
            lblTankCapacity.Size = new Size(120, 20);
            lblTankCapacity.TabIndex = 13;
            lblTankCapacity.Text = "Tank Capacity (L)";
            // 
            // txtPricePerLiters
            // 
            txtPricePerLiters.Location = new Point(532, 92);
            txtPricePerLiters.Name = "txtPricePerLiters";
            txtPricePerLiters.Size = new Size(181, 27);
            txtPricePerLiters.TabIndex = 12;
            // 
            // lblPricePerLiter
            // 
            lblPricePerLiter.AutoSize = true;
            lblPricePerLiter.Location = new Point(366, 95);
            lblPricePerLiter.Name = "lblPricePerLiter";
            lblPricePerLiter.Size = new Size(100, 20);
            lblPricePerLiter.TabIndex = 11;
            lblPricePerLiter.Text = "Price per Liter";
            lblPricePerLiter.Click += label3_Click_1;
            // 
            // txtLiters
            // 
            txtLiters.Location = new Point(532, 59);
            txtLiters.Name = "txtLiters";
            txtLiters.Size = new Size(181, 27);
            txtLiters.TabIndex = 10;
            txtLiters.TextChanged += textBox8_TextChanged;
            // 
            // lblLiters
            // 
            lblLiters.AutoSize = true;
            lblLiters.Location = new Point(366, 62);
            lblLiters.Name = "lblLiters";
            lblLiters.Size = new Size(118, 20);
            lblLiters.TabIndex = 9;
            lblLiters.Text = "Liters Requested";
            // 
            // txtCashTendered
            // 
            txtCashTendered.Location = new Point(532, 224);
            txtCashTendered.Name = "txtCashTendered";
            txtCashTendered.Size = new Size(181, 27);
            txtCashTendered.TabIndex = 24;
            // 
            // lblCashTendered
            // 
            lblCashTendered.AutoSize = true;
            lblCashTendered.Location = new Point(367, 227);
            lblCashTendered.Name = "lblCashTendered";
            lblCashTendered.Size = new Size(106, 20);
            lblCashTendered.TabIndex = 23;
            lblCashTendered.Text = "Cash Tendered";
            // 
            // txtLoyaltyPoints
            // 
            txtLoyaltyPoints.Location = new Point(532, 191);
            txtLoyaltyPoints.Name = "txtLoyaltyPoints";
            txtLoyaltyPoints.Size = new Size(181, 27);
            txtLoyaltyPoints.TabIndex = 22;
            // 
            // lblLoyaltyPoints
            // 
            lblLoyaltyPoints.AutoSize = true;
            lblLoyaltyPoints.Location = new Point(367, 194);
            lblLoyaltyPoints.Name = "lblLoyaltyPoints";
            lblLoyaltyPoints.Size = new Size(99, 20);
            lblLoyaltyPoints.TabIndex = 21;
            lblLoyaltyPoints.Text = "Loyalty Points";
            // 
            // btnCompute
            // 
            btnCompute.BackColor = Color.Lime;
            btnCompute.Location = new Point(260, 440);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(271, 29);
            btnCompute.TabIndex = 25;
            btnCompute.Text = "Compute Bill";
            btnCompute.UseVisualStyleBackColor = false;
            btnCompute.Click += btnCompute_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.Location = new Point(537, 440);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(271, 29);
            btnClear.TabIndex = 26;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.Lime;
            btnReport.Location = new Point(260, 475);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(271, 29);
            btnReport.TabIndex = 27;
            btnReport.Text = "View Receipt";
            btnReport.UseVisualStyleBackColor = false;
            // 
            // btnExi
            // 
            btnExi.BackColor = Color.Red;
            btnExi.Location = new Point(537, 475);
            btnExi.Name = "btnExi";
            btnExi.Size = new Size(271, 29);
            btnExi.TabIndex = 28;
            btnExi.Text = "Exit";
            btnExi.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 757);
            Controls.Add(btnExi);
            Controls.Add(btnReport);
            Controls.Add(btnClear);
            Controls.Add(btnCompute);
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
        private Button btnCompute;
        private Button btnClear;
        private Button btnReport;
        private Button btnExi;
    }
}
