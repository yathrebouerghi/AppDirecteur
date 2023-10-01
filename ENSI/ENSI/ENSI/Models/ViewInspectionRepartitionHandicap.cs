using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class ViewInspectionRepartitionHandicap
{
    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string? LibeTypeHand { get; set; }

    public int? NombMasc { get; set; }

    public int? NombFemi { get; set; }

    public int? NombTota { get; set; }
}
