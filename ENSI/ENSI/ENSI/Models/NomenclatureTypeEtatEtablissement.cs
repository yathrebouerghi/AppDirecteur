using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureTypeEtatEtablissement
{
    public string CodeTypeEtatEtab { get; set; } = null!;

    public string? LibeTypeEtatEtab { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<NomenclatureEtatEtablissement> NomenclatureEtatEtablissements { get; set; } = new List<NomenclatureEtatEtablissement>();
}
