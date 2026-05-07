using System;
using System.Collections.Generic;

namespace EasyImmo.Data.Entities;

public partial class AgentEvent
{
    public int AgentEventId { get; set; }

    public int AgentId { get; set; }

    public int EventId { get; set; }

    public virtual Agent Agent { get; set; } = null!;

    public virtual Event Event { get; set; } = null!;
}
