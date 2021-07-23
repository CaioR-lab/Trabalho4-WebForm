using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    class Produto : BaseModels
    {
        public string Nome { get; set; }

        public Produto(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;

        }

        public Produto()
        {

        }
    }

}
