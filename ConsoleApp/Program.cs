
using Domain.Models;
using Infrastucture.Services;

var stockService = new StockService();
var productService = new ProductService();

var stock = new Stock() { Name = "Stock 2", Address = "33 mkr" };
stockService.AddStock(stock);
productService.AddProducts(new Product() { Name = "Banana", Count = 100, Id = 1 });
productService.AddProducts(new Product() { Name = "Milk", Count = 123, Id = 2 });
productService.AddProducts(new Product() { Name = "Cake", Count = 235, Id = 1 });
productService.AddProducts(new Product() { Name = "Apple", Count = 43, Id = 2 });
productService.AddProducts(new Product() { Name = "Kiwi", Count = 53, Id = 2 });
productService.AddProducts(new Product() { Name = "Orange", Count = 76, Id = 1 });


var stockProducts = stockService.GetStockProductsById(2);

var stockProduct = stockService.GetStockByProducts();




