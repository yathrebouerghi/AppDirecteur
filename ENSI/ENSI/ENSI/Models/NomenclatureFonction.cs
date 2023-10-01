using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureFonction
{
    /// <summary>
    /// Code Fonction
    /// </summary>
    public string CodeFonc { get; set; } = null!;

    /// <summary>
    /// Libellé Fonction (Arabe)
    /// </summary>
    public string? LibeFonc { get; set; }

    /// <summary>
    /// Order d&apos;affichage
    /// </summary>
    public int? OrdrAffi { get; set; }

    /// <summary>
    /// Actif (Oui/Non)
    /// </summary>
    public bool? Acti { get; set; }

    public virtual ICollection<PersonnelPersonnel> PersonnelPersonnel { get; set; } = new List<PersonnelPersonnel>();
}
