using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saklaso_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ///savarjisho 1


            int[] nums = { 52, -16, 48, -2, -89, 31, 9, -12 };

            foreach (int num in nums)
            {

                if (num > 0)
                {
                    Console.WriteLine(num);
                }

            }

            ///savarjisho 1 (end)



            ///savarjisho 2


            int[] numbers = { 11, 42, 53, 2, 12, 62, 8, 92, 65, 22 };

            int patara = 0;
            int didi = 0;

            foreach (int num in numbers)
            {

                if (num < patara)
                {
                    patara = num;
                }

                if (num > didi)
                {
                    didi = num;
                }

            }

            Console.WriteLine($"didi ricxvia : {didi}");
            Console.WriteLine($"patara ricxvia ; {patara}");



            int[] numbers2 = { 11, 42, 53, 2, 12, 62, 8, 92, 65, 22 };



            int smallrixvi = 0;
            int bigricxvi = 0;

            foreach (int num1 in numbers2)
            {

                if (num1 < smallrixvi)
                {
                    smallrixvi = num1;
                }

                if (num1 > didi)
                {
                    bigricxvi = num1;
                }

            }

            Console.WriteLine($"udidesi ricxvia : {bigricxvi}");
            Console.WriteLine($"yvelaze patara ricxvia  : {smallrixvi}");
            ///savarjisho 2 (end)









            ///savarjisho 3

            int[] numbers3 = { 145, 21, 43, 75, 32, 15, 48, 65, 125, 68 };

            Array.Sort(numbers3);
            Console.WriteLine("zrdadi tanmimdevroba :");

            foreach (int item in numbers3)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();


            Array.Reverse(numbers3);
            Console.WriteLine("klebadi tanmimdevroba : ");
            foreach (int num in numbers3)
            {
                Console.Write(num + " ");
            }

            ///savarjisho 3 (end)








            ///savarjisho 4 

            string[] strs = { ".com", ".net", "hsNameA.com", "hsNameB.net", "test" };
            Console.WriteLine("saitebi .net donmenit :");

            foreach (string site in strs)
            {
                if (site.EndsWith(".net"))
                    Console.WriteLine(site);
            }



            string[] str1 = { ".com", ".net", "hsNameA.com", "hsNameB.net", "test" };
            Console.WriteLine("sitebi com donmenit :");

            foreach (string site2 in str1)
            {
                if (site2.EndsWith(".com"))
                    Console.WriteLine(site2);
            }

            ///savarjisho 4 (end)



            ///savarjisho 5 



            double[] nums123 = { -10.0, 16.4, 12.125, 100.85, -2.2, 25.25, -3.5 };
            Console.WriteLine("davbechdot yvela dadebiti ricxvis  kvadratuli fesvi :");

            foreach (double doublenum in nums123)
            {
                if (doublenum > 0)
                {
                    double squre = Math.Sqrt(doublenum);
                    Console.WriteLine($" square root of  {doublenum} : {squre:F4}");
                }
            }


            ///savarjisho 5 (end)





            ///savarjisho 6


            string[] websites =
            {
            "hsNameA.com", "hsNameB.net", "hsNameC.net",
            "hsNameD.com", "hsNameE.org", "hsNameF.org",
            "hsNameG.tv", "hsNameH.net", "hsNameI.tv"
            };


            Console.WriteLine("davbechdot mxolod donmain mnishvnelobebi : ");


            foreach (string site123 in websites)
            {

                int doIndex = site123.IndexOf(".");
                if (doIndex >= 0)
                {
                    string domainname = site123.Substring(0, doIndex);
                    Console.WriteLine(domainname);
                }
            }


            ///savarjisho 6 (end)



            ////7 savarjisho 



            int input;

            if (int.TryParse(Console.ReadLine(),out input) && input >0)
            {
                int[] arr77 = new int[input];
                Random rand = new Random();

                for (int i = 0; i < arr77.Length; i++)
                {

                    arr77[i] = rand.Next(-100, 101);
                }

                Console.WriteLine("random ricxvi :");
                foreach (int item in arr77)
                {
                    Console.WriteLine(item + " ");
                }
            }

         else
            {
                Console.WriteLine("you done it");
            }




            /// 7 savarjisho (end)

        }
    }
}
