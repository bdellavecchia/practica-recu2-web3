using BD.ModeloEF;
using BD.Repositorios.Interfaces;
using System.Collections.Generic;
using xdDellaVecchia_recuPractica.Servicios.Interfaces;

namespace xdDellaVecchia_recuPractica.Servicios
{
    public class ObraDeArteServicio : IObraDeArteServicio
    {
        IObraDeArteRepositorio _obraDeArteRepositorio;
        public ObraDeArteServicio(IObraDeArteRepositorio obraDeArteRepositorio)
        {
            _obraDeArteRepositorio = obraDeArteRepositorio;
        }

        //Generar el código necesario para almacenar una nueva Obra de arte por medio del botón grabar
        public void Agregar(ObraDeArte obra)
        {
            _obraDeArteRepositorio.Agregar(obra);
            _obraDeArteRepositorio.SaveChanges();
        }

        public List<ObraDeArte> ObtenerSigloXIX()
        {
            return _obraDeArteRepositorio.ObtenerSigloXIX();
        }

        public List<ObraDeArte> ObtenerObras()
        {
            return _obraDeArteRepositorio.ObtenerObras();
        }

        public void Eliminar(int id)
        {
            _obraDeArteRepositorio.Eliminar(id);
            _obraDeArteRepositorio.SaveChanges();
        }

        public ObraDeArte ObtenerPorId(int id)
        {
            return _obraDeArteRepositorio.ObtenerPorId(id);
        }
    }
}
