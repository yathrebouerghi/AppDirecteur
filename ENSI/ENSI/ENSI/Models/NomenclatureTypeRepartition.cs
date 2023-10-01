using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureTypeRepartition
{
    public string CodeTypeRepar { get; set; } = null!;

    public string? LibeTypeRepar { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
