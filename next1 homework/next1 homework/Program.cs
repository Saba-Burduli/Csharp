using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace next1_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<login> list = new List<login>()
            {
                new login() { getname = "saba", getlastname = "burduli", getUsername = "ComicSolvency", getage = 15 , activestatus = false },
                new login() { getname = "giorgi", getlastname = "grigalashvili", getUsername = "Grishki,grigoli", getage = 15 , activestatus = true },
                new login() { getname = "lika", getlastname = "Kharkheli", getUsername = "lia kharkeli", getage = 15 ,activestatus =true },
                new login() { getname = "nika", getlastname = "kbilcecxlashvili", getUsername = "Nikoloz Kbilcecxlashvili", getage = 15 ,activestatus = false },
                new login() { getname = "daviti", getlastname = "axraxadze", getUsername = "kiwaa", getage = 15 ,activestatus = true },
            };




            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);

            List<login> list2 = new List<login>()
             {
                 new login(){getname = "nika", getlastname = "burduli", getage = 15},
                 new login(){getname = "tamari", getlastname = "samxaradze", getage = 15},
                 new login(){getname = "mate", getlastname = "grigalashvili", getage = 16},
             };

            funqciebi funq = new funqciebi();


            login person = new login()
            {

                getname = Console.ReadLine(),
                getlastname = Console.ReadLine(),
                getUsername = Console.ReadLine(),
                getage = int.Parse(Console.ReadLine())
            };

            funq.addpersoninsistem(person, list);


            for (int i = 0; i < list.Count; i++)
            {

                Console.WriteLine($" name - {list[i].getname} lastname - {list[i].getlastname}    Username - {list[i].getUsername}   age - {list[i].getage}  ");

            }


            for (int i = list.Count -1; i>=0; i--)
            {
                if (!list[i].activestatus) { 
                
                list.RemoveAt(i);   
                
                
                }

            }


            foreach ( var item in list)
            {
                if(item.getname == "daviti" )
                {
                    item.getname = Console.ReadLine();
                    item.getlastname = Console.ReadLine();
                    item.getUsername = Console.ReadLine();  
                    item.getage = int.Parse(Console.ReadLine());   
                }

             

            Console.WriteLine($" name - {item.getname} , lastname -  {item.getlastname} , username - {item.getUsername} , age - {item.getage}");
            }






        }
    }
}


