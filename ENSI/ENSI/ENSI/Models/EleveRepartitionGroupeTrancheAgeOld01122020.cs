﻿using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class EleveRepartitionGroupeTrancheAgeOld01122020
{
    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string CodeTranAge { get; set; } = null!;

    public int? NombGrou { get; set; }

    public int? NombPersPourGrou { get; set; }
}
