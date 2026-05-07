using System;
using System.Collections.Generic;

namespace EasyImmo.Data.Entities;

public partial class Address
{
    public int AddressId { get; set; }

    public int HouseNumber { get; set; }

    public string? BoxNumber { get; set; }

    public int StreetId { get; set; }

    public virtual ICollection<Person> People { get; set; } = new List<Person>();

    public virtual ICollection<Property> Properties { get; set; } = new List<Property>();

    public virtual Street Street { get; set; } = null!;
}
