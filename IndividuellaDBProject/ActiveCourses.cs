using IndividuellaDBProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndividuellaDBProject
{
    class ActiveCourses : IndividuellaDBContext
    {
        public static void GetOnGoingCourses()
        {
            Console.Clear();
            var Context = new IndividuellaDBContext();

            var ActiveCourse = Context.CourseTbl.Where(x => x.IsActive == true);
            foreach (CourseTbl item in ActiveCourse)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Course: ");
                Console.Write(item.CourseName);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" is Active");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ReadKey();

            //var Courses = Context.CourseTbl.Where(x => x.CourseId > 0);
            //foreach (CourseTbl item in Courses)
            //{               
            //    Console.WriteLine("Course: {0}", item.CourseName);
            //    Console.WriteLine("----------------------------------");
            //}

        }
    }
}
