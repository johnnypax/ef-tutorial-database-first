using System;
using System.Collections.Generic;

namespace EF_lez01_single_table.Models;

public partial class Contatto
{
    public int ContattoId { get; set; }

    public string Nome { get; set; } = null!;

    public string Cognome { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string CodFis { get; set; } = null!;

    public int? Eta { get; set; }

    public override string ToString()
    {
        return $"[CONTATTO] {ContattoId} {Nome} {Cognome} {Email} {CodFis} {Eta}";
    }
}
