using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxia.Dados.Contexto
{
    public class GalaxiaContext : DbContext
    {
        public DbSet<Planeta> Planeta { get; set; }
        public GalaxiaContext() : base("Default")
        {
            
        }
    }
}
