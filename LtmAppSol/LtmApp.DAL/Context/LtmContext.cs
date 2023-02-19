using LtmApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace LtmApp.DAL.Context
{
    public class LtmContext : DbContext
    {
        public LtmContext()
        {

        }
        public LtmContext(DbContextOptions<LtmContext> options) : base(options)
        {
        }
        #region "Registros"
        public DbSet<Department> Department { get; set; }
        #endregion
    }
}