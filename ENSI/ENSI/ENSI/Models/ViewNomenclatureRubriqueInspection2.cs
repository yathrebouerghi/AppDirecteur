using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class ViewNomenclatureRubriqueInspection2
{
    public string CodeRubrInsp { get; set; } = null!;

    public string? LibeRubrInsp { get; set; }

    public string CodeCateRubrInsp { get; set; } = null!;

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public string CodeTypeEtab { get; set; } = null!;
}
