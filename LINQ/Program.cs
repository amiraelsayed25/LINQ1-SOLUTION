using static LINQ.DataSources.Source;
using LINQ.Models;
using System;
using System.Linq;
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








		}
	}
}
