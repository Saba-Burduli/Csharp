using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace davaleba_next
{
    internal class Program
    {
        static void Main(string[] args)
        {

           


          

            


                List<Student> studentList = new List<Student>()

            {

                   


                new Student()
                {

                    Firstname = "saba",
                    Lastname = "burduli",
                    age = 15,
                    Subject = "chemistry",
                    Grade = 10,



               }
            };

                foreach (var item in studentList)
                {
                    if (item is Student)
                    {

                        Student student1 = (Student)item;
                        Console.WriteLine($"firstname  - {student1.Firstname}  lastname - {student1.Lastname}   age  - {student1.age}  subject - {student1.Subject}   grade - {student1.Grade}  ");
                    };


                };

              



                List<teacher> teacherList = new List<teacher>() {

            new teacher() {

            Firstname  = "cico" ,
            Lastname = "Arsenishvili" ,
            age = 65,
            Subject = "chemistry" ,
            Salary = 1500 ,
            EmployeeType = "full - time" ,


            }

            };

                foreach (var item1 in teacherList)
                {


                    teacher student = (teacher)item1;
                    if (item1 is teacher)
                    {
                        Console.WriteLine($" firstname - {student.Firstname} Lastname - {student.Lastname}  age - {student.age}  Salary - {student.Salary}  subject - {student.Subject}  EmployeeType - {student .EmployeeType} ");
                    }

                    
                    


                }


            var chemistryTeacher = new teacher();
            chemistryTeacher.addStudents(new Student { Firstname = "Alice", Subject = "Math", Grade = 0 });
            chemistryTeacher.addStudents(new Student { Firstname = "Bob", Subject = "Eretmaneth", Grade = 0 });



            chemistryTeacher.AssignScore("chemistry", 90);


            foreach (var student in chemistryTeacher.Students)
            {
                Console.WriteLine($"{student.Name} ({student.Subject}): Score = {student.Score}");
            }


            /*
                        List<Employee> EmployeeList = new List<Employee>();
                        {


                            new Student()
                            {

                                Firstname = "saba",
                                Lastname = "burduli",
                                age = 15,
                                Subject = "chemistry",
                                Grade = 10,



                            };


                            new teacher()
                            {

                                Firstname = "cico",
                                Lastname = "Arsenishvili",
                                age = 65,
                                Subject = "chemistry",
                                Salary = 1500,
                                EmployeeType = "full - time",


                            };





                        }

            */









        }
    }
}
