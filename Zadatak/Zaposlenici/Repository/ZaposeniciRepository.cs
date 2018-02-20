using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Zadatak.Data;
using Zadatak.Models;
using Zadatak.Services;

namespace Zadatak
{
    public class ZaposeniciRepository : IZaposleniciRepository
    {
        private readonly ApplicationDbContext _context;

        public ZaposeniciRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Create(Zaposlenik zaposlenik)
        {
            _context.Zaposlenici.Add(zaposlenik);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var student = _context.Zaposlenici
                .Where(z => z.Id == id)
                .FirstOrDefault();
            _context.Remove(student);

            _context.SaveChanges();
        }

        public Zaposlenik Get(int id)
        {
            return _context.Zaposlenici
                .AsNoTracking()
                .Where(z => z.Id == id)
                .FirstOrDefault();
        }

        public IEnumerable<Zaposlenik> GetAll()
        {
            return _context.Zaposlenici
                .AsNoTracking()
                .ToList();
        }
    }
}