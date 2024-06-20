using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> list = new List<Category>() {

             new Category()
            {
                ProductName = "Iphone 15",
                Quantity = 1500,
                Price = 3999,
                Category = "Phone",
                ManufacturerName = "apple",
                CategoryName = "tech"


            },

           

                new Category()
            {

                ProductName = "redmi 10",
                Quantity = 3000,
                Price = 700,
                Category = "Phone",
                ManufacturerName = "Xiaomi",
                CategoryName = "tech"


            }

            
        };


            foreach (var item in list) {

            Console.WriteLine(item.PrintMethod()); 
                

            }
       
            var target = list; 

            int index = 0;

            bool found = false;

            while (index < list.Count  && !found) {


                if (list[index] == target) {
                
                found = true;
                    Console.WriteLine( target + "found" + index);
                
                }
                index++;
            
            
            }

            if (!found) { 
            
            Console.WriteLine("this product is not");    
            
            }


        }
    }
}
