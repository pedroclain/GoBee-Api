namespace GoBee.Domain.Usuarios;

public class Usuario : Entity
{
    public required string Nome { get; set; }
    public required string Senha{ get; set; }
    public required string Email { get; set; }
    public required PerfilUsuario Perfil { get; set; }
}
