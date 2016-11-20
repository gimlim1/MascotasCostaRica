using System;
using RPG.MascotasCR.BS.Usuarios;
using RPG.MascotasCR.DS.MascotasCR.Modelos;

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

        public void Registre(User elUsuario)
        {
            Registrador elRegistrador = new Registrador();
            elRegistrador.Registre(elUsuario);
        }
    }
}
