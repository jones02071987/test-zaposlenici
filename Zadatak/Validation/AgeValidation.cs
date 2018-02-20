using System;
using System.ComponentModel.DataAnnotations;
using Zadatak.Data;

namespace Zadatak.Services
{
    public class AgeValidation : ValidationAttribute
    {
        private readonly AgeCalculator _ageCalculator = new AgeCalculator();
        private int _minAge = 18;
        private int _maxAge = 65;

        public override bool IsValid(object value)
        {
            var date = value as DateTime?;

            var age = _ageCalculator.Age(date);

            bool tooYoung = age < _minAge;
            bool tooOld = age > _maxAge;

            return !tooYoung && !tooOld;
        }
    }
}