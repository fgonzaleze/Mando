using DAL;
using Entities;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Mando.Models
{
    public class listadoMisiones
    {
            public static List<clsMision> ListadoPersonas()
            {
                return clsListaMisiones.listadoMisiones();
            }

    }

}
