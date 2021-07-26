using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data.Repository
{
    public class RepositoryCategoria:Crud
    {
        public static List<Categoria> categorias { get; set; }

        public RepositoryCategoria()
        {
            categorias = new List<Categoria>();
            this.operacaocadastrar = Create;
        }

        public void Create(Categoria model)
        {
            categorias.Add(model);

        }
    }
}
