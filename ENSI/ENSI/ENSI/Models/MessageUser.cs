using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class MessageUser
{
    public int IdMessage { get; set; }

    public string CodeUtil { get; set; } = null!;

    public DateTime? Datereception { get; set; }

    public string Observation { get; set; } = null!;

    public int? Lu { get; set; }

    public virtual MessageMessage IdMessageNavigation { get; set; } = null!;
}
