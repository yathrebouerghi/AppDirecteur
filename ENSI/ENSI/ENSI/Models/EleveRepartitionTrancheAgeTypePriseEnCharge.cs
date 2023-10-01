﻿using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class EleveRepartitionTrancheAgeTypePriseEnCharge
{
    /// <summary>
    /// Code établissement
    /// </summary>
    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string CodeTranAge { get; set; } = null!;

    public string CodeTypePrisChar { get; set; } = null!;

    public int? NombFemi { get; set; }

    public int? NombMasc { get; set; }

    public virtual NomenclatureTrancheAge CodeTranAgeNavigation { get; set; } = null!;

    public virtual NomenclatureTypePriseEnCharge CodeTypePrisCharNavigation { get; set; } = null!;

    public virtual EtablissementFicheEtablissement EtablissementFicheEtablissement { get; set; } = null!;
}
