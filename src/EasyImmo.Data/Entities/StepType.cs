using System;
using System.Collections.Generic;

namespace EasyImmo.Data.Entities;

public partial class StepType
{
    public int StepTypeId { get; set; }

    public string StepTypeName { get; set; } = null!;

    public virtual ICollection<FolderStep> FolderSteps { get; set; } = new List<FolderStep>();
}
