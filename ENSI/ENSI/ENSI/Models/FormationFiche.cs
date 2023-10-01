﻿using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class FormationFiche
{
    public int Codeformation { get; set; }

    public string? Codegouv { get; set; }

    public int? Annescol { get; set; }

    public string? CodeSecFor { get; set; }

    public string? CodeNivFor { get; set; }

    public string? CodeNatFor { get; set; }

    public DateTime? Dateformation { get; set; }

    public int? NbJourFomration { get; set; }

    public int? NbheureFormation { get; set; }

    public string? SujetFormation { get; set; }

    public string? LieurFormation { get; set; }

    public string? ButFormation { get; set; }

    public int? NbFemme { get; set; }

    public int? NbHomme { get; set; }

    public string? Organisation { get; set; }

    public string? Inspecteur { get; set; }

    public string? CodeCerc { get; set; }

    public string? NomFormateur { get; set; }

    public string? CodeNatFormateur { get; set; }

    public string? PrixFormation { get; set; }

    public string? InvesFormation { get; set; }

    public DateTime? Daterapport { get; set; }

    public string? Codeutilrapport { get; set; }

    public string? Activiteformation { get; set; }

    public string? Observation { get; set; }

    public DateTime? Datecreation { get; set; }

    public string? Codeutil { get; set; }

    public DateTime? Datemodification { get; set; }

    public string? CodeutilM { get; set; }
}
