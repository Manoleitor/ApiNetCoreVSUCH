using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiNetCoreVS.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiNetCoreVS.Data
{
    public class Context : DbContext
    {
        public DbSet<TxtFile> TxtFiles { get; set; }

        public Context(DbContextOptions<Context> options): base(options)
        {

        }
    }
}
