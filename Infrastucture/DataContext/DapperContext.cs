namespace Infrastucture.DataContext;
using Npgsql;
using NpgsqlTypes;

public class DapperContext
{
   private readonly string _connectionString ="Host=localhost;Port=5432;Database=SkladDb;User Id=postgres;Password=sabriddin2004;";

   public NpgsqlConnection Connection(){

     return new NpgsqlConnection(_connectionString);

   }

}
