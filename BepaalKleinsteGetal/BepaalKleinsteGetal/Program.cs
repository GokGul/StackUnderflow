using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BepaalKleinsteGetal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm back bitches!");
            bool loop = true;

            while (loop){
                int result;
                List<int> Numbas = new List<int>();

                Console.WriteLine("Gimme some numbas!");

                int i = 1;
                while (i <= 10)
                {
                    Console.WriteLine("Numba " + i);

                    if (int.TryParse(Console.ReadLine(), out result))
                    {
                        Numbas.Add(result);
                        i++;

                        if (i == 11)
                        {
                            Console.WriteLine("Smallest numba: " + getSmallest(Numbas));

                            loop = AskForExit();
                        }
                    }
                    else
                    {
                        Console.WriteLine("That ain't no numba nigga!");
                    }
                }
            }
        }

        private static bool AskForExit()
        {
            bool loop = true;

            while (loop) {
                Console.WriteLine("Does yo ass wanna exit now? Y/N");
                string choice = Console.ReadLine();

                if (choice.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    loop = false;
                    Console.WriteLine("Bye bitch..");
                }
                else if (choice.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Here we go again..");
                }
                else
                {
                    Console.WriteLine("WTF, use your eyes to read idiot.");
                }
            }

            return loop;
        }

        private static int getSmallest(List<int> n)
        {
            int smallest =100;

            for (int i = 1; i<=n.Count; i++)
            {
                //Console.WriteLine("N= " + n.Count + " i= " + i);
                if (smallest > n[i-1])
                {
                    //Console.WriteLine(n[i-1]);
                    smallest = n[i-1];
                }
            }

            return smallest;
        }
    }
}
