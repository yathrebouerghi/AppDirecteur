using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureTrangeAgeCouv
{
    public string CodeTranCouv { get; set; } = null!;

    public string? LibeTranCouv { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
