using System;

namespace ConsoleApp1
{
    class Program
    {
        private static object exit;

        static void Main(string[] args)
        {
            //take input
            string input;
            int n;
            Console.WriteLine("Enter integer for the number pattern of integers to be displayed ");
            input = Console.ReadLine();
            
            try
            {
                n = int.Parse(input);
                // n = Integer.parseInt(String i);
                //n = Convert.ToInt32(input);
                bool stopProgram = false;

                while (stopProgram == false)
                {
                    if (n > 0)
                    {
                        //int n = 6;
                        int b = 0;
                        int x = 1;
                        for (int i = 1; n != 0; i++)
                        {
                           
                            //Console.WriteLine("b value:" + b);
                            //Console.WriteLine("i value:" + i);
                            int c = b + i;
                            Console.Write(c + ",");
                            b = c;
                            n--;
                            x++;
                            if (n == 1)
                            {
                                //Console.WriteLine("b value:" + b);
                                //Console.WriteLine("x value:" + x);
                                // int d = c+x;
                                //Console.Write(d);
                                int e = b + x;
                                Console.Write(e);
                                n--;
                            }
                            }
                        stopProgram = true;

                    }
                    else
                    {
                        Console.Write("Kindly enter a valid positive integer value.Exiting the application");
                        stopProgram = true;
                    }

                }
            }
            catch
            {
                Console.WriteLine(
                    $"The entered { input } is not a valid input format.");
                // result = 1;
            }




        }
    }
}
