namespace Linq_Assignment_2
{
    public class Program
    {
        static void Main()
        {
            #region Question01
            var result01 = Sourse.ProductList
                .OrderByDescending(s => s.UnitPrice)
                .Take(3);
            foreach (var item in result01)
            {
                Console.WriteLine(item);
            }
            #endregion


            #region Question02
            var pages = Sourse.ProductList
                .Skip(5)
                .Take(5);
            foreach (var item in pages)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Question03
            var result02 = Sourse.ProductList
                .OrderBy(s => s.UnitPrice)
                .Where(s => s.UnitPrice < 25);
            foreach (var item in result02)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Question04
            var result04 = Sourse.ProductList
                .Where(s => s.UnitsInStock > 0)
                .Select(s => s.Category == "Seafood");
            foreach (var item in result04)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Question05
            int[] ids = { 3, 9, 13, 18 };
            bool result05 = ids.Contains(9);
            Console.WriteLine(result05);
            #endregion

            #region Question06
            var result06 = Sourse.ProductList
                .GroupBy(s => s.Category);
            foreach (var item in result06)
            {
                Console.WriteLine($"item {item} - Count {item.Count()}");
            }
            #endregion

            #region Question07
            var result07 = Sourse.ProductList
                .GroupBy(s => s.Category);
            foreach (var item in result07)
            {
                Console.WriteLine($"item {item}");

                foreach (var item_ in item.Select(s => s.ProductName))
                {
                    Console.WriteLine($"NAMES {item_}");
                }
            }
            #endregion

            #region Question08
            var result08 = Sourse.ProductList
                .GroupBy(s => s.Category)
                .Where(s => s.Count() > 3)
                .Select(s => s.Key);
            foreach (var item in result08)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Question09
            var result09 = from c in Sourse.CustomerList
                           group c by c.Country into g
                           select new
                           {
                               Country = g.Key,
                               Count = g.Count(),
                               TotalOrderValue = g.SelectMany(c => c.Orders).Sum(o => o.Total)
                           };
            foreach (var item in result09)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Question10
            var result10 = Sourse.ProductList
                .Sum(s => s.UnitsInStock);
            Console.WriteLine(result10);
            #endregion

            #region Question11
            var cheapest = Sourse.ProductList.Min(s => s.UnitPrice);
            var mostExpensive = Sourse.ProductList.Max(s => s.UnitPrice);
            Console.WriteLine($"Cheapest: {cheapest}, Expensive: {mostExpensive}");
            #endregion

            #region Question12
            var result12 = Sourse.ProductList
                .Select(s => s.Category)
                .Distinct();
            foreach (var item in result12)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Question13
            int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            int[] setB = { 3, 6, 9, 12, 15, 13 };
            var result13 = setA.Except(setB);
            foreach (var item in result13)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Question14
            string[] list1 = { "Germany", "France", "UK", "Spain" };
            string[] list2 = { "france", "SPAIN", "Italy" };
            var result14 = list1.Except(list2, StringComparer.Ordinal);
            foreach (var item in result14)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Question15
            var dict15 = Sourse.ProductList
                .ToDictionary(s => s.ProductID);
            Console.WriteLine(dict15[18]);
            #endregion

            #region Question16
            var result16 = Sourse.ProductList
                .First(s => s.UnitPrice > 50);
            Console.WriteLine(result16);
            #endregion

            #region Question17
            var result17 = Sourse.ProductList
                .FirstOrDefault(s => s.UnitPrice > 500);
            Console.WriteLine(result17);
            #endregion

            #region Question18
            var result18 = Enumerable.Range(1, 12)
                .Select(i => $"7 x {i} = {7 * i}");
            foreach (var item in result18)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Question19
            var result19 = Enumerable.Range(1, 30)
                .Where(n => n % 2 == 0);
            foreach (var item in result19)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Question20
            var first3Products = Sourse.ProductList
                .Take(3)
                .Select(s => s.ProductName);
            var first3Customers = Sourse.CustomerList
                .Take(3)
                .Select(c => c.CustomerName);
            var result20 = first3Products.Concat(first3Customers);
            foreach (var item in result20)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Question21
            var result21 = Sourse.ProductList
                .Zip(Sourse.CustomerList, (p, c) => $"{p.ProductName} sold to {c.CustomerName}");
            foreach (var item in result21)
            {
                Console.WriteLine(item);
            }
            #endregion












        }
    }
}