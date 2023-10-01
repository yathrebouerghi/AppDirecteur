﻿using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class ViewActivite
{
    public int CodeAct { get; set; }

    public string? Codegouv { get; set; }

    public int? AnneScol { get; set; }

    public string? CodeSecFor { get; set; }

    public string? CodeNatAct { get; set; }

    public DateTime? DateAct { get; set; }

    public string? SujetAct { get; set; }

    public string? LieuAct { get; set; }

    public int? NbFemme { get; set; }

    public int? NbHomme { get; set; }

    public string? Typepart { get; set; }

    public DateTime? Daterapport { get; set; }

    public string? Codeutilrapport { get; set; }

    public string? ActiviteAct { get; set; }

    public string? Observation { get; set; }

    public DateTime? Datecreation { get; set; }

    public string? Codeutil { get; set; }

    public DateTime? Datemodification { get; set; }

    public string? CodeutilM { get; set; }

    public string? LibesecFor { get; set; }

    public string? Libegouv { get; set; }

    public string? LibeNatAct { get; set; }

    public string? Participant { get; set; }

    public string? Moisactivite { get; set; }
}
