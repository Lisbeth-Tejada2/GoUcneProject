
using GoUcneProject.Shared;
namespace GoUcneProject.Client.Servicios.Interfaces
{
    public interface ICategoriaService
    {
        Task<ResponseDTO<List<CategoriaDTO>>> Lista();
    }
}
