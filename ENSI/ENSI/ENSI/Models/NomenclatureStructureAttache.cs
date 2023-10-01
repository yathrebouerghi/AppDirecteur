using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureStructureAttache
{
    public string CodeStruAtta { get; set; } = null!;

    public string? LibeStruAtta { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
