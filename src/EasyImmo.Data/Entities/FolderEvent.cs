using System;
using System.Collections.Generic;

namespace EasyImmo.Data.Entities;

public partial class FolderEvent
{
    public int FolderEventId { get; set; }

    public int FolderId { get; set; }

    public int EventId { get; set; }

    public virtual Event Event { get; set; } = null!;

    public virtual Folder Folder { get; set; } = null!;
}
