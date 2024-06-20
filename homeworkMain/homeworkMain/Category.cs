using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace homeworkMain
{
    internal class Category : Product
    {


        public string ManufacturerName { get; set; } //mwarmoebelis saxeli

        public string CategoryName { get; set; }  //kategoris saxeli





        public override string PrintMethod()
        {




            return base.PrintMethod() + $" ManufacturerName : {ManufacturerName}  -   CategoryName : {CategoryName}   ";
        }




        public override void search()
        {
            base.search();
            Console.WriteLine("search category and ProductName :");
            Category = Console.ReadLine();
            ProductName = Console.ReadLine();  
        }
























    }





}
