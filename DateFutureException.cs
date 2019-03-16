using System;

namespace CSharpLab2_Lab3
{
    class DateFutureException : Exception
    {
        private string _msg;
        private DateTime _futureDate;

        public DateFutureException(string msg)
        {
            _msg = msg;
        }

        public DateFutureException(DateTime bDate)
        {
            _futureDate = bDate;
            _msg = $"Error (Future Date): {_futureDate}";
        }

        public DateFutureException(DateTime bDate, string msg)
        {
            _futureDate = bDate;
            _msg = msg;
        }

        public override string Message
        {
            get { return _msg; }
        }
    }
}
