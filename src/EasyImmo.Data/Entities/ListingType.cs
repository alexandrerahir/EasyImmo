using System;
using System.Collections.Generic;

namespace EasyImmo.Data.Entities;

public partial class ListingType
{
    public int ListingTypeId { get; set; }

    public string ListingTypeName { get; set; } = null!;

    public virtual ICollection<Listing> Listings { get; set; } = new List<Listing>();
}
