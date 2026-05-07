using System;
using System.Collections.Generic;

namespace EasyImmo.Data.Entities;

public partial class Province
{
    public int ProvinceId { get; set; }

    public string ProvinceName { get; set; } = null!;

    public int RegionId { get; set; }

    public virtual ICollection<Municipality> Municipalities { get; set; } = new List<Municipality>();

    public virtual Region Region { get; set; } = null!;
}
