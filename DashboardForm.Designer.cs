namespace PerfumeSystem
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnSales = new Guna.UI2.WinForms.Guna2Button();
            this.btnPayroll = new Guna.UI2.WinForms.Guna2Button();
            this.btnExpenses = new Guna.UI2.WinForms.Guna2Button();
            this.btnFinancial = new Guna.UI2.WinForms.Guna2Button();
            this.btnRawMaterials = new Guna.UI2.WinForms.Guna2Button();
            this.btnUnits = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();

            // btnSales
            this.btnSales.FillColor = System.Drawing.Color.FromArgb(255, 98, 0);
            this.btnSales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.Location = new System.Drawing.Point(50, 50);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(200, 50);
            this.btnSales.Text = "المبيعات المباشرة";

            // btnPayroll
            this.btnPayroll.FillColor = System.Drawing.Color.FromArgb(255, 98, 0);
            this.btnPayroll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPayroll.ForeColor = System.Drawing.Color.White;
            this.btnPayroll.Location = new System.Drawing.Point(50, 120);
            this.btnPayroll.Name = "btnPayroll";
            this.btnPayroll.Size = new System.Drawing.Size(200, 50);
            this.btnPayroll.Text = "إدارة الرواتب";

            // btnExpenses
            this.btnExpenses.FillColor = System.Drawing.Color.FromArgb(255, 98, 0);
            this.btnExpenses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnExpenses.ForeColor = System.Drawing.Color.White;
            this.btnExpenses.Location = new System.Drawing.Point(50, 190);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(200, 50);
            this.btnExpenses.Text = "إدارة المصروفات";

            // btnFinancial
            this.btnFinancial.FillColor = System.Drawing.Color.FromArgb(255, 98, 0);
            this.btnFinancial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnFinancial.ForeColor = System.Drawing.Color.White;
            this.btnFinancial.Location = new System.Drawing.Point(50, 260);
            this.btnFinancial.Name = "btnFinancial";
            this.btnFinancial.Size = new System.Drawing.Size(200, 50);
            this.btnFinancial.Text = "الإدارة المالية";

            // btnRawMaterials
            this.btnRawMaterials.FillColor = System.Drawing.Color.FromArgb(255, 98, 0);
            this.btnRawMaterials.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRawMaterials.ForeColor = System.Drawing.Color.White;
            this.btnRawMaterials.Location = new System.Drawing.Point(50, 330);
            this.btnRawMaterials.Name = "btnRawMaterials";
            this.btnRawMaterials.Size = new System.Drawing.Size(200, 50);
            this.btnRawMaterials.Text = "المواد الخام";

            // btnUnits
            this.btnUnits.FillColor = System.Drawing.Color.FromArgb(255, 98, 0);
            this.btnUnits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnUnits.ForeColor = System.Drawing.Color.White;
            this.btnUnits.Location = new System.Drawing.Point(50, 400);
            this.btnUnits.Name = "btnUnits";
            this.btnUnits.Size = new System.Drawing.Size(200, 50);
            this.btnUnits.Text = "وحدات القياس";

            // DashboardForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnPayroll);
            this.Controls.Add(this.btnExpenses);
            this.Controls.Add(this.btnFinancial);
            this.Controls.Add(this.btnRawMaterials);
            this.Controls.Add(this.btnUnits);
            this.Name = "DashboardForm";
            this.Text = "لوحة التحكم - نظام العطور";
            this.ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2Button btnSales;
        private Guna.UI2.WinForms.Guna2Button btnPayroll;
        private Guna.UI2.WinForms.Guna2Button btnExpenses;
        private Guna.UI2.WinForms.Guna2Button btnFinancial;
        private Guna.UI2.WinForms.Guna2Button btnRawMaterials;
        private Guna.UI2.WinForms.Guna2Button btnUnits;
    }
}