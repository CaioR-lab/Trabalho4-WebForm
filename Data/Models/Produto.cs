using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Produto : BaseModels
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Categoria Categoria { get; set; }

        public Produto(int id,string nome,string descricao, Categoria categoria)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Categoria = categoria;
        }

        public Produto()
        {

        }
    }
}
