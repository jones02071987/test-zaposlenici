using AutoMapper;
using Zadatak.Models;

namespace Zadatak.Data
{
    public class DateResolver : IValueResolver<Zaposlenik, ZaposlenikDto, string>
    {
        private readonly AgeCalculator _ageCalculator;

        public DateResolver(AgeCalculator ageCalculator)
        {
            _ageCalculator = ageCalculator;
        }

        public string Resolve(Zaposlenik source, ZaposlenikDto destination, string destMember, ResolutionContext context)
        {
            return _ageCalculator.Age(source.DatumRodjenja).ToString();
        }
    }
}