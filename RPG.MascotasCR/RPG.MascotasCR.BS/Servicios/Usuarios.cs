using RPG.MascotasCR.BS.Usuarios;

namespace RPG.MascotasCR.BS.Servicios
{
    public class Usuarios : Contratos.IUsuarios
    {
        public bool IniciarSesion(string elUsuario, string elPassword)
        {
            bool esValido;

            Iniciador elIniciador;
            elIniciador = new Iniciador();

            esValido = elIniciador.IniciarSesion(elUsuario, elPassword);

            return esValido;
        }

    }
}
