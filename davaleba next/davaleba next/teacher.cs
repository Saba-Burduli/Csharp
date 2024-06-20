using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba_next
{
    internal class teacher : Employee
    {

        public string Subject { get; set; }

       private List<Student> students ;

        public teacher() {
        
        
        students = new List<Student>(); 


        }   
        
        public void addStudents (Student student)
        {
            students.Add(student);  
        }



        public void AssignScore(string targetSubject, int Grade)
        {


            foreach (var student in students)
            {
                if (student.Subject == "chemistry")
                {
                    student.Grade = Grade;

                    Console.WriteLine($"agebuli qula : {Grade} moswavle - {student.Firstname} - subject {student.Subject} ");

                }


                else
                {

                    Console.WriteLine($" studenti {student.Firstname} {student.Lastname} ar momzadebula");

                }
            }
           
        }
        
    }
}
