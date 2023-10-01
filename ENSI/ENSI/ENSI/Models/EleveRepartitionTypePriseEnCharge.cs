﻿using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class EleveRepartitionTypePriseEnCharge
{
    /// <summary>
    /// Code établissement
    /// </summary>
    public string CodeEtab { get; set; } = null!;

    /// <summary>
    /// Année scolaire
    /// </summary>
    public int AnneScol { get; set; }

    /// <summary>
    /// Code Niveau d&apos;Etude
    /// </summary>
    public string CodeTypePrisChar { get; set; } = null!;

    public int? NombFemi { get; set; }

    public int? NombMasc { get; set; }

    public virtual NomenclatureTypePriseEnCharge CodeTypePrisCharNavigation { get; set; } = null!;

    public virtual EtablissementFicheEtablissement EtablissementFicheEtablissement { get; set; } = null!;
}
