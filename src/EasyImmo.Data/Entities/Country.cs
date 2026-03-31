using System;
using System.Collections.Generic;

namespace EasyImmo.Data.Entities;

public partial class Country
{
    public int CountryId { get; set; }

    public string CountryName { get; set; } = null!;

    public string IsoCode { get; set; } = null!;

    public virtual ICollection<Region> Regions { get; set; } = new List<Region>();
}
