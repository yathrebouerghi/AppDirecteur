using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class SignalisationFichier
{
    public int CodeFichier { get; set; }

    public int? CodeSignalisation { get; set; }

    public string? NomFichier { get; set; }

    public string? Extension { get; set; }

    public byte[]? Data { get; set; }
}
