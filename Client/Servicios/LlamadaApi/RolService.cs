using GoUcneProject.Client.Servicios.Interfaces;
using GoUcneProject.Shared;
using System.Net.Http.Json;

namespace GoUcneProject.Client.Servicios.LlamadaApi
{
    public class RolService : IRolService
    {

        private readonly HttpClient _http;
        public RolService(HttpClient http)
        {
            _http = http;
        }
        public async Task<ResponseDTO<List<RolDTO>>> Lista()
        {
            var result = await _http.GetFromJsonAsync<ResponseDTO<List<RolDTO>>>("api/rol/Lista");
            return result!;
        }
    }
}
