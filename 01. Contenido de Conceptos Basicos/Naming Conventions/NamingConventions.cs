using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naming_Conventions
{
    internal class NamingConventions
    {
        /* Naming Conventions
 
         * PascalCase 
         * camelCase 
         * UPPERCASE
         * Prefixes
         * Plurals
         * Verb-Noun Pairs
         * Nombres Significativos y entendibles
         
        */

        public class MyClass // PascalCase // For Classes // Nombres Significativos y entendibles
        {
            private int myCoolAge; // camelCase // For fields // Nombres Significativos y entendibles
            public string MyAmazingProperty { get; set; } // PascalCase // For Properties // Nombres Significativos y entendibles

            List<string> fruits = new List<string>(); // Plurals // For collections and Arrays // Nombres Significativos y entendibles

            public MyClass(string propertyValue)
            {
                MyAmazingProperty = propertyValue;
            }

            public static int AddNumbers(int a, int b) // PascalCase // For Methods // Nombres Significativos y entendibles
            {
                return a + b;
            }

            public void Print(string contentText) // camelCase // For Parameters // Nombres Significativos y entendibles
            {
                string myText = ""; // camelCase // For Variables // Nombres Significativos y entendibles
                Console.WriteLine(myText);
            }

            public void OnCLick() // For Methods // PascalCase + Verb-Noun Pairs // Nombres Significativos y entendibles
            {

            }

            public string GetResult(int input) // For Methods // PascalCase + Verb-Noun Pairs // Nombres Significativos y entendibles
            {
                int result = input * 2;
                return "The result is: " + result;
            }

            public void ProcessData(List<int> data) // For Methods // PascalCase + Verb-Noun Pairs // Nombres Significativos y entendibles
            {
                int sum = 0;

                foreach (int value in data)
                {
                    sum += value;
                }
            }
        }

        public struct MyScruct // PascalCase // For Structs // Nombres Significativos y entendibles
        {
            public int FirstNumber { get; set; }
            public int SecondNumber { get; set; }

            public MyScruct(int firstNumber, int secondNumber)
            {
                FirstNumber = firstNumber;
                SecondNumber = secondNumber;
            }
        }

        interface IPaymentStrategy // Prefixes // I-indicates that it is an Interface // Nombres Significativos y entendibles
        {

        }
    }
}
