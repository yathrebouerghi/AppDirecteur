using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class ViewNomenclatureGouvernorat
{
    public string CodeGouv { get; set; } = null!;

    public string? LibeGouv { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public string? LibeDist { get; set; }

    public string CodeDist { get; set; } = null!;
}
