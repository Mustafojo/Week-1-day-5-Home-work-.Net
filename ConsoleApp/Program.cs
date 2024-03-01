
using Infrastucture.Services;
using Domain.Models;

/*
var sklad2=new Sklad();
sklad2.Name="Skladi 2";
sklad2.Address="46";

var SkladService1=new SkladService();
SkladService1.AddSklad(sklad2);
System.Console.WriteLine("Uspeshno");
*/
/*
var product1=new Product();
product1.Name="VELIk";
product1.Quantity=10;
product1.Id_Sklad=1;

ProductService ProductService1=new ProductService();
ProductService1.AddProducts(product1);
*/


/*
var SkladService1=new SkladService();

System.Console.WriteLine(SkladService1.GetSkladProducts(1).Sklad.Name);
System.Console.WriteLine(SkladService1.GetSkladProducts(1).Sklad.Address);

System.Console.WriteLine("---------------------------------------------------------");
System.Console.WriteLine("---------------------------------------------------------");

foreach (var item in SkladService1.GetSkladProducts(1).ListProducts)
{
    
    System.Console.WriteLine(item.Name);
    System.Console.WriteLine(item.Quantity);
   System.Console.WriteLine("---------------------------------------------------------");
   
}
System.Console.WriteLine("---------------------------------------------------------");
System.Console.WriteLine("---------------------------------------------------------");
*/
/*
var PeremeshenieService1=new PeremeshenieService();
 var t= DateTime.Parse("2023:10:28");

foreach (var item in PeremeshenieService1.GetPeremesheniesbyTime(t))
{
    System.Console.WriteLine($"Id_Peremeshenie : {item.Id_Peremeshenie}"); 
    System.Console.WriteLine($"Id_Product : {item.Id_Product}"); 
    System.Console.WriteLine($"Id_IzSklada : {item.IzSklada}"); 
    System.Console.WriteLine($"Id_NaSklad : {item.NaSklad}"); 
    System.Console.WriteLine($"Quantity : {item.Quantity}"); 
    System.Console.WriteLine($"Data_Peremeshenie : {item.Data_Peremeshenie}");
    System.Console.WriteLine("-------------------------------------------------------------------");
}

*/


