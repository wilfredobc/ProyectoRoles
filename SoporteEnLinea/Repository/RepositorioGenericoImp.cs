using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SoporteEnLinea.Repository;
using SoporteEnLinea.Models;
using System.Data.Entity;

namespace SoporteEnLinea.Data
{
    public class RepositorioGenericoImp<t> : IRepositorioGenerico<t> where t : class
    {
        ApplicationDbContext db;
        DbSet<t> table;

        public RepositorioGenericoImp()
        {
            db = new ApplicationDbContext();
            table = db.Set<t>();
        }

        public async Task ActualizarAsync(t obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public async Task AgregarAsync(t obj)
        {
            table.Add(obj);
            await db.SaveChangesAsync();
        }

        public async Task<t> BuscarAsync(int? Id)
        {
            return await table.FindAsync(Id);
        }

        public async Task Eliminar(int? Id)
        {
            var obj = await table.FindAsync(Id);
            table.Remove(obj);
            await db.SaveChangesAsync();            
        }

        public async Task<IEnumerable<t>> ObtenerTodosAsync()
        {
            return await table.ToListAsync();            
        }
    }
}