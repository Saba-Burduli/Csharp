using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saklaso_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("vitamashot tamashi jeirani :");

            Console.WriteLine("wesebi :");

            Console.WriteLine("motamasheebi: User and Computer.");

            Console.WriteLine("tamashis main teqsti: tamashi grdzeldeba manamde sanam motamashe ar daagrovebs 3 qulas");

            int userQulebi = 0; 
            int compiuterqulebi = 0;    

            Random random = new Random();


            while (userQulebi< 3 && compiuterqulebi <3) {

                Console.WriteLine("airchie : (cha , tavsaxuri , makrateli)");
                string usergadawyvetileba = Console.ReadLine().ToLower();//es methodi nishnavs didi asoebis dapataravebas  


                ///davagenerirot  kompiuteris  archevani 

                string[] choises = { "cha", "tavsaxuri" , "makrateli" };
                string compiuterarchevani = choises[random.Next(choises.Length)];

                Console.WriteLine($"kompiuteris archevani : {compiuterarchevani}");



                ///gamovavlinot gamarjvebuli 


                if (usergadawyvetileba == compiuterarchevani)
                {
                    Console.WriteLine("frea");
                }

                else if ((usergadawyvetileba == "cha" && compiuterarchevani == "makrateli") ||
                    (usergadawyvetileba == "tavsaxuri" && compiuterarchevani == "cha") ||
                    (usergadawyvetileba == "makrateli" && compiuterarchevani == "tavsaxuri")
                    )
                {
                    Console.WriteLine("shen moige es raundi gilocav !!!");
                    userQulebi++;
                }


                else {
                    Console.WriteLine("kompiuterma moigo es raundi");
                    compiuterqulebi++;  
                
                }
                Console.WriteLine($"motamashis qulebi : {userQulebi} . compiuteris qulebi : {compiuterqulebi} .");

                if (userQulebi == 3)
                {

                    Console.WriteLine("yochag shen moige es tamashi");


                }


                else 
                {
                    Console.WriteLine("shemdegshi gagimartlebs araushavs . compiuterma mogigo");
                }
                    

                Console.WriteLine("madloba rom itamashe es tamashi . warmatebebi");


            }
         
        }
    }
}
