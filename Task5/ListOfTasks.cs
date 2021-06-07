using System;
using System.Collections.Generic;
using System.Linq;

namespace Task5
{
    class ListOfTasks
    {
        public int sumHP;
        public int sumMP;
        public int sumLP;
        public int total;

        class FieldsForListOfTasks
        {

            public string Name { get; set; }
            public int Comlexity { get; set; }
            public int Priority { get; set; }
        }

        private List<FieldsForListOfTasks> list = new List<FieldsForListOfTasks>();


        public void EnterAndAddToListTasksParameters()
        {

            int counter = 0;

            do
            {
                FieldsForListOfTasks flt = new FieldsForListOfTasks();
                ValidationOfEnteredValues validator = new ValidationOfEnteredValues();

                Console.Write(" \nEnter Task Name: ");
                flt.Name = Console.ReadLine();


                Console.Write("Enter сomplexity: ");
                flt.Comlexity = validator.ValidateEnteredComplexity();

                Console.Write("Enter priority: ");
                flt.Priority = validator.ValidateEnteredPriority();

                list.Add(flt);

                Console.WriteLine("If you want to finish, please enter 'exit'. Otherwise enter any character ");
                string exit = Convert.ToString(Console.ReadLine());
                if (exit == "exit")
                {
                    break;
                }
            }
            while (counter < 100);


        }

        public int GetSumlOfTimeForHighPriorityTask()
        {
            List<FieldsForListOfTasks> HighPriorityTask = list.FindAll(hp => hp.Priority == 1);
            sumHP = HighPriorityTask.Sum(shp => shp.Comlexity);
            return sumHP;

        }


        public int GetSumOfTimeForMediumPriorityTask()
        {
            List<FieldsForListOfTasks> MediumPriorityTask = list.FindAll(mp => mp.Priority == 2);
            sumMP = MediumPriorityTask.Sum(smp => smp.Comlexity);
            return sumMP;
        }

        public int GetSumOfTimeForLowPriorityTask()
        {

            List<FieldsForListOfTasks> LowPriorityTask = list.FindAll(lp => lp.Priority == 3);
            sumLP = LowPriorityTask.Sum(slp => slp.Comlexity);
            return sumLP;

        }

        public void ListOfTasksForPrint(int n)
        {
            Console.WriteLine($"\nList of tasks with P{n}: ");
            foreach (FieldsForListOfTasks taskName in list.Where(task => task.Priority == n))
            {
                Console.WriteLine($"{taskName.Name}");
            }
        }

        public int TotalCalculation()
        {
            GetSumOfTimeForMediumPriorityTask();
            GetSumOfTimeForLowPriorityTask();
            GetSumOfTimeForLowPriorityTask();
            total = sumHP + sumMP + sumLP;
            Console.WriteLine($"\nTime required to complete all tasks: { total} hours");
            return total;
        }

        public void DisplayListOfTasks(int daysInHours)
        {

            int[] mass = list.Select(x => x.Priority).Distinct().ToArray();
            Array.Sort(mass);

            foreach (int i in mass)
                if (daysInHours > 0)
                {

                    switch (i)
                    {
                        case 1:
                            GetSumlOfTimeForHighPriorityTask();
                            daysInHours = daysInHours - sumHP;
                            if (daysInHours >= 0)
                            {
                                ListOfTasksForPrint(1);
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("\nYou don't have enough time to complete all tasks with P1");
                                break;
                            }
                            ;
                        case 2:
                            GetSumOfTimeForMediumPriorityTask();
                            daysInHours = daysInHours - sumMP;
                            if (daysInHours > 0)
                            {
                                ListOfTasksForPrint(2);
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("\nYou don't have enough time to complete all tasks with P2");
                                break;
                            }
                        case 3:
                            GetSumOfTimeForLowPriorityTask();
                            daysInHours = daysInHours - sumLP;
                            if (daysInHours > 0)
                            {
                                ListOfTasksForPrint(3);
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("\nYou don't have enough time to complete all tasks with P3");
                                break;
                            }
                    }
                }
            TotalCalculation();
        }
    }
}
