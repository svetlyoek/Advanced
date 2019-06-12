
namespace DateModifier
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class DateModifier
    {
        private string[] firstDate;

        private string[] secondDate;

        public string[] FirstDate
        {
            get { return this.firstDate; }

            set { this.firstDate = value; }
        }

        public string[] SecondDate
        {
            get { return this.secondDate; }

            set { this.secondDate = value; }
        }

        public DateModifier(string[] firstDate, string[] secondDate)
        {
            this.FirstDate = firstDate;
            this.SecondDate = secondDate;
        }

        public void CalculateDifference(string[] firstDate, string[] secondDate)
        {
            int firstYear = int.Parse(firstDate[0]);
            int firstMonth = int.Parse(firstDate[1]);
            int firstDay = int.Parse(firstDate[2]);


            int secondYear = int.Parse(secondDate[0]);
            int secondMonth = int.Parse(secondDate[1]);
            int secondDay = int.Parse(secondDate[2]);

            DateTime start = new DateTime(firstYear, firstMonth, firstDay);
            DateTime end = new DateTime(secondYear, secondMonth, secondDay);

            TimeSpan difference = end - start;

            Console.WriteLine(Math.Abs(difference.Days));
        }

    }
}
