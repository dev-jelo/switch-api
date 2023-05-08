using System;
using System.Collections.Generic;

namespace switchAPI.Models;

public partial class Variant
{
    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Review { get; set; }

    public string? Actuation { get; set; }

    public string? Tactileforce { get; set; }

    public string? Bottom { get; set; }

    public string? Ptravel { get; set; }

    public string? Ttravel { get; set; }

    public string? Sound { get; set; }

    public long? Curve { get; set; }

    public long? Reviewfrom { get; set; }

    public string? From { get; set; }
}
