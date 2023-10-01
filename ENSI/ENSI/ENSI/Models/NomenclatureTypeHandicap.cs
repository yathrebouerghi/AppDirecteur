using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureTypeHandicap
{
    public string CodeTypeHand { get; set; } = null!;

    public string? LibeTypeHand { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<EleveEleveHandicap> EleveEleveHandicaps { get; set; } = new List<EleveEleveHandicap>();
}
