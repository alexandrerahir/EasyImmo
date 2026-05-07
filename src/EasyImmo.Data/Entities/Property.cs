using System;
using System.Collections.Generic;

namespace EasyImmo.Data.Entities;

public partial class Property
{
    public int PropertyId { get; set; }

    public string PropertyTitle { get; set; } = null!;

    public string? PropertyDescription { get; set; }

    public int PersonId { get; set; }

    public int PropertyTypeId { get; set; }

    public int AddressId { get; set; }

    public virtual Address Address { get; set; } = null!;

    public virtual ICollection<Listing> Listings { get; set; } = new List<Listing>();

    public virtual Person Person { get; set; } = null!;

    public virtual ICollection<Photo> Photos { get; set; } = new List<Photo>();

    public virtual ICollection<PropertyDetail> PropertyDetails { get; set; } = new List<PropertyDetail>();

    public virtual PropertyType PropertyType { get; set; } = null!;
}
