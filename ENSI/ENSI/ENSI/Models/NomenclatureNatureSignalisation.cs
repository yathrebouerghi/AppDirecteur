﻿using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureNatureSignalisation
{
    public string CodeNatureSignalisation { get; set; } = null!;

    public string? LibeNatureSignalisation { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
