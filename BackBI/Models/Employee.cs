using System;
using System.Collections.Generic;

namespace BackBI.Models;

public partial class Employee
{
    public int PersonId { get; set; }

    public string? Name { get; set; }

    public string? PreferredName { get; set; }

    public bool? IsSalesperson { get; set; }

    public bool? IsEmployee { get; set; }

    public string? PhoneNumber { get; set; }

    public string? FaxNumber { get; set; }

    public string? EmailAddress { get; set; }

    public byte[]? Photo { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }
}
