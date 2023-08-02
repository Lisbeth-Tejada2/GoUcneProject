using GoUcneProject.Server.Models;

namespace GoUcneProject.Server.Repositorio.Interfaces
{
    public interface ICategoriaRepositorio
    {
        Task<List<Categoria>> Lista();
    }
}
