using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barks
{
    class ListChecker
    {
        List<string> List = new List<string>();
        string input;
        public void ListValueChecker()
        {
            

            List.Add("");
            while(input != "name")
            {
            for(int indexer = 0; indexer < List.Count; indexer++)
            {
                    Console.WriteLine("Enter a word...");
             
                           input = Console.ReadLine();
            
            if(List[indexer].Contains(input))
            {
                        Console.WriteLine("Bark! This word already exists homie.");
            }
            else
            {
                      
                        Console.WriteLine("Stored.");
                        List[indexer] += input;
            }
            }
            }
            Console.ReadLine();
        }
    }
}
