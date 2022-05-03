using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DateModifier
    {
        private DateTime date1;
        private DateTime date2;

        public DateTime Date1 { get => date1; set => date1 = value; }
        public DateTime Date2 { get => date2; set => date2 = value; }

        public void FindDays()
        {
            if (Date1.CompareTo(Date2) > 0)
            {
                Console.WriteLine((Date1 - Date2).ToString("dd"));
            }
            else Console.WriteLine((Date2 - Date1).ToString("dd"));
        }

    }
}
