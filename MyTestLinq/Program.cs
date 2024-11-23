using System.Xml.Linq;

namespace MyTestLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinqSamples samples = new LinqSamples();
            //samples.Linq1();
            //samples.Linq5();
            //samples.Linq20();
            //samples.Linq22();
            //samples.Linq24();
            //samples.Linq25();
            //samples.Linq26();
            //samples.Linq27();
            //samples.Linq31();
            //samples.Linq34();
            samples.Linq36();
            //samples.Linq38();
            //samples.Linq56();
            //samples.Linq57();
            //samples.Linq59();
            //samples.Linq61();
            //samples.Linq62();
            //samples.Linq66();
            //samples.Linq67();
            //samples.Linq70();
            //samples.Linq73();
            //samples.Linq74();
            //samples.Linq78();
            //samples.Linq79();
            //samples.Linq81();
            //samples.Linq82();
            //samples.Linq85();
            //samples.Linq86();
            //samples.Linq89();
            //samples.Linq90();
            //samples.Linq92();
            //samples.Linq94();
            //samples.Linq96();
            //samples.Linq97();
        }
    }
    public class LinqSamples
    {
        // RestrictionOperators - Where
        public void Linq1()
        {
            Console.WriteLine("Linq1");
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            
            //  where < 5
            var lowNumbers = numbers;
            //

            foreach (var num in lowNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        // RestrictionOperators - Where
        public void Linq5()
        {
            Console.WriteLine("Linq5");
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            // where index, digit length < index
            var shortDigits = digits;
            //

            Console.WriteLine("Short digits:");
            foreach (var d in shortDigits)
            {
                Console.WriteLine("The word {0} is shorter than its value.", d);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        // PartitioningOperators - Take
        public void Linq20()
        {
            Console.WriteLine("Linq20");
            int[] numbers = { 5, 4, 1, 3, 9, 8, 7, 2, 0 };

            // Take 3
            // 5 4 1
            var first3Numbers = numbers;
            //

            Console.WriteLine("First 3 numbers:");
            foreach (var n in first3Numbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        // PartitioningOperators - Skip
        public void Linq22()
        {
            Console.WriteLine("Linq22");
            int[] numbers = { 5, 4, 1, 2, 9, 8, 6, 7, 2, 0 };

            // skip 4
            // 9, 8, 6, 7, 2, 0
            var allButFirst4Numbers = numbers;
            //

            Console.WriteLine("All but first 4 numbers:");
            foreach (var n in allButFirst4Numbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        // PartitioningOperators - TakeWhile
        public void Linq24()
        {
            Console.WriteLine("Linq24");
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 72, 0 };

            // TakeWhile < 6
            var firstNumbersLessThan6 = numbers;
            //

            Console.WriteLine("First numbers less than 6:");
            foreach (var num in firstNumbersLessThan6)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        // PartitioningOperators - TakeWhile        
        public void Linq25()
        {
            Console.WriteLine("Linq25");
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // TakeWhile   n >= index 
            // 5 4
            var firstSmallNumbers = numbers;
            //

            Console.WriteLine("First numbers not less than their position:");
            foreach (var n in firstSmallNumbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        // PartitioningOperators - SkipWhile        
        public void Linq26()
        {
            Console.WriteLine("Linq26");
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // skipWhile 
            //  3, 9, 8, 6, 7, 2, 0
            var allButFirst3Numbers = numbers;
            //

            Console.WriteLine("All elements starting from first element divisible by 3:");
            foreach (var n in allButFirst3Numbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // PartitioningOperators - SkipWhile        
        public void Linq27()
        {
            Console.WriteLine("Linq27");
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // skipWhile index, n >= index
            // 1, 3, 9, 8, 6, 7, 2, 0
            var laterNumbers = numbers;
            //

            Console.WriteLine("All elements starting from first element less than its position:");
            foreach (var n in laterNumbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // OrderingOperators - OrderBy
        public void Linq31()
        {
            Console.WriteLine("Linq31");
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            // OrderBy CaseInsensitiveComparer
            // "AbAcUs", "aPPLE",  "BlUeBeRrY", "bRaNcH", "cHeRry", "ClOvEr"
            var sortedWords = words;
            //

            ObjectDumper.Write(sortedWords);
            Console.WriteLine();
            Console.WriteLine();
        }
        // OrderingOperators - OrderByDescending
        public void Linq34()
        {
            Console.WriteLine("Linq34");
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            // OrderByDescending CaseInsensitiveComparer
            // "ClOvEr", "cHeRry", "bRaNcH", "BlUeBeRrY", "aPPLE", "AbAcUs"
            var sortedWords = words;
            //

            ObjectDumper.Write(sortedWords);
            Console.WriteLine();
            Console.WriteLine();
        }
        // OrderingOperators - OrderBy        
        public void Linq36()
        {
            Console.WriteLine("Linq36");
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            // OrderBy Length ThenBy CaseInsensitiveComparer
            // "aPPLE", "AbAcUs", "bRaNcH", "cHeRry", "ClOvEr", "BlUeBeRrY"
            var sortedWords = words;
            // orderby (sql) length
            //var sortedWords2 = 

            //var sortedWords3 = sortedWords2;

            ObjectDumper.Write(sortedWords);
            Console.WriteLine();

            //ObjectDumper.Write(sortedWords3);
            Console.WriteLine();
            Console.WriteLine();
        }
        // OrderingOperators - OrderBy        
        public void Linq38()
        {
            Console.WriteLine("Linq38");
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            // OrderBy Length ThenByDescending CaseInsensitiveComparer
            // "aPPLE", "ClOvEr", "cHeRry", "bRaNcH", "AbAcUs", "BlUeBeRrY",
            var sortedWords = words;
            //

            ObjectDumper.Write(sortedWords);
            Console.WriteLine();
            Console.WriteLine();
        }
        // ConversionOperators - ToDictionary        
        public void Linq56()
        {
            Console.WriteLine("Linq56");
            var scoreRecords = new[] { new {Name = "Alice", Score = 50},
                                        new {Name = "Bob"  , Score = 40},
                                        new {Name = "Cathy", Score = 45}
                                    };

            // ToDictionary Name
            var scoreRecordsDict = scoreRecords;
            //

            //Console.WriteLine("Bob's score: {0}", scoreRecordsDict["Bob"]);
            Console.WriteLine();
            foreach (var item in scoreRecordsDict)
            {
               // Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // ConversionOperators - OfType        
        public void Linq57()
        {
            Console.WriteLine("Linq57");
            object[] numbers = { null, 1.0, "two", 3, "four", 5, "six", 7.0 };

            // OfType
            // 1 7
            var doubles = numbers;
            //

            Console.WriteLine("Numbers stored as doubles:");
            foreach (var d in doubles)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // ElementOperators - First        
        public void Linq59()
        {
            Console.WriteLine("Linq59");
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            // First s[0] == 'o'
            var startsWithO = strings;
            //

            Console.WriteLine("A string starting with 'o': {0}", startsWithO);
            Console.WriteLine();
            Console.WriteLine();
        }
        // ElementOperators - FirstOrDefault        
        public void Linq61()
        {
            Console.WriteLine("Linq61");
            int[] numbers = { };

            // FirstOrDefault
            int firstNumOrDefault = numbers    [0];
            //

            Console.WriteLine(firstNumOrDefault);
            Console.WriteLine();
            Console.WriteLine();
        }
        // ElementOperators - FirstOrDefault
        public void Linq62()
        {
            Console.WriteLine("Linq62");
            List<Product> products = GetProductList();

            // FirstOrDefault ProductID == 789
            Product product789 = products   [0];
            //

            Console.WriteLine("Product 789 exists: {0}", product789 != null);
            Console.WriteLine();
            Console.WriteLine();
        }
        // GenerationOperators - Enumerable.Repeat        
        public void Linq66()
        {
            Console.WriteLine("Linq66");

            // Enumerable Repeat 7 10
            var numbers = new int[7];
            //

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // Quantifiers - Any Contains
        public void Linq67()
        {
            Console.WriteLine("Linq67");
            string[] words = { "believe", "relief", "receipt", "field" };
            
            // any contains "ei"
            bool iAfterE = words is null;
            //

            Console.WriteLine("There is a word in the list that contains 'ei': {0}", iAfterE);
            Console.WriteLine();
            Console.WriteLine();
        }
        // Quantifiers - All
        public void Linq70()
        {
            Console.WriteLine("Linq70");
            int[] numbers = { 1, 11, 3, 19, 41, 65, 29 };
            
            // All n % 2  == 1
            bool onlyOdd = numbers      != null;
            //

            Console.WriteLine("The list contains only odd numbers: {0}", onlyOdd);
            Console.WriteLine();
            Console.WriteLine();
        }
        // AggregateOperators - Distinct Count
        public void Linq73()
        {
            Console.WriteLine("Linq73");
            int[] primeFactorsOf300 = { 2, 2, 3, 5, 5 };

            // Distinct Count
            // 3
            int uniqueFactors = 0; // primeFactorsOf300
            //

            Console.WriteLine("There are {0} unique prime factors of 300.", uniqueFactors);
            Console.WriteLine();
            Console.WriteLine();
        }
        // AggregateOperators - Count
        public void Linq74()
        {
            Console.WriteLine("Linq74");
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // Count n % 2 == 1
            int oddNumbers = 0; // numbers
            //

            Console.WriteLine("There are {0} odd numbers in the list.", oddNumbers);
            Console.WriteLine();
            Console.WriteLine();
        }
        // AggregateOperators - Sum
        public void Linq78()
        {
            Console.WriteLine("Linq78");
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // Sum
            double numSum = 0;// numbers
            //

            Console.WriteLine("The sum of the numbers is {0}.", numSum);
            Console.WriteLine();
            Console.WriteLine();
        }
        // AggregateOperators - Sum
        public void Linq79()
        {
            Console.WriteLine("Linq79");
            string[] words = { "cherry", "apple", "blueberry" };

            // Sum length
            double totalChars = words.Length;
            //

            Console.WriteLine("There are a total of {0} characters in these words.", totalChars);
            Console.WriteLine();
            Console.WriteLine();
        }
        // AggregateOperators - Min
        public void Linq81()
        {
            Console.WriteLine("Linq81");
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // min
            int minNum = 0; // numbers;
            //

            Console.WriteLine("The minimum number is {0}.", minNum);
            Console.WriteLine();
            Console.WriteLine();
        }
        // AggregateOperators - Min
        public void Linq82()
        {
            Console.WriteLine("Linq82");
            string[] words = { "cherry", "apple", "blueberry" };

            // min length
            int shortestWord = 0; // words
            //

            Console.WriteLine("The shortest word is {0} characters long.", shortestWord);
            Console.WriteLine();
            Console.WriteLine();
        }
        // AggregateOperators - Max
        public void Linq85()
        {
            Console.WriteLine("Linq85");
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // max
            int maxNum = 0; // numbers
            //

            Console.WriteLine("The maximum number is {0}.", maxNum);
            Console.WriteLine();
            Console.WriteLine();
        }
        // AggregateOperators - Max
        public void Linq86()
        {
            Console.WriteLine("Linq86");
            string[] words = { "cherry", "apple", "blueberry" };

            // max length
            int longestLength = 0; // words
            //

            Console.WriteLine("The longest word is {0} characters long.", longestLength);
            Console.WriteLine();
            Console.WriteLine();
        }
        // AggregateOperators - Average
        public void Linq89()
        {
            Console.WriteLine("Linq89");
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // Average
            double averageNum = 0; // numbers
            //

            Console.WriteLine("The average number is {0}.", averageNum);
            Console.WriteLine();
            Console.WriteLine();
        }
        // AggregateOperators - Average
        public void Linq90()
        {
            Console.WriteLine("Linq90");
            string[] words = { "cherry", "apple", "blueberry" };

            // Average length
            double averageLength = 0; //words
            //

            Console.WriteLine("The average word length is {0} characters.", averageLength);
            Console.WriteLine();
            Console.WriteLine();
        }
        // AggregateOperators - Aggregate
        public void Linq92()
        {
            Console.WriteLine("Linq92");
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            // Aggregate runningProduct * nextFactor
            double product = 0; // doubles
            //

            Console.WriteLine("Total product of all numbers: {0}", product);
            Console.WriteLine();
            Console.WriteLine();
        }
        // MiscellaneousOperators - Concat
        public void Linq94()
        {
            Console.WriteLine("Linq94");
            int[] numbersA = { 0, 2, 4, 5, 6, 7, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            //  Concat
            var allNumbers = numbersA;
            //

            Console.WriteLine("All numbers from both arrays:");
            foreach (var n in allNumbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // MiscellaneousOperators - SequenceEqual
        public void Linq96()
        {
            Console.WriteLine("Linq96");
            var wordsA = new string[] { "cherry", "apple", "blueberry" };
            var wordsB = new string[] { "cherry", "apple", "blueberry" };

            // SequenceEqual
            bool match = wordsA is null;
            //

            Console.WriteLine("The sequences match: {0}", match);
            Console.WriteLine();
            Console.WriteLine();
        }
        // MiscellaneousOperators - SequenceEqual
        public void Linq97()
        {
            Console.WriteLine("Linq97");
            var wordsA = new string[] { "cherry", "apple", "blueberry" };
            var wordsB = new string[] { "apple", "blueberry", "cherry" };

            // SequenceEqual
            bool match = wordsA.SequenceEqual(wordsB);
            //

            Console.WriteLine("The sequences match: {0}", match);
            Console.WriteLine();
            Console.WriteLine();
        }





        private List<Customer> customerList;
        public List<Customer> GetCustomerList()
        {
            if (customerList == null)
                createLists2();

            return customerList;
        }


        private void createLists2()
        {
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
        }
        public class CaseInsensitiveComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
            }
        }
        private List<Product> productList;
        public List<Product> GetProductList()
        {
            if (productList == null)
                createLists();

            return productList;
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
        }
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
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}
