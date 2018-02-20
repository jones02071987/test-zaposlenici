using System;

namespace Zadatak.Data
{
    public class AgeCalculator
    {
        public int Age(DateTime? startingDate)
        {
            var today = DateTime.UtcNow;

            int? age = today.Year - startingDate?.Year;

            bool hadBirthday = today.DayOfYear >= startingDate?.DayOfYear;

            if (!hadBirthday)
            {
                age--;
            }

            return age ?? 0;
        }
    }
}