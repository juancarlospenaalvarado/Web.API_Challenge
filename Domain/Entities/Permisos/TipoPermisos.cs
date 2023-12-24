using Domain.Primitives;

namespace Domain.Entities.Permisos
{
    public class TipoPermisos : AggregateRoot
    {

        public TipoPermisos(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }


        private TipoPermisos() { }

        public int Id { get; init; }
        public string Descripcion { get; set; } = string.Empty;


    }
}
