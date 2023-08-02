using GoUcneProject.Shared;

namespace GoUcneProject.Client.Servicios.Interfaces
{
    public interface IDashBoardService
    {
        Task<ResponseDTO<DashBoardDTO>> Resumen();
    }
}
