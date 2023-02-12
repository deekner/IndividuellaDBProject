using IndividuellaDBProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndividuellaDBProject
{
    class StudentInfo : IndividuellaDBContext
    {
        public static void GetStudentData()
        {            
            Console.Clear();
            var Context = new IndividuellaDBContext();

            var Student = Context.StudentTbl.Where(x => x.StudentId > 0);
            foreach (StudentTbl item in Student)
            {
                Console.WriteLine("Student ID = {0} ", item.StudentId);
                Console.WriteLine("Firstname = {0}", item.FirstName);
                Console.WriteLine("Lastname = {0}", item.LastName);
                Console.WriteLine("Class = {0}", item.ClassId);
                Console.WriteLine("----------------------------------");               
            }
            Console.ReadKey();

        }
    }
}
