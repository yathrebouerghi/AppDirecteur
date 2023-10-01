using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureEtatReclamation
{
    /// <summary>
    /// Commune
    /// </summary>
    public string CodeEtatRecl { get; set; } = null!;

    public string? LibeEtatRecl { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<ReclamationReclamationParent> ReclamationReclamationParents { get; set; } = new List<ReclamationReclamationParent>();

    public virtual ICollection<ReclamationReclamation> ReclamationReclamations { get; set; } = new List<ReclamationReclamation>();
}
