using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkMain
{
    internal class Product
    {


        public string ProductName { get; set; }

        public int Quantity { get; set; }  

        public int Price { get; set; }

        public string Category { get; set; }





        public virtual  string PrintMethod()
        {
            return $"ProductName :  {ProductName} -  Quantity : {Quantity} -  Price : {Price}  -  Category : {Category}  "; 
        }


        public virtual void search() {


            //category search
            Console.WriteLine("enter category :  ");


            Category = Console.ReadLine();



            //productsname search
            Console.WriteLine("enter  ProductName : ");

            ProductName = Console.ReadLine();


        }
        
    }
}
