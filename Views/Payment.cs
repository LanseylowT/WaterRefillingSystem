using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterRefillingSystem.Views
{
    public partial class Payment : Form
    {

        public Payment payment { get; set; }

        public Payment()
        {
            InitializeComponent();
        }


        private void DisplayAmountToPay() {

        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
            // Calculate the balance

        }

        private void btnProcessPayment_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.Cancel;
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
    }
}
