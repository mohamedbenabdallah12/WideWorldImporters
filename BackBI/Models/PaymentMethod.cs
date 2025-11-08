using System;
using System.Collections.Generic;

namespace BackBI.Models;

public partial class PaymentMethod
{
    public int PaymentMethodKey { get; set; }

    public string? PaymentMethod1 { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }
}
