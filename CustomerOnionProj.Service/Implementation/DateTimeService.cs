using CustomerOnionProj.Service.Contract;
using System;

namespace CustomerOnionProj.Service.Implementation
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}