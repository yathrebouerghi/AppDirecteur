using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureGrade
{
    public string CodeGrad { get; set; } = null!;

    public string? LibeGrad { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<PersonnelPersonnel> PersonnelPersonnel { get; set; } = new List<PersonnelPersonnel>();
}
