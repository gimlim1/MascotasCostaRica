using System.Linq;
using RPG.MascotasCR.DS.MascotasCR;
using RPG.MascotasCR.DS.MascotasCR.Modelos;

namespace RPG.MascotasCR.BS.Usuarios
{
    public class Iniciador
    {

        public bool IniciarSesion(string elUsuarioIngresado, string elPasswordIngresado)
        {
            bool esValido = false;

            User elUsuario = new User();
            using (var elRepositorio = new ContextoDatos())
            {
                elUsuario = elRepositorio.User.Where(x => x.Username.Equals(elUsuarioIngresado) &&
                                                     x.Password.Equals(elPasswordIngresado)).FirstOrDefault();
               
                if (elUsuario != null)
                {
                    if (elUsuarioIngresado.Equals(elUsuario.Username) &&
                        elPasswordIngresado.Equals(elUsuario.Password))
                    {

                        esValido = true;
                    }
                    else
                    {
                        esValido = false;
                    }
                }
            }
            return esValido;
        }
    }
}