using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab21
{
    internal class Program
    {
         static void Main(string[] args)
        {
           int[,] arr = { { 1, 1, 1, 1, 1, }, { 1, 1, 1, 1, 1 } };
           
            ThreadStart threadStart = new ThreadStart(Gardener1);
            Thread thread = new Thread(threadStart);
            thread.Start();
            Gardener2();
            PrintArray();
            Console.ReadKey();



            void Gardener1()
            {

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (arr[i, j] >= 1)
                        {
                            arr[i, j] = -1;
                            Thread.Sleep(1);
                        }
                    }
                }
            }

            void Gardener2()
            {

                for (int j = 4; j >= 0; j--)
                {
                    for (int i = 1; i >= 0; i--)
                    {
                        if (arr[i, j] >= 1)
                        {
                            arr[i, j] = -2;
                            Thread.Sleep(1);
                        }
                    }
                }
            }

            void PrintArray()
            {

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        
                            Console.Write(arr[i,j] + " "); 
                    }
                    Console.WriteLine();
                }
            }
        }

        
    }
}
