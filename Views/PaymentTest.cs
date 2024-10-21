using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterRefillingSystem.Models;
using System.Windows.Forms;
using WaterRefillingSystem.Repository;
using WaterRefillingSystem.Data;

namespace WaterRefillingSystem.Views
{
    public partial class PaymentTest : Form
    {

        private Payment payment { get; set; }
        private Order Order { get; set; }
        private OrderRepository _orderRepository;
        private PaymentRepository _paymentRepository;

        public PaymentTest(Order order)
        {
            InitializeComponent();
            Order = order;
            _orderRepository = new OrderRepository(Commons.ConnectionString);
            _paymentRepository = new PaymentRepository(Commons.ConnectionString);
            payment = new Payment();
        }


        private void DisplayAmountToPay() 
        {
            txtAmountToPay.Text = $"{Order.TotalPrice}";
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
                MessageBox.Show("Payment successfully recorded! And latest auto increment ID: " + payment.OrderId);
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

        private void Payment_Load(object sender, EventArgs e)
        {
            DisplayAmountToPay();
        }

        private void txtPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (like Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public Payment GetPayment()
        {
            return payment;
        }
    }
}
