using System;
using System.Collections.Generic;



namespace ExadelTestWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //экземпляр класса ввода-вывода информации
            InputOutput inp = new InputOutput();
            //объект класса заданий а), б), в).
            Tasks task = new Tasks();
            //списки годов и специализаций для задания б)
            List<int> existYears = new List<int>();
            List<string> existLangs = new List<string>();

            Console.WriteLine("Введите кол-во джунов");
            byte q = Convert.ToByte(Console.ReadLine());
            Junior[] juniors = new Junior[q];
            for (int i = 0; i < juniors.Length; i++)
            {
                juniors[i] = new Junior();
                Console.WriteLine("Джун номер {0}:", i+1);
                inp.Input(juniors[i]);
                if (!existYears.Contains(juniors[i].Experience))
                {
                    existYears.Add(juniors[i].Experience);
                }
                if(!existLangs.Contains(juniors[i].Specialization.ToLower()))
                {
                    existLangs.Add(juniors[i].Specialization);
                }
            }
            task.FirstTask(juniors);
            task.SecondTask(juniors, existYears, existLangs);
            task.ThirdTask(juniors);

            Console.ReadLine();
        }
    }
}
