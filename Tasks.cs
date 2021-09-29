using System;
using System.Collections.Generic;

namespace ExadelTestWork
{
    class Tasks
    {
        public void FirstTask(Junior[] jun)
        {
            Console.WriteLine("------------------------------------------------------------\n" +
                "Задание а): Введите специализацию работника: ");
            string specInput = Console.ReadLine();
            for (int i = 0; i < jun.Length; i++)
            {
                if (jun[i].Specialization == specInput && jun[i].Experience == 1)
                {
                    Console.WriteLine(jun[i].ToString());
                }
            }
            Console.WriteLine("---------------------------------------------------------------");
        }

        public void SecondTask(Junior[] jun, List<int> existYears, List<string> existLangs)
        {
            Console.WriteLine("-----------------------------------------------------------\n" + 
                "Задание б): список джунов для каждого года и специализации");
            for (int i = 0; i < existYears.Count; i++)
            {
                Console.WriteLine("Год {0}: ", existYears[i]);
                for (int j = 0; j < jun.Length; j++)
                {
                    if (jun[j].Experience == existYears[i])
                    {
                        Console.WriteLine(jun[j].ToString());
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < existLangs.Count; i++)
            {
                Console.WriteLine("Язык программирования {0}: ", existLangs[i]);
                for (int j = 0; j < jun.Length; j++)
                {
                    if (jun[j].Specialization.ToLower() == existLangs[i].ToLower())
                    {
                        Console.WriteLine(jun[j].ToString());
                    }
                }
            }
            Console.WriteLine("---------------------------------------------------------------");
        }

        public void ThirdTask(Junior[] jun)
        {
            Console.WriteLine("-----------------------------------------------------------\n" + 
                "Задание в): введите заданный год: ");
            int yearInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Список джунов, родившихся после {0} года: ", yearInput);
            for (int i = 0; i < jun.Length; i++)
            {
                if (jun[i].BirthDate.Year - yearInput > 0)
                {
                    Console.WriteLine(jun[i].ToString());
                }
            }
            Console.WriteLine("---------------------------------------------------------------");
        }
    }
}
