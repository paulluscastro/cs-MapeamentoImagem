using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapeamentoImagem.Classes
{
    public class DataContext : DbContext
    {
        public DbSet<Crianca> Criancas { get; set; }

        public DataContext()
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = true;
        }
    }
}
