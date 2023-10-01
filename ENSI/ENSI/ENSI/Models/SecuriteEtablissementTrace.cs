using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class SecuriteEtablissementTrace
{
    public string? Codeutil { get; set; }

    public string? CodeutilSecurite { get; set; }

    public DateTime? Dateoperaion { get; set; }

    public string? Operation { get; set; }

    public string? Detail { get; set; }
}
