using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POC_backEnd.Context;
using POC_backEnd.Data.Interface;
using POC_backEnd.Models;
using System;

namespace POC_backEnd.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PocTotalMediaController : ControllerBase
{
    private readonly PocTotalMediaContext _context;

    private readonly ICountryRepository countryRepository;
    private readonly IVatRateRepository vatRateRepository;

    public PocTotalMediaController(ICountryRepository countryRepository, IVatRateRepository vatRateRepository)
    {
        this.countryRepository = countryRepository;
        this.vatRateRepository = vatRateRepository;
    }

    [HttpGet("/GetCountries")]
    public async Task<IActionResult> GetCountries()
    {
       var countries = countryRepository.GetCountries();
        return Ok(countries);
    }

    [HttpGet("/GetVatRates/{countryName}")]
    public async Task<IActionResult> GetVatRates(string countryName)
    {
        var countries = vatRateRepository.GetVatRatesByCountryName(countryName);
        return Ok(countries);
    }

}
