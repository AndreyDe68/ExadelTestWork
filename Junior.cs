using System;

namespace ExadelTestWork
{
    public class Junior
    {
        private string _lastName;
        private string _name;
        private string _middleName;
        private DateTime _birthDate;
        private string _address;
        private string _phoneNumber;
        private string _specialization;
        private byte _experiance;

        public Junior()
        {
        }

        public Junior(string lastName, string name, string middleName, DateTime birthDate, string address,string phoneNumber, string specialization, byte experiance)
        {
            _lastName = lastName;
            _name = name;
            _middleName = middleName;
            _birthDate = birthDate;
            _phoneNumber = phoneNumber;
            _specialization = specialization;
            _experiance = experiance;
        }
        
        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
        public string MiddleName
        {
            get
            {
                return _middleName;
            }

            set
            {
                _middleName = value;
            }
        }
        public DateTime BirthDate
        {
            get => _birthDate;
            set => _birthDate = value;
        }
        public string Address
        {
            get => _address;
            set => _address = value;
        }
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }

            set
            {
                _phoneNumber = value;
            }
        }
        public byte Experience
        {
            get
            {
                return _experiance;
            }
            set
            {
                _experiance = value;
            }
        }
        public string Specialization
        {
            get
            {
                return _specialization;
            }
            set
            {
                _specialization = value;
            }
        }

        public override string ToString()
        {
            string s = $"Джун: {LastName} {Name} {MiddleName}, дата рождения: {BirthDate.Year}, адрес: {Address}, " +
                $"номер телефона: {PhoneNumber}, специализация: {Specialization}, год работы: {Experience} ";
            return s;
        }
    }
}
