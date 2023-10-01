using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureTypeproposition
{
    public string CodetypePro { get; set; } = null!;

    public string? LibetypePro { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
