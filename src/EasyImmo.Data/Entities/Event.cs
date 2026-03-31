using System;
using System.Collections.Generic;

namespace EasyImmo.Data.Entities;

public partial class Event
{
    public int EventId { get; set; }

    public DateTime EventDate { get; set; }

    public string? EventNote { get; set; }

    public int EventTypeId { get; set; }

    public virtual ICollection<AgentEvent> AgentEvents { get; set; } = new List<AgentEvent>();

    public virtual EventType EventType { get; set; } = null!;

    public virtual ICollection<FolderEvent> FolderEvents { get; set; } = new List<FolderEvent>();
}
