using System.Collections.Generic;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WaterRefillingSystem.Models;

// TODO: [DONE] Test Table Lookup Operations for ServiceOption
namespace WaterRefillingSystem.Repository
{
    public class ServiceOptionRepository : BaseRepository<ServiceOption>
    {
        public ServiceOptionRepository(string connectionString) : base(connectionString) {}

        protected override async Task<ServiceOption> MapReaderToEntityAsync(MySqlDataReader reader)
        {
            return await Task.Run(() => new ServiceOption
            {
                ServiceId = (int)reader["service_id"],
                ServiceName = reader["service_name"].ToString(),
            });
        }

        // Using stored procedure for fetching all service options
        public Task<List<ServiceOption>> GetAllServiceOptionsAsyncSP() =>
            GetAllWithParamsAsync("GetAllServiceOptions", new MySqlParameter[] { });



        // Using stored procedure for adding a new service option
        public Task AddServiceOptionAsyncSP(ServiceOption serviceOption) =>
            AddWithParamsAsync("AddServiceOption",
                new[]
                {
                    new MySqlParameter("p_service_name", serviceOption.ServiceName),
                });



        // Using stored procedure for updating an existing service option
        public Task UpdateServiceOptionAsyncSP(ServiceOption serviceOption) =>
            UpdateWithParamsAsync("UpdateServiceOption",
                new[]
                {
                    new MySqlParameter("p_service_id", serviceOption.ServiceId),
                    new MySqlParameter("p_service_name", serviceOption.ServiceName),
                });



        // Using stored procedure for deleting a service option
        public Task DeleteServiceOptionAsyncSP(int serviceId) =>
            DeleteWithParamsAsync("DeleteServiceOption",
                new[]
                {
                    new MySqlParameter("p_service_id", serviceId)
                });



        // Using stored procedure for fetching a service option by ID
        public Task<ServiceOption> GetServiceOptionByIdAsyncSP(int serviceId) =>
            GetByIdWithParamsAsync("GetServiceOptionById",
                new[]
                {
                    new MySqlParameter("p_service_id", serviceId)
                });
    }
}