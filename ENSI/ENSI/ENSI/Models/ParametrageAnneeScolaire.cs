using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class ParametrageAnneeScolaire
{
    public int AnneScol { get; set; }

    public string? Obse { get; set; }

    public DateTime? DateInit { get; set; }

    public string? CodeUtil { get; set; }

    public bool? Acti { get; set; }
}
