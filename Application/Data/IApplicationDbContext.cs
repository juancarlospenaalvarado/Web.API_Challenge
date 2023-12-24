using Domain.Entities.Permisos;
using Microsoft.EntityFrameworkCore;

namespace Application.Data;

public interface IApplicationDbContext
{
    
    DbSet<Permiso> Permisos { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
