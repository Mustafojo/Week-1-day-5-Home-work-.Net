namespace Infrastucture.Services;

using Dapper;

using DataContext;
using Domain.Models;

public class PeremeshenieService
{

    
     private readonly DapperContext _context;

     public PeremeshenieService()
     {
        _context=new DapperContext();
     }

     public List<Peremeshenie> GetPeremesheniesbyTime(DateTime date)
     {
       var sql =" select * from Peremeshenie where data_peremeshenie >' @date'";


        return _context.Connection().Query<Peremeshenie>(sql,new{Date=date}).ToList();
     }
     

     

   







}
