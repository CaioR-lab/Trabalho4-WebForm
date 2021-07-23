using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    class Categoria : BaseModels
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public Categoria()
        {
        }
    }
}
