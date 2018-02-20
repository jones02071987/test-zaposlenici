using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Zadatak.Data;
using Zadatak.Models;

namespace Zadatak.Services
{
    public class DbSeeder
    {
        private readonly ApplicationDbContext _context;

        public DbSeeder(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            _context.Database.Migrate();
            if (!_context.Zaposlenici.Any())
            {
                _context.Zaposlenici.AddRange(
                    new List<Zaposlenik>
                    {
                        new Zaposlenik{ Ime = "Javier", Prezime = "Piesold", DatumRodjenja = new DateTime(1987,2,2)},
                        new Zaposlenik{ Ime = "Georgiana", Prezime = "Fotitt", DatumRodjenja = new DateTime(1991,11,30)},
                        new Zaposlenik{ Ime = "Cassius", Prezime = "Fatkin", DatumRodjenja = new DateTime(1988,1,29)},
                        new Zaposlenik{ Ime = "Ax", Prezime = "Jeandillou", DatumRodjenja = new DateTime(1982,7,5)},
                        new Zaposlenik{ Ime = "Andris", Prezime = "Rushbrooke", DatumRodjenja = new DateTime(1986,8,11)},
                        new Zaposlenik{ Ime = "Eldredge", Prezime = "Rignall", DatumRodjenja = new DateTime(1991,10,22)},
                        new Zaposlenik{ Ime = "Toby", Prezime = "Morad", DatumRodjenja = new DateTime(1991,11,17)},
                        new Zaposlenik{ Ime = "Hughie", Prezime = "Ramage", DatumRodjenja = new DateTime(1999,10,13)},
                        new Zaposlenik{ Ime = "Florina", Prezime = "Scates", DatumRodjenja = new DateTime(1996,6,9)},
                        new Zaposlenik{ Ime = "Anton", Prezime = "Laneham", DatumRodjenja = new DateTime(1977,10,29)},
                        new Zaposlenik{ Ime = "Dolli", Prezime = "O'Sullivan", DatumRodjenja = new DateTime(1972,2,27)},
                        new Zaposlenik{ Ime = "Berti", Prezime = "Christene", DatumRodjenja = new DateTime(1986,2,27)},
                        new Zaposlenik{ Ime = "Upton", Prezime = "Scritch", DatumRodjenja = new DateTime(1972,8,24)},
                        new Zaposlenik{ Ime = "Dmitri", Prezime = "MacGee", DatumRodjenja = new DateTime(1993,10,18)},
                        new Zaposlenik{ Ime = "Darrelle", Prezime = "Fazackerley", DatumRodjenja = new DateTime(1987,9,9)}
                    });
                _context.SaveChanges();
            }
        }
    }
}