using System.Data.Entity;

namespace RPG.MascotasCR.DS.MascotasCR
{
    public class ContextoDatos : DbContext
    {
        public ContextoDatos(): base("name=ContextoDatos") {
            this.Configuration.LazyLoadingEnabled = false;
            base.Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
