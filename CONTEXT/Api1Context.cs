using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API._1.CONTEXT
{
    public class Api1Context : DbContext
    {
        public Api1Context(DbContextOptions<Api1Context> options) : base(options)
        {

    }
        
        public DbSet<MODELS.Items> Items { get; set; }

    }






}
