﻿using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class ViewIntervention
{
    public string CodeInterv { get; set; } = null!;

    public string? Libeinterv { get; set; }

    public bool? Checked { get; set; }

    public string? Observation { get; set; }

    public string? LibeDele { get; set; }

    public string? Libegouv { get; set; }

    public string? LibeDist { get; set; }

    public string? CodeDele { get; set; }

    public string? CodeGouv { get; set; }

    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string? LibeZone { get; set; }

    public string? LibeTypeEtab { get; set; }

    public string? LibeSect { get; set; }

    public string LibeEtab { get; set; } = null!;

    public string? LibeEtatEtab { get; set; }

    public string LibeTypeEtatEtab { get; set; } = null!;

    public string? LibeCommEtab { get; set; }
}
