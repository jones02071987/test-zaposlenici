using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Zadatak.Data;
using Zadatak.Models;
using Zadatak.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Zadatak.Controllers.api
{
    [Route("api/[controller]")]
    public class ZaposleniciController : Controller
    {
        private readonly IZaposleniciRepository _zaposleniciRepository;

        public ZaposleniciController(IZaposleniciRepository zaposleniciRepository)
        {
            _zaposleniciRepository = zaposleniciRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(Mapper.Map<IEnumerable<ZaposlenikDto>>(_zaposleniciRepository.GetAll()));
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult Create(Zaposlenik zaposlenik)
        {
            _zaposleniciRepository.Create(zaposlenik);
            return Ok(zaposlenik);
        }
    }
}