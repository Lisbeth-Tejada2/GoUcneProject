using GoUcneProject.Server.Models;

namespace GoUcneProject.Server.Repositorio.Interfaces
{
    public interface IRolRepositorio
    {
        Task<List<Rol>> Lista();
    }
}
