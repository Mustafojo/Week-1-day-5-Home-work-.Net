namespace Infrastucture.Services;

using Dapper;

using DataContext;
using Domain.Models;

public class MovingService
{

    
     private readonly DapperContext _context;

     public MovingService()
     {
        _context = new DapperContext();
     }
     
     public List<Moving> GetPeremesheniesbyTime(DateTime date)
     {
       var sql =" select * from Moving where data_peremeshenie >' @date'";


        return _context.Connection().Query<Moving>(sql,new{Date=date}).ToList();
     }
     

     

   







}
