using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureNaturePere
{
    public string CodeNaturePere { get; set; } = null!;

    public string? LibeNaturePere { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
