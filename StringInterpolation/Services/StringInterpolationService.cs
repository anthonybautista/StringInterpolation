using System;
using System.Globalization;
using Microsoft.Extensions.Logging;
using StringInterpolation.Utils;

namespace StringInterpolation.Services
{
    public class StringInterpolationService
    {
        private readonly ISystemDate _date;
        private readonly ILogger<IStringInterpolationService> _logger;

        public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
        {
            _date = date;
            _logger = logger;
            _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
        }

        //1. January 22, 2019 (right aligned in a 40 character field)
        public string Number01()
        {
            var date = _date.Now.ToString("MMMM dd, yyyy");
            var answer = $"{date,40}";
            Console.WriteLine(answer);

            return answer;
        }

        public string Number02()
        {
            var answer = _date.Now.ToString("yyyy.MM.dd");
            Console.WriteLine(answer);

            return answer;
        }

        public string Number03()
        {
            var date = _date.Now.ToString("MMMM, yyyy");
            string day = _date.Now.ToString("dd");
            var answer = $"Day {day} of {date}";
            Console.WriteLine(answer);

            return answer;
        }

        public string Number04()
        {
            string year = _date.Now.ToString("yyyy");
            string month = _date.Now.ToString("MM");
            string day = _date.Now.ToString("dd");
            var answer = $"Year: {year}, Month: {month}, Day: {day}";
            Console.WriteLine(answer);

            return answer;
        }

        public string Number05()
        {
            var date = _date.Now.ToString("dddd");
            var answer = $"{date,10}";
            Console.WriteLine(answer);

            return answer;
        }

        public string Number06()
        {
            var answer = $"{_date.Now.ToString("hh:mm tt"),10}{_date.Now.ToString("dddd"),10}";
            Console.WriteLine(answer);

            return answer;
        }

        public string Number07()
        {
            string hour = _date.Now.ToString("hh");
            string minute = _date.Now.ToString("mm");
            string second = _date.Now.ToString("ss");
            var answer = $"h:{hour}, m:{minute}, s:{second}";
            Console.WriteLine(answer);

            return answer;
        }

        public string Number08()
        {
            var answer = $"{_date.Now.ToString("yyyy.MM.dd.hh.mm.ss")}";
            Console.WriteLine(answer);

            return answer;
        }

        public string Number09()
        {
            var pi = Math.PI;
            // github workflow was not using the correct currency symbol. Found this solution at:
            // https://stackoverflow.com/questions/10416553/string-format-currency
            var answer = @String.Format(new CultureInfo("en-US"), "{0:C}", pi);

            return answer;
        }

        public string Number10()
        {
            var pi = Math.PI;
            var answer = $"{pi.ToString("F3"),10}";

            return answer;
        }

        public string Number11()
        {
            //honestly not sure about this, but here is a solution I found on StackOverflow
            //https://stackoverflow.com/questions/35449339/c-sharp-converting-from-float-to-hexstring-via-ieee-754-and-back-to-float
            var n = Math.Sqrt(2);
            var bytes = BitConverter.GetBytes(n);
            var i = BitConverter.ToInt32(bytes, 0);
            var answer = "0x" + i.ToString("X8");

            return answer;
        }

    }
}