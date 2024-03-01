namespace Infrastucture.Services;
using Infrastucture.DataContext;
using Domain.Models;
using Dapper;

public class SkladService
{

        private readonly DapperContext _context;

     public SkladService()
     {
        _context=new DapperContext();

     }
     
     public void AddSklad(Sklad sklad) 
     {
        var sql="insert into Sklad (name,address) values(@name,@address)";
        _context.Connection().Execute(sql,sklad);
         
     }


      public SkladProducts GetSkladProducts(int id)
    {
      {

        var sql = @"
               select * from Sklad where id_sklad=@id;
               select * from Products where id_sklad = @id;
                ";

        using (var multiple = _context.Connection().QueryMultiple(sql, new { Id = id }))
        {

            var skladProducts = new SkladProducts();
            skladProducts.Sklad = multiple.ReadFirst<Sklad>();
            skladProducts.ListProducts = multiple.Read<Product>().ToList();
            return skladProducts;

        }
      }  
    }




}
