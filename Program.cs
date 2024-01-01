//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace List_and_Dictionary_Assingment
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Dictionary<string, int> myDictionary = new Dictionary<string, int>();


//            myDictionary.Add("Apple", 10);
//            myDictionary.Add("Banana", 5);
//            myDictionary.Add("Orange", 8);


//            Console.WriteLine("Number of Apples: " + myDictionary["Apple"]);
//            Console.WriteLine("Number of Bananas: " + myDictionary["Banana"]);
//            Console.WriteLine("Number of Oranges: " + myDictionary["Orange"]);


//            if (myDictionary.ContainsKey("Grapes"))
//            {
//                Console.WriteLine("Number of Grapes: " + myDictionary["Grapes"]);
//            }
//            else
//            {
//                Console.WriteLine("Grapes are not in the dictionary.");
//            }


//            Console.WriteLine("\nAll Fruits in Dictionary:");
//            foreach (var fruits in myDictionary)
//            {
//                Console.WriteLine(fruits.Key + ": " + fruits.Value);
//            }
//            Console.ReadLine();
//        }


//    }
//}
