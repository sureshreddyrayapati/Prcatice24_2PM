using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Prcatice24_2PM
{
    public class EntitesDb:DbContext
    {
        public EntitesDb():base("cn1") 
        {

        }
        public DbSet<Entitess> Entites { get; set; }
    }
}
