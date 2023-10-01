using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureClub
{
    public string CodeClub { get; set; } = null!;

    public string? LibeClub { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
