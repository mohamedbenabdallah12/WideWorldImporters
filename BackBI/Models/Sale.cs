using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BackBI.Models;

public partial class Sale
{
    public int? InvoiceId { get; set; }

    public int? CustomerId { get; set; }

    public int? BillToCustomerId { get; set; }

    public int? DeliveryMethodId { get; set; }

    public int? ContactPersonId { get; set; }

    public int? SalespersonPersonId { get; set; }

    public int? StockItemId { get; set; }

    public bool? IsCreditNote { get; set; }

    public int? TotalDryItems { get; set; }

    public int? TotalChillerItems { get; set; }

    public string? DeliveryRun { get; set; }

    public string? Description { get; set; }

    public int? PackageTypeId { get; set; }

    public int? Quantity { get; set; }

    public decimal? ExtendedPrice { get; set; }

    public decimal? TotalDryItems1 { get; set; }

    public DateTime? InvoiceDateKey { get; set; }

    public DateTime? DeliveryDateKey { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? TaxRate { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? Profit { get; set; }

    public decimal? TotalChillerItems1 { get; set; }
    [JsonIgnore]

    public virtual Customer? BillToCustomer { get; set; }

    [JsonIgnore]
    public virtual Employee? ContactPerson { get; set; }
    [JsonIgnore]
    public virtual Customer? Customer { get; set; }
    [JsonIgnore]
    public virtual DeliveryMethod1? DeliveryMethod { get; set; }
    [JsonIgnore]
    public virtual Date? InvoiceDateKeyNavigation { get; set; }
    [JsonIgnore]
    public virtual PackageType? PackageType { get; set; }
    [JsonIgnore]
    public virtual Employee? SalespersonPerson { get; set; }
    [JsonIgnore]
    public virtual StockItem? StockItem { get; set; }
}
