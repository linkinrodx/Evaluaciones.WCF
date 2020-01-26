using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[ServiceContract]
public interface IService
{
    [OperationContract]
    Usuario GetUsuario(int UsuarioId);

    [OperationContract]
    int InsUsuario(Usuario usuario);

    [OperationContract]
    int UpdUsuario(Usuario usuario);
}
