using System;
using System.Collections.Generic;

namespace BackBI.Models;

public partial class Supplier
{
    public int SupplierId { get; set; }

    public string? SupplierName { get; set; }

    public string? PrimaryContactName { get; set; }

    public string? SupplierCategoryName { get; set; }

    public int? PaymentDays { get; set; }

    public string? PhoneNumber { get; set; }

    public string? FaxNumber { get; set; }

    public string? PostalPostalCode { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }
}
