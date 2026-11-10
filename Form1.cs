using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        // Tracks if a valid receipt has been generated
        private bool hasComputed = false;
        private string savedReceipt = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            hasComputed = false;
            savedReceipt = "";

            // 1. Validate Info Fields
            if (txtPumpNo.Text.Trim() == "" || txtCustomer.Text.Trim() == "" ||
                txtPlateNo.Text.Trim() == "" || txtFuelType.Text.Trim() == "")
            {
                MessageBox.Show("Please complete all pump and customer information.");
                return;
            }

            // 2. Parse Inputs
            if (!decimal.TryParse(txtLiters.Text.Trim(), out decimal liters) ||
                !decimal.TryParse(txtPricePerLiter.Text.Trim(), out decimal price) ||
                !int.TryParse(txtTankCapacity.Text.Trim(), out int tankCapacity) ||
                !int.TryParse(txtFuelLevel.Text.Trim(), out int fuelLevel) ||
                !int.TryParse(txtLoyaltyPoints.Text.Trim(), out int loyaltyPoints) ||
                !decimal.TryParse(txtCashTendered.Text.Trim(), out decimal cash))
            {
                MessageBox.Show("Please enter valid numbers.");
                return;
            }

            // 3. Check Negatives
            if (liters < 0 || price < 0 || tankCapacity < 0 || fuelLevel < 0 || loyaltyPoints < 0 || cash < 0)
            {
                MessageBox.Show("Negative values are not allowed.");
                return;
            }

            // 4. Check Greater Than Zero
            if (liters <= 0 || price <= 0 || tankCapacity <= 0)
            {
                MessageBox.Show("Liters, price per liter, and tank capacity must be greater than zero.");
                return;
            }

            // 5. Tank Checks
            if (fuelLevel > tankCapacity)
            {
                MessageBox.Show("Current fuel level cannot exceed tank capacity.");
                return;
            }
            int tankSpace = tankCapacity - fuelLevel;
            if (liters > tankSpace)
            {
                MessageBox.Show("Fuel requested exceeds available tank space.");
                return;
            }

            // 6. Calculations
            decimal gross = liters * price;

            decimal discPerLiter = 0m;
            if (liters >= 40m) discPerLiter = 1.00m;
            else if (liters >= 20m) discPerLiter = 0.50m;

            decimal volDiscount = liters * discPerLiter;
            decimal rawLoyalty = (decimal)(loyaltyPoints / 100) * 10m;
            decimal loyaltyCap = 0.20m * (gross - volDiscount);
            decimal loyaltyDisc = Math.Min(rawLoyalty, loyaltyCap);

            decimal net = gross - volDiscount - loyaltyDisc;
            decimal vat = net / 1.12m * 0.12m;
            decimal change = cash - net;

            // 7. Payment Check
            if (cash < net)
            {
                MessageBox.Show("Insufficient cash tendered.");
                return;
            }

            int pointsEarned = (int)(net / 50m);

            // 8. Tank Status
            decimal newFuelLevel = fuelLevel + liters;
            string status;
            if (newFuelLevel == tankCapacity) status = "FULL TANK";
            else if (newFuelLevel >= 0.80m * tankCapacity) status = "ALMOST FULL";
            else if (newFuelLevel >= 0.50m * tankCapacity) status = "HALF TANK";
            else status = "LOW LEVEL";

            // 9. Display Results
            txtTankSpace.Text = tankSpace.ToString();
            txtGrossAmount.Text = gross.ToString("F2");
            txtVolDiscount.Text = volDiscount.ToString("F2");
            txtLoyaltyDiscount.Text = loyaltyDisc.ToString("F2");
            txtNetAmount.Text = net.ToString("F2");
            txtVatAmount.Text = vat.ToString("F2");
            txtChange.Text = change.ToString("F2");
            txtPointsEarned.Text = pointsEarned.ToString();
            txtTankStatus.Text = status;

            // 10. Save Receipt Snapshot
            savedReceipt =
                "FUEL RECEIPT" + Environment.NewLine +
                "Pump No: " + txtPumpNo.Text.Trim() +
                " Customer: " + txtCustomer.Text.Trim() +
                " Plate: " + txtPlateNo.Text.Trim() + Environment.NewLine +
                "Fuel Type: " + txtFuelType.Text.Trim() +
                " Liters: " + liters.ToString("F2") +
                " Price: " + price.ToString("F2") + Environment.NewLine +
                "Tank: " + fuelLevel + " L of " + tankCapacity + " L" +
                " Loyalty Points: " + loyaltyPoints + Environment.NewLine +
                "Available Tank Space: " + tankSpace + Environment.NewLine +
                "Gross Amount: " + gross.ToString("F2") + Environment.NewLine +
                "Volume Discount: " + volDiscount.ToString("F2") +
                " Loyalty Discount: " + loyaltyDisc.ToString("F2") + Environment.NewLine +
                "Net Amount Due: " + net.ToString("F2") + Environment.NewLine +
                "VAT Included: " + vat.ToString("F2") + Environment.NewLine +
                "Cash Tendered: " + cash.ToString("F2") +
                " Change: " + change.ToString("F2") + Environment.NewLine +
                "Points Earned: " + pointsEarned +
                " Tank Status: " + status;

            hasComputed = true;
            MessageBox.Show("Fuel bill computed successfully!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
                if (c is TextBox tb) tb.Clear();

            hasComputed = false;
            savedReceipt = "";
            txtPumpNo.Focus();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (!hasComputed)
            {
                MessageBox.Show("Please compute the bill first.");
                return;
            }
            MessageBox.Show(savedReceipt, "Fuel Receipt");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ==========================================================
        // INPUT TEXTBOX HANDLERS: Clear saved receipt if user edits
        // ==========================================================
        private void txtPumpNo_TextChanged(object sender, EventArgs e) { hasComputed = false; savedReceipt = ""; }
        private void txtCustomer_TextChanged(object sender, EventArgs e) { hasComputed = false; savedReceipt = ""; }
        private void txtPlateNo_TextChanged(object sender, EventArgs e) { hasComputed = false; savedReceipt = ""; }
        private void txtFuelType_TextChanged(object sender, EventArgs e) { hasComputed = false; savedReceipt = ""; }
        private void textBox8_TextChanged(object sender, EventArgs e) { hasComputed = false; savedReceipt = ""; } // This is txtLiters
        private void txtPricePerLiters_TextChanged(object sender, EventArgs e) { hasComputed = false; savedReceipt = ""; }
        private void txtTankCapacity_TextChanged(object sender, EventArgs e) { hasComputed = false; savedReceipt = ""; }
        private void txtFuelLevel_TextChanged(object sender, EventArgs e) { hasComputed = false; savedReceipt = ""; }
        private void txtLoyaltyPoints_TextChanged(object sender, EventArgs e) { hasComputed = false; savedReceipt = ""; }
        private void txtCashTendered_TextChanged(object sender, EventArgs e) { hasComputed = false; savedReceipt = ""; }

        // ==========================================================
        // DUMMY HANDLERS: Required by your Designer file to prevent errors
        // ==========================================================
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label3_Click_1(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void label3_Click_2(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void lblFuelType_Click(object sender, EventArgs e) { }

        // Output textboxes (No need to clear receipt if these somehow change)
        private void txtTankSpace_TextChanged(object sender, EventArgs e) { }
        private void txtGrossAmount_TextChanged(object sender, EventArgs e) { }
        private void txtVolDiscount_TextChanged(object sender, EventArgs e) { }
        private void txtLoyaltyDiscount_TextChanged(object sender, EventArgs e) { }
        private void txtNetAmount_TextChanged(object sender, EventArgs e) { }
        private void txtVatAmount_TextChanged(object sender, EventArgs e) { }
        private void txtChange_TextChanged(object sender, EventArgs e) { }
        private void txtPointsEarned_TextChanged(object sender, EventArgs e) { }
        private void txtTankStatus_TextChanged(object sender, EventArgs e) { }
    }
}