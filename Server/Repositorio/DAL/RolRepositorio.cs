using Microsoft.EntityFrameworkCore;
using GoUcneProject.Server.Models;
using GoUcneProject.Server.Repositorio.Interfaces;

namespace GoUcneProject.Server.Repositorio.DAL
{
    public class RolRepositorio : IRolRepositorio
    {
        private readonly DbventaBlazorContext _dbContext;

        public RolRepositorio(DbventaBlazorContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Rol>> Lista()
        {
            try
            {
                return await _dbContext.Rols.ToListAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
