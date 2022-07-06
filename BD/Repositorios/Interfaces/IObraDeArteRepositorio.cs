using BD.ModeloEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Repositorios.Interfaces
{
    public interface IObraDeArteRepositorio
    {
        void Agregar(ObraDeArte obra);
        List<ObraDeArte> ObtenerObras();
        ObraDeArte ObtenerPorId(int id);
        List<ObraDeArte> ObtenerSigloXIX();
        void Eliminar(int id);
        void SaveChanges();

    }
}
