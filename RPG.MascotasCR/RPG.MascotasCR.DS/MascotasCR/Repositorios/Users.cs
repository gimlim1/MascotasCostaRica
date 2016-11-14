using RPG.MascotasCR.DS.MascotasCR.Modelos;
using System.Data.Entity;

namespace RPG.MascotasCR.DS.MascotasCR.Repositorios
{
    
    public class Users : ContextoDatos
    {
        public virtual DbSet<User> User { get; set; }
    }
}
