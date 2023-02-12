using System;
using System.Collections.Generic;
using System.Text;

namespace IndividuellaDBProject
{
    class NavigationMenu
    {
    
        public static void Menu()
        {
            Console.CursorVisible = false;

            int selectedIndex = 0;
            string[] menuItems = { "Employee Information", "Student Information", "On Going Courses", "Quit" };

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
                                Console.WriteLine();
                                Console.WriteLine("Proceeds to Employee Information...");
                                Console.ReadKey();
                                EmployeeInfo.EmployeeMenu();
                            break;
                            case 1:
                                Console.WriteLine();
                                Console.WriteLine("Proceeds to Student Information...");
                                Console.ReadKey();
                                StudentInfo.GetStudentData();
                            break;
                            case 2:
                                Console.WriteLine();
                                Console.WriteLine("Proceeds to Courses...");
                                Console.ReadKey();
                                ActiveCourses.GetOnGoingCourses();
                            break;
                            case 3:
                            return;
                        }
                        break;
                }
            }
        }
    }
}
