using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaterRefillingSystem.Data;
using WaterRefillingSystem.Models;
using WaterRefillingSystem.Repository;

namespace WaterRefillingSystem.NewViews
{
    public partial class SalesAndExpensesPage : Form
    {
        private readonly SalesRepository _salesRepository;
        private readonly ExpenseRepository _expenseRepository;
        private readonly CustomerRepository _customerRepository;
        private readonly OrderRepository _orderRepository;
        
        public SalesAndExpensesPage()
        {
            InitializeComponent();
            _salesRepository = new SalesRepository(Commons.ConnectionString);
            _expenseRepository = new ExpenseRepository(Commons.ConnectionString);
            _customerRepository = new CustomerRepository(Commons.ConnectionString);
            _orderRepository = new OrderRepository(Commons.ConnectionString);
        }
        
        // --------------------- Event Handlers ---------------------//
        
        private async void SalesAndExpensesPage_Load(object sender, EventArgs e)
        {
            SetUpSalesDataGrid();
            SetUpExpensesDataGrid();
            
            // Set up indexes of the combo boxes
            cmbSalesFilter.SelectedIndex = 0;
            cmbExpensesFilter.SelectedIndex = 0;
        }

        private async void cmbSalesFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get filter from combo box
            var filter = cmbSalesFilter.SelectedItem.ToString();
            
            var sales = await _salesRepository.GetSalesByDateFilter(filter);
            
            // Clear the datagrid
            dtgSales.Rows.Clear();
            DisplaySales(sales);
        }

        private async void cmbExpensesFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get filter from combo box
            var filter = cmbExpensesFilter.SelectedItem.ToString();
            
            var expenses = await _expenseRepository.GetExpensesByDateFilter(filter);
            
            // Clear the datagrid
            dtgExpenses.Rows.Clear();
            DisplayExpenses(expenses);
        }
    
        // --------------------- Helper Functions ---------------------//

        private void SetUpSalesDataGrid()
        {
            // Set the column header style
            dtgSales.EnableHeadersVisualStyles = false;
            dtgSales.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            dtgSales.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Example Data: Add columns and rows for demonstration purposes
            dtgSales.Columns.Add("SaleId", "Sale Id");
            dtgSales.Columns.Add("CustomerId", "Customer Id");
            dtgSales.Columns.Add("Name", "Name");
            dtgSales.Columns.Add("Date", "Date");
            dtgSales.Columns.Add("PaymentStatus", "Payment Status");
            dtgSales.Columns.Add("TotalAmount", "Total Amount");
            // Add a scroll bar
            dtgSales.ScrollBars = ScrollBars.Both;
        }
    
        private async void DisplaySales(List<Sales> sales)
        {
            try
            {
                foreach (var sale in sales)
                {
                    var customer = await _customerRepository.GetCustomerByIdAsyncSP(sale.CustomerId);
                    var order = await _orderRepository.GetOrderByOrderIdAsyncSP(sale.OrderId);
                    
                    // Add data into the data grid
                    dtgSales.Rows.Add(sale.SaleId, sale.CustomerId, customer.Name, sale.Date.Date, order.PaymentStatus, sale.TotalAmount);
                }
            }
            catch (Exception e)
            {
                
            }
        }

        private void SetUpExpensesDataGrid()
        {
            // Set the column header style
            dtgExpenses.EnableHeadersVisualStyles = false;
            dtgExpenses.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            dtgExpenses.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Example Data: Add columns and rows for demonstration purposes
            dtgExpenses.Columns.Add("ExpenseId", "Expense Id");
            dtgExpenses.Columns.Add("Title", "Title");
            dtgExpenses.Columns.Add("Amount", "Amount");
            dtgExpenses.Columns.Add("Date", "Date");
            
            // Add a scroll bar
            dtgExpenses.ScrollBars = ScrollBars.Both;
        }
        
        private void DisplayExpenses(List<Expense> expenses)
        {
            try
            {
                foreach (var expense in expenses)
                {
                    // Add data into the data grid
                    dtgExpenses.Rows.Add(expense.ExpenseId, expense.Title, expense.Amount, expense.Date.Date);
                }
            }
            catch (Exception e)
            {
                
            }
        }


        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            AddExpensePage addExpensePage = new AddExpensePage();
            var result = addExpensePage.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Refresh the data grid
                cmbExpensesFilter_SelectedIndexChanged(sender, e);
            }
        }
    }
}
