using GoBee.Domain.Usuarios;

namespace GoBee.Infrastructure.Repositorios;

internal class UsuarioRepositorio : IUsuarioRepositorio
{
    Task<Usuario> IUsuarioRepositorio.FindByUsername(string username)
    {
        throw new NotImplementedException();
    }

    Task<IEnumerable<Usuario>> IUsuarioRepositorio.ListAllUsuarios()
    {
        throw new NotImplementedException();
    }
}
