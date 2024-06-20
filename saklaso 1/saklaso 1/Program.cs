using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saklaso_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// savarjisho 1 


            Console.WriteLine("sheiyvane sheni  cifri :");
            double nomeri = Convert.ToDouble(Console.ReadLine());

            if (nomeri > 0)
            {
                Console.WriteLine(" aris dadebiti ricvi");

            }

            else if (nomeri < 0) {
                Console.WriteLine("es ricxvi aris uaryofiti");
            } 
            else{
                Console.WriteLine("es ricxvi aris 0");
            }

            /// savarjisho 1 (end)

            ///savarjisho 2 


            Console.WriteLine("sheiyvalet tkeveni wlovaneba :");
            int saba = Convert.ToInt32(Console.ReadLine());
            if (saba >= 18)
                Console.WriteLine("warmatebuli registracia !");

            else
            {
                Console.WriteLine("tkveni asakistvis es platforma araris");
            }
            ///savarjisho 2 (end)




            ///savarjisho 4 
            
            Console.WriteLine("sheiyvanet tkveni ricxvi :");
            double sabasnumber =double.Parse(Console.ReadLine());   

            if (sabasnumber == 63)
            {
                Console.WriteLine("es aris yvelaze didi ricxvi da aris sididit n1");
            }
            else if (sabasnumber==25) {
                Console.WriteLine("es aris rigit meore yvelaze didi ricxvi");

              
            
            }

            else if (sabasnumber==10)
            {
                Console.WriteLine("es aris rigit n3 ricxvi sididit");

            }


            else {

                Console.WriteLine("default");
            
            }

            ///savarjosho 4 (end)


            ///savarjisho 5 
            
            Console.WriteLine("chaweret kviris dgeebi cifrebit (mag : 1 = orshabati)");
double kvirisdgeebi = Convert.ToDouble(Console.ReadLine());
            
           switch(kvirisdgeebi)
            {
                    case 1:
                    Console.WriteLine("orshabati");
                    break;  

                    case 2: Console.WriteLine("samsabati");
                    break;

                    case 3: Console.WriteLine("otxshabati");
                    break;

                    case 4: Console.WriteLine("xutshabati");
                    break;

                    case 5: Console.WriteLine("paraskevi");
                    break;

                    case 6: Console.WriteLine("shabati");
                    break;

                    case 7: Console.WriteLine("kvira");
                    break;

                    default:Console.WriteLine("sheiyvane kviris dge :");
                    break;
            }
            Console.WriteLine($"dges aris {kvirisdgeebi}");

            ///savarjisho 5 (end)





            /// savarjisho 6 

            Console.Write("sheiyvanet : ");
            int Number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("chaweret meore: ");
            int Number2 = Convert.ToInt32(Console.ReadLine());

            int Result;

            if (Number1 == Number2)
            {
                Result = 3 * (Number1 + Number2);
            }
            else
            {
                Result = Number1 + Number2;
            }

            Console.WriteLine($"The result is: {Result}");

            /// savarjisho 6 (end)
        }
    }
}
