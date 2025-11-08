using System;
using System.Collections.Generic;

namespace BackBI.Models;

public partial class Date
{
    public DateTime Date1 { get; set; }

    public int DayNumber { get; set; }

    public string Day { get; set; } = null!;

    public string Month { get; set; } = null!;

    public string ShortMonth { get; set; } = null!;

    public int CalendarMonthNumber { get; set; }

    public string CalendarMonthLabel { get; set; } = null!;

    public int CalendarYear { get; set; }

    public string CalendarYearLabel { get; set; } = null!;

    public int FiscalMonthNumber { get; set; }

    public string FiscalMonthLabel { get; set; } = null!;

    public int FiscalYear { get; set; }

    public string FiscalYearLabel { get; set; } = null!;

    public int IsoWeekNumber { get; set; }
}
