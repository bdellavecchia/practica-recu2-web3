using BD.ModeloEF;
using BD.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Repositorios
{
    public class ObraDeArteRepositorio : Repo , IObraDeArteRepositorio
    {
        public ObraDeArteRepositorio(ParcialPrograWeb3Context ctx) : base(ctx)
        {
        }

        //Generar el código necesario para almacenar una nueva Obra de arte por medio del botón grabar
        public void Agregar(ObraDeArte obra)
        {
            _Contexto.ObraDeArtes.Add(obra);
        }

        public List<ObraDeArte> ObtenerSigloXIX()
        {
            return _Contexto.ObraDeArtes.Where(obra => obra.AnioCreacion >= 1800 && obra.AnioCreacion < 1900).ToList();
        }

        List<ObraDeArte> IObraDeArteRepositorio.ObtenerObras()
        {
            return _Contexto.ObraDeArtes.ToList();
        }

        public ObraDeArte ObtenerPorId(int id)
        {
            return _Contexto.ObraDeArtes.Where(obra => obra.Id == id).FirstOrDefault();
        }
        
        public void Eliminar(int id)
        {
            ObraDeArte obraDeArteABorrar = ObtenerPorId(id);
            _Contexto.Remove(obraDeArteABorrar);
            _Contexto.SaveChanges();
        }
    }
}
