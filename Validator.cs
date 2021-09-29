using System;
using System.Globalization;
using System.Text.RegularExpressions;


namespace ExadelTestWork
{
    public class Validator
    {
        public bool isEmpty(string lstName, string Name, string MidName, DateTime bDate, string address, string phNum, string spec, byte exp)
        {
            bool isEmpty = false;
            if ((lstName.Length < 1) || (Name.Length < 1) || (MidName.Length < 1) || (bDate.Date == null) || (address.Length < 1) || (phNum.Length < 1) ||
                (spec.Length < 1) || (exp == 0))
            {
                throw new EmptyFieldException();
            }
            return isEmpty;
        }

        public bool isValidPhone(string PhoneNumber)
        {
            Match match = Regex.Match(PhoneNumber, @"^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$");
            if (match.Success) {
                return true;
            }
            else
            {
                throw new IncorrentNumException();
            }
        }

        //public bool isValidDate(string birthDay)
        //{
        //    var dateFormat = "MM.dd.yyyy";
        //    DateTimeStyles styles = DateTimeStyles.None;
        //    DateTime scheduleDate;
        //    if (DateTime.TryParseExact(birthDay, dateFormat, DateTimeFormatInfo.InvariantInfo, styles, out scheduleDate))
        //    {
        //        return true;
        //    }
            
        //}
    }

}
