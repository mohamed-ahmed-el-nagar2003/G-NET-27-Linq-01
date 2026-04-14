using System.Collections;
using System.Diagnostics;
using System.Threading;
using System.Xml.Linq;

namespace linq_01

{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q_01
            //1. Get all products from the "Seafood" category. Print eachproduct's name and price.
            // var result = Source.ProductList.Where(p => p.Category == "Seafood").Select(p => $"Product Name :{p.ProductName}  Price :{p.UnitPrice}");
            #endregion

            #region Q_02
            //Get a list of only the product names from ProductList. Printeach name.
            // var result = Source.ProductList.Select(p => p.ProductName  );

            #endregion

            #region Q_03
            //Sort all products by UnitPrice (ascending). Print each product's name and price.
            //var result = Source.ProductList.OrderBy(p => p.UnitPrice).Select(p => new {p.ProductName , p.UnitPrice});
            #endregion

            #region Q_04
            //4. Get all products where UnitPrice is between 10 and 30
            // var result = Source.ProductList.Where(p => p.UnitPrice > 10 && p.UnitPrice < 30);

            #endregion

            #region Q_05
            //5. Get all products that are in stock (UnitsInStock > 0) and belong to the "Condiments" category.
            // var result = Source.ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");
            #endregion

            #region Q_06
            //            6.Create a new anonymous type with three properties:
            //            ● Name → the product name
            //            ● Price → the unit price
            //            ● StockStatus → a string: "Available" if UnitsInStock > 0,
            //             otherwise "Out of Stock"
            //            ● Print the result.

            //var result = Source.ProductList.Select(p => new
            //{
            //    Name = p.ProductName,
            //    Price = p.UnitPrice,
            //    StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //}
            //);
            #endregion

            #region Q_07
            //7. Print each product's name along with its position (1-based) in the list. Expected format: 1.Chai, 2.Chang, etc.
            //var result = Source.ProductList.Select((p , pi) => $"{pi+1}.{p.ProductName}");
            #endregion

            #region Q_08
            // 8.Sort ProductList by Category ascending, then within each category, sort by UnitPrice descending.
            //var result = Source.ProductList
            //.OrderBy(p => p.Category)
            //.ThenByDescending(p => p.UnitPrice);
            #endregion

            #region Q_09
            //Get all products from the "Beverages" category, sorted by UnitsInStock descending. Print name and stock.
           // var result = Source.ProductList.Where(p => p.Category == "Beverages").OrderByDescending(p => p.UnitsInStock).Select(p => new {p.ProductName , p.UnitsInStock});
            #endregion

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
