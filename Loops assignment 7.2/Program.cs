using System.Security.Principal;

namespace Loops_assignment_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("I will now count down from 10!");



            //for (int i = 10; i >= 1; i = i - 1)
            //{
            //    Console.WriteLine(i + ". " );
            //}
            //Console.WriteLine("Blast Off");

            //Console.WriteLine();

            //Console.WriteLine("X    Y");
            //for (int i = -10; i <= 10; i = i + 2)

            //{
            //    Console.WriteLine(i + " " + " " + i * i);
            //}


            string name;
            Console.WriteLine("Give me a name and i'll type it 10 times!");
            name = Console.ReadLine();
            

            for (int i = 1; i <= 10; i = i + 1)
            { 
                Console.WriteLine(i + ". " + name);
      
            }
            
            {
                if (name == "aldworth")
                {
                    for (int i2 = 1; i2 <= 5; i2 = i2 + 1)

                        Console.WriteLine(i2 + ". " + "aldworth");
                }
            
                {

                }
            }
            }
        }
            }
        
    

