using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class ViewNomenclatureCommune
{
    public string CodeComm { get; set; } = null!;

    public string? LibeComm { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public string? CodeDele { get; set; }
}
