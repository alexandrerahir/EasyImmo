using System;
using System.Collections.Generic;

namespace EasyImmo.Data.Entities;

public partial class PropertyType
{
    public int PropertyTypeId { get; set; }

    public string PropertyTypeName { get; set; } = null!;

    public virtual ICollection<Property> Properties { get; set; } = new List<Property>();
}
