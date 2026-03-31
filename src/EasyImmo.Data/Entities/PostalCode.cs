using System;
using System.Collections.Generic;

namespace EasyImmo.Data.Entities;

public partial class PostalCode
{
    public int PostalCodeId { get; set; }

    public string PostalCode1 { get; set; } = null!;

    public int MunicipalityId { get; set; }

    public virtual Municipality Municipality { get; set; } = null!;

    public virtual ICollection<Street> Streets { get; set; } = new List<Street>();
}
