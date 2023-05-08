using System;
using System.Collections.Generic;

namespace switchAPI.Models;

public partial class Switch
{
    public string? Id { get; set; }

    public string? Name { get; set; }

    public long? Linear { get; set; }

    public long? Tactile { get; set; }

    public long? Clicky { get; set; }

    public long? Collar { get; set; }

    public long? Bar { get; set; }

    public long? Silent { get; set; }

    public long? Low { get; set; }

    public long? Optical { get; set; }

    public long? Mod { get; set; }

    public long? Variants { get; set; }

    public string? Info { get; set; }

    public string? Review { get; set; }

    public string? Imagesource { get; set; }

    public string? Infosource { get; set; }

    public string? Reviewsource { get; set; }

    public string? Soundsource { get; set; }

    public string? Curvesource { get; set; }

    public string? Ptravel { get; set; }

    public string? Ttravel { get; set; }

    public long? Actuation { get; set; }

    public long? Tactileforce { get; set; }

    public long? Bottom { get; set; }
}
