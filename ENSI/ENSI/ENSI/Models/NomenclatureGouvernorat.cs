using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureGouvernorat
{
    /// <summary>
    /// Code gouvernorat
    /// </summary>
    public string CodeGouv { get; set; } = null!;

    /// <summary>
    /// Libellé gouvernorat
    /// </summary>
    public string? LibeGouv { get; set; }

    /// <summary>
    /// District
    /// </summary>
    public string? CodeDist { get; set; }

    /// <summary>
    /// Order d&apos;affichage
    /// </summary>
    public int? OrdrAffi { get; set; }

    /// <summary>
    /// Actif (Oui/Non)
    /// </summary>
    public bool? Acti { get; set; }

    public virtual NomenclatureDistrict? CodeDistNavigation { get; set; }

    public virtual ICollection<NomenclatureDelegation> NomenclatureDelegations { get; set; } = new List<NomenclatureDelegation>();

    public virtual ICollection<NomenclatureSignalisation> NomenclatureSignalisations { get; set; } = new List<NomenclatureSignalisation>();
}
