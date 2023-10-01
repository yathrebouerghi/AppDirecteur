using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureTypeFormation
{
    public string CodeTypeForm { get; set; } = null!;

    public string? LibeTypeForm { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<PersonnelFormationContinue> PersonnelFormationContinues { get; set; } = new List<PersonnelFormationContinue>();
}
