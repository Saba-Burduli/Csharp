using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projtest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] ints = { 1, 2, 3 };   


            for (int i = 0; i < ints.Length; i++) {
            
            if (ints[i] == ints.Length) {

                    Console.WriteLine(ints[i]); 
                
                }
            
            }
           
        }
    }
}
