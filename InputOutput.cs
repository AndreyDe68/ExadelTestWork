using System;

namespace ExadelTestWork
{
    class InputOutput
    {
        public Validator validator = new Validator();
        public void Input(Junior jun)
        {
            try
            {
                Console.Write("Введите фамилию: ");
                jun.LastName = Console.ReadLine();
                Console.Write("Имя: ");
                jun.Name = Console.ReadLine();
                Console.Write("Отчество: ");
                jun.MiddleName = Console.ReadLine();
                Console.Write("Дата рождения(dd.mm.yyyy): ");
                jun.BirthDate = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Адрес: ");
                jun.Address = Console.ReadLine();
                Console.Write("Номер телефона, формат (XXX) XXX-XXXX: ");
                try 
                {
                    jun.PhoneNumber = Console.ReadLine();
                    validator.isValidPhone(jun.PhoneNumber);
                }
                catch (IncorrentNumException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.Write("Специализация: ");
                jun.Specialization = Console.ReadLine();
                Console.Write("Стаж: ");
                jun.Experience = Convert.ToByte(Console.ReadLine());
                validator.isEmpty(jun.LastName, jun.Name, jun.MiddleName, jun.BirthDate, jun.Address, jun.PhoneNumber, jun.Specialization, jun.Experience);
            }
            catch (EmptyFieldException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Output(Junior jun)
        {
            Console.WriteLine(jun.ToString());
        }
        
    }
}
