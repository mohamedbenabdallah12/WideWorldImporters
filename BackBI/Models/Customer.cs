using System;
using System.Collections.Generic;

namespace BackBI.Models;

public partial class Customer
{
    public int CustomerKey { get; set; }

    public string? CustomerName { get; set; }

    public string? BillToCustomer { get; set; }

    public string? Category { get; set; }

    public string? BuyingGroup { get; set; }

    public string? PrimaryContactPeerson { get; set; }

    public string? AlternativePersonContact { get; set; }

    public string? DeliveryMethodName { get; set; }

    public string? DeliveryCity { get; set; }

    public string? PostalCity { get; set; }

    public string? PhoneNumber { get; set; }

    public string? FaxNumber { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }
}
