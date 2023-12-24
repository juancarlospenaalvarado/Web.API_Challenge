namespace Domain.Entities.Permisos;

public interface IPermisoRepository
{
    Task<List<Permiso>> GetAll();
    Task<Permiso?> GetByIdAsync(int id);
    Task<bool> ExistsAsync(int id);
    void Add(Permiso permiso);
    void Update(Permiso permiso);
    void Delete(Permiso permiso);
}
