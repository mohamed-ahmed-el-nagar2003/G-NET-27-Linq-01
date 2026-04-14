using System.Collections;

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

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
