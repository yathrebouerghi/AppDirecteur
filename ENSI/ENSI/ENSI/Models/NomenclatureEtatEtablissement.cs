using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureEtatEtablissement
{
    /// <summary>
    /// Code type établissement
    /// </summary>
    public string CodeEtatEtab { get; set; } = null!;

    /// <summary>
    /// Libellé type établissement (Arabe)
    /// </summary>
    public string? LibeEtatEtab { get; set; }

    /// <summary>
    /// Order d&apos;affichage
    /// </summary>
    public int? OrdrAffi { get; set; }

    /// <summary>
    /// Actif (Oui/Non)
    /// </summary>
    public bool? Acti { get; set; }

    public string? CodeTypeEtatEtab { get; set; }

    public virtual NomenclatureTypeEtatEtablissement? CodeTypeEtatEtabNavigation { get; set; }
}
