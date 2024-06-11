using GoBee.Domain.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoBee.Infrastructure.Repositorios;

public interface IUsuarioRepositorio
{
    public Task<Usuario> FindByUsername(string username);
    public Task<IEnumerable<Usuario>> ListAllUsuarios();
}