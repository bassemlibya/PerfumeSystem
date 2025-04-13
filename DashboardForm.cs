using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PerfumeSystem
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Size = new Size(800, 600);
            this.BackColor = Color.White;
            this.Text = "لوحة التحكم - نظام العطور";

            // زر المبيعات
            Guna2Button btnSales = new Guna2Button
            {
                Location = new Point(50, 50),
                Size = new Size(200, 50),
                Text = "المبيعات المباشرة",
                FillColor = Color.FromArgb(255, 98, 0),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };
            btnSales.Click += (s, e) => new SalesForm().ShowDialog();

            // زر الرواتب
            Guna2Button btnPayroll = new Guna2Button
            {
                Location = new Point(50, 120),
                Size = new Size(200, 50),
                Text = "إدارة الرواتب",
                FillColor = Color.FromArgb(255, 98, 0),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };
            btnPayroll.Click += (s, e) => new PayrollForm().ShowDialog();

            // زر المصروفات
            Guna2Button btnExpenses = new Guna2Button
            {
                Location = new Point(50, 190),
                Size = new Size(200, 50),
                Text = "إدارة المصروفات",
                FillColor = Color.FromArgb(255, 98, 0),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };
            btnExpenses.Click += (s, e) => new ExpensesForm().ShowDialog();

            // زر الإدارة المالية
            Guna2Button btnFinancial = new Guna2Button
            {
                Location = new Point(50, 260),
                Size = new Size(200, 50),
                Text = "الإدارة المالية",
                FillColor = Color.FromArgb(255, 98, 0),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };
            btnFinancial.Click += (s, e) => new FinancialForm().ShowDialog();

            // زر المواد الخام
            Guna2Button btnRawMaterials = new Guna2Button
            {
                Location = new Point(50, 330),
                Size = new Size(200, 50),
                Text = "المواد الخام",
                FillColor = Color.FromArgb(255, 98, 0),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };
            btnRawMaterials.Click += (s, e) => new RawMaterialsForm().ShowDialog();

            // زر وحدات القياس
            Guna2Button btnUnits = new Guna2Button
            {
                Location = new Point(50, 400),
                Size = new Size(200, 50),
                Text = "وحدات القياس",
                FillColor = Color.FromArgb(255, 98, 0),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };
            btnUnits.Click += (s, e) => new UnitsForm().ShowDialog();

            this.Controls.AddRange(new Control[] { btnSales, btnPayroll, btnExpenses, btnFinancial, btnRawMaterials, btnUnits });
        }
    }
}