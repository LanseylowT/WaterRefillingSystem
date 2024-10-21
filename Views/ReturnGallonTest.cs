using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WaterRefillingSystem.Data;
using WaterRefillingSystem.Models;
using WaterRefillingSystem.Repository;

namespace WaterRefillingSystem.Views
{
    public partial class ReturnGallonTest : Form
    {
        private Customer Customer { get; set; }
        private Order Order { get; set; }
        private readonly CustomerRepository _customerRepository;
        public ReturnGallonTest(Order order)
        {
            InitializeComponent();
            _customerRepository = new CustomerRepository(Commons.ConnectionString);
            Order = order;
        }

        private void LoadData()
        {
            cmbBorrowedContainer.Items.Clear();
            if (Customer != null)
            {
                txtItemType.Text = Order.ItemId == 1 ? "Slim Container" : "Round Container";
                for (int i = 1; i <= Order.BorrowedGallons; i++)
                {
                    cmbBorrowedContainer.Items.Add(i);
                }

                // Optionally, set the first item as the selected value
                if (cmbBorrowedContainer.Items.Count > 0)
                {
                    cmbBorrowedContainer.SelectedIndex = 0;
                }
            }
        }

        private async void ReturnGallonTest_Load(object sender, System.EventArgs e)
        {
            Customer = await _customerRepository.GetCustomerByIdAsyncSP(Order.CustomerId);
        }

        private void btnReturn_Click(object sender, System.EventArgs e)
        {

        }
    }
}