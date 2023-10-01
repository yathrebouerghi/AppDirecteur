using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureTypeConnexionInternet
{
    /// <summary>
    /// خصائص الفضاء الخارجي
    /// </summary>
    public string CodeTypeConnInte { get; set; } = null!;

    public string? LibeTypeConnInte { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
