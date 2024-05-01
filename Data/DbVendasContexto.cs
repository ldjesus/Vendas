using Microsoft.EntityFrameworkCore;

namespace VENDAS.Data
{
    public class DbVendasContexto : DbContext
    {
        public DbVendasContexto(DbContextOptions<DbVendasContexto> options) : base(options)
        {

        }
        DbSet<Vendedor> Vendedores{get;set;}

    }
}