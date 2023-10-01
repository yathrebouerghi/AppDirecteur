using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureTypeSignalisation
{
    public string CodeTypeSignalisation { get; set; } = null!;

    public string? LibeTypeSignalisation { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<NomenclatureSignalisation> NomenclatureSignalisations { get; set; } = new List<NomenclatureSignalisation>();
}
