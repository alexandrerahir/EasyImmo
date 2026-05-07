using System;
using System.Collections.Generic;

namespace EasyImmo.Data.Entities;

public partial class FolderStep
{
    public int FolderStepId { get; set; }

    public DateTime FolderStepDate { get; set; }

    public string? FolderStepNote { get; set; }

    public int FolderId { get; set; }

    public int StepTypeId { get; set; }

    public virtual Folder Folder { get; set; } = null!;

    public virtual StepType StepType { get; set; } = null!;
}
