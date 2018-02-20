using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zadatak.Models;

namespace Zadatak.Services
{
    public interface IZaposleniciRepository
    {
        IEnumerable<Zaposlenik> GetAll();
        Zaposlenik Get(int id);
        void Delete(int id);
        void Create(Zaposlenik zaposlenik);
    }
}
