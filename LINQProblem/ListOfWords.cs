using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblem
{
    class ListOfWords 
    {

        //Member Variables (HAS A)
       // public string words;

        //Constructor
        public void returnWords()
        {
            //// Using LINQ, write a function that returns alll words that contains the substring "th" from a list 
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var Words = from word in words
                         where word.Contains("th")
                          select word;
            foreach(var word in Words)
            {
                Console.WriteLine(word);
            }

            
            Console.ReadLine();
            
        }

        public void withoutDuplicates()
        {////Using LINQ, write a function that takes in a list of strings and returns a copy of the list without duplicates.
            var names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var Nm = names.Distinct();
                        


            foreach (string name in Nm)
            {
                Console.WriteLine(name);
            }



            Console.ReadLine();

        }

        //Using LINQ, write a function that calculates the class grade average after dropping the lowest grade for each student.
        //The function should take in a list of strings of grades (e.g., one string might be "90,100,82,89,55"), 
        //drops the lowest grade from each string, averages the rest of the grades from that string, then averages the averages.
        public void CalculateGradeDropLow()
        {
            	int[] classGrades = { 80, 100, 92, 89, 65 , 93,81,78,84,69, 73,88,83,99,64, 98,100,66,74,55};

            double result = classGrades.OrderByDescending(x => x).Take(classGrades.Count()-4).Average();
            
            
                Console.WriteLine(result);
            

            Console.ReadLine();

        }

        public void LetterFrequency()
        {
            string name = "Terrill";
            
            int[] count = new int[(int)char.MaxValue];
            foreach (var item in name)
            {
                count[(int)item]++;
            }
            for (int i = 0; i < (int)char.MaxValue; i++)
            {
                if (count[i]> 0 && char.IsLetterOrDigit((char)i))
                {
                    Console.WriteLine("{0} {1}", (char)i, count[i]);
                }
         
            }Console.ReadLine();
        }


    }
    //Member Methods (CAN DO)






}
