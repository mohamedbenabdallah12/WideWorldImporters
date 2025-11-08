using System;
using System.Collections.Generic;

namespace BackBI.Models;

public partial class StockItem
{
    public int StockItemKey { get; set; }

    public string? StockItemName { get; set; }

    public string? ColorName { get; set; }

    public string? UnitPackageTypeName { get; set; }

    public string? OuterPackageTypeName { get; set; }

    public string? SupplierName { get; set; }

    public string? Brand { get; set; }

    public string? Size { get; set; }

    public int? LeadTimeDays { get; set; }

    public int? QuantityPerOuter { get; set; }

    public bool? IsChillerStock { get; set; }

    public string? Barcode { get; set; }

    public decimal? TaxRate { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? RecommendedRetailPrice { get; set; }

    public decimal? TypicalWeightPerUnit { get; set; }

    public byte[]? Photo { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }
}
