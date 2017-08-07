using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterativeAndRecursive
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreePermutations();

            DepartmentPermutations();

        }

        // problem solving 
        // permutations, the of which they com in
        //attacking the iterative method of program problem solving

        public static void ThreePermutations()
        {
            for (var i = 0; i <= 9; i++)
            {
                for (var x = 0; x <= 9; x++)
                {
                    for (var y = 0; y <= 9; y++)
                    {
                        string iVar = i.ToString();
                        string xVar = x.ToString();
                        string yVar = y.ToString();

                        Console.WriteLine(iVar + xVar + yVar);
                    }
                }
            }
        }


        // assign a number to three departments
        // - fire
        // - police
        // - sanitation
        // Each assigned a number in the range of 1 - 7 
        // Each number for all departments have to be different
        // all department numbers combined need to be the sum of 12
        // police number has to be even every time

        public static void DepartmentPermutations()
        {
            for (var fire = 1; fire <= 7; fire++)
            {
                for (var police = 1; police <= 7; police++)
                {
                    for (var sanitation = 1; sanitation <= 7; sanitation++)
                    {
                        if ((fire != police) &&
                            (fire != sanitation) &&
                            (police != sanitation) &&
                            (fire + police + sanitation == 12) &&
                            (police % 2 == 0))
                        {
                            string fireVar = fire.ToString();
                            string policeVar = police.ToString();
                            string sanitationVar = sanitation.ToString();

                            Console.WriteLine(fireVar + policeVar + sanitationVar);
                        }
                    }
                }
            }
        }



    }
}
