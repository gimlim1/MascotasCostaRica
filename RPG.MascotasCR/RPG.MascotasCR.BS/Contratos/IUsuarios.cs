using System.ServiceModel;

namespace RPG.MascotasCR.BS.Contratos
{

    [ServiceContract]
    public interface IUsuarios
    {

        [OperationContract]
        bool IniciarSesion(string elUsuario, string elPassword);


    }

}
