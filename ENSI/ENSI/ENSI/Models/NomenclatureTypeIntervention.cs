using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureTypeIntervention
{
    public string CodeTypeInterv { get; set; } = null!;

    public string? LibeTypeInterv { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
