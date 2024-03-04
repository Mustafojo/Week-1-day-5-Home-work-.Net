namespace Infrastucture.Services;
using Infrastucture.DataContext;
using Domain.Models;
using Dapper;



public class StockService
{
    private readonly DapperContext _context;

    public StockService()
    {
        _context = new DapperContext();
    }

    public void AddStock(Stock stock)
    {
        var sql = "insert into Stock (name,address) values (@name,@address)";
        _context.Connection().Execute(sql , stock);
    }

    public StockProducts GetStockProductsById(int id)
    {
        var sql = @"select * from Stock where id = @id;
                    select * from Products where id = @id";
        
        using (var mul = _context.Connection().QueryMultiple(sql , new {Id = id}))
        {
            var stockproduct = new StockProducts();
            stockproduct.Stock = mul.ReadFirst<Stock>();
            stockproduct.ListProducts = mul.Read<Product>().ToList();
            return stockproduct;
        }
    }

    public List<StockProducts> GetStockByProducts()
    {
        var sql = "select id from stock";
        var list = _context.Connection().Query<int>(sql).ToList();
        var sql1 = @"select * from stock where id = @id
                     select * from products where id = @id";
        
        var stockproducts = new List<StockProducts>();
        foreach (var item in list)
        {
            using (var mult = _context.Connection().QueryMultiple(sql1 , new { Id = item}))
            {
                var stock = new StockProducts();
                stock.Stock = mult.ReadFirst<Stock>();
                stock.ListProducts = mult.Read<Product>().ToList();
                stockproducts.Add(stock);
            }
        }
        return stockproducts;
    }
    
    public string MovingProduct(MovingProduct movingProduct)
    {
        var sql = "select * from products where Name = @name and id = @id;";
        
        var fromStock = _context.Connection()
            .QueryFirstOrDefault<Product>(sql, new { Name = movingProduct.Name, StockId = movingProduct.FromStock });
        if (fromStock == null) return "Product not found.";
        if (fromStock.Count < movingProduct.Count)
        {
            return "Product kam ast";
        }

        fromStock.Count -= movingProduct.Count;
        var sql1 = "update products set count = @count where id = @id";
        _context.Connection().Execute(sql1, new { Id = fromStock.Id, Count = fromStock.Count });
        
        var sql2 = "select * from products where Name = @name and id = @id;";
        var toStock = _context.Connection()
            .QueryFirstOrDefault<Product>(sql2, new { Name = movingProduct.Name, Id = movingProduct.ToStock });
        if (toStock == null) return "Product not found.";

        toStock.Count += movingProduct.Count;
        var sql3 = "update products set quantity = @quantity where id_product = @id";
        _context.Connection().Execute(sql3, new { Id = toStock.Id, Quantity = toStock.Count  });

        var moving = new Moving()
        {
            FromStock = fromStock.StockId,
            ToStock = toStock.StockId,
            Quantity = movingProduct.Count,
            Id = 1,
            DateofMoving = DateTime.Now,
        };

        var sql5 = @"insert into moving (productid, FromStock, ToStock, Count, DataofMoving) values 
                    (@Productid, @fromStock, @toStock, @count, @DateofMoving)";
        _context.Connection().Execute(sql5, moving);
        
        return "Successfully";
    }
    
}