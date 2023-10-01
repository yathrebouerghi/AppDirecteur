using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureNatureformateur
{
    public string CodeNatFor { get; set; } = null!;

    public string? LibeNatFor { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
