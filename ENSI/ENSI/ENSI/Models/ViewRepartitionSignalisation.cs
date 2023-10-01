﻿using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class ViewRepartitionSignalisation
{
    public int CodeSignalisation { get; set; }

    public string? NomInformateur { get; set; }

    public string? Tel { get; set; }

    public string? Message { get; set; }

    public string? CodeTypeSignalisation { get; set; }

    public DateTime? DateCreation { get; set; }

    public string? Ville { get; set; }

    public string? Email { get; set; }

    public string? NomConcerne { get; set; }

    public string? AdresseConcerne { get; set; }

    public string? CodeConcerne { get; set; }

    public string? CodeInformateur { get; set; }

    public string? VilleConcerne { get; set; }

    public string? Etablissement { get; set; }

    public string? Fichier { get; set; }

    public string? CodeGouv { get; set; }

    public string? CodeDele { get; set; }

    public string? DateSignalisation { get; set; }

    public string? MethodeSignalisation { get; set; }

    public DateTime? DateDepot { get; set; }

    public string? NumeroDepot { get; set; }

    public string? TypeSignalisation { get; set; }

    public string? ChefService { get; set; }

    public string? CodeInspecteur { get; set; }

    public string? CodeResponsable { get; set; }

    public DateTime? DateChefService { get; set; }

    public DateTime? DateInfoInspecteur { get; set; }

    public DateTime? DateAnalyse { get; set; }

    public string? TextAnalyse { get; set; }

    public string? Avis { get; set; }

    public DateTime? DateCloture { get; set; }

    public string? CodeStatus { get; set; }

    public string? ObservationChefService { get; set; }

    public string? ResultatChefService { get; set; }

    public string? TypeEtablissement { get; set; }

    public int? AnneScol { get; set; }

    public bool? Acti { get; set; }

    public string? MotifSupression { get; set; }

    public string? Inspecteur2 { get; set; }

    public DateTime? Datevisite { get; set; }

    public DateTime? Datecreationrapport { get; set; }

    public bool? ConusltatEnfance { get; set; }

    public string? LibeInformateur { get; set; }

    public string? LibeConcerne { get; set; }

    public string? LibeTypeEtab { get; set; }

    public string? Responsable { get; set; }

    public string? Methode { get; set; }

    public string Numrapport { get; set; } = null!;

    public string? TypeSign { get; set; }

    public string? ResponsableSignalisation { get; set; }

    public string? MoisSignalisation { get; set; }

    public string LibeTypeEtatEtab { get; set; } = null!;

    public string Enfance { get; set; } = null!;

    public string? LibeEtatSignalisation { get; set; }

    public string? Anomalie { get; set; }

    public string? LibeGouv { get; set; }

    public string? LibeDist { get; set; }
}
