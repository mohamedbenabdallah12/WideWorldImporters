using System;
using System.Collections.Generic;

namespace BackBI.Models;

public partial class TransactionType
{
    public int TransactionTypeKey { get; set; }

    public string? TransactionType1 { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }
}
