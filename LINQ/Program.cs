using LINQ.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using static LINQ.DataSources.Source;
namespace LINQ
{
	public class Program
	{
		static void Main(string[] args)
		{

			////	Q1
			//var SeafoodProducts = ProductList
			//	.Where(p => p.Category == "Seafood");
			//foreach (var p in SeafoodProducts)
			//{
			//	Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
			//}

			////Q2 
			//var ProductName = ProductList
			//	.Select(p => p.ProductName);
			//foreach (var p in ProductName)
			//{
			//	Console.WriteLine($"{p}");
			//}

			////Q3
			//var SortedProducts = ProductList
			//	.OrderBy(p => p.UnitPrice);
			//foreach (var P in SortedProducts)
			//{
			//	Console	.WriteLine($"{P.ProductName}-{P.UnitPrice}");
			//}

			////Q 4. Get all products where UnitPrice is between 10 and 30
			//var Between10and30 = ProductList
			//	.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
			//foreach (var p in Between10and30) 
			//{ 
			//    Console.WriteLine($"{p.UnitPrice}");
			//}

			////Q5 5. Get all products that are in stock (UnitsInStock > 0) and belong to the "Condiments" category.
			//var InStock = ProductList
			//	.Where(p => p.UnitsInStock>0 && p.Category == "Condiments");
			//foreach(var p in InStock)
			//{
			//	Console.WriteLine($"{p.UnitsInStock}-{p.ProductName}");
			//}


			////Q6 6. Create a new anonymous type with three properties:
			////● Name → the product name
			////● Price → the unit price
			////● StockStatus → a string: "Available" if UnitsInStock > 0,otherwise "Out of Stock"
			////● Print the result.

			//var Product = ProductList
			//	.Select(p => new
			//	{
			//		Name = p.ProductName,
			//		Price = p.UnitPrice,
			//		StockStatus= p.UnitsInStock > 0
			//		? "Available"
			//		: "Out of Stock"
			//	}
			//	);
			//foreach ( var p in Product )
			//{
			//	Console	.WriteLine($"{p.Name} - {p.Price} - {p.StockStatus}");
			//}








		}
	}
}
