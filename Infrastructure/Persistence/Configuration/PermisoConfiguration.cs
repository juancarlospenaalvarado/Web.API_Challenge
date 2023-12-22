using Domain.Permisos;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configuration;

internal class PermisoConfiguration : IEntityTypeConfiguration<Permiso>
{
    public void Configure(EntityTypeBuilder<Permiso> builder)
    {
        builder.ToTable("Permisos");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.NombreEmpleado).HasMaxLength(50);

        builder.Property(c => c.ApellidoEmpleado).HasMaxLength(50);

        builder.Property(c => c.TipoPermiso).HasMaxLength(50);

        builder.Property(c => c.FechaPermiso).HasMaxLength(9);
    }
}

