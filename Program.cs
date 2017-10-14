using System;
using System.Linq;
// Just Testing Git
namespace BTD
{
    public class Program
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Converter Binario para Decimal By NERD-X");
            Translation();
        }
        public static void Translation()
        {
                bool running = true;
                bool result = true;

                while (running) 
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Binario: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    string bin0 = Console.ReadLine().Trim();

                    if (bin0.ToLower()== "exit")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Cya later m8.");
                        Console.ForegroundColor = ConsoleColor.White;
                        running = false;
                        break;
                    }
                    
                    else 
                    {
                        Char[] targetbin = bin0.ToCharArray();
                        int loop = targetbin.Length;
                        Array.Reverse(targetbin);
                        double[] numbers = new double[loop];

                        for (int i = 0; i < loop; i++)
                        {
                            numbers[i] = 0;
                        }

                        for (int i = 0; i < loop; i++)
                        {
                    
                            string nums = targetbin[i].ToString();
                            if (nums == "1")
                            {
                                double i2 = Math.Pow(2,i);
                                numbers [i] = i2;
                                result = true;
                            }
                            else if (nums == "0")
                            {
                                result = true;
                                continue;
                            }
                            else 
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Input Invalido.");
                                result = false;
                                break;
                            }

                        }
                        if (result) 
                        {
                            double Resultado = numbers.Sum();

                            Console.ForegroundColor = ConsoleColor.Green; 
                            Console.Write("Resultado: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(Resultado);
                            Console.WriteLine(""); 
                        }
                        else 
                        {
                            continue;
                        }

                    }

                }
        }
    }
}
