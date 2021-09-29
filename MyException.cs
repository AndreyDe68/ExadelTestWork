using System;

namespace ExadelTestWork
{
    class EmptyFieldException : Exception
    {
        public EmptyFieldException() : base()
        {
            Console.WriteLine("Одно из полей не было заполнено.");
        }
    }

    class IncorrentNumException : Exception
    {
        public IncorrentNumException() : base()
        {
            Console.WriteLine("Неверно введен номер телефона.");

        }
    }

}
