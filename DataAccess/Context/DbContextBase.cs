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

namespace WH.Common.DataAccess.Context
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

        public virtual async Task<long> GetNextValueSequence(string sequenceName)
        {
            long value;
            using (var command = Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = $"SELECT {sequenceName}.nextval value FROM dual";
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                }
                DbDataReader reader = await command.ExecuteReaderAsync();
                await reader.ReadAsync();
                value = reader.GetInt64(0);
            }
            return value;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (this.loggerProvider != null)
            {
                optionsBuilder.UseLoggerFactory(new LoggerFactory(new[] { this.loggerProvider }));
            }
            optionsBuilder.UseOracle(this.configuration.GetConnectionString("WarehouseDatabase"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(WH.Common.DataAccess.Configuration.SysUsersETC)));
            base.OnModelCreating(modelBuilder);
        }
    }
}
