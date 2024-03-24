using System;
using System.Collections.Generic;

namespace firstapp.Models;

public partial class Product
{
    public int PId { get; set; }

    public string? PName { get; set; }

    public int? PPrice { get; set; }

    public string? PDiscription { get; set; }

    public string? PCategory { get; set; }
}
