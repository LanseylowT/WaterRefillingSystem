using System;
using System.Windows.Forms;
using WaterRefillingSystem.Data;
using WaterRefillingSystem.Models;
using WaterRefillingSystem.Repository;

namespace WaterRefillingSystem.NewViews
{
    public partial class AddExpensePage : Form
    {
        private readonly ExpenseRepository _expenseRepository;
        
        public AddExpensePage()
        {
            InitializeComponent();
            _expenseRepository = new ExpenseRepository(Commons.ConnectionString);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Title cannot be empty");
                return;
            }
            var expense = new Expense
            {
                Title = txtTitle.Text.Trim(),
                Amount = Convert.ToDecimal(txtExpensesAmount.Text.Trim()),
                Date = DateTime.Today
            };

            await _expenseRepository.AddExpenseAsyncSP(expense);
            Dashboard2 dashboard2 = new Dashboard2();
            dashboard2.LoadLabels();
            MessageBox.Show("Expense added successfully");
            DialogResult = DialogResult.OK;
            Close();
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtExpensesAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (like Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
    }
}
