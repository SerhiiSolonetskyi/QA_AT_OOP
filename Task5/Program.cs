using System;
using System.Collections.Generic;

namespace Task5
{
    class Program
    {
        public static int daysInHours;
        static void Main()
        {
            ListOfTasks list = new ListOfTasks();
            Console.Write("Days:  ");
            int countOfdays = Convert.ToInt32(Console.ReadLine());
            daysInHours = countOfdays * 8;
            list.EnterAndAddToListTasksParameters();
            list.DisplayListOfTasks(daysInHours);

        }
    }
}
