using System;
using System.Collections.Generic;

namespace EF_lez02_one_to_many.Models;

public partial class Persona
{
    public int PersonaId { get; set; }

    public string Nome { get; set; } = null!;

    public string Cognome { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<Cartum> Carta { get; set; } = new List<Cartum>();

    public override string ToString()
    {
        return $"[Persona] {PersonaId} {Nome} {Cognome} {Email}";
    }
}
