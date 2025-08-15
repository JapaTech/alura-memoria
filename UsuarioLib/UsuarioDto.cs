namespace UsuarioLib;

public record UsuarioDto
{
    public UsuarioDto(string nome, string email, List<string> telefones)
    {
        Nome = nome;
        Email = email;
        telefones = Telefones;
    }

    public string Nome { get; set; }
    public string Email { get; set; }
    public List<string> Telefones { get; set; }
}