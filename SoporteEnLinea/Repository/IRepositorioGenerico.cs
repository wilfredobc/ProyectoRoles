using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoporteEnLinea.Repository
{
    public interface IRepositorioGenerico<t> where t : class
    {
        Task<IEnumerable<t>> ObtenerTodosAsync();
        Task<t> BuscarAsync(int? Id);
        Task AgregarAsync(t obj);
        Task ActualizarAsync(t obj);
        Task Eliminar(int? Id);
    }
}
