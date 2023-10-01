using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureCercle
{
    public string CodeCerc { get; set; } = null!;

    public string? LibeCerc { get; set; }

    public string? CodeGouv { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
