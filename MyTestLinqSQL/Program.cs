using System.Xml.Linq;

namespace MyTestLinqSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinqSamples samples = new LinqSamples();
            samples.Linq1();
            //samples.Linq2();
            //samples.Linq3();
            //samples.Linq4();
            //samples.Linq21();
            //samples.Linq23();
            //samples.Linq28();
            //samples.Linq29();
            //samples.Linq30();
            //samples.Linq32();
            //samples.Linq33();
            //samples.Linq35();
            //samples.Linq36();
            //samples.Linq37();
            //samples.Linq39();
            //samples.Linq54();
            //samples.Linq55();
            //samples.Linq58();
            //samples.Linq64();
            //samples.Linq65();
            //samples.Linq69();
            //samples.Linq72();
            //samples.Linq76();
            //samples.Linq77();
            //samples.Linq80();
            //samples.Linq83();
            //samples.Linq84();
            //samples.Linq87();
            //samples.Linq88();
            //samples.Linq91();
            //samples.Linq93();
            //samples.Linq95();
            //samples.Linq99();
            //samples.Linq100();
            //samples.Linq101();
            //samples.Linq102();
            //samples.Linq103();
            //samples.Linq104();
            //samples.Linq105();
            //samples.Linq106();
            //samples.Linq107();
        }
    }

    public class LinqSamples
    {
        // RestrictionOperators - where
        public void Linq1()
        {
            Console.WriteLine("Linq1");
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // where < 5
            var lowNums = numbers;
            //

            foreach (var num in lowNums)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // RestrictionOperators - where
        public void Linq2()
        {
            Console.WriteLine("Linq2");
            List<Product> products = GetProductList();

            // where prod.UnitsInStock == 0
            var soldOutProducts = products;                
            //

            Console.WriteLine("Sold out products:");
            foreach (var product in soldOutProducts)
            {
                Console.WriteLine("{0} is sold out!", product.ProductName);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // RestrictionOperators - where
        public void Linq3()
        {
            Console.WriteLine("Linq3");
            List<Product> products = GetProductList();

            // where prod.UnitsInStock > 0 && prod.UnitPrice > 3.00M
            var expensiveInStockProducts = 
                products
                ;
            //

            Console.WriteLine("In-stock products that cost more than 3.00:");
            foreach (var product in expensiveInStockProducts)
            {
                Console.WriteLine("{0} is in stock and costs more than 3.00.", product.ProductName);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // RestrictionOperators - where
        public void Linq4()
        {
            Console.WriteLine("Linq4");
            List<Customer> customers = GetCustomerList();

            // where cust.Region == "WA"
            var waCustomers = 
                customers
                
                ;
            //

            Console.WriteLine("Customers from Washington and their orders:");
            foreach (var customer in waCustomers)
            {
                Console.WriteLine("Customer {0}: {1}", customer.CustomerID, customer.CompanyName);
                foreach (var order in customer.Orders)
                {
                    Console.WriteLine("  Order {0}: {1}", order.OrderID, order.OrderDate);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // PartitioningOperators - take
        public void Linq21()
        {
            Console.WriteLine("Linq21");
            List<Customer> customers = GetCustomerList();

            // where  cust.Region == "WA"
            // select new { cust.CustomerID, order.OrderID, order.OrderDate }
            // take 3
            var first3WAOrders = (
                customers
                );
            //

            Console.WriteLine("First 3 orders in WA:");
            foreach (var order in first3WAOrders)
            {
                ObjectDumper.Write(order);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // PartitioningOperators - skip
        public void Linq23()
        {
            Console.WriteLine("Linq23");
            List<Customer> customers = GetCustomerList();

            // where cust.Region == "WA"
            // select new { cust.CustomerID, order.OrderID, order.OrderDate }
            // skip
            var waOrders = 
                 customers
               
                ;

            var allButFirst2Orders = waOrders.Skip(2); 
            //

            Console.WriteLine("All but first 2 orders in WA:");
            foreach (var order in allButFirst2Orders)
            {
                ObjectDumper.Write(order);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // OrderingOperators - orderby
        public void Linq28()
        {
            Console.WriteLine("Linq28");
            string[] words = { "cherry", "apple", "blueberry" };

            // orderby
            var sortedWords = 
                words
                ;
            //

            Console.WriteLine("The sorted list of words:");
            foreach (var w in sortedWords)
            {
                Console.WriteLine(w);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // OrderingOperators - orderby 
        public void Linq29()
        {
            Console.WriteLine("Linq29");
            string[] words = { "cherry", "apple", "blueberry" };

            // orderby length
            var sortedWords = 
                  words
                ;
            //

            Console.WriteLine("The sorted list of words (by length):");
            foreach (var w in sortedWords)
            {
                Console.WriteLine(w);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // OrderingOperators - orderby
        public void Linq30()
        {
            Console.WriteLine("Linq30");
            List<Product> products = GetProductList();

            // orderby
            var sortedProducts =
                 products
                ;
            //

            ObjectDumper.Write(sortedProducts);
            Console.WriteLine();
            Console.WriteLine();
        }
        // OrderingOperators - orderby descending
        public void Linq32()
        {
            Console.WriteLine("Linq32");
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            // orderby descending
            var sortedDoubles =
                 doubles

                ;
            //

            Console.WriteLine("The doubles from highest to lowest:");
            foreach (var d in sortedDoubles)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // OrderingOperators - orderby descending
        public void Linq33()
        {
            Console.WriteLine("Linq33");
            List<Product> products = GetProductList();

            // orderby descending prod.UnitsInStock
            var sortedProducts =
                products
               ;
            //

            ObjectDumper.Write(sortedProducts);
            Console.WriteLine();
            Console.WriteLine();
        }
        // OrderingOperators - orderby length digit
        public void Linq35()
        {
            Console.WriteLine("Linq35");
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            // orderby length digit
            var sortedDigits = 
               digits
              
               ;
            //

            Console.WriteLine("Sorted digits:");
            foreach (var d in sortedDigits)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // OrderingOperators - OrderBy ThenBy
        public void Linq36()
        {
            Console.WriteLine("Linq36");
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var sortedWords =
                words.OrderBy(a => a.Length)
                     .ThenBy(a => a, new CaseInsensitiveComparer());

            // Another way. TODO is this use of ThenBy correct? It seems to work on this sample array.
            // OrderBy ThenBy
            var sortedWords2 =
                 words
                ;

            var sortedWords3 = sortedWords2;
            //

            ObjectDumper.Write(sortedWords);

            ObjectDumper.Write(sortedWords3);
            Console.WriteLine();
            Console.WriteLine();
        }
        // OrderingOperators - orderby descending
        public void Linq37()
        {
            Console.WriteLine("Linq37");
            List<Product> products = GetProductList();

            // orderby descending
            var sortedProducts =
                products
               ;
            //

            ObjectDumper.Write(sortedProducts);
            Console.WriteLine();
            Console.WriteLine();
        }
        // OrderingOperators - where reverse
        public void Linq39()
        {
            Console.WriteLine("Linq39");
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            // where reverse
            var reversedIDigits = 
                 digits
                ;
            //

            Console.WriteLine("A backwards list of the digits with a second character of 'i':");
            foreach (var d in reversedIDigits)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // ConversionOperators - orderby descending toarray 
        public void Linq54()
        {
            Console.WriteLine("Linq54");
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            // orderby descending toarray 
            var sortedDoubles = 
                 doubles
                ;
                
            var doublesArray = sortedDoubles;
            //

            Console.WriteLine("Every other double from highest to lowest:");
            for (int d = 0; d < doublesArray.Length; d += 2)
            {
                Console.WriteLine(doublesArray[d]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // ConversionOperators - orderby tolist
        public void Linq55()
        {
            Console.WriteLine("Linq55");
            string[] words = { "cherry", "apple", "blueberry" };

            // orderby tolist
            var sortedWords =
                 words
                ;
            var wordList = sortedWords;
            //

            Console.WriteLine("The sorted word list:");
            foreach (var w in wordList)
            {
                Console.WriteLine(w);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // ElementOperators - where first
        public void Linq58()
        {
            Console.WriteLine("Linq58");
            List<Product> products = GetProductList();

            // where first
            Product product12 = products        [0];

            //

            ObjectDumper.Write(product12);
            Console.WriteLine();
            Console.WriteLine();
        }
        // ElementOperators - where elementAt
        public void Linq64()
        {
            Console.WriteLine("Linq64");
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //// where elementAt 1
            int fourthLowNum = 0;  // second number is index 1 because sequences use 0-based indexing

            //

            Console.WriteLine("Second number > 5: {0}", fourthLowNum);
            Console.WriteLine();
            Console.WriteLine();
        }
        // GenerationOperators - Enumerable.Range
        public void Linq65()
        {
            Console.WriteLine("Linq65");
            // Enumerable.Range 100 50
            var numbers = 0;
                
            //

            //foreach (var n in numbers)
            {
                //Console.WriteLine("The number {0} is {1}.", n.Number, n.OddEven);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // Quantifiers - where any 
        public void Linq69()
        {
            Console.WriteLine("Linq69");
            List<Product> products = GetProductList();

            // where any 
            var productGroups = 0;
               
               ;
            //

            ObjectDumper.Write(productGroups, 1);
            Console.WriteLine();
            Console.WriteLine();
        }
        // Quantifiers - where all
        public void Linq72()
        {
            Console.WriteLine("Linq72");
            List<Product> products = GetProductList();

            // where all
            var productGroups = 
                 products
                ;
            //

            ObjectDumper.Write(productGroups, 1);
            Console.WriteLine();
            Console.WriteLine();
        }
        // AggregateOperators - count
        public void Linq76()
        {
            Console.WriteLine("Linq76");
            List<Customer> customers = GetCustomerList();

            // count
            var orderCounts =
                 customers
                
                ;
            //

            ObjectDumper.Write(orderCounts);
            Console.WriteLine();
            Console.WriteLine();
        }
        // AggregateOperators - count
        public void Linq77()
        {
            Console.WriteLine("Linq77");
            List<Product> products = GetProductList();

            // count
            var categoryCounts = 0;

            //

            ObjectDumper.Write(categoryCounts);
            Console.WriteLine();
            Console.WriteLine();
        }
        // AggregateOperators - group by  into, sum
        public void Linq80()
        {
            Console.WriteLine("Linq80");
            List<Product> products = GetProductList();

            // group by  into, sum 
            var categories = 
                 products
                
            ;
            //

            ObjectDumper.Write(categories);
            Console.WriteLine();
            Console.WriteLine();
        }
        // AggregateOperators - group by  into, min
        public void Linq83()
        {
            Console.WriteLine("Linq83");
            List<Product> products = GetProductList();

            // group by  into, min
            var categories =
                 products
                ;
            //

            ObjectDumper.Write(categories);
            Console.WriteLine();
            Console.WriteLine();
        }
        // AggregateOperators - group by  into, let, min
        public void Linq84()
        {
            Console.WriteLine("Linq84");
            List<Product> products = GetProductList();

            // group by  into, let, min
            var categories =
               products
               ;
            //

            ObjectDumper.Write(categories, 1);
            Console.WriteLine();
            Console.WriteLine();
        }
        // AggregateOperators - group by  into, max
        public void Linq87()
        {
            Console.WriteLine("Linq87");
            List<Product> products = GetProductList();

            // group by  into, max
            var categories = 
               products
               ;
            //

            ObjectDumper.Write(categories);
            Console.WriteLine();
            Console.WriteLine();
        }
        // AggregateOperators - group by  into, let, max
        public void Linq88()
        {
            Console.WriteLine("Linq88");
            List<Product> products = GetProductList();

            // group by  into, let, max
            var categories = 
                 products
                ;
            //

            ObjectDumper.Write(categories, 1);
            Console.WriteLine();
            Console.WriteLine();
        }
        // AggregateOperators - group by  into, let, average
        public void Linq91()
        {
            Console.WriteLine("Linq91");
            List<Product> products = GetProductList();

            // group by  into, let, average
            var categories = 
                 products
                ;
            //

            ObjectDumper.Write(categories);
            Console.WriteLine();
            Console.WriteLine();
        }
        // AggregateOperators - aggregate
        public void Linq93()
        {
            Console.WriteLine("Linq93");
            double startBalance = 100.0;

            int[] attemptedWithdrawals = { 20, 10, 40, 50, 10, 70, 30 };

            // aggregate
            double endBalance = 
                0
                ;
            //

            Console.WriteLine("Ending balance: {0}", endBalance);
            Console.WriteLine();
            Console.WriteLine();
        }
        // MiscellaneousOperators - concat
        public void Linq95()
        {
            Console.WriteLine("Linq95");
            List<Customer> customers = GetCustomerList();
            List<Product> products = GetProductList();

            var customerNames =
                from cust in customers
                select cust.CompanyName;
            var productNames =
                from prod in products
                select prod.ProductName;
            
            // concat
            var allNames = customerNames;
            //

            Console.WriteLine("Customer and product names:");
            foreach (var n in allNames)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // QueryExecution - increment
        public void Linq99()
        {
            Console.WriteLine("Linq99");
            // Queries are not executed until you enumerate over them.
            int[] numbers = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int i = 0;
            // increment
            var simpleQuery = 
                numbers
                
                ;
            //

            // The local variable 'i' is not incremented
            // until the query is executed in the foreach loop.
            Console.WriteLine("The current value of i is {0}", i); //i is still zero

            foreach (var item in simpleQuery)
            {
                Console.WriteLine("v = {0}, i = {1}", item, i); // now i is incremented          
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // QueryExecution - increment tolist
        public void Linq100()
        {
            Console.WriteLine("Linq100");
            // Methods like ToList(), Max(), and Count() cause the query to be
            // executed immediately.            
            int[] numbers = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int i = 0;

            // increment tolist
            var immediateQuery = 
                (
                 numbers
                )
                 ;
            //

            Console.WriteLine("The current value of i is {0}", i); //i has been incremented

            foreach (var item in immediateQuery)
            {
                Console.WriteLine("v = {0}, i = {1}", item, i);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // QueryExecution - where
        public void Linq101()
        {
            Console.WriteLine("Linq101");
            int[] numbers = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // where <= 3
            var lowNumbers = 
                numbers
                 ;
            //

            Console.WriteLine("First run numbers <= 3:");
            foreach (int n in lowNumbers)
            {
                Console.WriteLine(n);
            }

            // Query the original query.
            var lowEvenNumbers =
                from num in lowNumbers
                where num % 2 == 0
                select num;

            Console.WriteLine("Run lowEvenNumbers query:");
            foreach (int n in lowEvenNumbers)
            {
                Console.WriteLine(n);
            }

            // Modify the source data.
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = -numbers[i];
            }

            // During this second run, the same query object,
            // lowNumbers, will be iterating over the new state
            // of numbers[], producing different results:
            Console.WriteLine("Second run numbers <= 3:");
            foreach (int n in lowNumbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // JoinOperators - join on equals
        public void Linq102()
        {
            Console.WriteLine("Linq102");
            List<Customer> customers = GetCustomerList();
            List<Supplier> suppliers = GetSupplierList();

            // join on equals
            var custSupJoin =
                suppliers
                ;
            //

            foreach (var item in custSupJoin)
            {
                //Console.WriteLine("Country = {0}, Supplier = {1}, Customer = {2}", item.Country, item.SupplierName, item.CustomerName);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // JoinOperators - join on equals into
        public void Linq103()
        {
            Console.WriteLine("Linq103");
            List<Customer> customers = GetCustomerList();
            List<Supplier> suppliers = GetSupplierList();

            // join on equals into
            var custSupQuery = 
                suppliers
                ;
            //

            foreach (var item in custSupQuery)
            {
                //Console.WriteLine(item.Key + ":");
                //foreach (var element in item.Items)
                //{
                //    Console.WriteLine("   " + element.CompanyName);
                //}
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // JoinOperators - join on equals into
        public void Linq104()
        {
            Console.WriteLine("Linq104");
            string[] categories = new string[]{
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood" };

            List<Product> products = GetProductList();

            // join on equals into
            var prodByCategory = 
                 categories
                ;
            //

            foreach (var item in prodByCategory)
            {
                //Console.WriteLine(item.ProductName + ": " + item.Category);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // JoinOperators - join on equals into orderby select new
        public void Linq105()
        {
            Console.WriteLine("Linq105");
            List<Customer> customers = GetCustomerList();
            List<Supplier> suppliers = GetSupplierList();

            // join on equals into orderby select new
            var supplierCusts = 
                 suppliers
                ;
            //

            foreach (var item in supplierCusts)
            {
                //Console.WriteLine("{0} ({1}): {2}", item.SupplierName, item.Country, item.CompanyName);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // JoinOperators - join on equals into orderby select new
        public void Linq106()
        {
            Console.WriteLine("Linq106");
            List<Customer> customers = GetCustomerList();
            List<Supplier> suppliers = GetSupplierList();

            // join on equals into orderby select new
            var custSuppliers = 
                customers
                ;
            //

            foreach (var item in custSuppliers)
            {
                //Console.WriteLine("{0} ({1}): {2}", item.CompanyName, item.Country, item.SupplierName);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // JoinOperators - join on new equals new into orderby select new
        public void Linq107()
        {
            Console.WriteLine("Linq107");
            List<Customer> customers = GetCustomerList();
            List<Supplier> suppliers = GetSupplierList();

            // join on new equals new into orderby select new
            var supplierCusts = suppliers;
            //

            foreach (var item in supplierCusts)
            {
                //Console.WriteLine("{0} ({1}, {2}): {3}", item.SupplierName, item.City, item.Country, item.CompanyName);
            }
            Console.WriteLine();
            Console.WriteLine();
        }






        private List<Product> productList;
        private List<Customer> customerList;
        private List<Supplier> supplierList;
        public List<Product> GetProductList()
        {
            if (productList == null)
                createLists();

            return productList;
        }

        public List<Customer> GetCustomerList()
        {
            if (customerList == null)
                createLists();

            return customerList;
        }
        public List<Supplier> GetSupplierList()
        {
            if (supplierList == null)
                createLists();

            return supplierList;
        }

        private void createLists()
        {
            // Product data created in-memory using collection initializer:
            productList =
                new List<Product> {
                    new Product { ProductID = 1, ProductName = "Chai", Category = "Beverages", UnitPrice = 18.0000M, UnitsInStock = 39 },
                    new Product { ProductID = 2, ProductName = "Chang", Category = "Beverages", UnitPrice = 19.0000M, UnitsInStock = 17 },
                    new Product { ProductID = 3, ProductName = "Aniseed Syrup", Category = "Condiments", UnitPrice = 10.0000M, UnitsInStock = 13 },
                    new Product { ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments", UnitPrice = 22.0000M, UnitsInStock = 53 },
                    new Product { ProductID = 5, ProductName = "Chef Anton's Gumbo Mix", Category = "Condiments", UnitPrice = 21.3500M, UnitsInStock = 0 },
                    new Product { ProductID = 6, ProductName = "Grandma's Boysenberry Spread", Category = "Condiments", UnitPrice = 25.0000M, UnitsInStock = 120 },
                    new Product { ProductID = 7, ProductName = "Uncle Bob's Organic Dried Pears", Category = "Produce", UnitPrice = 30.0000M, UnitsInStock = 15 },
                    new Product { ProductID = 8, ProductName = "Northwoods Cranberry Sauce", Category = "Condiments", UnitPrice = 40.0000M, UnitsInStock = 6 },
                    new Product { ProductID = 9, ProductName = "Mishi Kobe Niku", Category = "Meat/Poultry", UnitPrice = 97.0000M, UnitsInStock = 29 },
                    new Product { ProductID = 10, ProductName = "Ikura", Category = "Seafood", UnitPrice = 31.0000M, UnitsInStock = 31 },
                    new Product { ProductID = 11, ProductName = "Queso Cabrales", Category = "Dairy Products", UnitPrice = 21.0000M, UnitsInStock = 22 },
                    new Product { ProductID = 12, ProductName = "Queso Manchego La Pastora", Category = "Dairy Products", UnitPrice = 38.0000M, UnitsInStock = 86 },
                    new Product { ProductID = 13, ProductName = "Konbu", Category = "Seafood", UnitPrice = 6.0000M, UnitsInStock = 24 },
                    new Product { ProductID = 14, ProductName = "Tofu", Category = "Produce", UnitPrice = 23.2500M, UnitsInStock = 35 },
                    new Product { ProductID = 15, ProductName = "Genen Shouyu", Category = "Condiments", UnitPrice = 15.5000M, UnitsInStock = 39 },
                    new Product { ProductID = 16, ProductName = "Pavlova", Category = "Confections", UnitPrice = 17.4500M, UnitsInStock = 29 },
                    new Product { ProductID = 17, ProductName = "Alice Mutton", Category = "Meat/Poultry", UnitPrice = 39.0000M, UnitsInStock = 0 },
                    new Product { ProductID = 18, ProductName = "Carnarvon Tigers", Category = "Seafood", UnitPrice = 62.5000M, UnitsInStock = 42 },
                    new Product { ProductID = 19, ProductName = "Teatime Chocolate Biscuits", Category = "Confections", UnitPrice = 9.2000M, UnitsInStock = 25 },
                    new Product { ProductID = 20, ProductName = "Sir Rodney's Marmalade", Category = "Confections", UnitPrice = 81.0000M, UnitsInStock = 40 },
                    new Product { ProductID = 21, ProductName = "Sir Rodney's Scones", Category = "Confections", UnitPrice = 10.0000M, UnitsInStock = 3 },
                    new Product { ProductID = 22, ProductName = "Gustaf's Knäckebröd", Category = "Grains/Cereals", UnitPrice = 21.0000M, UnitsInStock = 104 },
                    new Product { ProductID = 23, ProductName = "Tunnbröd", Category = "Grains/Cereals", UnitPrice = 9.0000M, UnitsInStock = 61 },
                    new Product { ProductID = 24, ProductName = "Guaraná Fantástica", Category = "Beverages", UnitPrice = 4.5000M, UnitsInStock = 20 },
                    new Product { ProductID = 25, ProductName = "NuNuCa Nuß-Nougat-Creme", Category = "Confections", UnitPrice = 14.0000M, UnitsInStock = 76 },
                    new Product { ProductID = 26, ProductName = "Gumbär Gummibärchen", Category = "Confections", UnitPrice = 31.2300M, UnitsInStock = 15 },
                    new Product { ProductID = 27, ProductName = "Schoggi Schokolade", Category = "Confections", UnitPrice = 43.9000M, UnitsInStock = 49 },
                    new Product { ProductID = 28, ProductName = "Rössle Sauerkraut", Category = "Produce", UnitPrice = 45.6000M, UnitsInStock = 26 },
                    new Product { ProductID = 29, ProductName = "Thüringer Rostbratwurst", Category = "Meat/Poultry", UnitPrice = 123.7900M, UnitsInStock = 0 },
                    new Product { ProductID = 30, ProductName = "Nord-Ost Matjeshering", Category = "Seafood", UnitPrice = 25.8900M, UnitsInStock = 10 },
                    new Product { ProductID = 31, ProductName = "Gorgonzola Telino", Category = "Dairy Products", UnitPrice = 12.5000M, UnitsInStock = 0 },
                    new Product { ProductID = 32, ProductName = "Mascarpone Fabioli", Category = "Dairy Products", UnitPrice = 32.0000M, UnitsInStock = 9 },
                    new Product { ProductID = 33, ProductName = "Geitost", Category = "Dairy Products", UnitPrice = 2.5000M, UnitsInStock = 112 },
                    new Product { ProductID = 34, ProductName = "Sasquatch Ale", Category = "Beverages", UnitPrice = 14.0000M, UnitsInStock = 111 },
                    new Product { ProductID = 35, ProductName = "Steeleye Stout", Category = "Beverages", UnitPrice = 18.0000M, UnitsInStock = 20 },
                    new Product { ProductID = 36, ProductName = "Inlagd Sill", Category = "Seafood", UnitPrice = 19.0000M, UnitsInStock = 112 },
                    new Product { ProductID = 37, ProductName = "Gravad lax", Category = "Seafood", UnitPrice = 26.0000M, UnitsInStock = 11 },
                    new Product { ProductID = 38, ProductName = "Côte de Blaye", Category = "Beverages", UnitPrice = 263.5000M, UnitsInStock = 17 },
                    new Product { ProductID = 39, ProductName = "Chartreuse verte", Category = "Beverages", UnitPrice = 18.0000M, UnitsInStock = 69 },
                    new Product { ProductID = 40, ProductName = "Boston Crab Meat", Category = "Seafood", UnitPrice = 18.4000M, UnitsInStock = 123 },
                    new Product { ProductID = 41, ProductName = "Jack's New England Clam Chowder", Category = "Seafood", UnitPrice = 9.6500M, UnitsInStock = 85 },
                    new Product { ProductID = 42, ProductName = "Singaporean Hokkien Fried Mee", Category = "Grains/Cereals", UnitPrice = 14.0000M, UnitsInStock = 26 },
                    new Product { ProductID = 43, ProductName = "Ipoh Coffee", Category = "Beverages", UnitPrice = 46.0000M, UnitsInStock = 17 },
                    new Product { ProductID = 44, ProductName = "Gula Malacca", Category = "Condiments", UnitPrice = 19.4500M, UnitsInStock = 27 },
                    new Product { ProductID = 45, ProductName = "Rogede sild", Category = "Seafood", UnitPrice = 9.5000M, UnitsInStock = 5 },
                    new Product { ProductID = 46, ProductName = "Spegesild", Category = "Seafood", UnitPrice = 12.0000M, UnitsInStock = 95 },
                    new Product { ProductID = 47, ProductName = "Zaanse koeken", Category = "Confections", UnitPrice = 9.5000M, UnitsInStock = 36 },
                    new Product { ProductID = 48, ProductName = "Chocolade", Category = "Confections", UnitPrice = 12.7500M, UnitsInStock = 15 },
                    new Product { ProductID = 49, ProductName = "Maxilaku", Category = "Confections", UnitPrice = 20.0000M, UnitsInStock = 10 },
                    new Product { ProductID = 50, ProductName = "Valkoinen suklaa", Category = "Confections", UnitPrice = 16.2500M, UnitsInStock = 65 },
                    new Product { ProductID = 51, ProductName = "Manjimup Dried Apples", Category = "Produce", UnitPrice = 53.0000M, UnitsInStock = 20 },
                    new Product { ProductID = 52, ProductName = "Filo Mix", Category = "Grains/Cereals", UnitPrice = 7.0000M, UnitsInStock = 38 },
                    new Product { ProductID = 53, ProductName = "Perth Pasties", Category = "Meat/Poultry", UnitPrice = 32.8000M, UnitsInStock = 0 },
                    new Product { ProductID = 54, ProductName = "Tourtière", Category = "Meat/Poultry", UnitPrice = 7.4500M, UnitsInStock = 21 },
                    new Product { ProductID = 55, ProductName = "Pâté chinois", Category = "Meat/Poultry", UnitPrice = 24.0000M, UnitsInStock = 115 },
                    new Product { ProductID = 56, ProductName = "Gnocchi di nonna Alice", Category = "Grains/Cereals", UnitPrice = 38.0000M, UnitsInStock = 21 },
                    new Product { ProductID = 57, ProductName = "Ravioli Angelo", Category = "Grains/Cereals", UnitPrice = 19.5000M, UnitsInStock = 36 },
                    new Product { ProductID = 58, ProductName = "Escargots de Bourgogne", Category = "Seafood", UnitPrice = 13.2500M, UnitsInStock = 62 },
                    new Product { ProductID = 59, ProductName = "Raclette Courdavault", Category = "Dairy Products", UnitPrice = 55.0000M, UnitsInStock = 79 },
                    new Product { ProductID = 60, ProductName = "Camembert Pierrot", Category = "Dairy Products", UnitPrice = 34.0000M, UnitsInStock = 19 },
                    new Product { ProductID = 61, ProductName = "Sirop d'érable", Category = "Condiments", UnitPrice = 28.5000M, UnitsInStock = 113 },
                    new Product { ProductID = 62, ProductName = "Tarte au sucre", Category = "Confections", UnitPrice = 49.3000M, UnitsInStock = 17 },
                    new Product { ProductID = 63, ProductName = "Vegie-spread", Category = "Condiments", UnitPrice = 43.9000M, UnitsInStock = 24 },
                    new Product { ProductID = 64, ProductName = "Wimmers gute Semmelknödel", Category = "Grains/Cereals", UnitPrice = 33.2500M, UnitsInStock = 22 },
                    new Product { ProductID = 65, ProductName = "Louisiana Fiery Hot Pepper Sauce", Category = "Condiments", UnitPrice = 21.0500M, UnitsInStock = 76 },
                    new Product { ProductID = 66, ProductName = "Louisiana Hot Spiced Okra", Category = "Condiments", UnitPrice = 17.0000M, UnitsInStock = 4 },
                    new Product { ProductID = 67, ProductName = "Laughing Lumberjack Lager", Category = "Beverages", UnitPrice = 14.0000M, UnitsInStock = 52 },
                    new Product { ProductID = 68, ProductName = "Scottish Longbreads", Category = "Confections", UnitPrice = 12.5000M, UnitsInStock = 6 },
                    new Product { ProductID = 69, ProductName = "Gudbrandsdalsost", Category = "Dairy Products", UnitPrice = 36.0000M, UnitsInStock = 26 },
                    new Product { ProductID = 70, ProductName = "Outback Lager", Category = "Beverages", UnitPrice = 15.0000M, UnitsInStock = 15 },
                    new Product { ProductID = 71, ProductName = "Flotemysost", Category = "Dairy Products", UnitPrice = 21.5000M, UnitsInStock = 26 },
                    new Product { ProductID = 72, ProductName = "Mozzarella di Giovanni", Category = "Dairy Products", UnitPrice = 34.8000M, UnitsInStock = 14 },
                    new Product { ProductID = 73, ProductName = "Röd Kaviar", Category = "Seafood", UnitPrice = 15.0000M, UnitsInStock = 101 },
                    new Product { ProductID = 74, ProductName = "Longlife Tofu", Category = "Produce", UnitPrice = 10.0000M, UnitsInStock = 4 },
                    new Product { ProductID = 75, ProductName = "Rhönbräu Klosterbier", Category = "Beverages", UnitPrice = 7.7500M, UnitsInStock = 125 },
                    new Product { ProductID = 76, ProductName = "Lakkalikööri", Category = "Beverages", UnitPrice = 18.0000M, UnitsInStock = 57 },
                    new Product { ProductID = 77, ProductName = "Original Frankfurter grüne Soße", Category = "Condiments", UnitPrice = 13.0000M, UnitsInStock = 32 }
            };

            // Customer/Order data read into memory from XML file using XLinq:
            customerList = (
                from e in XDocument.Load("Customers.xml").
                          Root.Elements("customer")
                select new Customer
                {
                    CustomerID = (string)e.Element("id"),
                    CompanyName = (string)e.Element("name"),
                    Address = (string)e.Element("address"),
                    City = (string)e.Element("city"),
                    Region = (string)e.Element("region"),
                    PostalCode = (string)e.Element("postalcode"),
                    Country = (string)e.Element("country"),
                    Phone = (string)e.Element("phone"),
                    Fax = (string)e.Element("fax"),
                    Orders = (
                        from o in e.Elements("orders").Elements("order")
                        select new Order
                        {
                            OrderID = (int)o.Element("id"),
                            OrderDate = (DateTime)o.Element("orderdate"),
                            Total = (decimal)o.Element("total")
                        })
                        .ToArray()
                })
                .ToList();

            supplierList = new List<Supplier>(){
                    new Supplier {SupplierName = "Exotic Liquids", Address = "49 Gilbert St.", City = "London", Country = "UK"},
                    new Supplier {SupplierName = "New Orleans Cajun Delights", Address = "P.O. Box 78934", City = "New Orleans", Country = "USA"},
                    new Supplier {SupplierName = "Grandma Kelly's Homestead", Address = "707 Oxford Rd.", City = "Ann Arbor", Country = "USA"},
                    new Supplier {SupplierName = "Tokyo Traders", Address = "9-8 Sekimai Musashino-shi", City = "Tokyo", Country = "Japan"},
                    new Supplier {SupplierName = "Cooperativa de Quesos 'Las Cabras'", Address = "Calle del Rosal 4", City = "Oviedo", Country = "Spain"},
                    new Supplier {SupplierName = "Mayumi's", Address = "92 Setsuko Chuo-ku", City = "Osaka", Country = "Japan"},
                    new Supplier {SupplierName = "Pavlova, Ltd.", Address = "74 Rose St. Moonie Ponds", City = "Melbourne", Country = "Australia"},
                    new Supplier {SupplierName = "Specialty Biscuits, Ltd.", Address = "29 King's Way", City = "Manchester", Country = "UK"},
                    new Supplier {SupplierName = "PB Knäckebröd AB", Address = "Kaloadagatan 13", City = "Göteborg", Country = "Sweden"},
                    new Supplier {SupplierName = "Refrescos Americanas LTDA", Address = "Av. das Americanas 12.890", City = "Sao Paulo", Country = "Brazil"},
                    new Supplier {SupplierName = "Heli Süßwaren GmbH & Co. KG", Address = "Tiergartenstraße 5", City = "Berlin", Country = "Germany"},
                    new Supplier {SupplierName = "Plutzer Lebensmittelgroßmärkte AG", Address = "Bogenallee 51", City = "Frankfurt", Country = "Germany"},
                    new Supplier {SupplierName = "Nord-Ost-Fisch Handelsgesellschaft mbH", Address = "Frahmredder 112a", City = "Cuxhaven", Country = "Germany"},
                    new Supplier {SupplierName = "Formaggi Fortini s.r.l.", Address = "Viale Dante, 75", City = "Ravenna", Country = "Italy"},
                    new Supplier {SupplierName = "Norske Meierier", Address = "Hatlevegen 5", City = "Sandvika", Country = "Norway"},
                    new Supplier {SupplierName = "Bigfoot Breweries", Address = "3400 - 8th Avenue Suite 210", City = "Bend", Country = "USA"},
                    new Supplier {SupplierName = "Svensk Sjöföda AB", Address = "Brovallavägen 231", City = "Stockholm", Country = "Sweden"},
                    new Supplier {SupplierName = "Aux joyeux ecclésiastiques", Address = "203, Rue des Francs-Bourgeois", City = "Paris", Country = "France"},
                    new Supplier {SupplierName = "New England Seafood Cannery", Address = "Order Processing Dept. 2100 Paul Revere Blvd.", City = "Boston", Country = "USA"},
                    new Supplier {SupplierName = "Leka Trading", Address = "471 Serangoon Loop, Suite #402", City = "Singapore", Country = "Singapore"},
                    new Supplier {SupplierName = "Lyngbysild", Address = "Lyngbysild Fiskebakken 10", City = "Lyngby", Country = "Denmark"},
                    new Supplier {SupplierName = "Zaanse Snoepfabriek", Address = "Verkoop Rijnweg 22", City = "Zaandam", Country = "Netherlands"},
                    new Supplier {SupplierName = "Karkki Oy", Address = "Valtakatu 12", City = "Lappeenranta", Country = "Finland"},
                    new Supplier {SupplierName = "G'day, Mate", Address = "170 Prince Edward Parade Hunter's Hill", City = "Sydney", Country = "Australia"},
                    new Supplier {SupplierName = "Ma Maison", Address = "2960 Rue St. Laurent", City = "Montréal", Country = "Canada"},
                    new Supplier {SupplierName = "Pasta Buttini s.r.l.", Address = "Via dei Gelsomini, 153", City = "Salerno", Country = "Italy"},
                    new Supplier {SupplierName = "Escargots Nouveaux", Address = "22, rue H. Voiron", City = "Montceau", Country = "France"},
                    new Supplier {SupplierName = "Gai pâturage", Address = "Bat. B 3, rue des Alpes", City = "Annecy", Country = "France"},
                    new Supplier {SupplierName = "Forêts d'érables", Address = "148 rue Chasseur", City = "Ste-Hyacinthe", Country = "Canada"},
                };
        }

        public class CaseInsensitiveComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
            }
        }
    }

    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }

    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
    }

    public class Customer
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public Order[] Orders { get; set; }
    }

    public class Supplier
    {
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
