using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace damatebiti_savarjisho
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            string text = "efgfoe uif fbtu xbmm pg uif dbtumf";
            string shipri = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    shipri += text[i];
                }
                else
                {
                    shipri += (char)(text[i] - 1);

                }

            }
            Console.WriteLine(shipri);


            Console.WriteLine((char)219);


            string text2 = "efgfoe uif fbtu xbmm pg uif dbtumf";
            string shifri2 = "";
            for (int i = 0; i < text2.Length; i++)
            {
                if (text2[i] == ' ')
                {
                    shifri2 += text2[i];
                }
                else
                {

                    shifri2 += (char)(text2[i] - 1);
                }
            }
            Console.WriteLine(shifri2);


            string text3 = "efgfoe uif fbtu xbmm pg uif dbtumf";
            string shifri3 = "";
            for (int i = 0; i < text3.Length; i++)
            {
                if (text3[i] == ' ')
                {
                    shifri3 += text3[i];

                }

                else
                {
                    shifri3 += (char)(text3[i] - 1);
                }
            }
            Console.WriteLine(shifri3);




            string text4 = "efgfoe uif fbtu xbmm pg uif dbtumf";
            string shifri4 = "";

            for (int i = 0; i < text4.Length; i++)
            {
                if (text4[i] == ' ')
                {
                    shifri4 += text4[i];
                }

                else
                {

                    shifri4 += (char)(text4[i] - 1);



                }
                Console.WriteLine(shifri4);








                string text5 = "efgfoe uif fbtu xbmm pg uif dbtumf";
                string shifri5 = "";


                for (int j = 0; j < text5.Length; j++)
                {
                    if (text5[j] == ' ')
                    {
                        shifri5 += text5[j];

                    }

                    else
                    {

                        shifri5 += (char)(text5[j] - 1);


                        Console.WriteLine(shifri5);



                    }



                }


               
            }






            string text10 = "efgfoe uif fbtu xbmm pg uif dbtumf";
            string shifri10 = "";



            for(int i = 0;i < text10.Length;i++)
            {
                if (text10[i] == ' ')
                {
                    shifri10 += text10[i];

                }

                else {

                    shifri10 += (char)(text10[i] - 1);
                
                }


               
            }
            Console.WriteLine(shifri10);





            string textsaba = "efgfoe uif fbtu xbmm pg uif dbtumf";
            string shifrisaba = ""; 

            for(int S  = 0; S<textsaba.Length; S++) { 
            
            if (textsaba[S] == ' ')
                {
                    shifrisaba += textsaba[S]; 

                }

            else
                {
                    shifrisaba += (char)(textsaba[S] - 1);
                }
            
            }

            Console.WriteLine(shifrisaba);  
        }
    }
}

