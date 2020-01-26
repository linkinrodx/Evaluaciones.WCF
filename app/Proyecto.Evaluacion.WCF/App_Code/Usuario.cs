using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Usuario
/// </summary>
public class Usuario
{
    public int UsuarioId { get; set; }
    public string Correo { get; set; }
    public string Nombres { get; set; }
    public bool Eliminado { get; set; }
}