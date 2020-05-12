using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblem
{
    class ListOfWords
    {

        //Member Variables (HAS A)
        public String words;

        //Constructor
        public void returnWords()
        {
            //// Using LINQ, write a function that returns alll words that contains the substring "th" from a list 
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var newWord = words.Where(m => m.Contains("th"));

            
        }

        public void withoutDuplicates ()
        {////Using LINQ, write a function that takes in a list of strings and returns a copy of the list without duplicates.
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var results = names.Remove()

        }
    }
        //Member Methods (CAN DO)





    
}
