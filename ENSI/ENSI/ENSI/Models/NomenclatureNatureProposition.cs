﻿using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureNatureProposition
{
    public string CodeNatPro { get; set; } = null!;

    public string? LibeNatPro { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
