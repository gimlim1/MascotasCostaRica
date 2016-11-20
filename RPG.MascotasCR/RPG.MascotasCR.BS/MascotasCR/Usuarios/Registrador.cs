using System.Linq;
using RPG.MascotasCR.DS.MascotasCR;
using RPG.MascotasCR.DS.MascotasCR.Modelos;

namespace RPG.MascotasCR.BS.Usuarios
{
    public class Registrador
    {

        public void Registre(User elUsuario)
        {
            using (var elRepositorio = new ContextoDatos())
            {
                elRepositorio.User.Add(elUsuario);
                elRepositorio.SaveChanges();
            }
        }

    }
}