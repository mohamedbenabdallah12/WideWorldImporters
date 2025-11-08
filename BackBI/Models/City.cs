using System;
using System.Collections.Generic;

namespace BackBI.Models;

public partial class City
{
    public int CityKey { get; set; }

    public string? CityName { get; set; }

    public string? StateProvince { get; set; }

    public string? SalesTerritory { get; set; }

    public string? CountryName { get; set; }

    public string? Continent { get; set; }

    public string? Region { get; set; }

    public string? Subregion { get; set; }

    public long? LatestRecordedPopulation { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }
}
