using Microsoft.EntityFrameworkCore;
using GoUcneProject.Server.Models;
using GoUcneProject.Server.Repositorio.Interfaces;

namespace GoUcneProject.Server.Repositorio.DAL
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly DbventaBlazorContext _dbContext;

        public CategoriaRepositorio(DbventaBlazorContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Categoria>> Lista()
        {
            try
            {
                return await _dbContext.Categoria.ToListAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
