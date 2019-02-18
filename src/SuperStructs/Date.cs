using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStructs
{
    public struct Date
    {
        DateTime date;

        public static implicit operator Date(DateTime dateTime)
        {
            return new Date { date = dateTime.Date };
        }

        public static Date Today
        {
            get { return DateTime.Today; }

        }

        public override string ToString()
        {
            return date.ToString();
        }
    }
}