using Microsoft.EntityFrameworkCore;
namespace CreatedMVC.Data
{
    public class BancoContext :DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<Models.ContatoModel> Contatos { get; set; }
    }
}
