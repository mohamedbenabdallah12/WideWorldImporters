using System;
using System.Collections.Generic;

namespace BackBI.Models;

public partial class DeliveryMethod
{
    public int? DeliveryMethodId { get; set; }

    public string? DeliveryMethodName { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }
}
