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
    public partial class PaymentPage : Form
    {
        private Payment payment { get; set; }
        private Order Order { get; set; }
        private OrderRepository _orderRepository;
        private PaymentRepository _paymentRepository;
        private Panel _pnlMain;
        public PaymentPage(Order order, Panel panel)
        {
            InitializeComponent();
            Order = order;
            _orderRepository = new OrderRepository(Commons.ConnectionString);
            _paymentRepository = new PaymentRepository(Commons.ConnectionString);
            payment = new Payment();
            _pnlMain = panel;
        }
        
        // --------------------- Event Handlers ---------------------//
        
        private void txtPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (like Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
            // Calculate the balance
            txtChange.Text = $"{Order.TotalPrice - Convert.ToDecimal(txtPayment.Text)}";
        }
        
        private async void btnProcessPayment_Click(object sender, EventArgs e)
        {
            string paymentAmount = txtAmountToPay.Text;
            if (!string.IsNullOrEmpty(paymentAmount))
            {
                payment.AmountPaid = Convert.ToDecimal(paymentAmount);
                payment.OrderId = await _orderRepository.GetLatestAutoIncrementFromOrders();
                payment.PaymentDate = DateTime.Now;
                await _paymentRepository.AddPaymentAsyncSP(payment);
                DialogResult = DialogResult.OK;
                MessageBox.Show("Payment successfully recorded!");
                Dashboard2 dashboard2 = new Dashboard2();
                dashboard2.LoadLabels();
                LoadForm(new HomePage(_pnlMain));
                Close();
            } 
            else
            {
                MessageBox.Show("Field must not be empty!");
            }
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        
        private void PaymentPage_Load(object sender, EventArgs e)
        {
            DisplayAmountToPay();
        }
        
        
        // --------------------- Helper Functions ---------------------//
        
        private void LoadForm(object form)
        {
            if (_pnlMain.Controls.Count > 0)
                _pnlMain.Controls.RemoveAt(0);

            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            _pnlMain.Controls.Add(f);
            _pnlMain.Tag = f;
            f.Show();
        }
        
        private void DisplayAmountToPay() 
        {
            txtAmountToPay.Text = $"{Order.TotalPrice}";
        }
        
        public Payment GetPayment()
        {
            return payment;
        }
    }
}
