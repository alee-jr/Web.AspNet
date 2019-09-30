using _07_Fiap.WebAspNEt.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07_Fiap.WebAspNEt.Banco
{
    public class BanguContext : DbContext
    {
        public DbSet<Cela> Celas { get; set; }
        public DbSet<Presidiario> Presidiarios { get; set; }
        public BanguContext(DbContextOptions o) : base(o)
        {
                
        }
    }
}
