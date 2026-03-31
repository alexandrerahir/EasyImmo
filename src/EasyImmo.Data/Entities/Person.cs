using System;
using System.Collections.Generic;

namespace EasyImmo.Data.Entities;

public partial class Person
{
    public int PersonId { get; set; }

    public string FirstNamePerson { get; set; } = null!;

    public string LastNamePerson { get; set; } = null!;

    public string EmailPerson { get; set; } = null!;

    public string PhonePerson { get; set; } = null!;

    public int AddressId { get; set; }

    public virtual Address Address { get; set; } = null!;

    public virtual ICollection<Folder> Folders { get; set; } = new List<Folder>();

    public virtual ICollection<Property> Properties { get; set; } = new List<Property>();
}
