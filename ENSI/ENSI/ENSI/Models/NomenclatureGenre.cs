﻿using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureGenre
{
    /// <summary>
    /// Code genre
    /// </summary>
    public string CodeGenr { get; set; } = null!;

    /// <summary>
    /// Libellé genre (Arabe)
    /// </summary>
    public string? LibeGenr { get; set; }

    /// <summary>
    /// Order d&apos;affichage
    /// </summary>
    public int? OrdrAffi { get; set; }

    /// <summary>
    /// Actif (Oui/Non)
    /// </summary>
    public bool? Acti { get; set; }

    public virtual ICollection<EleveEleveHandicap> EleveEleveHandicaps { get; set; } = new List<EleveEleveHandicap>();

    public virtual ICollection<PersonnelPersonnel> PersonnelPersonnel { get; set; } = new List<PersonnelPersonnel>();
}
