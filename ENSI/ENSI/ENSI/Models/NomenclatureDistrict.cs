using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureDistrict
{
    /// <summary>
    /// Code district
    /// </summary>
    public string CodeDist { get; set; } = null!;

    /// <summary>
    /// Libellé district
    /// </summary>
    public string? LibeDist { get; set; }

    /// <summary>
    /// Order d&apos;affichage
    /// </summary>
    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<NomenclatureGouvernorat> NomenclatureGouvernorats { get; set; } = new List<NomenclatureGouvernorat>();
}
