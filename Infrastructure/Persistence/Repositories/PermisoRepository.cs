using Domain.Entities.Permisos;

namespace Infrastructure.Persistence.Repositories;

internal class PermisoRepository : IPermisoRepository
{
    private readonly ApplicationDbContext _context;

    public PermisoRepository(ApplicationDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public void Add(Permiso permiso) => _context.Permisos.Add(permiso);
    public void Delete(Permiso permiso) => _context.Permisos.Remove(permiso);
    public void Update(Permiso permiso) => _context.Permisos.Update(permiso);
    public async Task<bool> ExistsAsync(int id) => await _context.Permisos.AnyAsync(permiso => permiso.Id == id);
    public async Task<Permiso?> GetByIdAsync(int id) => await _context.Permisos.SingleOrDefaultAsync(c => c.Id == id);
    public async Task<List<Permiso>> GetAll() => await _context.Permisos.ToListAsync();
}

