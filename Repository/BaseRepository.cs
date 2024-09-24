using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WaterRefillingSystem.Models;

namespace WaterRefillingSystem.Repository
{
    public abstract class BaseRepository<T>
    {
        protected readonly string _connectionString;

        protected BaseRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Existing method for queries without parameters
        public async Task<List<T>> GetAllAsync(string query)
        {
            var entities = new List<T>();

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                await conn.OpenAsync();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            entities.Add( await MapReaderToEntityAsync(reader));
                        }
                    }
                }
            }

            return entities;
        }
        
        
        // New method for stored procedures with parameters
        public async Task<List<T>> GetAllWithParamsAsync(string procedureName, MySqlParameter[] parameters)
        {
            var entities = new List<T>();

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                await conn.OpenAsync();

                using (MySqlCommand cmd = new MySqlCommand(procedureName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure; // Mark as stored procedure
                    cmd.Parameters.AddRange(parameters);

                    using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            entities.Add(await MapReaderToEntityAsync(reader));
                        }
                    }
                }
            }

            return entities;
        }


        // Existing AddAsync method
        public async Task AddAsync(string query, MySqlParameter[] parameters)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
        
        
        // New method for adding with stored procedure
        public async Task AddWithParamsAsync(string procedureName, MySqlParameter[] parameters)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                using (MySqlCommand cmd = new MySqlCommand(procedureName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure; // Mark as stored procedure
                    cmd.Parameters.AddRange(parameters);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }


        // Existing UpdateAsync method
        public async Task UpdateAsync(string query, MySqlParameter[] parameters)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
        
        
        // New method for updating with stored procedure
        public async Task UpdateWithParamsAsync(string procedureName, MySqlParameter[] parameters)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                using (MySqlCommand cmd = new MySqlCommand(procedureName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure; // Mark as stored procedure
                    cmd.Parameters.AddRange(parameters);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
        
        
        // Existing DeleteAsync method
        public async Task DeleteAsync(string query, MySqlParameter[] parameters)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
        
        // New method for deleting with stored procedure
        public async Task DeleteWithParamsAsync(string procedureName, MySqlParameter[] parameters)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                using (MySqlCommand cmd = new MySqlCommand(procedureName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure; // Mark as stored procedure
                    cmd.Parameters.AddRange(parameters);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<T> GetByIdAsync(string query, MySqlParameter[] parameters)
        {
            T entity = default(T);

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            entity = await MapReaderToEntityAsync(reader);
                        }
                    }
                }
            }

            return entity;
        }
        
        // New method for fetching by ID with stored procedure
        public async Task<T> GetByIdWithParamsAsync(string procedureName, MySqlParameter[] parameters)
        {
            T entity = default(T);

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                using (MySqlCommand cmd = new MySqlCommand(procedureName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure; // Mark as stored procedure
                    cmd.Parameters.AddRange(parameters);
                    using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            entity = await MapReaderToEntityAsync(reader);
                        }
                    }
                }
            }

            return entity;
        }
        
        protected abstract Task<T> MapReaderToEntityAsync(MySqlDataReader reader);
    }
    
}