﻿using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class InspectionLienexterne
{
    public int NumeVisiInsp { get; set; }

    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string CodeLienExterne { get; set; } = null!;

    public string? LibeLienExterne { get; set; }

    public string? Observation { get; set; }
}
