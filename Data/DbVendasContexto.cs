using Microsoft.EntityFrameworkCore;
using Vendas.Models;

namespace Vendas.Data
{
    public class DbVendasContexto : DbContext
    {
        public DbVendasContexto(DbContextOptions<DbVendasContexto> options) : base(options)
        {

        }
        DbSet<Vendedor> Vendedores{get;set;}

    }
}