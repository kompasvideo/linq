﻿using System.Xml.Linq;

namespace My_linq
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
            //samples.Linq36();
            //samples.Linq38();
            //samples.Linq56();
            //samples.Linq57();
            //samples.Linq59();
            //samples.Linq61();
            //samples.Linq62();
            samples.Linq66();
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
        // Where
        public void Linq1()
        {
            Console.WriteLine("Linq1");
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var lowNums = numbers;
            foreach (var num in lowNums)
            {
                Console.Write(num);
                Console.Write('\t');
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // Where
        public void Linq5()
        {
            Console.WriteLine("Linq5");
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var shortDigits = digits;

            Console.WriteLine("Short digits:");
            foreach (var d in shortDigits)
            {
                Console.WriteLine("The word {0} is shorter than its value.", d);
            }
            Console.WriteLine();
            Console.WriteLine();
        }        
        // Take
        public void Linq20()
        {
            Console.WriteLine("Linq20");
            int[] numbers = { 5, 4, 1, 3, 9, 8, 7, 2, 0 };
            var first3Numbers = numbers;

            Console.WriteLine("First 3 numbers:");
            foreach (var n in first3Numbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // Skip
        public void Linq22()
        {
            Console.WriteLine("Linq22");
            int[] numbers = { 5, 4, 1, 2, 9, 8, 6, 7, 2, 0 };
            var allButFirst4Numbers = numbers;

            Console.WriteLine("All but first 4 numbers:");
            foreach (var n in allButFirst4Numbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // TakeWhile
        public void Linq24()
        {
            Console.WriteLine("Linq24");
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 72, 0 };
            var firstNumbersLessThan6 = numbers;

            Console.WriteLine("First numbers less than 6:");
            foreach (var num in firstNumbersLessThan6)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // TakeWhile        
        public void Linq25()
        {
            Console.WriteLine("Linq25");
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var firstSmallNumbers = numbers;

            Console.WriteLine("First numbers not less than their position:");
            foreach (var n in firstSmallNumbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // SkipWhile        
        public void Linq26()
        {
            Console.WriteLine("Linq26");
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var allButFirst3Numbers = numbers;

            Console.WriteLine("All elements starting from first element divisible by 3:");
            foreach (var n in allButFirst3Numbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // SkipWhile        
        public void Linq27()
        {
            Console.WriteLine("Linq27");
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var laterNumbers = numbers;

            Console.WriteLine("All elements starting from first element less than its position:");
            foreach (var n in laterNumbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // OrderBy        
        public void Linq31()
        {
            Console.WriteLine("Linq31");
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortedWords = words;
            ObjectDumper.Write(sortedWords);
            Console.WriteLine();
            Console.WriteLine();
        }
        // OrderByDescending
        public void Linq34()
        {
            Console.WriteLine("Linq34");
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var sortedWords = words;

            ObjectDumper.Write(sortedWords);
            Console.WriteLine();
            Console.WriteLine();
        }
        // OrderBy        
        public void Linq36()
        {
            Console.WriteLine("Linq36");
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            // OrderBy ThenBy
            var sortedWords = words;
                
            //var sortedWords2 =
                

            //var sortedWords3 = sortedWords2

            ObjectDumper.Write(sortedWords);

            //ObjectDumper.Write(sortedWords3);
            Console.WriteLine();
            Console.WriteLine();
        }
        // OrderBy        
        public void Linq38()
        {
            Console.WriteLine("Linq38");
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            
            // OrderBy ThenByDescending 
            var sortedWords = words;
            ObjectDumper.Write(sortedWords);
            Console.WriteLine();
            Console.WriteLine();
        }
        // ToDictionary        
        public void Linq56()
        {
            Console.WriteLine("Linq56");
            var scoreRecords = new[] { new {Name = "Alice", Score = 50},
                                        new {Name = "Bob"  , Score = 40},
                                        new {Name = "Cathy", Score = 45}
                                    };

            var scoreRecordsDict = scoreRecords;
            //Console.WriteLine("Bob's score: {0}", scoreRecordsDict["Bob"]);
            Console.WriteLine();
            foreach (var item in scoreRecordsDict)
            {
               // Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // OfType        
        public void Linq57()
        {
            Console.WriteLine("Linq57");
            object[] numbers = { null, 1.0, "two", 3, "four", 5, "six", 7.0 };
            var doubles = numbers;
            Console.WriteLine("Numbers stored as doubles:");
            foreach (var d in doubles)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // First        
        public void Linq59()
        {
            Console.WriteLine("Linq59");
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var startsWithO = strings;
            Console.WriteLine("A string starting with 'o': {0}", startsWithO);
            Console.WriteLine();
            Console.WriteLine();
        }
        // FirstOrDefault        
        public void Linq61()
        {
            Console.WriteLine("Linq61");
            int[] numbers = { };
            int firstNumOrDefault = 0;
            Console.WriteLine(firstNumOrDefault);
            Console.WriteLine();
            Console.WriteLine();
        }
        // FirstOrDefault
        public void Linq62()
        {
            Console.WriteLine("Linq62");
            List<Product> products = GetProductList();
            //Product product789 = products;
            //Console.WriteLine("Product 789 exists: {0}", product789 != null);
            Console.WriteLine();
            Console.WriteLine();
        }
        // Enumerable.Repeat        
        public void Linq66()
        {
            Console.WriteLine("Linq66");
            // var numbers = ;
            // foreach (var n in numbers)
            // {
            //     Console.WriteLine(n);
            // }
            Console.WriteLine();
            Console.WriteLine();
        }
        // Any Contains
        public void Linq67()
        {
            Console.WriteLine("Linq67");
            string[] words = { "believe", "relief", "receipt", "field" };
            bool iAfterE = words.Any(w => w.Contains("ei"));
            Console.WriteLine("There is a word in the list that contains 'ei': {0}", iAfterE);
            Console.WriteLine();
            Console.WriteLine();
        }
        // All
        public void Linq70()
        {
            Console.WriteLine("Linq70");
            int[] numbers = { 1, 11, 3, 19, 41, 65, 29 };
            bool onlyOdd = numbers.All(n => n % 2 == 1);
            Console.WriteLine("The list contains only odd numbers: {0}", onlyOdd);
            Console.WriteLine();
            Console.WriteLine();
        }
        // Distinct Count
        public void Linq73()
        {
            Console.WriteLine("Linq73");
            int[] primeFactorsOf300 = { 2, 2, 3, 5, 5 };
            int uniqueFactors = primeFactorsOf300.Distinct().Count();
            Console.WriteLine("There are {0} unique prime factors of 300.", uniqueFactors);
            Console.WriteLine();
            Console.WriteLine();
        }
        // Count
        public void Linq74()
        {
            Console.WriteLine("Linq74");
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int oddNumbers = numbers.Count(n => n % 2 == 1);
            Console.WriteLine("There are {0} odd numbers in the list.", oddNumbers);
            Console.WriteLine();
            Console.WriteLine();
        }
        // Sum
        public void Linq78()
        {
            Console.WriteLine("Linq78");
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            double numSum = numbers.Sum();
            Console.WriteLine("The sum of the numbers is {0}.", numSum);
            Console.WriteLine();
            Console.WriteLine();
        }
        // Sum
        public void Linq79()
        {
            Console.WriteLine("Linq79");
            string[] words = { "cherry", "apple", "blueberry" };
            double totalChars = words.Sum(n => n.Length);
            Console.WriteLine("There are a total of {0} characters in these words.", totalChars);
            Console.WriteLine();
            Console.WriteLine();
        }
        // Min
        public void Linq81()
        {
            Console.WriteLine("Linq81");
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int minNum = numbers.Min();
            Console.WriteLine("The minimum number is {0}.", minNum);
            Console.WriteLine();
            Console.WriteLine();
        }
        // Min
        public void Linq82()
        {
            Console.WriteLine("Linq82");
            string[] words = { "cherry", "apple", "blueberry" };
            int shortestWord = words.Min(w => w.Length);
            Console.WriteLine("The shortest word is {0} characters long.", shortestWord);
            Console.WriteLine();
            Console.WriteLine();
        }
        // Max
        public void Linq85()
        {
            Console.WriteLine("Linq85");
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int maxNum = numbers.Max();
            Console.WriteLine("The maximum number is {0}.", maxNum);
            Console.WriteLine();
            Console.WriteLine();
        }
        // Max
        public void Linq86()
        {
            Console.WriteLine("Linq86");
            string[] words = { "cherry", "apple", "blueberry" };
            int longestLength = words.Max(x => x.Length);
            Console.WriteLine("The longest word is {0} characters long.", longestLength);
            Console.WriteLine();
            Console.WriteLine();
        }
        // Average
        public void Linq89()
        {
            Console.WriteLine("Linq89");
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            double averageNum = numbers.Average();
            Console.WriteLine("The average number is {0}.", averageNum);
            Console.WriteLine();
            Console.WriteLine();
        }
        // Average
        public void Linq90()
        {
            Console.WriteLine("Linq90");
            string[] words = { "cherry", "apple", "blueberry" };
            double averageLength = words.Average(w => w.Length);
            Console.WriteLine("The average word length is {0} characters.", averageLength);
            Console.WriteLine();
            Console.WriteLine();
        }
        // Aggregate
        public void Linq92()
        {
            Console.WriteLine("Linq92");
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };
            double product = doubles.Aggregate((runningProduct, nextFactor) 
                => runningProduct * nextFactor);
            Console.WriteLine("Total product of all numbers: {0}", product);
            Console.WriteLine();
            Console.WriteLine();
        }
        // Concat
        public void Linq94()
        {
            Console.WriteLine("Linq94");
            int[] numbersA = { 0, 2, 4, 5, 6, 7, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var allNumbers = numbersA.Concat(numbersB);
            Console.WriteLine("All numbers from both arrays:");
            foreach (var n in allNumbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // SequenceEqual
        public void Linq96()
        {
            Console.WriteLine("Linq96");
            var wordsA = new string[] { "cherry", "apple", "blueberry" };
            var wordsB = new string[] { "cherry", "apple", "blueberry" };
            bool match = wordsA.SequenceEqual(wordsB);
            Console.WriteLine("The sequences match: {0}", match);
            Console.WriteLine();
            Console.WriteLine();
        }
        // SequenceEqual
        public void Linq97()
        {
            Console.WriteLine("Linq97");
            var wordsA = new string[] { "cherry", "apple", "blueberry" };
            var wordsB = new string[] { "apple", "blueberry", "cherry" };

            bool match = wordsA.SequenceEqual(wordsB);

            Console.WriteLine("The sequences match: {0}", match);
            Console.WriteLine();
            Console.WriteLine();
        }





        private List<Customer> customerList;
        public List<Customer> GetCustomerList()
        {
            if (customerList == null)
                createLists();

            return customerList;
        }
        private void createLists()
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