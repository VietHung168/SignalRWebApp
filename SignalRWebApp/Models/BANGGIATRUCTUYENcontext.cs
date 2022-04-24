using System;
using System.Data.Entity;


namespace SignalRWebApp.Models
{
    public class BANGGIATRUCTUYENcontext : DbContext
    {
        const String DefaultConnectionName = "SignaRTestConnection";

        #region "ctor"

        public BANGGIATRUCTUYENcontext() : this(DefaultConnectionName)
        {
        }

        public BANGGIATRUCTUYENcontext(String sqlConnectionName) : base(String.Format("name={0}", sqlConnectionName))
        {
        }

        #endregion

        #region Collections Definitions

        public DbSet<BANGGIATRUCTUYEN> BANGGIATRUCTUYENs { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BANGGIATRUCTUYEN>()
                        .ToTable("BANGGIATRUCTUYEN", "dbo")
                        .HasKey(t => t.MACP);
        }
    }
}