namespace Infrastucture.Services;

using Dapper;
using Domain.Models;
using Infrastucture.DataContext;

public class ProductService
{
    private readonly DapperContext _context;

    public ProductService()
    {
        _context = new DapperContext();
    }
    
    public void AddProducts(Product product)
    {
        var sql = "insert into Products (name,count,stockid) values (@name,@count,@stockid)";
        _context.Connection().Execute(sql,product);
    }
}