using System;

namespace CSharpLab2_Lab3
{
    class DatePastException : Exception
    {
        private string _msg;
        private DateTime _pastDate;

        public DatePastException(string msg)
        {
            _msg = msg;
        }

        public DatePastException(DateTime bDate)
        {
            _pastDate = bDate;
            _msg = $"Error (Past Date): {_pastDate}";
        }

        public DatePastException(DateTime bDate, string msg)
        {
            _pastDate = bDate;
            _msg = msg;
        }

        public override string Message
        {
            get { return _msg; }
        }
    }
}
