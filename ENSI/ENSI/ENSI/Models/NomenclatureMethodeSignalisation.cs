using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureMethodeSignalisation
{
    public string CodeMethodeSignalisation { get; set; } = null!;

    public string? LibeMethodeSignalisation { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
