using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureEmplacementEtablissement
{
    /// <summary>
    /// خصائص الفضاء الخارجي
    /// </summary>
    public string CodeEmpl { get; set; } = null!;

    public string? LibeEmpl { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
