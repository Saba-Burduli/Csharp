using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sashinao_2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Random random = new Random();
            int chaifiqreRicxvi = random.Next(1,31);




            Console.WriteLine("mogesalmebit chvens axal tamashsi sadac tkven unda chaifiqrot ricxvi 1 dan 30 mde .amistvis ki geqnebat 3  cda (warmatebebs gisurvebt ! <3)");
            Console.WriteLine("avirchie ricxvi . exla ki gamoicani");


            for (int mcdeloba = 1; mcdeloba <= 3; mcdeloba++)
            {
                Console.WriteLine($"archevani sheacheret {mcdeloba}: chaweret tkveni savaraudo ricxvi  :");
                int motamashisricxvi = int.Parse( Console.ReadLine() ); 
                if (motamashisricxvi == chaifiqreRicxvi)
                {
                    Console.WriteLine("yochag shen gamoicani es ricxvi. gilocav");
                    break;
                }

                else if (motamashisricxvi > chaifiqreRicxvi)
                {
                    Console.WriteLine("minishneba  :  sheni aricheuli ricxvi metia chafiqrebul ricxvze ");

                }



                else {
                    Console.WriteLine("sheni chafiqrebuli rixvi naxlebia shen gamocnobil ricxvze");
                }




                Console.WriteLine($"kompiuteris mier chafiqrebuli ricxvi iyo {chaifiqreRicxvi}");
                Console.WriteLine("madloba tamashistvis");










                Random randomnumber = new Random();
                int guessnumber = random.Next(7,8); 


                Console.WriteLine("mogesalmebit . vitamashot chveni axali tamashi . tkven unda gamoicnot ramdenjer akvs mogebuli f1 wc mogebuli yveladrois saukekeso pilots lewis hamiltons :");
                Console.WriteLine("amistvis tkven geqnebat 1 shansi . warmatebebs gisurvebt");


                for (int attempt =1; attempt<=1;)
                {
                    Console.Write($"cda 1 : {attempt} . chawere sheni archeuli ricxvi");
                    int motamahisarchevani = int.Parse( Console.ReadLine() );   

                    if (motamahisarchevani == guessnumber)
                    {
                        Console.WriteLine($"swori xar ! lewis hamiltoni {guessnumber} jer aris msoflio chempioni");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("shen araswori xar lewis hamitoni 7 gzis msoflio chempionia");
                    }

                }












            }


        }
    }
}
