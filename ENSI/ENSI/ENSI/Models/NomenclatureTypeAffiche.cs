using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureTypeAffiche
{
    public string CodeTypeAffiche { get; set; } = null!;

    public string? LibeTypeAffiche { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
