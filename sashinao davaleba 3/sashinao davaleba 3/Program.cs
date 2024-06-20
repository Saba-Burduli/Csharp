using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sashinao_davaleba_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           


       
                Console.Write("Enter a single number: ");
                int target = int.Parse(Console.ReadLine());

               
                int[] saba = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

               
                for (int i = 0; i < saba.Length; i++)
                {
                    for (int j = i + 1; j < saba.Length; j++)
                    {
                        if (saba[i] + saba[j] == target)
                        {
                            Console.WriteLine($"Pair found: {saba[i]} and {saba[j]}");
                        }
                    }
                }















            Console.WriteLine("sheiyvane sheni ricxvi ");
            
            int targetsum = int.Parse(Console.ReadLine());
            int[] sabasum = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for(int i = 0;i < sabasum.Length; i++)
            {

                for(int j = i + 1;j<sabasum.Length; j++)
                {
                    if (sabasum[i] + sabasum[j] == targetsum)
                    {
                        Console.WriteLine($"sheni wyvili napovnia : {sabasum[i]} da {sabasum[j]}");
                    }
                }



            }











            Console.WriteLine("sheiyvane sheni rixvi :");
            int sheyvanilirixvi = int.Parse(Console.ReadLine());

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            
            for(int i = 0; i <numbers.Length; i++)
            {
                for (int j = i + 1;j<numbers.Length ; j++)
                {
                    if (numbers[i] + numbers[j] ==sheyvanilirixvi)
                    {
                        Console.WriteLine($"modzebnili wyvilia : {numbers[i]} da {numbers[j]}");
                    }
                }
            } 

































            }
        }

    }

