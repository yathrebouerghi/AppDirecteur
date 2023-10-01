using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureEtatSignalisation
{
    public string CodeEtatSignalisation { get; set; } = null!;

    public string? LibeEtatSignalisation { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
