using IndividuellaDBProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndividuellaDBProject
{
    internal class EmployeeInfo : IndividuellaDBContext
    {


        public static void EmployeeMenu()
        {
            Console.CursorVisible = false;

            int selectedIndex = 0;
            string[] menuItems = { "Staff List", "Staff In Departments", "Back to Main Menu" };

            while (true)
            {
                Console.Clear();
                for (int i = 0; i < menuItems.Length; i++)
                {
                    Console.WriteLine("{0}{1}", i == selectedIndex ? "> " : "  ", menuItems[i]);
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        selectedIndex = Math.Max(0, selectedIndex - 1);
                        break;
                    case ConsoleKey.DownArrow:
                        selectedIndex = Math.Min(menuItems.Length - 1, selectedIndex + 1);
                        break;
                    case ConsoleKey.Enter:
                        switch (selectedIndex)
                        {
                            case 0:
                                GetEmployeeData();
                                break;
                            case 1:
                                SpecificDepartmentInfo();
                                break;
                            case 2:
                                NavigationMenu.Menu();
                                return;
                        }
                        break;
                }
            }
        }

        //Hämtar Employee Data in en lista
        public static void GetEmployeeData()
        {
            Console.Clear();
            var Context = new IndividuellaDBContext();

            var Employee = Context.EmployeeTbl.Where(x => x.EmployeeId > 0);
            foreach (EmployeeTbl item in Employee)
            {
                Console.WriteLine("Employee ID = {0} ", item.EmployeeId);
                Console.WriteLine("Firstname = {0}", item.FirstName);
                Console.WriteLine("Lastname = {0}", item.LastName);
                Console.WriteLine("Role = {0}", item.Role);
                Console.WriteLine("----------------------------------");
            }
            Console.ReadKey();

        }

        //Meny för specifika Departments
        public static void SpecificDepartmentInfo()
        {
            Console.CursorVisible = false;

            int selectedIndex = 0;
            string[] menuItems = { "Teachers\n", "Administrators\n", "Principal\n", "Librarians\n", "Janitors\n", "Kitchen Staffs\n", "Counsellors\n", "Go Back" };

            while (true)
            {
                Console.Clear();
                for (int i = 0; i < menuItems.Length; i++)
                {
                    Console.WriteLine("{0}{1}", i == selectedIndex ? "> " : "  ", menuItems[i]);
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        selectedIndex = Math.Max(0, selectedIndex - 1);
                        break;
                    case ConsoleKey.DownArrow:
                        selectedIndex = Math.Min(menuItems.Length - 1, selectedIndex + 1);
                        break;
                    case ConsoleKey.Enter:
                        switch (selectedIndex)
                        {
                            case 0:
                                GetEmployeeInTeacher();
                                break;
                            case 1:
                                GetEmployeeInAdministrator();
                                break;
                            case 2:
                                GetEmployeeInPrincipal();
                                break;
                            case 3:
                                GetEmployeeInLibrarian();
                                break;
                            case 4:
                                GetEmployeeInJanitor();
                                break;
                            case 5:
                                GetEmployeeInKitchenStaff();
                                break;
                            case 6:
                                GetEmployeeInCounsellor();
                                break;
                            case 7:
                                NavigationMenu.Menu();
                                return;
                        }
                        break;
                }
            }
        }

        //Metoder som hämtar data från specifik Role
        public static void GetEmployeeInTeacher()
        {
            Console.Clear();
            var context = new IndividuellaDBContext();

            var Employee = context.EmployeeTbl.Where(x => x.Role == "Teacher");
            foreach (EmployeeTbl item in Employee)
            {
                Console.WriteLine("FullName: {1} {2}\nRole: {0}\n", item.Role, item.FirstName, item.LastName);
                
            }
            Console.Write("There are: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Employee.Count());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Teachers");
            Console.ReadKey();
        }
        public static void GetEmployeeInAdministrator()
        {
            Console.Clear();
            var context = new IndividuellaDBContext();

            var Employee = context.EmployeeTbl.Where(x => x.Role == "Administrator");
            foreach (EmployeeTbl item in Employee)
            {
                Console.WriteLine("FullName: {1} {2}\nRole: {0}", item.Role, item.FirstName, item.LastName);
                Console.WriteLine();
            }
            Console.Write("There are: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Employee.Count());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Administrators");
            Console.ReadKey();
        }
        public static void GetEmployeeInPrincipal()
        {
            Console.Clear();
            var context = new IndividuellaDBContext();

            var Employee = context.EmployeeTbl.Where(x => x.Role == "Principal");
            foreach (EmployeeTbl item in Employee)
            {
                Console.WriteLine("FullName: {1} {2}\nRole: {0}", item.Role, item.FirstName, item.LastName);
                Console.WriteLine();
            }
            Console.Write("There is: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Employee.Count());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Principal");
            Console.ReadKey();
        }
        public static void GetEmployeeInLibrarian()
        {
            Console.Clear();
            var context = new IndividuellaDBContext();

            var Employee = context.EmployeeTbl.Where(x => x.Role == "Librarian");
            foreach (EmployeeTbl item in Employee)
            {
                Console.WriteLine("FullName: {1} {2}\nRole: {0}", item.Role, item.FirstName, item.LastName);
                Console.WriteLine();
            }
            Console.Write("There are: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Employee.Count());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Librarians");
            Console.ReadKey();
        }
        public static void GetEmployeeInJanitor()
        {
            Console.Clear();
            var context = new IndividuellaDBContext();

            var Employee = context.EmployeeTbl.Where(x => x.Role == "Janitor");
            foreach (EmployeeTbl item in Employee)
            {
                Console.WriteLine("FullName: {1} {2}\nRole: {0}", item.Role, item.FirstName, item.LastName);
                Console.WriteLine();
            }
            Console.Write("There are: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Employee.Count());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Janitors");
            Console.ReadKey();
        }
        public static void GetEmployeeInKitchenStaff()
        {
            Console.Clear();
            var context = new IndividuellaDBContext();

            var Employee = context.EmployeeTbl.Where(x => x.Role == "KitchenStaff");
            foreach (EmployeeTbl item in Employee)
            {
                Console.WriteLine("FullName: {1} {2}\nRole: {0}", item.Role, item.FirstName, item.LastName);
                Console.WriteLine();
            }
            Console.Write("There are: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Employee.Count());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Kitchen staffs");
            Console.ReadKey();
        }
        public static void GetEmployeeInCounsellor()
        {
            Console.Clear();
            var context = new IndividuellaDBContext();

            var Employee = context.EmployeeTbl.Where(x => x.Role == "Counsellor");
            foreach (EmployeeTbl item in Employee)
            {
                Console.WriteLine("FullName: {1} {2}\nRole: {0}", item.Role, item.FirstName, item.LastName);
                Console.WriteLine();
            }
            Console.Write("There are: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Employee.Count());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Counsellor");
            Console.ReadKey();
        }


    }
}
