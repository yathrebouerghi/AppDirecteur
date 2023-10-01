using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class MessageFichier
{
    public int IdMessage { get; set; }

    public string? Nomfichier { get; set; }

    public string? Extension { get; set; }

    public byte[]? Fichier { get; set; }

    public string? Observation { get; set; }

    public virtual MessageMessage IdMessageNavigation { get; set; } = null!;
}
