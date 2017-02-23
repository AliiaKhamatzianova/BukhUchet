using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;

namespace BukhUchet.Models
{
    public class DBContext : DbContext
    {
        public DBContext() : base("DBContext")
        {

        }

        public virtual DbSet<Rasxod> Rasxods {get;set;}
    }
}
