﻿using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class ViewNomenclatureDelegation
{
    public string CodeDele { get; set; } = null!;

    public string? LibeDele { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public string CodeGouv { get; set; } = null!;

    public string? LibeGouv { get; set; }
}
