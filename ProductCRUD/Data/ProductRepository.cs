
using Dapper;
using ProductCRUD.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

public class ProductRepository
{
    private readonly string _connectionString;

    public ProductRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public IEnumerable<Product> GetAllProducts()
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            return connection.Query<Product>("SELECT * FROM Products");
        }
    }

    public void AddProduct(Product product)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            connection.Execute("INSERT INTO Products (Name, Price) VALUES (@Name, @Price)", product);
        }
    }

    // Implement methods for updating and deleting products similarly
}


