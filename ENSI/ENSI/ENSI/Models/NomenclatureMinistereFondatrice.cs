using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureMinistereFondatrice
{
    public string CodeMiniFond { get; set; } = null!;

    public string LibeMiniFond { get; set; } = null!;

    public int OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
