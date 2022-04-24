using System;
using System.Data.Entity;


namespace SignalRWebApp.Models
{
    public class LENHDATcontext : DbContext
    {
        const String DefaultConnectionName = "SignaRTestConnection";

        #region "ctor"

        public LENHDATcontext() : this(DefaultConnectionName)
        {
        }

        public LENHDATcontext(String sqlConnectionName) : base(String.Format("name={0}", sqlConnectionName))
        {
        }

        #endregion

        #region Collections Definitions

        public DbSet<LENHDAT> LENHDATs { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LENHDAT>()
                        .ToTable("LENHDAT", "dbo")
                        .HasKey(t => t.ID);
        }
    }
}