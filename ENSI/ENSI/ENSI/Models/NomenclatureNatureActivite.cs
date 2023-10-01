using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureNatureActivite
{
    public string CodeNatAct { get; set; } = null!;

    public string? LibeNatAct { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
