using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;
using static LINQ02.ListGenerator;
using static System.Net.Mime.MediaTypeNames;
namespace LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region LINQ - Element Operators
            #region 1. Get first Product out of Stock
            //var FirstProduct = ProductsList.First(P => P.UnitsInStock == 0);
            //Console.WriteLine(FirstProduct);
            #endregion

            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var res = ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(res);

            #endregion

            #region 3. Retrieve the second number greater than 5

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = Arr.Where(A => A > 5 && A != Arr.FirstOrDefault(A => A > 5)).FirstOrDefault();
            //Console.WriteLine(res);
            #endregion
            #endregion

            #region LINQ - Aggregate Operators
            #region 1. Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var GetCountOddNUm = Arr.Where(A => A % 2 == 1).Count();
            //Console.WriteLine(GetCountOddNUm);

            #endregion

            #region 2. Return a list of customers and how many orders each has.

            //var customerList = CustomersList.Select(C => new { C.CustomerID, orderNumbers = C.Orders.Count() });
            //foreach (var customer in customerList)
            //{
            //    Console.WriteLine(customer);
            //}
            #endregion

            #region 3. Return a list of categories and how many products each has

            //var categoryList = ProductsList.GroupBy(P => P.Category).Select(PG => new { PG.Key, productNumbers = PG.Count() });
            //foreach (var category in categoryList)
            //{
            //    Console.WriteLine(category);
            //}

            #endregion

            #region 4. Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var totalNumber = Arr.Sum();
            //Console.WriteLine(totalNumber);

            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt (Readdictionary_english.txt into Array of String First).

            string path = @"C:\Users\hp\source\repos\LINQ02\LINQ02\bin\Debug\net8.0\dictionary_english.txt";
            string[] lines = File.ReadAllLines(path);
            //var words = lines.Select(L => new { L, L.Length });
            //foreach (var item in words)Console.WriteLine(item);
            #endregion

            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First)

            //var shortWord = lines.Min(L => L.Length);
            //Console.WriteLine(shortWord);

            #endregion

            #region 7. Get the length of the longest word in dictionary_english.txt

            //var longWord = lines.Max(L => L.Length);
            //Console.WriteLine(longWord);

            #endregion

            #region 8. Get the average length of the words in dictionary_english.txt 
            //var avgWord = lines.Average(L => L.Length);
            //Console.WriteLine(avgWord);
            #endregion

            #region 9. Get the total units in stock for each product category
            //var totalUnitList = ProductsList.GroupBy(P => P.Category).Select(PG => new { PG.Key, unitsInStock = PG.Sum(p => p.UnitsInStock) });
            //foreach(var item in totalUnitList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 10. Get the cheapest price among each category's products
            //var cheapestPrice = ProductsList.GroupBy(C => C.Category).Select(PG => new { PG.Key, cheapest = PG.Min(P => P.UnitPrice) });
            //foreach(var price in cheapestPrice)
            //{
            //    Console.WriteLine(price);
            //}
            #endregion

            #region 11. Get the products with the cheapest price in each category (Use Let)

            //var cheapestPrice = from P in ProductsList
            //                    group P by P.Category 
            //                    into C
            //                    let CheapPrice = C.OrderBy(p => p.UnitPrice).FirstOrDefault()
            //                    select new { C.Key, CheapProduct = CheapPrice };

            //foreach(var price in cheapestPrice)
            //{
            //    Console.WriteLine(price);
            //}

            #endregion

            #region 12. Get the most expensive price among each category's products

            //var expensivePrice = ProductsList.GroupBy(P => P.Category).Select(PG => new { PG.Key, expensive = PG.Max(p => p.UnitPrice) });
            //foreach (var expensive in expensivePrice)
            //{
            //    Console.WriteLine(expensive);
            //}
            #endregion

            #region 13. Get the products with the most expensive price in each category.

            //var expensivePrice = from P in ProductsList
            //                     group P by P.Category
            //                     into E
            //                     let CheapPrice = E.OrderByDescending(p => p.UnitPrice).FirstOrDefault()
            //                     select new { E.Key, CheapProduct = CheapPrice };
            //foreach (var expensive in expensivePrice)
            //{
            //    Console.WriteLine(expensive);
            //}
            #endregion

            #region 14. Get the average price of each category's products.

            //var avgList = ProductsList.GroupBy(P => P.Category).Select(PG => new { PG.Key, average = PG.Average(p => p.UnitPrice) });
            //foreach ( var item in avgList )
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #endregion

            #region LINQ - Set Operators

            #region 1. Find the unique Category names from Product List

            //var uniqueCategory = ProductsList.DistinctBy(P=>P.Category).Select(p => p.Category);
            //foreach(var category in uniqueCategory)
            //{
            //    Console.WriteLine(category);
            //}

            #endregion

            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.

            var list1 = ProductsList.Select(P => P.ProductName.ToCharArray()[0]);
            var list2 = CustomersList.Select(C => C.CustomerID.ToCharArray()[0]);
            //var UniqueList = list1.Union(list2);
            //foreach (var item in UniqueList) 
            //{
            //    Console.WriteLine(item); 
            //}

            #endregion

            #region 3. Create one sequence that contains the common first letter from both product and customer names.
            //var CommonList = list1.Intersect(list2);
            //foreach (var item in CommonList) 
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var exceptList = list1.Except(list2);
            //foreach (var item in exceptList)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            //var list3 = ProductsList.Select(P => P.ProductName.Remove(0, P.ProductName.Length - 3));
            //var list4 = CustomersList.Select(C => C.CustomerName.Remove(0, C.CustomerID.Length - 3));
            //var dubList = list3.Concat(list4);
            //foreach (var item in dubList)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

            #region LINQ - Partitioning Operators

            #region 1. Get the first 3 orders from customers in Washington

            //var first3Orders = CustomersList.Where(C => C.Region == "WA").SelectMany(C => C.Orders).Take(3); ;
            //foreach (var order in first3Orders)
            //{
            //    Console.WriteLine(order);
            //}

            #endregion

            #region 2. Get all but the first 2 orders from customers in Washington.

            //var orders = CustomersList.Where(C => C.Region == "WA").SelectMany(C => C.Orders).Skip(2); ;
            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion

            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = numbers.TakeWhile((v, i) => v > i);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 4.Get the elements of the array starting from the first element divisible by 3.

            //var res = numbers.Where(i => i % 3 == 0 && i != 0);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 5. Get the elements of the array starting from the first element less than its position.

            //int[] nums = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = nums.SkipWhile((v, i) => v >= i);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion

            #region LINQ - Quantifiers

            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            //var words = lines.Any(l => l.Contains("ei"));
            //Console.WriteLine(words);

            #endregion

            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.

            //var groubProductList = ProductsList.GroupBy(p => p.Category).Where(PG => PG.Count(p => p.UnitsInStock == 0) > 0);
            //foreach (var item in groubProductList)
            //{
            //    Console.WriteLine(item);
            //    foreach (var prod in item)
            //        Console.WriteLine(prod);
            //}

            #endregion

            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.
            //var groubProductList = ProductsList.GroupBy(P => P.Category).Where(PG => PG.All(P => P.UnitsInStock > 0));

            //foreach (var item in groubProductList)
            //{
            //  Console.WriteLine(item);
            //  foreach (var prod in item)
            //      Console.WriteLine(prod);
            //}

            #endregion

            #endregion

            #region LINQ – Grouping Operators

            #region 1. Use group by to partition a list of numbers by their remainder when divided by 5

            //List<int> number = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var numberGroups = numbers.GroupBy(N => N % 5);
            //foreach (var item in numberGroups)
            //{
            //    Console.WriteLine($"Numbers with a remainder of {item.Key} when divided by 5:");
            //    foreach (var prod in item)
            //        Console.WriteLine(prod);
            //}
            #endregion

            #region 2. Uses group by to partition a list of words by their first letter. Use dictionary_english.txt for Input

            //var wordsGroup = lines.GroupBy(l => l[0]);
            // foreach (var item in wordsGroup)
            //{
            //    Console.WriteLine($"********{item.Key}******:");
            //    foreach (var prod in item)
            //        Console.WriteLine(prod);
            //}

            #endregion

            #endregion

        }
    }
}
