using System;
using System.Collections.Generic;

namespace EasyImmo.Data.Entities;

public partial class Photo
{
    public int PhotoId { get; set; }

    public string PhotoUrl { get; set; } = null!;

    public int PropertyId { get; set; }

    public virtual Property Property { get; set; } = null!;
}
