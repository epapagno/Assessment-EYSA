using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Common.DataAccess.Context
{
    public class DbContextBase : DbContext
    {
        private ILoggerProvider loggerProvider;
        private IConfiguration configuration;
        public DbContextBase(ILoggerProvider loggerProvider, IConfiguration configuration) : base()
        {
            this.loggerProvider = loggerProvider;
            this.configuration = configuration;
        }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (this.loggerProvider != null)
            {
                optionsBuilder.UseLoggerFactory(new LoggerFactory(new[] { this.loggerProvider }));
            }
            //optionsBuilder.UseNpgsql(this.configuration.GetConnectionString("Asessment-EYSA"));
            optionsBuilder.UseNpgsql("Host=localhost;Database=Asessment-EYSA;Username=admin;Password=admin");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(Common.DataAccess.Configuration.DishIngredientETC)));
            base.OnModelCreating(modelBuilder);
        }
    }
}
