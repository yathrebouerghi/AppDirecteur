using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class EtablissementLienexterne
{
    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string CodeLienExterne { get; set; } = null!;

    public bool? Checked { get; set; }

    public string? Observation { get; set; }
}
