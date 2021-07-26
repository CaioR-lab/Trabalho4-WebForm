using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class RepositoryProduto:Crud
    {
        public static List<Produto> produtos { get; set; }

        public RepositoryProduto()
        {
            produtos = new List<Produto>();
            this.operacaocadastrar = Create;
        }

        public void Create(Produto model)
        {
            produtos.Add(model);

        }
    }
}