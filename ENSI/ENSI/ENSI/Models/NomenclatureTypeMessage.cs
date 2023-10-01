using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class NomenclatureTypeMessage
{
    public string CodeTypeM { get; set; } = null!;

    public string LibeTypeM { get; set; } = null!;

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<MessageMessage> MessageMessages { get; set; } = new List<MessageMessage>();
}
