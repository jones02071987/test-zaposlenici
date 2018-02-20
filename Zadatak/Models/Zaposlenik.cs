using System;
using System.ComponentModel.DataAnnotations;
using Zadatak.Services;

namespace Zadatak.Models
{
    public class Zaposlenik
    {
        public int? Id { get; set; }

        [RegularExpression(@"^[^~`^<>]+$")]
        [StringLength(30, ErrorMessage = "Maksimalno 30 znakova"), Required]
        public string Ime { get; set; }

        [RegularExpression(@"^[^~`^<>]+$")]
        [StringLength(30, ErrorMessage = "Maksimalno 30 znakova"), Required]
        public string Prezime { get; set; }

        [Required, DateValidation(ErrorMessage = "Nije unesen pravilan datum")]
        [Display(Name = "Datum rođenja")]
        public DateTime? DatumRodjenja { get; set; }
    }
}