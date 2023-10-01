using System;
using System.Collections.Generic;

namespace ENSI.Models;

public partial class EtablissementClubGeneral
{
    public int NumeVisiInsp { get; set; }

    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string? PrixClub { get; set; }

    public int? NbInscrit { get; set; }
}
