using System;

namespace hw2
   
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 6-значное число:  ");
            string var = Console.ReadLine();

            if (var.Length == 6)
            {
                int i = 0;
                int first = 0;
                int second = 0;

                foreach (char num in var) // дробим стринг на чары(строку на буквы)
                {
                    int j = Convert.ToInt32(num);

                   // Console.WriteLine(j);
                    if (i < 3)
                    {
                        first += j;
                        
                    }
                    else
                    {
                        second += j;
                        //Console.WriteLine(second);
                    }
                    i++;
                }
                Console.WriteLine((first == second) ? "lucky" : "unlucky");
            }
            else 
            { 
                Console.WriteLine("uevoe znachenie"); 

            } Console.ReadLine();
        } 
    } 
} 
