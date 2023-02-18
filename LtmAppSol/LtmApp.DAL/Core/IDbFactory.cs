using Microsoft.EntityFrameworkCore;

namespace LtmApp.DAL.Core
{
    public class IDbFactory
    {
        DbContext GetDbContext { get; }
    }
}
