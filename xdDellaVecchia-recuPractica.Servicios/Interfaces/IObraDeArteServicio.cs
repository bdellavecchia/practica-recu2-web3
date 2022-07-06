using BD.ModeloEF;
using System.Collections.Generic;

namespace xdDellaVecchia_recuPractica.Servicios.Interfaces
{
    public interface IObraDeArteServicio
    {
        void Agregar(ObraDeArte obra);
        List<ObraDeArte> ObtenerObras();
        List<ObraDeArte> ObtenerSigloXIX();
        ObraDeArte ObtenerPorId(int id);
        void Eliminar(int id);

    }
}
