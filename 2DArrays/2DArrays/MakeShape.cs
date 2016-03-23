using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArrays
{
     class MakeShape
    {
        List<List<string>> List = new List<List<string>>();


        public MakeShape(int numbOfStars)
        {
            
            for (int outerLoop = 0; outerLoop <= numbOfStars; outerLoop++)
            {
                List.Add(new List<string>());

                for (int innerLoop = 0; innerLoop <= outerLoop; innerLoop++)
                {
                    List[outerLoop].Add("*");
                }
            }
        }

        public void PrintPattern()
        {
            for (int outerLoop = 0; outerLoop < List.Count; outerLoop++)
            {
                Console.WriteLine();
                for (int innerLoop = 0; innerLoop < outerLoop + 1; innerLoop++)
                {
                    Console.Write(List[outerLoop][innerLoop]);
                }
            }
        }
    }
}
    


