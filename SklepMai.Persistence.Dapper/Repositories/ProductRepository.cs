using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SklepMai.Domain.Models;
using SklepMai.Domain.Repositories;
using SklepMai.Persistence.Dapper.Configurations;
using Dapper;

namespace SklepMai.Persistence.Dapper.Repositories
{
    public class ProductRepository : IProductRepository
    {
        IConnectionStringBuilder _connectionStringBuilder;

        public ProductRepository(IConnectionStringBuilder connectionStringBuilder)
        {
            _connectionStringBuilder = connectionStringBuilder;
        }

        public async Task<int> AddItem(ProductDto item)
        {
            string commandName = "Products_create_product";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@name", item.Name);
            parameters.Add("@description", item.Description);
            parameters.Add("@price", item.Price);
            parameters.Add("@image_url", item.ImageUrl);
            parameters.Add("@create_by", item.CreatedBy);
            parameters.Add("@new_id", -1);

            using (SqlConnection connection = new SqlConnection(_connectionStringBuilder.GetConnectionString))
            {
                await connection.OpenAsync();

                await connection.ExecuteAsync(commandName, parameters, commandType: System.Data.CommandType.StoredProcedure);

                return parameters.Get<int>("@new_id");
            }
        }

        public async Task<bool> DeleteItem(int id)
        {
            string commandName = "Products_delete_product";

            using (SqlConnection connection = new SqlConnection(_connectionStringBuilder.GetConnectionString))
            {
                await connection.OpenAsync();

                var result = await connection.ExecuteAsync(commandName, new { id = id }, commandType: System.Data.CommandType.StoredProcedure);

                return result > 0;
            }
        }

        public async Task<IEnumerable<ProductDto>> GetAllItems()
        {
            string commandName = "Products_get_all";

            using (SqlConnection connection = new SqlConnection(_connectionStringBuilder.GetConnectionString))
            {
                await connection.OpenAsync();

                return await connection.QueryAsync<ProductDto>(commandName, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public async Task<ProductDto> GetItemById(int id)
        {
            string commandName = "Products_get_product_by_id";

            using (SqlConnection connection = new SqlConnection(_connectionStringBuilder.GetConnectionString))
            {
                await connection.OpenAsync();

                return await connection.QueryFirstOrDefaultAsync<ProductDto>(commandName, new { id = id}, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public async Task<bool> IsProductNameAlreadyExist(string productName)
        {
            string commandName = "Product_is_name_already_exist";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@name", productName);

            using (SqlConnection connection = new SqlConnection(_connectionStringBuilder.GetConnectionString))
            {
                await connection.OpenAsync();

                return await connection.QueryFirstOrDefaultAsync<ProductDto>(commandName, parameters, commandType: System.Data.CommandType.StoredProcedure) != null;
            }
        }

        public async Task<bool> UpdateItem(ProductDto item)
        {
            string commandName = "Products_update_product";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@id", item.Id);
            parameters.Add("@name", item.Name);
            parameters.Add("@description", item.Description);
            parameters.Add("@price", item.Price);
            parameters.Add("@image_url", item.ImageUrl);
            parameters.Add("@last_update_by", item.LastUpdatedBy);

            using (SqlConnection connection = new SqlConnection(_connectionStringBuilder.GetConnectionString))
            {
                await connection.OpenAsync();

                var result = await connection.ExecuteAsync(commandName, parameters, commandType: System.Data.CommandType.StoredProcedure);

                return result > 0;
            }
        }
    }
}