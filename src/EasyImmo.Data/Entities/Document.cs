using System;
using System.Collections.Generic;

namespace EasyImmo.Data.Entities;

public partial class Document
{
    public int DocumentId { get; set; }

    public string DocumentPath { get; set; } = null!;

    public DateTime DocumentDate { get; set; }

    public bool DocumentIsSigned { get; set; }

    public DateTime? DocumentSignatureDate { get; set; }

    public int DocumentTypeId { get; set; }

    public int FolderId { get; set; }

    public virtual DocumentType DocumentType { get; set; } = null!;

    public virtual Folder Folder { get; set; } = null!;
}
