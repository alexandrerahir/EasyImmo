using System;
using System.Collections.Generic;

namespace EasyImmo.Data.Entities;

public partial class Municipality
{
    public int MunicipalityId { get; set; }

    public string MunicipalityName { get; set; } = null!;

    public int ProvinceId { get; set; }

    public virtual ICollection<PostalCode> PostalCodes { get; set; } = new List<PostalCode>();

    public virtual Province Province { get; set; } = null!;
}
