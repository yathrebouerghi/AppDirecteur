using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class InspectionNiveauEtude
{
    public int NumeVisiInsp { get; set; }

    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string CodeNivEle { get; set; } = null!;

    public string? LibeNivEle { get; set; }

    public int? Nombenfant { get; set; }
}
