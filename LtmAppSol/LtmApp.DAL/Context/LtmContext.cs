using LtmApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text;

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
        public DbSet<Course> Course { get; set; }
        #endregion
    }
}