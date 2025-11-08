using System;
using System.Collections.Generic;

namespace BackBI.Models;

public partial class PackageType
{
    public int PackageTypeId { get; set; }

    public string? PackageTypeName { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }
}
