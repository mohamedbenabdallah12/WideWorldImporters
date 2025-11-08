using System;
using System.Collections.Generic;

namespace BackBI.Models;

public partial class DestinationOleDb
{
    public int TransactionTypeKey { get; set; }

    public string? TransactionType { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }
}
