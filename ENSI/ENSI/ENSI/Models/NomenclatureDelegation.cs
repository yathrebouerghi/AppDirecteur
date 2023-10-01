using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureDelegation
{
    /// <summary>
    /// Code délégation
    /// </summary>
    public string CodeDele { get; set; } = null!;

    /// <summary>
    /// Libellé délégation
    /// </summary>
    public string? LibeDele { get; set; }

    /// <summary>
    /// Code gouvernorat
    /// </summary>
    public string? CodeGouv { get; set; }

    /// <summary>
    /// Order d&apos;affichage
    /// </summary>
    public int? OrdrAffi { get; set; }

    /// <summary>
    /// Actif (Oui/Non)
    /// </summary>
    public bool? Acti { get; set; }

    public virtual NomenclatureGouvernorat? CodeGouvNavigation { get; set; }

    public virtual ICollection<EnfantNecessite> EnfantNecessites { get; set; } = new List<EnfantNecessite>();

    public virtual ICollection<EtablissementFicheEtablissement> EtablissementFicheEtablissements { get; set; } = new List<EtablissementFicheEtablissement>();

    public virtual ICollection<NomenclatureEtablissement> NomenclatureEtablissementCodeDeleFondNavigations { get; set; } = new List<NomenclatureEtablissement>();

    public virtual ICollection<NomenclatureEtablissement> NomenclatureEtablissementCodeDeleNavigations { get; set; } = new List<NomenclatureEtablissement>();

    public virtual ICollection<NomenclatureSignalisation> NomenclatureSignalisations { get; set; } = new List<NomenclatureSignalisation>();

    public virtual ICollection<PersonnelPersonnel> PersonnelPersonnel { get; set; } = new List<PersonnelPersonnel>();
}
