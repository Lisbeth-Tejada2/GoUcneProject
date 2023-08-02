using GoUcneProject.Shared;

namespace GoUcneProject.Client.Servicios.Interfaces
{
    public interface IRolService
    {
        Task<ResponseDTO<List<RolDTO>>> Lista();
    }
}
