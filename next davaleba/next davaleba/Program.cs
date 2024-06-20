using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace next_davaleba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = 0;    
            int max = 128;    

            for (int i = min; i < max; i++)
            {


                char c = (char)i;
                string display = string.Empty;
                if (char.IsWhiteSpace (c))
                {
                    display = c.ToString ();

                    switch (c) {
                    
                    case 't':
                            display = "t";
                            break;


                        case ' ':
                            display = "space"; 
                            break;  


                            case 'n':
                            display = "n";
                            break;  

                            case 'r':
                            display = "r";
                            break;  

                            case 'v':
                            display = "v";
                            break;  

                            case 'f':
                            display = "f";  
                            break;  
                    }


                }

                else if (char.IsControl (c)) { 
                

                    display = "control";
                
                }

                else {

                    display = c.ToString();    
                
                }



                Console.WriteLine (i.ToString().PadRight(10));
                Console.WriteLine (display.PadRight(10));
                Console.WriteLine(i.ToString("X2"));
                Console.WriteLine();

            }



        }
    }
}
