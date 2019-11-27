using System;

namespace DataGraph.TimeModule
{
    public class DateValidator
    {

        public static bool ValidateDate(Date date)
        {
            if (date == null)
                return false;

            return (ValidateDay(date.Day) && ValidateMonth(date.Month) && ValidateYear(date.Year));
        }

        public static bool ValidateDay(int? day)
        {
            return (day == null || (day > 0 && day < 32));
        }

        public static bool ValidateMonth(int? month)
        {
            return (month == null || (month > 0 && month < 13));
        }

        public static bool ValidateYear(long? year)
        {
            return true;
        }

    }
}