﻿using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureCommune
{
    /// <summary>
    /// Commune
    /// </summary>
    public string CodeComm { get; set; } = null!;

    public string? LibeComm { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public string? CodeDele { get; set; }

    public virtual ICollection<EnfantNecessite> EnfantNecessites { get; set; } = new List<EnfantNecessite>();

    public virtual ICollection<NomenclatureEtablissement> NomenclatureEtablissements { get; set; } = new List<NomenclatureEtablissement>();
}
