namespace Infrastucture.DataContext;
using Npgsql;
using NpgsqlTypes;

public class DapperContext
{
   private readonly string _connectionString ="Host=localhost;Port=5432;Database=EducationDb;User Id = postgres;Password=2007;";

   public NpgsqlConnection Connection()
   {
      return new NpgsqlConnection(_connectionString);
   }

}
