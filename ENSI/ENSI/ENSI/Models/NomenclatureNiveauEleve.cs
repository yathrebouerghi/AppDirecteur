using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureNiveauEleve
{
    public string CodeNivEle { get; set; } = null!;

    public string? LibeNivEle { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
