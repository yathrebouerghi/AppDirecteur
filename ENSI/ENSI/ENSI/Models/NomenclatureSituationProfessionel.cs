using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureSituationProfessionel
{
    public string CodeSituProf { get; set; } = null!;

    public string? LibeSituProf { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<PersonnelPersonnel> PersonnelPersonnel { get; set; } = new List<PersonnelPersonnel>();
}
