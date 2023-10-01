﻿using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureInfrastrcture
{
    public string CodeInfrastrcture { get; set; } = null!;

    public string? LibeInfrastrcture { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<EtablissementInfrastructureAutre> EtablissementInfrastructureAutres { get; set; } = new List<EtablissementInfrastructureAutre>();
}
