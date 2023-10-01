using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureNationalite
{
    public string CodeNati { get; set; } = null!;

    public string LibeNati { get; set; } = null!;

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<EleveRepartitionNationalite> EleveRepartitionNationalites { get; set; } = new List<EleveRepartitionNationalite>();
}
