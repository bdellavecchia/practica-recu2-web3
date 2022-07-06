using BD.ModeloEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Repositorios
{
    public abstract class Repo
    {
        protected ParcialPrograWeb3Context _Contexto { get; set; }

        public Repo(ParcialPrograWeb3Context ctx)
        {
            _Contexto = ctx;
        }

        public void SaveChanges()
        {
            _Contexto.SaveChanges();
        }
    }
}
