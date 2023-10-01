using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureEtatPsycologique
{
    public string CodeEtatPsyc { get; set; } = null!;

    public string LibeEtatPsyc { get; set; } = null!;

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<EleveRepartitionEtatPsycologique> EleveRepartitionEtatPsycologiques { get; set; } = new List<EleveRepartitionEtatPsycologique>();
}
