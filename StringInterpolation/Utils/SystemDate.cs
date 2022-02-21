using System;

namespace StringInterpolation.Utils
{
    public class SystemDate : ISystemDate
    {
        public DateTime Now => DateTime.Now;
    }
}