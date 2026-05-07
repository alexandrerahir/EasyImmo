using System;
using System.Collections.Generic;

namespace EasyImmo.Data.Entities;

public partial class Listing
{
    public int ListingId { get; set; }

    public DateTime ListingStartDate { get; set; }

    public DateTime? ListingEndDate { get; set; }

    public double ListingPrice { get; set; }

    public double? AgencyFees { get; set; }

    public double? NotaryFees { get; set; }

    public double? RentalCharge { get; set; }

    public double? RentalWarranty { get; set; }

    public int ListingTypeId { get; set; }

    public int PropertyId { get; set; }

    public int AgentId { get; set; }

    public virtual Agent Agent { get; set; } = null!;

    public virtual ICollection<Folder> Folders { get; set; } = new List<Folder>();

    public virtual ListingType ListingType { get; set; } = null!;

    public virtual Property Property { get; set; } = null!;
}
