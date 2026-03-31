using System;
using System.Collections.Generic;

namespace EasyImmo.Data.Entities;

public partial class PropertyDetail
{
    public int PropertyDetailId { get; set; }

    public double? LivingArea { get; set; }

    public double? LandArea { get; set; }

    public double? TotalSurfaceArea { get; set; }

    public int? BedroomCount { get; set; }

    public int? BathroomCount { get; set; }

    public int? ToiletCount { get; set; }

    public int? TotalRoomCount { get; set; }

    public string? EnergyClass { get; set; }

    public double? EnergyConsumption { get; set; }

    public string? HeatingType { get; set; }

    public int? ConstructionYear { get; set; }

    public string? Condition { get; set; }

    public int PropertyId { get; set; }

    public virtual Property Property { get; set; } = null!;
}
