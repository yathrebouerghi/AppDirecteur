﻿using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureTerrain
{
    public string CodeTerrain { get; set; } = null!;

    public string? LibeTerrain { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
