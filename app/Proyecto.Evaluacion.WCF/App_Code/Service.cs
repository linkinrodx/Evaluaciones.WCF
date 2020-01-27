using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

public class Service : IService
{
    public Usuario GetUsuario(int UsuarioId)
    {
        var connection = new Connection();
        return connection.GetUsuario(UsuarioId);
    }

    public int InsUsuario(Usuario usuario)
    {
        var connection = new Connection();
        return connection.InsUsuario(usuario);
    }

    public int UpdUsuario(Usuario usuario)
    {
        var connection = new Connection();
        return connection.UpdUsuario(usuario);
    }


    //public string GetData(int value)
    //{
    //    return string.Format("You entered: {0}", value);
    //}

    //public CompositeType GetDataUsingDataContract(CompositeType composite)
    //{
    //    if (composite == null)
    //    {
    //        throw new ArgumentNullException("composite");
    //    }
    //    if (composite.BoolValue)
    //    {
    //        composite.StringValue += "Suffix";
    //    }
    //    return composite;
    //}
}
