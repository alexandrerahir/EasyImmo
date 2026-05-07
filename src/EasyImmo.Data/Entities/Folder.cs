using System;
using System.Collections.Generic;

namespace EasyImmo.Data.Entities;

public partial class Folder
{
    public int FolderId { get; set; }

    public DateTime FolderOpenDate { get; set; }

    public DateTime? FolderCloseDate { get; set; }

    public string? FolderCloseReason { get; set; }

    public int ListingId { get; set; }

    public int PersonId { get; set; }

    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();

    public virtual ICollection<FolderEvent> FolderEvents { get; set; } = new List<FolderEvent>();

    public virtual ICollection<FolderStep> FolderSteps { get; set; } = new List<FolderStep>();

    public virtual Listing Listing { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;
}
