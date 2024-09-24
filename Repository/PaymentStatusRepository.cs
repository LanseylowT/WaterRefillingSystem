using System.Collections.Generic;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WaterRefillingSystem.Models;

namespace WaterRefillingSystem.Repository
{
    // TODO: [DONE] Test CRUD Operations for Payment Status Repository
    public class PaymentStatusRepository : BaseRepository<PaymentStatus>
    {
        public PaymentStatusRepository(string connectionString) : base(connectionString) {}

        protected override async Task<PaymentStatus> MapReaderToEntityAsync(MySqlDataReader reader)
        {
            return await Task.Run(() => new PaymentStatus
            {
                StatusId = (int)reader["status_id"],
                StatusName = reader["status_name"].ToString(),
            });
        }

        // Using stored procedure for fetching all payment statuses
        public Task<List<PaymentStatus>> GetAllPaymentStatusesAsyncSP() =>
            GetAllWithParamsAsync("GetAllPaymentStatuses", new MySqlParameter[] { });



        // Using stored procedure for adding a payment status
        public Task AddPaymentStatusAsyncSP(PaymentStatus paymentStatus) =>
            AddWithParamsAsync("AddPaymentStatus", 
                new[]
                {
                    new MySqlParameter("p_status_name", paymentStatus.StatusName),
                });



        // Using stored procedure for updating a payment status
        public Task UpdatePaymentStatusAsyncSP(PaymentStatus paymentStatus) =>
            UpdateWithParamsAsync("UpdatePaymentStatus", 
                new[]
                {
                    new MySqlParameter("p_status_id", paymentStatus.StatusId),
                    new MySqlParameter("p_status_name", paymentStatus.StatusName),
                });



        // Using stored procedure for deleting a payment status
        public Task DeletePaymentStatusAsyncSP(int statusId) =>
            DeleteWithParamsAsync("DeletePaymentStatus", 
                new[]
                {
                    new MySqlParameter("p_status_id", statusId)
                });

 

        // Using stored procedure for fetching payment status by ID
        public Task<PaymentStatus> GetPaymentStatusByIdAsyncSP(int statusId) =>
            GetByIdWithParamsAsync("GetPaymentStatusById", 
                new[]
                {
                    new MySqlParameter("p_status_id", statusId)
                });
        
    }
}
