using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zadatak.Data
{
    public class ZaposlenikDto
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string DatumRodjenja { get; set; }
    }
}
