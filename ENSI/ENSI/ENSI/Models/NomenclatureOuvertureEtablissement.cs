using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureOuvertureEtablissement
{
    public string CodeOuveEtab { get; set; } = null!;

    public string? LibeOuveEtab { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<EtablissementFicheEtablissement> EtablissementFicheEtablissements { get; set; } = new List<EtablissementFicheEtablissement>();
}
