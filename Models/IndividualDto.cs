using System;

public class IndividualDto
{
    public Guid Id { get; internal set; }
    public string Nome { get; set; }
    public string NomePai { get; set; }
    public string NomeMae { get; set; }
    public string NomeResponsavel { get; set; }
}
