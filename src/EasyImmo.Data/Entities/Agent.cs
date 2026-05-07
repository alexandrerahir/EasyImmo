using System;
using System.Collections.Generic;

namespace EasyImmo.Data.Entities;

public partial class Agent
{
    public int AgentId { get; set; }

    public string FirstNameAgent { get; set; } = null!;

    public string LastNameAgent { get; set; } = null!;

    public string EmailAgent { get; set; } = null!;

    public string PhoneAgent { get; set; } = null!;

    public string PasswordAgent { get; set; } = null!;

    public virtual ICollection<AgentEvent> AgentEvents { get; set; } = new List<AgentEvent>();

    public virtual ICollection<Listing> Listings { get; set; } = new List<Listing>();
}
